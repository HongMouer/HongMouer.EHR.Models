using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 学历代码 参照 GB/T 4658-2006 学历代码
    /// </summary>
    [Serializable]
    public enum EnumEducation
    {

        /// <summary>
        /// 研究生教育
        /// </summary>
        研究生教育 = 10,

        /// <summary>
        /// 博士研究生毕业
        /// </summary>
        博士研究生毕业 = 11,

        /// <summary>
        /// 博士研究生结业
        /// </summary>
        博士研究生结业 = 12,

        /// <summary>
        /// 博士研究生肄业
        /// </summary>
        博士研究生肄业 = 13,

        /// <summary>
        /// 硕士研究生毕业
        /// </summary>
        硕士研究生毕业 = 14,

        /// <summary>
        /// 硕士研究生结业
        /// </summary>
        硕士研究生结业 = 15,

        /// <summary>
        /// 硕士研究生肄业
        /// </summary>
        硕士研究生肄业 = 16,

        /// <summary>
        /// 研究生班毕业
        /// </summary>
        研究生班毕业 = 17,

        /// <summary>
        /// 研究生班结业
        /// </summary>
        研究生班结业 = 18,

        /// <summary>
        /// 研究生班肄业
        /// </summary>
        研究生班肄业 = 19,

        /// <summary>
        /// 大学本科
        /// </summary>
        大学本科 = 20,

        /// <summary>
        /// 大学本科毕业
        /// </summary>
        大学本科毕业 = 21,

        /// <summary>
        /// 大学本科结业
        /// </summary>
        大学本科结业 = 22,

        /// <summary>
        /// 大学本科肄业
        /// </summary>
        大学本科肄业 = 23,

        /// <summary>
        /// 大学普通班毕业
        /// </summary>
        大学普通班毕业 = 28,

        /// <summary>
        /// 专科教育
        /// </summary>
        专科教育 = 30,

        /// <summary>
        /// 大学专科毕业
        /// </summary>
        大学专科毕业 = 31,

        /// <summary>
        /// 大学专科结业
        /// </summary>
        大学专科结业 = 32,

        /// <summary>
        /// 大学专科肄业
        /// </summary>
        大学专科肄业 = 33,

        /// <summary>
        /// 中等职业教育
        /// </summary>
        中等职业教育 = 40,

        /// <summary>
        /// 中等专科毕业
        /// </summary>
        中等专科毕业 = 41,

        /// <summary>
        /// 中等专科结业
        /// </summary>
        中等专科结业 = 42,

        /// <summary>
        /// 中等专科肄业
        /// </summary>
        中等专科肄业 = 43,

        /// <summary>
        /// 职业高中毕业
        /// </summary>
        职业高中毕业 = 44,

        /// <summary>
        /// 职业高中结业
        /// </summary>
        职业高中结业 = 45,

        /// <summary>
        /// 职业高中肄业
        /// </summary>
        职业高中肄业 = 46,

        /// <summary>
        /// 技工学校毕业
        /// </summary>
        技工学校毕业 = 47,

        /// <summary>
        /// 技工学校结业
        /// </summary>
        技工学校结业 = 48,

        /// <summary>
        /// 技工学校肄业
        /// </summary>
        技工学校肄业 = 49,

        /// <summary>
        /// 普通高等中学教育
        /// </summary>
        普通高等中学教育 = 60,

        /// <summary>
        /// 普通高中毕业
        /// </summary>
        普通高中毕业 = 61,

        /// <summary>
        /// 普通高中结业
        /// </summary>
        普通高中结业 = 62,

        /// <summary>
        /// 普通高中肄业
        /// </summary>
        普通高中肄业 = 63,

        /// <summary>
        /// 初等中学教育
        /// </summary>
        初等中学教育 = 70,

        /// <summary>
        /// 初中毕业
        /// </summary>
        初中毕业 = 71,

        /// <summary>
        /// 初中肄业
        /// </summary>
        初中肄业 = 72,

        /// <summary>
        /// 小学教育
        /// </summary>
        小学教育 = 80,

        /// <summary>
        /// 小学毕业
        /// </summary>
        小学毕业 = 81,

        /// <summary>
        /// 小学肄业
        /// </summary>
        小学肄业 = 82,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 90,
    }
}
