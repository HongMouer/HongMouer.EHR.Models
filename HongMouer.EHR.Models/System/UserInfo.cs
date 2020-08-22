using HongMouer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{
    /// <summary>
    /// 用户表
    /// </summary>
    [Table("SYS_USER")]
    [Serializable]
    public class UserInfo : BaseModels
    {

        /// <summary>
        /// 用户id
        /// </summary>
        [Key("USER_ID"), Column("USER_ID")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户工号
        /// </summary>
        [Column("User_Num")]
        public string UserNum { get; set; }

        /// <summary>
        /// /用户名
        /// </summary>
        [Column("User_Name")]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Column("User_Password")]
        public string UserPassword { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [Column("Nick_Name")]
        public string NickName { get; set; }

        /// <summary>
        /// 头像地址
        /// </summary>
        [Column("Head_Portrait_Url")]
        public string HeadPortraitUrl { get; set; }


        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [Column("Validity_Start_Time")]
        public DateTime? ValidityStartTime { get; set; }

        /// <summary>
        /// 有效期结束时间
        /// </summary>
        [Column("Validity_End_Time")]
        public DateTime? ValidityEndTime { get; set; }


        /// <summary>
        /// 当前所属科室，每次切换系统更新该字段
        /// </summary>
        [Column("Current_Dept_Code")]
        public int? CurrentDeptCode { get; set; }

        /// <summary>
        /// 当前所属病区，每次切换系统更新该字段
        /// </summary>
        [Column("Current_Ward_Code")]
        public int? CurrentWardCode { get; set; }

        /// <summary>
        /// 行政科室
        /// </summary>
        [Column("Executive_Dept_Code")]
        public int? ExecutiveDeptCode { get; set; }

        /// <summary>
        /// 用户职称,主任、副主任等
        /// </summary>
        [Column("User_Title_Code")]
        public int? UserTitleCode { get; set; }

        /// <summary>
        /// 用户职称名称
        /// </summary>
        [Column("User_Title_Name")]
        public string UserTitleName { get; set; }

        /// <summary>
        /// 用户职务代码 医生、护士、技术员等
        /// </summary>
        [Column("Job_Code")]
        public string JobCode { get; set; }

        /// <summary>
        /// 用户职务名称
        /// </summary>
        [Column("Job_Name")]
        public string JobName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [Column("Tel")]
        public string Tel { get; set; }

        /// <summary>
        /// 所属院区
        /// </summary>
        [Column("Yard_Code")]
        public int? YardCode { get; set; }

        /// <summary>
        /// 当前院区
        /// </summary>
       [Column("Curr_Yard_Code")]
        public int? CurrYardCode { get; set; }

        /// <summary>
        /// 医生电子签名 医生电子签名图片ID
        /// </summary>
       [Column("Doctor_Stamp_Id")]
        public string DoctorStampId { get; set; }

        /// <summary>
        /// 权限组
        /// </summary>
       [Column("RIGHTS_GROUP")]
        public string RightsGroup { get; set; }

        /// <summary>
        /// 精神类药处方权
        /// </summary>
        [Column("Mental_Right")]
        public string MentalRight { get; set; }

        /// <summary>
        /// 麻醉类药处方权
        /// </summary>
        [Column("Anesthesia_Right")]
        public string AnesthesiaRight { get; set; }

        /// <summary>
        /// 毒类药品处方权
        /// </summary>
        [Column("Toxicity_Right ")]
        public string ToxicityRight { get; set; }

        /// <summary>
        /// 放射性药品处方权
        /// </summary>
       [Column("RAD_RIGHT")]
        public string RadRight { get; set; }

        /// <summary>
        /// 手术主刀权
        /// </summary>
        [Column("OPERATION_RIGHT")]
        public string OperationRight { get; set; }

        /// <summary>
        /// 抗菌药物处方权
        /// </summary>
        [Column("ANTIBIOTICS_RIGHT")]
        public string AntibioticsRight { get; set; }

        /// <summary>
        /// 医保用药处方权
        /// </summary>
        [Column("Medicine_Drug_RIGHT")]
        public string MedicineDrugRight { get; set; }
    }
}
