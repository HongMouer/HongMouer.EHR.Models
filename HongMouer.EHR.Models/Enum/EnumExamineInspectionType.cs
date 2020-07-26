using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV5199.01 检验检查类别代码，进行扩展
    /// </summary>
    [Serializable]
    public enum EnumExamineInspectionType
    {
        /// <summary>
        /// 问询
        /// </summary>
        问询 = 1,

        /// <summary>
        /// 物理
        /// </summary>
        物理 = 2,

        /// <summary>
        /// 计算机X线断层摄影
        /// </summary>
        计算机X线断层摄影 = 201,

        /// <summary>
        /// 核磁共振成像
        /// </summary>
        核磁共振成像 = 202,

        /// <summary>
        /// 数字减影血管造影
        /// </summary>
        数字减影血管造影 = 203,

        /// <summary>
        /// 普通X光摄影
        /// </summary>
        普通X光摄影 = 204,

        /// <summary>
        /// 特殊X光摄影
        /// </summary>
        特殊X光摄影 = 205,

        /// <summary>
        /// 超声检查
        /// </summary>
        超声检查 = 206,

        /// <summary>
        /// 病理检查
        /// </summary>
        病理检查 = 207,

        /// <summary>
        /// 内镜检查
        /// </summary>
        内镜检查 = 208,

        /// <summary>
        /// 核医学检查
        /// </summary>
        核医学检查 = 209,

        /// <summary>
        /// 其他检查项目
        /// </summary>
        其他检查项目 = 299,

        /// <summary>
        /// 实验室
        /// </summary>
        实验室 = 3,

        /// <summary>
        /// 临检项目
        /// </summary>
        临检项目 = 301,

        /// <summary>
        /// 血生化项目
        /// </summary>
        血生化项目 = 302,

        /// <summary>
        /// 免疫项目
        /// </summary>
        免疫项目 = 303,

        /// <summary>
        /// 微生物项目
        /// </summary>
        微生物项目 = 304,

        /// <summary>
        /// 血液学项目
        /// </summary>
        血液学项目 = 305,

        /// <summary>
        /// 其他检验项目
        /// </summary>
        其他检验项目 = 399,

        /// <summary>
        /// 心电
        /// </summary>
        心电 = 4,

        /// <summary>
        /// 十二导同步心电检查
        /// </summary>
        十二导同步心电检查 = 401,

        /// <summary>
        /// 影像
        /// </summary>
        影像 = 9,
    }
}
