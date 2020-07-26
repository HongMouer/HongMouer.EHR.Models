using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    ///  从业状况  GB/T 2261.4-2003 从业状况(个人身份)代码
    /// </summary>
    [Serializable]
    public enum EnumOccupation
    {
        /// <summary>
        /// 国家公务员
        /// </summary>
        国家公务员 = 11,

        /// <summary>
        /// 专业技术人员
        /// </summary>
        专业技术人员 = 13,

        /// <summary>
        /// 职员
        /// </summary>
        职员 = 17,

        /// <summary>
        /// 企业管理人员
        /// </summary>
        企业管理人员 = 21,

        /// <summary>
        /// 工人
        /// </summary>
        工人 = 24,

        /// <summary>
        /// 农民
        /// </summary>
        农民 = 27,

        /// <summary>
        /// 学生
        /// </summary>
        学生 = 31,

        /// <summary>
        /// 现役军人
        /// </summary>
        现役军人 = 37,

        /// <summary>
        /// 自由职业者
        /// </summary>
        自由职业者 = 51,

        /// <summary>
        /// 个体经营者
        /// </summary>
        个体经营者 = 54,

        /// <summary>
        /// 无业人员
        /// </summary>
        无业人员 = 70,

        /// <summary>
        /// 退离休人员
        /// </summary>
        退离休人员 = 80,

        /// <summary> 
        /// 其他
        /// </summary>
        其他 = 90

    }
}
