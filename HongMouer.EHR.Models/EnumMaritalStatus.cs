using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 婚姻状况 GB/T 2261.2-2003 婚姻状态代码
    /// </summary>
    public enum EnumMaritalStatus
    {

        /// <summary>
        /// 未婚
        /// </summary>
        [Description("未婚")]
        未婚 = 10,

        /// <summary>
        /// 已婚
        /// </summary>
        [Description("已婚")]
        已婚 = 20,

        /// <summary>
        /// 初婚
        /// </summary>
        [Description("初婚")]
        初婚 = 21,

        /// <summary>
        /// 再婚
        /// </summary>
        [Description("再婚")]
        再婚 = 22,

        /// <summary>
        /// 复婚
        /// </summary>
        [Description("复婚")]
        复婚 = 23,

        /// <summary>
        /// 丧偶
        /// </summary>
        [Description("丧偶")]
        丧偶 = 30,

        /// <summary>
        /// 离婚
        /// </summary>
        [Description("离婚")]
        离婚 = 40,

        /// <summary>
        /// 未说明的婚姻状况
        /// </summary>
        [Description("未说明的婚姻状况")]
        未说明 = 90
    }
}
