using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV05.10.023 手术切口愈合等级代码
    /// </summary>
    [Serializable]
    public enum EnumOperationIncisionHealGrade
    {

        /// <summary>
        /// 类切口
        /// </summary>
        类切口 = 0 ,

        /// <summary>
        /// 切口等级I/愈合类型甲
        /// </summary>
        切口等级I_愈合类型甲 =1 ,

        /// <summary>
        /// 切口等级I/愈合类型乙
        /// </summary>
        切口等级I_愈合类型乙 =2 ,

        /// <summary>
        /// 切口等级I/愈合类型丙
        /// </summary>
        切口等级I_愈合类型丙 =3 ,

        /// <summary>
        /// 切口等级II/愈合类型甲
        /// </summary>
        切口等级II_愈合类型甲 =4 ,

        /// <summary>
        /// 切口等级II/愈合类型乙
        /// </summary>
        切口等级II_愈合类型乙 =5 ,

        /// <summary>
        /// 切口等级II/愈合类型丙
        /// </summary>
        切口等级II_愈合类型丙 =6 ,

        /// <summary>
        /// 切口等级III/愈合类型甲
        /// </summary>
        切口等级III_愈合类型甲 =7 ,

        /// <summary>
        /// 切口等级III/愈合类型乙
        /// </summary>
        切口等级III_愈合类型乙 =8 ,

        /// <summary>
        /// 切口等级III/愈合类型丙
        /// </summary>
        切口等级III_愈合类型丙 =9 ,

        /// <summary>
        /// 切口等级I/其他
        /// </summary>
        切口等级I_其他 =10,

        /// <summary>
        /// 切口等级II/其他
        /// </summary>
        切口等级II_其他 =11,

        /// <summary>
        /// 切口等级III/其他
        /// </summary>
        切口等级III_其他 =12,

        /// <summary>
        /// 其他切口类型
        /// </summary>
        其他切口类型 = 99, 
    }
}
