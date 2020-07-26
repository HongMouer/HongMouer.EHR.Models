using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT01.00.028 出院治疗结果代码
    /// </summary>
    [Serializable]
    public enum EnumTreatmentStatus
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
        /// 未愈
        /// </summary>
        未愈 = 3,

        /// <summary>
        /// 无效
        /// </summary>
        无效 = 4,

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
