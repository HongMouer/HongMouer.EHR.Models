using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HongMouer.Common.Utility
{
    /// <summary>
    /// 获取Guid帮助类
    /// </summary>
    public sealed class GuidHelper
    {
        /// <summary>
        /// 获取新的Guid 返回Guid类型
        /// </summary>
        public static Guid GetGuid()
        {
            return Guid.NewGuid();
        }

        /// <summary>
        /// 获取Guid 返回string类型
        /// 返回结果为全部大写字符
        /// </summary>
        /// <returns></returns>
        public static string GetGuidToUpper()
        {
            return Guid.NewGuid().ToString().ToUpper();
        }

        /// <summary>
        /// 获取Guid  返回不带有 “-”的Guid  
        /// 返回结果为全部大写字符
        /// </summary>
        /// <returns></returns>
        public static string GetNGuidToUpper()
        {
            return Guid.NewGuid().ToString("N").ToUpper();
        }

        /// <summary>
        /// 获取Guid 返回string类型
        /// 返回结果为全部小写字符
        /// </summary>
        /// <returns></returns>
        public static string GetGuidToLower()
        {
            return Guid.NewGuid().ToString().ToLower();
        }

        /// <summary>
        /// 获取Guid  返回不带有 “-”的Guid 
        /// 返回结果为全部小写字符
        /// </summary>
        /// <returns></returns>
        public static string GetNGuidToLower()
        {
            return Guid.NewGuid().ToString("N").ToUpper();
        }

        /// <summary>
        /// 判断 <see cref="Guid"/> 是否为空、null或Guid.Empty
        /// </summary>
        /// <param name="guid">Guid</param>
        public static bool IsNullOrEmpty(Guid guid) => guid == Guid.Empty;

        /// <summary>
        /// 判断 <see cref="Guid"/> 是否为空、null或Guid.Empty
        /// </summary>
        /// <param name="guid">Guid</param>
        public static bool IsNullOrEmpty(Guid? guid) => guid is null || IsNullOrEmpty(guid.Value);

        /// <summary>
        /// Guid 正则表达式
        /// </summary>
        private static readonly Regex GuidSchema = new Regex("^[A-Fa-f0-9]{32}$|" +
                                                             "^({|\\()?[A-Fa-f0-9]{8}-([A-Fa-f0-9]{4}-){3}[A-Fa-f0-9]{12}(}|\\))?$|" +
                                                             "^({)?[0xA-Fa-f0-9]{3,10}(, {0,1}[0xA-Fa-f0-9]{3,6}){2},{0,1}({)([0xA-Fa-f0-9]{3,4}, {0,1}){7}[0xA-Fa-f0-9]{3,4}(}})$");

        /// <summary>
        /// 判断 字符串是否有效<see cref="Guid"/>
        /// </summary>
        /// <param name="guidStr">Guid字符串</param>
        public static bool IsValid(string guidStr) => !string.IsNullOrWhiteSpace(guidStr) && GuidSchema.Match(guidStr).Success;
    }
}
