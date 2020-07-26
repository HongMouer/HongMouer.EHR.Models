using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT05.10.013 医嘱类别代码
    /// </summary>
    [Serializable]
    public enum EnumOrderCategory
    {
        /// <summary>
        /// 长期医嘱
        /// </summary>
        长期医嘱 = 1,

        /// <summary>
        /// 临时医嘱
        /// </summary>
        临时医嘱 = 2,

        /// <summary>
        /// 出院带药
        /// </summary>
        出院带药 = 3,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 9
    }
}
