using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT01.00.027 入院时情况代码
    /// </summary>
    [Serializable]
    public enum EnumAdmissionStatus
    {

        /// <summary>
        /// 危
        /// </summary>
        危 = 1,

        /// <summary>
        /// 急
        /// </summary>
        急 = 2,

        /// <summary>
        /// 一般
        /// </summary>
        一般 = 3
    }
}
