using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{
    public interface IDenpendency : IDisposable
    {
        /// <summary>
        /// 功能
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 分组名称
        /// </summary>
        string GroupName { get; }

        /// <summary>
        /// 备注
        /// </summary>
        string Remark { get; }

        /// <summary>
        /// 版本号
        /// </summary>
        string Version { get; }
    }
}
