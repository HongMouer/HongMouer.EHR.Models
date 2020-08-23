using HongMouer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{
    [Serializable]
    public class BaseModels
    {

        /// <summary>
        /// 状态
        /// </summary>
        [Column("STATUS")]
        public int Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Column("REMARK")]
        public string Remark { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [Column("SORT")]
        public int Sort { get; set; }

        /// <summary>
        /// 拼音输入码
        /// </summary>
        [Column("PINYIN_CODE")]
        public string PinyinCode { get; set; }

        /// <summary>
        /// 五笔输入码
        /// </summary>
        [Column("FIVE_PEN_CODE")]
        public string FivePenCode { get; set; }

        /// <summary>
        /// 数据版本号
        /// </summary>
        [Column("ROWVERSION")]
        public long RowVersion { get; set; } = DateTime.Now.Ticks;

        /// <summary>
        /// 创建人Id
        /// </summary>
        [Column("CREATE_USER_ID")]
        public int? CreateUserId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [Column("CREATE_USER_NAME")]
        public string CreateUserName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column("CREATE_TIME")]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 更新人Id
        /// </summary>
        [Column("MODIFY_USER_ID")]
        public int? ModifyUserID { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [Column("Modify_User_Name")]
        public string ModifyUserName { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Column("Modify_Time")]
        public DateTime? ModifyTime { get; set; }
    }
}
