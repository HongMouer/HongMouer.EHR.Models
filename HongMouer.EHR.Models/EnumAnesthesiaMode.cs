using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV06.00.103 麻醉-方法代码
    /// </summary>
    [Serializable]
    public enum EnumAnesthesiaMode
    {

        /// <summary>
        /// 全身麻醉
        /// </summary>
        全身麻醉 = 1 ,

        /// <summary>
        /// 吸入麻醉
        /// </summary>
        吸入麻醉 = 11,

        /// <summary>
        /// 静脉麻醉
        /// </summary>
        静脉麻醉 = 12,

        /// <summary>
        /// 基础麻醉
        /// </summary>
        基础麻醉 = 13,

        /// <summary>
        /// 椎管内麻醉
        /// </summary>
        椎管内麻醉 = 2 ,

        /// <summary>
        /// 蛛网膜下腔阻滞麻醉
        /// </summary>
        蛛网膜下腔阻滞麻醉 = 21,

        /// <summary>
        /// 硬脊膜外腔阻滞麻醉
        /// </summary>
        硬脊膜外腔阻滞麻醉 = 22,

        /// <summary>
        /// 局部麻醉
        /// </summary>
        局部麻醉 = 3 ,

        /// <summary>
        /// 神经丛阻滞麻醉
        /// </summary>
        神经丛阻滞麻醉 = 31,

        /// <summary>
        /// 神经节阻滞麻醉
        /// </summary>
        神经节阻滞麻醉 = 32,

        /// <summary>
        /// 神经阻滞麻醉
        /// </summary>
        神经阻滞麻醉 = 33,

        /// <summary>
        /// 区域阻滞麻醉
        /// </summary>
        区域阻滞麻醉 = 34,

        /// <summary>
        /// 局部浸润麻醉
        /// </summary>
        局部浸润麻醉 = 35,

        /// <summary>
        /// 表面麻醉
        /// </summary>
        表面麻醉 = 36,

        /// <summary>
        /// 复合麻醉
        /// </summary>
        复合麻醉 = 4 ,

        /// <summary>
        /// 静吸复合全麻
        /// </summary>
        静吸复合全麻 = 41,

        /// <summary>
        /// 针药复合麻醉
        /// </summary>
        针药复合麻醉 = 42,

        /// <summary>
        /// 神经丛与硬膜外阻滞复合麻醉
        /// </summary>
        神经丛与硬膜外阻滞复合麻醉 = 43,

        /// <summary>
        /// 全麻复合全身降温
        /// </summary>
        全麻复合全身降温 = 44,

        /// <summary>
        /// 全麻复合控制性降压
        /// </summary>
        全麻复合控制性降压 = 45,

        /// <summary>
        /// 其他麻醉方法
        /// </summary>
        其他麻醉方法 = 9 , 
    }
}
