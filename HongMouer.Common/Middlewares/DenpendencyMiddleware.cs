using HongMouer.Common.Utility;
using HongMouer.EHR.Models;
using HongMouer.EntityRelationalCore.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HongMouer.Common
{
    /// <summary>
    /// DenpendencyMiddleware
    /// </summary>
    public static class DenpendencyMiddleware
    {
        /// <summary>
        /// DenpendencyMiddleware
        /// </summary>
        /// <param name="services"></param>
        public static IServiceCollection AddDenpendencyServices(this IServiceCollection services)
        {
            var _Assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList().FindAll(s => s.FullName.StartsWith("HongMouer."));
            var _Types = _Assemblies.SelectMany(a => a.DefinedTypes).Select(type => type.AsType())
                .Where(x => x != typeof(IDenpendency) && typeof(IDenpendency).IsAssignableFrom(x)).ToArray();
            var _Context = services.BuildServiceProvider().GetService<IRepository>();
            var _Plugin = _Context.FindList<SystemPlugin>().ToList();
            var _ClassTypes = _Types.Where(x => x.IsClass).ToArray();
            var _InterfaceTypes = _Types.Where(x => x.IsInterface).ToArray();
            foreach (var item in _ClassTypes)
            {
                var _Interface = _InterfaceTypes.FirstOrDefault(x => x.IsAssignableFrom(item));
                if (_Interface != null)
                {
                    IDenpendency denpendency = (IDenpendency)Assembly.GetExecutingAssembly().CreateInstance(item.FullName, true, BindingFlags.Default, null, new object[] { null }, null, null);

                    if (_Plugin == null && !_Plugin.Exists(s => s.Status == EnumStatus.正常.GetHashCode()))
                    {
                        services.AddScoped(_Interface, item);
                    }
                    else if (_Plugin != null && _Plugin.Exists(s => s.Name == denpendency.Name && s.Status == EnumStatus.正常.GetHashCode()))
                    {
                        services.AddScoped(_Interface, item);
                    }

                    if (_Plugin != null || !_Plugin.Exists(s => s.Name == denpendency.Name))
                    {
                        _Context.Insert(new SystemPlugin
                        {
                            Id = SnowflakeHelper.NextId(),
                            GroupName = denpendency.GroupName,
                            Version = denpendency.Version,
                            Name = denpendency.Name,
                            PluginFullName = item.FullName,
                            InterfaceFullName = _Interface.FullName,
                            Status = EnumStatus.停用.GetHashCode(),
                            Remark = denpendency.Remark,
                            CreateTime = DateTime.Now,
                            ModifyTime = DateTime.Now,

                        });
                    }
                }
            }

            return services;
        }
    }
}
