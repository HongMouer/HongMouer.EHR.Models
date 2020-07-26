using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT05.10.004 挂号类别代码
    /// </summary>
    [Serializable]
    public enum EnumRegisterType
    {

        /// <summary>
        /// 普通门诊
        /// </summary>
        普通门诊 = 1,

        /// <summary>
        /// 西医
        /// </summary>
        西医 = 11,

        /// <summary>
        /// 中医
        /// </summary>
        中医 = 12,

        /// <summary>
        /// 急诊
        /// </summary>
        急诊 = 2,

        /// <summary>
        /// 西医急诊
        /// </summary>
        西医急诊 = 21,

        /// <summary>
        /// 中医急诊
        /// </summary>
        中医急诊 = 22,

        /// <summary>
        /// 健康咨询
        /// </summary>
        健康咨询 = 3,

        /// <summary>
        /// 体检
        /// </summary>
        体检 = 31,

        /// <summary>
        /// 预防体检
        /// </summary>
        预防体检 = 32,

        /// <summary>
        /// 孕产保健
        /// </summary>
        孕产保健 = 33,

        /// <summary>
        /// 专科门诊
        /// </summary>
        专科门诊 = 4,

        /// <summary>
        /// 特需门诊
        /// </summary>
        特需门诊 = 5,

        /// <summary>
        /// 专病门诊
        /// </summary>
        专病门诊 = 6,

        /// <summary>
        /// 预约挂号
        /// </summary>
        预约挂号 = 7,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 99,
    }
}
