using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV06.00.229 医嘱项目类别代码
    /// </summary>
    [Serializable]
    public enum EnumOrderType
    {

        /// <summary>
        /// 西药
        /// </summary>
        西药 = 11,

        /// <summary>
        /// 中成药
        /// </summary>
        中成药 = 12,

        /// <summary>
        /// 中草药
        /// </summary>
        中草药 = 13,

        /// <summary>
        /// 治疗
        /// </summary>
        治疗 = 21,

        /// <summary>
        /// 检验
        /// </summary>
        检验 = 22,

        /// <summary>
        /// 检查
        /// </summary>
        检查 = 23,

        /// <summary>
        /// 手术
        /// </summary>
        手术 = 24,

        /// <summary>
        /// 麻醉
        /// </summary>
        麻醉 = 25,

        /// <summary>
        /// 护理
        /// </summary>
        护理 = 26,

        /// <summary>
        /// 膳食
        /// </summary>
        膳食 = 27,

        /// <summary>
        /// 输血
        /// </summary>
        输血 = 28,

        /// <summary>
        /// 输氧
        /// </summary>
        输氧 = 29,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 31,

        /// <summary>
        /// 转科
        /// </summary>
        转科 = 32,

        /// <summary>
        /// 术后
        /// </summary>
        术后 = 33,

        /// <summary>
        /// 出院
        /// </summary>
        出院 = 34,

        /// <summary>
        /// 转院
        /// </summary>
        转院 = 35,

        /// <summary>
        /// 死亡
        /// </summary>
        死亡 = 36,

        /// <summary>
        /// 产后
        /// </summary>
        产后 = 37, 
    }
}
