using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV05.10.019 入院疾病病情代码
    /// </summary>
    [Serializable]
    public enum EnumAdmissionDiseaseCondition
    {
        /// <summary>
        /// 有
        /// </summary>
        有 = 1,

        /// <summary>
        /// 临床未确定
        /// </summary>
        临床未确定 = 2,

        /// <summary>
        /// 情况不明
        /// </summary>
        情况不明 = 3,

        /// <summary>
        /// 无
        /// </summary>
        无 = 4
    }
}
