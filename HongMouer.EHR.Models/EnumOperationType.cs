using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT01.00.031 手术患者类型代码
    /// </summary>
    [Serializable]
    public enum EnumOperationType
    {
        /// <summary>
        /// 非手术患者
        /// </summary>
        非手术患者 = 1,

        /// <summary>
        /// 急诊手术
        /// </summary>
        急诊手术 = 2,

        /// <summary>
        /// 择期手术
        /// </summary>
        择期手术 = 3

    }
}
