using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    ///  单位隶属关系代码  GB/T 12404
    /// </summary>
    [Serializable]
    public enum EnumUnitAffiliation
    {

        /// <summary>
        /// 中央
        /// </summary>
        中央 = 10,

        /// <summary>
        /// 省
        /// </summary>
        省 = 20,

        /// <summary>
        /// 市_地区
        /// </summary>
        市_地区 = 40,

        /// <summary>
        /// 街道_镇_乡
        /// </summary>
        街道_镇_乡 = 60,

        /// <summary>
        /// 街道
        /// </summary>
        街道 = 61,

        /// <summary>
        /// 县
        /// </summary>
        县 = 50,

        /// <summary>
        /// 镇
        /// </summary>
        镇 = 62,

        /// <summary>
        /// 居民_村民委员会
        /// </summary>
        居民_村民委员会 = 70,

        /// <summary>
        /// 居民委员会
        /// </summary>
        居民委员会 = 71,

        /// <summary>
        /// 村民委员会
        /// </summary>
        村民委员会 = 72,

        /// <summary>
        /// 乡
        /// </summary>
        乡 = 63,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 90,
    }
}
