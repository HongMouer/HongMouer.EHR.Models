using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV5502.19 住院患者疾病诊断对照代码
    /// </summary>
    public enum EnumDiseaseDiagnosisComparison
    {

        /// <summary>
        /// 门诊诊断与出院诊断
        /// </summary>
        门诊诊断与出院诊断 = 1,

        /// <summary>
        /// 中医入院与出院
        /// </summary>
        中医入院与出院 = 10,

        /// <summary>
        /// 入院诊断与出院诊断
        /// </summary>
        入院诊断与出院诊断 = 2,

        /// <summary>
        /// 术前诊断与术后诊断
        /// </summary>
        术前诊断与术后诊断 = 3,

        /// <summary>
        /// 放射诊断与术后诊断
        /// </summary>
        放射诊断与术后诊断 = 4,

        /// <summary>
        /// 出院诊断与病理诊断
        /// </summary>
        出院诊断与病理诊断 = 5,

        /// <summary>
        /// 放射诊断与病理诊断
        /// </summary>
        放射诊断与病理诊断 = 6,

        /// <summary>
        /// 临床诊断与尸检诊断
        /// </summary>
        临床诊断与尸检诊断 = 7,

        /// <summary>
        /// 中医门诊与出院
        /// </summary>
        中医门诊与出院 = 8,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 9,

        /// <summary>
        /// 疾病诊断对照组扩充内容=X
        /// </summary>
        疾病诊断对照组扩充内容 = 11,
    }
}
