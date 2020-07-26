using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT05.10.006 预约途径代码
    /// </summary>
    [Serializable]
    public enum EnumPppointmentWay
    {

        /// <summary>
        /// 现场预约
        /// </summary>
        现场预约 = 1,

        /// <summary>
        /// 电话预约
        /// </summary>
        电话预约 = 2,

        /// <summary>
        /// 短信预约
        /// </summary>
        短信预约 = 3,

        /// <summary>
        /// 网上预约
        /// </summary>
        网上预约 = 4,

        /// <summary>
        /// APP预约
        /// </summary>
        APP预约 = 5,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 9
    }
}
