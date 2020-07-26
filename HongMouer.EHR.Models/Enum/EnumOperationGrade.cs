using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV05.10.024 手术级别代码
    /// </summary>
    [Serializable]
    public enum EnumOperationGrade
    {
        /// <summary>
        /// 一级手术
        /// </summary>
        一级手术 = 1,

        /// <summary>
        /// 二级手术
        /// </summary>
        二级手术 = 2,

        /// <summary>
        /// 三级手术
        /// </summary>
        三级手术 = 3,

        /// <summary>
        /// 四级手术
        /// </summary>
        四级手术 = 4,

        /// <summary>
        /// 其他等级
        /// </summary>
        其他等级 = 5
    }
}
