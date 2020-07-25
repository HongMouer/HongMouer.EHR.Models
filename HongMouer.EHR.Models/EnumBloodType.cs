using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV04.50.005ABO 血型代码，并根据调查制度的病案 首页信息增加 9 未查
    /// </summary>
    [Serializable]
    public enum EnumBloodType
    {
        /// <summary>
        /// A型
        /// </summary>
        A型 = 1,

        /// <summary>
        /// B型
        /// </summary>
        B型 = 2,

        /// <summary>
        /// O型
        /// </summary>
        O型 = 3,

        /// <summary>
        /// AB型
        /// </summary>
        AB型 = 4,

        /// <summary>
        /// 不详
        /// </summary>
        不详 = 5,

        /// <summary>
        /// 未查
        /// </summary>
        未查 = 9
    }
}
