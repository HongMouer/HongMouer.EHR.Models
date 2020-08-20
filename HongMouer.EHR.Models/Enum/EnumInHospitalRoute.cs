using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{
    /// <summary>
    /// 参照 CV09.00.403 入院途径代码
    /// </summary>
    [Serializable]
    public enum EnumInHospitalRoute
    {
        /// <summary>
        /// 门诊
        /// </summary>
        门诊 = 1,

        /// <summary>
        /// 急诊
        /// </summary>
        急诊 = 2,

        /// <summary>
        /// 其他医疗机构转入
        /// </summary>
        其他医疗机构转入 = 3,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 9
    }
}
