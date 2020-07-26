using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV02.01.101 身份证件类别代码
    /// </summary>
    [Serializable]
    public enum EnumCertificateType
    {
        /// <summary>
        /// 居民身份证
        /// </summary>
        居民身份证 = 01,

        /// <summary>
        /// 居民户口本
        /// </summary>
        居民户口本 = 02,

        /// <summary>
        /// 护照
        /// </summary>
        护照 = 03,

        /// <summary>
        /// 军官证
        /// </summary>
        军官证 = 04,

        /// <summary>
        /// 驾驶证
        /// </summary>
        驾驶证 = 05,

        /// <summary>
        /// 港澳居民来往内地通行证
        /// </summary>
        港澳居民来往内地通行证 = 06,

        /// <summary>
        /// 台湾居民来往内地通行证
        /// </summary>
        台湾居民来往内地通行证 = 07,

        /// <summary>
        /// 母亲身份证
        /// </summary>
        母亲身份证 = 19,

        /// <summary>
        /// 其他法定有效证件
        /// </summary>
        其他法定有效证件 = 99, 
    }
}
