using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV06.00.102 用药途径代码
    /// </summary>
    [Serializable]
    public enum EnumDrugRoute
    {
        /// <summary>
        /// 口服
        /// </summary>
        口服 = 1,

        /// <summary>
        /// 直肠给药
        /// </summary>
        直肠给药 = 2,

        /// <summary>
        /// 舌下给药
        /// </summary>
        舌下给药 = 3,

        /// <summary>
        /// 注射给药
        /// </summary>
        注射给药 = 4,

        /// <summary>
        /// 皮下注射
        /// </summary>
        皮下注射 = 401,

        /// <summary>
        /// 皮内注射
        /// </summary>
        皮内注射 = 402,

        /// <summary>
        /// 肌肉注射
        /// </summary>
        肌肉注射 = 403,

        /// <summary>
        /// 静脉注射或静脉滴注
        /// </summary>
        静脉注射 = 404,

        /// <summary>
        /// 静脉滴注
        /// </summary>
        静脉滴注 = 405,

        /// <summary>
        /// 吸入给药
        /// </summary>
        吸入给药 = 5,

        /// <summary>
        /// 局部用药
        /// </summary>
        局部用药 = 6,

        /// <summary>
        /// 椎管内用药
        /// </summary>
        椎管内用药 = 601,

        /// <summary>
        /// 关节腔内用药
        /// </summary>
        关节腔内用药 = 602,

        /// <summary>
        /// 胸膜腔用药
        /// </summary>
        胸膜腔用药 = 603,

        /// <summary>
        /// 腹腔用药
        /// </summary>
        腹腔用药 = 604,

        /// <summary>
        /// 阴道用药
        /// </summary>
        阴道用药 = 605,

        /// <summary>
        /// 气管内用药
        /// </summary>
        气管内用药 = 606,

        /// <summary>
        /// 滴眼
        /// </summary>
        滴眼 = 607,

        /// <summary>
        /// 滴鼻
        /// </summary>
        滴鼻 = 608,

        /// <summary>
        /// 喷喉
        /// </summary>
        喷喉 = 609,

        /// <summary>
        /// 含化
        /// </summary>
        含化 = 610,

        /// <summary>
        /// 敷伤口
        /// </summary>
        敷伤口 = 611,

        /// <summary>
        /// 擦皮肤
        /// </summary>
        擦皮肤 = 612,

        /// <summary>
        /// 其他局部给药途径
        /// </summary>
        其他局部给药途径 = 699,

        /// <summary>
        /// 其他给药途径
        /// </summary>
        其他给药途径 = 9

    }
}
