using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 患者与本人关系代码  GB/T 4761
    /// </summary>
    [Serializable]
    public enum EnumRelationship
    {
        /// <summary>
        /// 本人
        /// </summary>
        本人 = 0,

        /// <summary>
        /// 户主
        /// </summary>
        户主 = 0101,

        /// <summary>
        /// 配偶
        /// </summary>
        配偶 = 1,

        /// <summary>
        /// 子
        /// </summary>
        子 = 2,

        /// <summary>
        /// 孙子
        /// </summary>
        孙子 = 4,

        /// <summary>
        /// 孙女
        /// </summary>
        孙女 = 402,

        /// <summary>
        /// 外孙子
        /// </summary>
        外孙子 = 403,

        /// <summary>
        /// 外孙女
        /// </summary>
        外孙女 = 401,

        /// <summary>
        /// 父母
        /// </summary>
        父母 = 5,

        /// <summary>
        /// 祖父母
        /// </summary>
        祖父母 = 6,

        /// <summary>
        /// 外祖父母
        /// </summary>
        外祖父母 = 601,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 8,

        /// <summary>
        /// 女
        /// </summary>
        女 = 3,

        /// <summary>
        /// 兄
        /// </summary>
        兄 = 7,

        /// <summary>
        /// 弟
        /// </summary>
        弟 = 701,

        /// <summary>
        /// 姐
        /// </summary>
        姐 = 702,

        /// <summary>
        /// 妹
        /// </summary>
        妹 = 703,
    }
}
