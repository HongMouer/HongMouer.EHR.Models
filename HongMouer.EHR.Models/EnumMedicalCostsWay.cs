using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 医疗费用支付方式参照【卫生信息数据元值域代码 第 13部分:卫生费用】CV07.10.003 医疗费用来源类别代码表
    /// </summary>
    [Serializable]
    public enum EnumMedicalCostsWay
    {

        /// <summary>
        /// 城镇职工基本医疗保险
        /// </summary>
        城镇职工基本医疗保险 = 01,

        /// <summary>
        /// 城镇居民基本医疗保险
        /// </summary>
        城镇居民基本医疗保险 = 02,

        /// <summary>
        /// 新型农村合作医疗
        /// </summary>
        新型农村合作医疗 = 03,

        /// <summary>
        /// 贫困救助
        /// </summary>
        贫困救助 = 04,

        /// <summary>
        /// 商业医疗保险
        /// </summary>
        商业医疗保险 = 05,

        /// <summary>
        /// 全公费
        /// </summary>
        全公费 = 06,

        /// <summary>
        /// 全自费
        /// </summary>
        全自费 = 07,

        /// <summary>
        /// 城乡居民医疗保险
        /// </summary>
        城乡居民医疗保险 = 90,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 99, 
    }
}
