using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT01.00.030 手术操作部位代码
    /// </summary>
    [Serializable]
    public enum EnumOperationPart
    {
        /// <summary>
        /// 双侧鼻孔
        /// </summary>
        [Description("BN")]
        双侧鼻孔 = 01,

        /// <summary>
        /// 臀部
        /// </summary>
        [Description("BU")]
        臀部 = 02,

        /// <summary>
        /// 左臂
        /// </summary>
        [Description("LA")]
        左臂 = 03,

        /// <summary>
        /// 左前胸
        /// </summary>
        [Description("LAC")]
        左前胸 = 04,

        /// <summary>
        /// 左肘前窝
        /// </summary>
        [Description("LACF")]
        左肘前窝 = 05,

        /// <summary>
        /// 左三角肌
        /// </summary>
        [Description("LD")]
        左三角肌 = 06,

        /// <summary>
        /// 左耳
        /// </summary>
        [Description("LE")]
        左耳 = 07,

        /// <summary>
        /// 左外颈
        /// </summary>
        [Description("LEJ")]
        左外颈 = 08,

        /// <summary>
        /// 左足
        /// </summary>
        [Description("LF")]
        左足 = 09,

        /// <summary>
        /// 左臀中肌
        /// </summary>
        [Description("LG")]
        左臀中肌 = 10,

        /// <summary>
        /// 左手
        /// </summary>
        [Description("LH")]
        左手 = 11,

        /// <summary>
        /// 左内颈
        /// </summary>
        [Description("LIJ")]
        左内颈 = 12,

        /// <summary>
        /// 左下腹
        /// </summary>
        [Description("LLAQ")]
        左下腹 = 13,

        /// <summary>
        /// 左下臂
        /// </summary>
        [Description("LLFA")]
        左下臂 = 14,

        /// <summary>
        /// 左中臂
        /// </summary>
        [Description("LMFA")]
        左中臂 = 15,

        /// <summary>
        /// 左侧鼻孔
        /// </summary>
        [Description("LN")]
        左侧鼻孔 = 16,

        /// <summary>
        /// 左后胸
        /// </summary>
        [Description("LPC")]
        左后胸 = 17,

        [Description("LSC")]
        左锁骨下 = 18,

        /// <summary>
        /// 左大腿
        /// </summary>
        [Description("LT")]
        左大腿 = 19,

        /// <summary>
        /// 左上臂
        /// </summary>
        [Description("LUA")]
        左上臂 = 20,

        /// <summary>
        /// 左上腹
        /// </summary>
        [Description("LUAQ")]
        左上腹 = 21,

        //       /// <summary>
        //       /// 左上臂
        //       /// </summary>
        //       [Description("LUFA")]
        //左上臂 =22,

        [Description("LVG")]
        左腹侧臀肌 = 23,

        /// <summary>
        /// 左股外肌
        /// </summary>
        [Description("LVL")]
        左股外肌 = 24,

        /// <summary>
        /// 右眼
        /// </summary>
        [Description("OD")]
        右眼 = 25,

        /// <summary>
        /// 左眼
        /// </summary>
        [Description("OS")]
        左眼 = 26,

        /// <summary>
        /// 双眼
        /// </summary>
        [Description("OU")]
        双眼 = 27,

        /// <summary>
        /// 肛门
        /// </summary>
        [Description("PA")]
        肛门 = 28,

        /// <summary>
        /// 会阴
        /// </summary>
        [Description("PERIN")]
        会阴 = 29,

        /// <summary>
        /// 右臂
        /// </summary>
        [Description("RA")]
        右臂 = 30,

        /// <summary>
        /// 右前胸
        /// </summary>
        [Description("RAC")]
        右前胸 = 31,

        /// <summary>
        /// 右肘前窝
        /// </summary>
        [Description("RACF")]
        右肘前窝 = 32,

        [Description("RD")]
        右侧三角肌 = 33,

        /// <summary>
        /// 右耳
        /// </summary>
        [Description("RE")]
        右耳 = 34,

        /// <summary>
        /// 右外颈
        /// </summary>
        [Description("REJ")]
        右外颈 = 35,

        /// <summary>
        /// 右足
        /// </summary>
        [Description("RF")]
        右足 = 36,

        /// <summary>
        /// 右臀中肌
        /// </summary>
        [Description("RG")]
        右臀中肌 = 37,

        /// <summary>
        /// 右手
        /// </summary>
        [Description("RH")]
        右手 = 38,

        /// <summary>
        /// 右内颈
        /// </summary>
        [Description("RIJ")]
        右内颈 = 39,

        /// <summary>
        /// 右下腹
        /// </summary>
        [Description("RLAQ")]
        右下腹 = 40,

        /// <summary>
        /// 右下臂
        /// </summary>
        [Description("RLFA")]
        右下臂 = 41,

        /// <summary>
        /// 右中臂
        /// </summary>
        [Description("RMFA")]
        右中臂 = 42,

        /// <summary>
        /// 右后胸
        /// </summary>
        [Description("RPC")]
        右后胸 = 43,

        /// <summary>
        /// 右锁骨下
        /// </summary>
        [Description("RSC")]
        右锁骨下 = 44,

        /// <summary>
        /// 右大腿
        /// </summary>
        [Description("RT")]
        右大腿 = 45,

        /// <summary>
        /// 右上臂
        /// </summary>
        [Description("RUA")]
        右上臂 = 46,

        /// <summary>
        /// 右上腹
        /// </summary>
        [Description("RUAQ")]
        右上腹 = 47,

        ///// <summary>
        ///// 右上臂
        ///// </summary>
        //[Description("RUFA")]
        //右上臂 = 48,

        /// <summary>
        /// 右腹侧臀肌
        /// </summary>
        [Description("RVG")]
        右腹侧臀肌 = 49,

        /// <summary>
        /// 右股外侧肌
        /// </summary>
        [Description("RVL")]
        右股外侧肌 = 50,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 99,
    }
}
