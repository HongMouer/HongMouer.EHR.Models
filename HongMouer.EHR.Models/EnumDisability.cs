using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV05.10.001 残疾情况代码
    /// </summary>
    [Serializable]
    public enum EnumDisability
    {
        /// <summary>
        /// 无残疾
        /// </summary>
        无残疾 = 1,

        /// <summary>
        /// 听力残疾
        /// </summary>
        听力残疾 = 2,

        /// <summary>
        /// 言语残疾
        /// </summary>
        言语残疾 = 3,

        /// <summary>
        /// 肢体残疾
        /// </summary>
        肢体残疾 = 4,

        /// <summary>
        /// 智力残疾
        /// </summary>
        智力残疾 = 5,

        /// <summary>
        /// 视力残疾
        /// </summary>
        视力残疾 = 6,

        /// <summary>
        /// 精神残疾
        /// </summary>
        精神残疾 = 7,

        /// <summary>
        /// 多重残疾
        /// </summary>
        多重残疾 = 8,

        /// <summary>
        /// 其他残疾
        /// </summary>
        其他残疾 = 9,
    }
}
