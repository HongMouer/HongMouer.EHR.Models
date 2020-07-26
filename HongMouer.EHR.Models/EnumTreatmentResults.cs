using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV5501.11 治疗结果代码
    /// </summary>
   [Serializable]
    public enum EnumTreatmentResults
    {
        /// <summary>
        /// 治愈
        /// </summary>
        治愈 = 1,

        /// <summary>
        /// 好转
        /// </summary>
        好转 = 2,

        /// <summary>
        /// 稳定
        /// </summary>
        稳定 = 3,

        /// <summary>
        /// 恶化
        /// </summary>
        恶化 = 4,

        /// <summary>
        /// 死亡
        /// </summary>
        死亡 = 5,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 9
    }
}
