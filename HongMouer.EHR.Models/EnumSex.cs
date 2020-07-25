using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 性别标准 GB/T 2261.1-2003 人的性别代码
    /// </summary>
    [Serializable]
    public enum EnumSex
    {

        /// <summary>
        /// 未知的性别
        /// </summary>
        [Description("未知的性别")]
        未知 = 0,

        /// <summary>
        /// 男性
        /// </summary>
        [Description("男性")]
        男性 = 1,

        /// <summary>
        /// 女性
        /// </summary>
        [Description("女性")]
        女性 = 2,

        /// <summary>
        /// 未说明
        /// </summary>
        [Description("未说明")]
        未说明 = 9
    }
}
