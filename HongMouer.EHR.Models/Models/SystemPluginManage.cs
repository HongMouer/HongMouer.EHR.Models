using HongMouer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 系统插件表
    /// </summary>
    [Table("SYS_PLUGIN")]
    public class SystemPlugin: BaseModels
    {

        /// <summary>
        /// 编号
        /// </summary>
        [Key("ID")]
        [Column("ID")]
        public long Id { get; set; }

        /// <summary>
        /// 功能
        /// </summary>
        [Column("NAME")]
        public string Name { get; set; }

        /// <summary>
        /// 系统模块
        /// </summary>
        [Column("MODULE")]
        public string Module { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [Column("GROUP_NAME")]
        public string GroupName { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [Column("VERSION")]
        public string Version { get; set; }

        /// <summary>
        /// 插件名
        /// </summary>
        [Column("PLUGIN_FULL_NAME")]
        public string PluginFullName { get; set; }

        /// <summary>
        /// 接口名
        /// </summary>
        [Column("INTERFACE_FULL_NAME")]
        public string InterfaceFullName { get; set; }
    }
}
