using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT05.10.007 处方类别代码参考【《处方管理办法(试行)》】 中的处方分类
    /// </summary>
    [Serializable]
    public enum EnumPrescriptionCategory
    {

        /// <summary>
        /// 门诊西药
        /// </summary>
        门诊西药 = 1 ,

        /// <summary>
        /// /门诊中草药
        /// </summary>
        门诊中草药 = 2 ,

        /// <summary>
        /// 急诊西药
        /// </summary>
        急诊西药 = 3 ,

        /// <summary>
        /// 急诊中草药
        /// </summary>
        急诊中草药 = 4 ,

        /// <summary>
        /// 儿科西药
        /// </summary>
        儿科西药 = 5 ,

        /// <summary>
        /// 儿科中草药
        /// </summary>
        儿科中草药 = 6 ,

        /// <summary>
        /// 精一
        /// </summary>
        精一 = 7 ,

        /// <summary>
        /// 麻醉
        /// </summary>
        麻醉 = 701,

        /// <summary>
        /// 精二
        /// </summary>
        精二 = 8 ,

        /// <summary>
        /// 中药饮片
        /// </summary>
        中药饮片 = 9 ,

        /// <summary>
        /// 中成药
        /// </summary>
        中成药 = 10,

        /// <summary>
        /// 其它
        /// </summary>
        其它 = 99,
    }
}
