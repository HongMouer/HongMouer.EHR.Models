using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT05.10.002 住院患者出院方式代码，参照调查制度 2016 病案首页
    /// </summary>
    [Serializable]
    public enum EnumDischargeMode
    {
        /// <summary>
        /// 医嘱离院
        /// </summary>
        医嘱离院 = 1,

        /// <summary>
        /// 医嘱转院
        /// </summary>
        医嘱转院 = 2,

        /// <summary>
        /// 医嘱转社区卫生服务机构
        /// </summary>
        医嘱转社区卫生服务机构 = 3,

        /// <summary>
        /// 医嘱转乡镇卫生院
        /// </summary>
        医嘱转乡镇卫生院 = 301,

        /// <summary>
        /// 非医嘱离院
        /// </summary>
        非医嘱离院 = 4,

        /// <summary>
        /// 死亡
        /// </summary>
        死亡 = 5,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 9,
    }
}
