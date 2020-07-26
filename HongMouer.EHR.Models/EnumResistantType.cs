using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{
    /// <summary>
    /// CT05.10.003 抗药结果代码参照【卫生信息数据元值域代 码 第 9 部分:实验室检查】CV04.50.013 药敏实验结果代码 表
    /// </summary>
    [Serializable]
    public enum EnumResistantType
    {

        /// <summary>
        /// 耐药
        /// </summary>
        耐药 =   1,

        /// <summary>
        /// 敏感
        /// </summary>
        敏感 = 2,

        /// <summary>
        /// 污染
        /// </summary>
        污染 = 3,

        /// <summary>
        /// 未做
        /// </summary>
        未做 = 4
    }
}
