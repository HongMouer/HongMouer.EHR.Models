using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV05.01.038 过敏源代码
    /// </summary>
    [Serializable]
    public enum EnumAllergySourceType
    {
        /// <summary>
        /// 药物
        /// </summary>
        药物 = 1,

        /// <summary>
        /// 青霉素类抗生素
        /// </summary>
        青霉素类抗生素 = 101,

        /// <summary>
        /// 磺胺类抗生素
        /// </summary>
        磺胺类抗生素 = 102,

        /// <summary>
        /// 头孢类抗生素
        /// </summary>
        头孢类抗生素 = 103,

        /// <summary>
        /// 含碘药品
        /// </summary>
        含碘药品 = 104,

        /// <summary>
        /// 酒精
        /// </summary>
        酒精 = 105,

        /// <summary>
        /// 镇静麻醉剂
        /// </summary>
        镇静麻醉剂 = 106,

        /// <summary>
        /// 链霉素类抗生素
        /// </summary>
        链霉素类抗生素 = 107,

        /// <summary>
        /// 其他药物过敏源
        /// </summary>
        其他药物过敏源 = 199,

        /// <summary>
        /// 食物
        /// </summary>
        食物 = 2,

        /// <summary>
        /// 猪肉
        /// </summary>
        猪肉 = 201,

        /// <summary>
        /// 羊肉
        /// </summary>
        羊肉 = 202,

        /// <summary>
        /// 牛肉
        /// </summary>
        牛肉 = 203,

        /// <summary>
        /// 牛奶
        /// </summary>
        牛奶 = 204,

        /// <summary>
        /// 蛋及蛋制品
        /// </summary>
        蛋及蛋制品 = 205,

        /// <summary>
        /// 鸡_鸭等禽类食品
        /// </summary>
        鸡_鸭等禽类食品 = 206,

        /// <summary>
        /// 鱼_虾等水产类食品
        /// </summary>
        鱼_虾等水产类食品 = 207,

        /// <summary>
        /// 水果_包括带壳的果仁
        /// </summary>
        水果_包括带壳的果仁 = 208,

        /// <summary>
        /// 其他食物过敏源
        /// </summary>
        其他食物过敏源 = 299,

        /// <summary>
        /// 环境
        /// </summary>
        环境 = 3,

        /// <summary>
        /// 植物花粉
        /// </summary>
        植物花粉 = 301,

        /// <summary>
        /// 动物毛发
        /// </summary>
        动物毛发 = 302,

        /// <summary>
        /// 空气粉尘
        /// </summary>
        空气粉尘 = 303,

        /// <summary>
        /// 其他环境过敏源
        /// </summary>
        其他环境过敏源 = 399,

        /// <summary>
        /// 混合型过敏源
        /// </summary>
        混合型过敏源 = 4,

        /// <summary>
        /// 其他过敏源
        /// </summary>
        其他过敏源 = 9,
    }
}
