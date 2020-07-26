using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// CT07.00.002 交易类别
    /// </summary>
    [Serializable]
    public enum EnumTransactionCategory
    {

        /// <summary>
        /// 负交易
        /// </summary>
        负交易 = 0,

        /// <summary>
        /// 正交易
        /// </summary>
        正交易 = 1,
    }
}
