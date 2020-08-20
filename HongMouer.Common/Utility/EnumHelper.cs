using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace HongMouer.Common.Utility
{

    //https://www.cnblogs.com/anding/p/5129178.html

    /// <summary>
    /// 
    /// </summary>
    public static class EnumHelper
    {
        private static ConcurrentDictionary<Enum, string> _ConcurrentDictionary = new ConcurrentDictionary<Enum, string>();

        /// <summary>
        /// 获取枚举的描述信息(Descripion)。
        /// 支持位域，如果是位域组合值，多个按分隔符组合。
        /// </summary>
        public static string GetDescription(this Enum @this)
        {
            return _ConcurrentDictionary.GetOrAdd(@this, (key) =>
            {
                var type = key.GetType();
                var field = type.GetField(key.ToString());
                //如果field为null则应该是组合位域值，
                return field == null ? key.GetDescriptions() : GetDescription(field);
            });
        }

        /// <summary>
        /// 获取位域枚举的描述，多个按分隔符组合
        /// </summary>
        public static string GetDescriptions(this Enum @this, string separator = ",")
        {
            var names = @this.ToString().Split(',');
            string[] res = new string[names.Length];
            var type = @this.GetType();
            for (int i = 0; i < names.Length; i++)
            {
                var field = type.GetField(names[i].Trim());
                if (field == null) continue;
                res[i] = GetDescription(field);
            }
            return string.Join(separator, res);
        }

        private static string GetDescription(FieldInfo field)
        {
            var att = System.Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute), false);
            return att == null ? field.Name : ((DescriptionAttribute)att).Description;
        }

        public static string GetDescription(Type enumType, object val)
        {
            string name = System.Enum.GetName(enumType, val);
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }

            FieldInfo field = enumType.GetField(name);

            return GetDescription(field);
        }

        /// <summary>
        /// 获取枚举信息
        /// </summary>
        public static List<EnumModel> ToList<T>()
        {
            List<EnumModel> list = new List<EnumModel>();
            Type type = typeof(T);
            foreach (int item in Enum.GetValues(typeof(T)))
            {
                EnumModel model = new EnumModel();
                model.Name = Enum.GetName(type, item);
                model.Value = item;
                model.Description = GetDescription(type, item);
                model.PinyinCode = SearchCodeHelper.GetPinyinCode(model.Name);
                model.FivePenCode = SearchCodeHelper.GetFivePenCode(model.Name);
                list.Add(model);
            }
            return list;
        }

        ///<summary>
        /// 枚举转实体
        ///<typeparam name="T">枚举</typeparam>
        ///<param name="value">值</param>
        public static T ToModel<T>(int value)
        {
            return (T)Enum.Parse(typeof(T), value.ToString(), true);
        }

        ///<summary>
        /// 枚举转实体
        ///</summary>
        ///<typeparam name="T">枚举</typeparam>
        ///<param name="value">值</param>
        public static T ToModel<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

    }

    /// <summary>
    /// 枚举类
    /// </summary>
    [Serializable]
    public class EnumModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数值
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// 检索码
        /// </summary>
        public string PinyinCode { get; set; }

        /// <summary>
        /// 数值
        /// </summary>
        public string FivePenCode { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 重写 ToString 方法
        /// </summary>
        /// <returns>字符串</returns>
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
