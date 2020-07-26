using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT01.00.001 业务活动类别代码
    /// </summary>
    [Serializable]
    public enum EnumBusinessActivitiesType
    {

        /// <summary>
        /// 门诊
        /// </summary>
        门诊 = 01,

        /// <summary>
        /// 急诊
        /// </summary>
        急诊 = 02,

        /// <summary>
        /// 住院
        /// </summary>
        住院 = 03,

        /// <summary>
        /// 体检
        /// </summary>
        体检 = 04,

        /// <summary>
        /// 运营
        /// </summary>
        运营 = 05,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 09
    }
}
