using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV04.50.021 输血品种代码
    /// </summary>
    [Serializable]
    public enum EnumBloodVarieties
    {

        /// <summary>
        /// 红细胞
        /// </summary>
        红细胞 = 1,

        /// <summary>
        /// 浓缩红细胞
        /// </summary>
        浓缩红细胞 = 11,

        /// <summary>
        /// 滤白红细胞
        /// </summary>
        滤白红细胞 = 12,

        /// <summary>
        /// 红细胞悬液
        /// </summary>
        红细胞悬液 = 13,

        /// <summary>
        /// 洗涤红细胞
        /// </summary>
        洗涤红细胞 = 14,

        /// <summary>
        /// 冰冻红细胞
        /// </summary>
        冰冻红细胞 = 15,

        /// <summary>
        /// 冰冻解冻去甘油红细胞
        /// </summary>
        冰冻解冻去甘油红细胞 = 16,

        /// <summary>
        /// Rh阴性悬浮红细胞
        /// </summary>
        Rh阴性悬浮红细胞 = 17,

        /// <summary>
        /// 全血
        /// </summary>
        全血 = 2,

        /// <summary>
        /// 滤白全血
        /// </summary>
        滤白全血 = 21,

        /// <summary>
        /// 重组全血
        /// </summary>
        重组全血 = 22,

        /// <summary>
        /// Rh阴性全血
        /// </summary>
        Rh阴性全血 = 23,

        /// <summary>
        /// 血小板
        /// </summary>
        血小板 = 3,

        /// <summary>
        /// 手工分离浓缩血小板
        /// </summary>
        手工分离浓缩血小板 = 31,

        /// <summary>
        /// 机采血小板
        /// </summary>
        机采血小板 = 32,

        /// <summary>
        /// 滤白机采血小板
        /// </summary>
        滤白机采血小板 = 33,

        /// <summary>
        /// 冷冻机采血小板
        /// </summary>
        冷冻机采血小板 = 34,

        /// <summary>
        /// 血浆
        /// </summary>
        血浆 = 4,

        /// <summary>
        /// 新鲜液体血浆
        /// </summary>
        新鲜液体血浆 = 41,

        /// <summary>
        /// 新鲜冰冻血浆
        /// </summary>
        新鲜冰冻血浆 = 42,

        /// <summary>
        /// 普通冰冻血浆
        /// </summary>
        普通冰冻血浆 = 43,

        /// <summary>
        /// 滤白病毒灭活冰冻血浆
        /// </summary>
        滤白病毒灭活冰冻血浆 = 44,

        /// <summary>
        /// 滤白新鲜冰冻血浆
        /// </summary>
        滤白新鲜冰冻血浆 = 45,

        /// <summary>
        /// 滤白普通冰冻血浆
        /// </summary>
        滤白普通冰冻血浆 = 46,

        /// <summary>
        /// 冷沉淀
        /// </summary>
        冷沉淀 = 5,

        /// <summary>
        /// 滤白冷沉淀
        /// </summary>
        滤白冷沉淀 = 51,

        /// <summary>
        /// 机采浓缩白细胞悬液
        /// </summary>
        机采浓缩白细胞悬液 = 6,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 9,
    }
}
