using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT07.00.001 费用项目类别代码，参照医院账单码
    /// </summary>
    [Serializable]
    public enum EnumCostItemCategory
    {

        /// <summary>
        /// 药品
        /// </summary>
        药品 = 1 ,

        /// <summary>
        /// 西药费
        /// </summary>
        西药费 = 11,

        /// <summary>
        /// 中成药费
        /// </summary>
        中成药费 = 12,

        /// <summary>
        /// 中草药费
        /// </summary>
        中草药费 = 13,

        /// <summary>
        /// 诊疗项目
        /// </summary>
        诊疗项目 = 2 ,

        /// <summary>
        /// 床位费
        /// </summary>
        床位费 = 21,

        /// <summary>
        /// 诊疗费
        /// </summary>
        诊疗费 = 22,

        /// <summary>
        /// 检查费
        /// </summary>
        检查费 = 23,

        /// <summary>
        /// 化验费
        /// </summary>
        化验费 = 24,

        /// <summary>
        /// 治疗费
        /// </summary>
        治疗费 = 25,

        /// <summary>
        /// 手术费
        /// </summary>
        手术费 = 26,

        /// <summary>
        /// 护理费
        /// </summary>
        护理费 = 27,

        /// <summary>
        /// 药事服务费
        /// </summary>
        药事服务费 = 28,

        /// <summary>
        /// 一般诊疗费
        /// </summary>
        一般诊疗费 = 29,

        /// <summary>
        /// 卫生材料
        /// </summary>
        卫生材料 = 3 ,

        /// <summary>
        /// /卫生材料费
        /// </summary>
        卫生材料费 = 31,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 9 ,

        /// <summary>
        /// /其他收费
        /// </summary>
        其他收费 = 91, 
    }
}
