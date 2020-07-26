using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV06.00.212 住院原因代码
    /// </summary>
    [Serializable]
    public enum EnumInHospitalReason
    {
        /// <summary>
        /// 病伤
        /// </summary>
        病伤 = 1,

        /// <summary>
        /// 体检
        /// </summary>
        体检 = 2,

        /// <summary>
        /// 分娩
        /// </summary>
        分娩 = 3,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 9
    }
}
