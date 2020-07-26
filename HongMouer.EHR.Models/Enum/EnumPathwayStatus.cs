using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT05.10.009 路径状态代码
    /// </summary>
    [Serializable]
    public enum EnumPathwayStatus
    {

        /// <summary>
        /// 入径
        /// </summary>
        入径 = 1,

        /// <summary>
        /// 出径
        /// </summary>
        出径 = 2,

        /// <summary>
        /// 执行
        /// </summary>
        执行 = 3,

        /// <summary>
        /// 完成
        /// </summary>
        完成 = 4,

        /// <summary>
        /// 变异
        /// </summary>
        变异 = 5,

        /// <summary>
        /// 退出
        /// </summary>
        退出 = 6,

        /// <summary>
        /// 未符合
        /// </summary>
        未符合 = 9,
    }
}
