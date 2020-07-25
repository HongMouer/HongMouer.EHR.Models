using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV05.01.040 输血反应类型代码
    /// </summary>
    [Serializable]
    public enum EnumBloodReactionType
    {
        /// <summary>
        /// 发热
        /// </summary>
        发热 = 1,

        /// <summary>
        /// 过敏
        /// </summary>
        过敏 = 2,

        /// <summary>
        /// 溶血
        /// </summary>
        溶血 = 3,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 9

    }
}
