using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{
    /// <summary>
    /// 参照 CV5501.15 住院病例病案质量代码
    /// </summary>
    [Serializable]
    public enum EnumMedicalRecordQuality
    {

        /// <summary>
        /// 甲
        /// </summary>
        甲 = 1,

        /// <summary>
        /// 乙
        /// </summary>
        乙 = 2,

        /// <summary>
        /// 丙
        /// </summary>
        丙 = 3
    }
}
