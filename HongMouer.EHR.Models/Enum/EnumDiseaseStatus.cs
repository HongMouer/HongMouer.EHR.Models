using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{
    /// <summary>
    /// 参照 CV05.01.001 住院患者疾病状态代码
    /// </summary>
    [Serializable]
    public enum EnumDiseaseStatus
    {
        /// <summary>
        /// 危急
        /// </summary>
        危急 = 1,

        /// <summary>
        /// 严重
        /// </summary>
        严重 = 2,

        /// <summary>
        /// 一般
        /// </summary>
        一般 = 3,

        /// <summary>
        /// 不适用
        /// </summary>
        不适用 = 4,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 9

    }
}
