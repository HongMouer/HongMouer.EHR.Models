using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV06.00.101 中药使用类别代码
    /// </summary>
   [Serializable]
    public enum EnumHerbalUsageCategory
    {
        /// <summary>
        /// 未使用
        /// </summary>
        未使用 = 1 ,

        /// <summary>
        /// 中成药
        /// </summary>
        中成药 = 2 ,

        /// <summary>
        /// 中草药
        /// </summary>
        中草药 = 3 ,

        /// <summary>
        /// 其他中药
        /// </summary>
        其他中药 = 9
    }
}
