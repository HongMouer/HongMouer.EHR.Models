using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HongMouer.Common.Utility
{

    /// https://github.com/bing-framework/Bing.NetCore/blob/master/utils/src/Bing.Utils/Bing/Judgments/RegexJudgment.cs
    /// <summary>
    /// 正则表达式(<see cref="Regex"/>) 判断
    /// </summary>
    public static class RegexJudgment
    {
        /// <summary>
        /// 验证输入与模式是否匹配
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="pattern">模式字符串</param>
        /// <param name="options">选项</param>
        public static bool IsMatch(string str, string pattern, RegexOptions options = RegexOptions.IgnoreCase) => Regex.IsMatch(str, pattern, options);
    }
}
