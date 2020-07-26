using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT05.10.005 挂号方式代码
    /// </summary>
    [Serializable]
    public enum EnumRegisterMode
    {

        /// <summary>
        /// 现场
        /// </summary>
        现场 = 1,

        /// <summary>
        /// 预约
        /// </summary>
        预约 = 2,

        /// <summary>
        /// 特诊
        /// </summary>
        特诊 = 3,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 9
    }
}
