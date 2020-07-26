using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV5502.20 住院患者疾病诊断类型-代码
    /// </summary>
    [Serializable]
    public enum EnumDiseaseDiagnosisType
    {

        /// <summary>
        /// 出院诊断
        /// </summary>
        出院诊断 = 1 ,

        /// <summary>
        /// 并发症诊断
        /// </summary>
        并发症诊断 = 10 ,

        /// <summary>
        /// 院内感染诊断
        /// </summary>
        院内感染诊断 = 11 ,

        /// <summary>
        /// 主要诊断
        /// </summary>
        主要诊断 = 12 ,

        /// <summary>
        /// 次要诊断
        /// </summary>
        次要诊断 = 13 ,

        /// <summary>
        /// 中医出院诊断病名
        /// </summary>
        中医出院诊断病名 = 14 ,

        /// <summary>
        /// 中医出院主病
        /// </summary>
        中医出院主病 = 141,

        /// <summary>
        /// 中医出院主证
        /// </summary>
        中医出院主证 = 142,

        /// <summary>
        /// 门诊诊断
        /// </summary>
        门诊诊断 = 2  ,

        /// <summary>
        /// 入院初步诊断
        /// </summary>
        入院初步诊断 = 3  ,

        /// <summary>
        /// 入院诊断
        /// </summary>
        入院诊断 = 31 ,

        /// <summary>
        /// 术前诊断
        /// </summary>
        术前诊断 = 4  ,

        /// <summary>
        /// 术后诊断
        /// </summary>
        术后诊断 = 5  ,

        /// <summary>
        /// 尸检诊断
        /// </summary>
        尸检诊断 = 6 ,

        /// <summary>
        /// 放射诊断
        /// </summary>
        放射诊断 = 7 ,

        /// <summary>
        /// 超声诊断
        /// </summary>
        超声诊断 = 8 ,

        /// <summary>
        /// 病理诊断
        /// </summary>
        病理诊断 = 9 ,

        /// <summary>
        /// 损伤中毒的外部原因
        /// </summary>
        损伤中毒的外部原因 = 98,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 99,
    }
}
