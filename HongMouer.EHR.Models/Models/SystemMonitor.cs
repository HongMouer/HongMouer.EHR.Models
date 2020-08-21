using HongMouer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 系统监控表
    /// </summary>
    [Table("SYS_MONITOR")]
    public class SystemMonitor:BaseModels
    {
        /// <summary>
        /// 链接ID
        /// </summary>
        [Column("CONNECTION_ID")]
        public string ConnectionId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>

        [Column("HOST_NAME")]
        public string HostName { get; set; }

        /// <summary>
        /// 客户端地址
        /// </summary>

        [Column("CLIENT_IP")]
        public string ClientIP { get; set; }

        /// <summary>
        /// 端口
        /// </summary>

        [Column("PORT")]
        public int Port { get; set; }

        /// <summary>
        /// 编号
        /// </summary>

        [Column("TRACE_IDENTIFIER")]
        public string TraceIdentifier { get; set; }

        /// <summary>
        /// 请求方法
        /// </summary>
        [Column("METHOD")]
        public string Method { get; set; }

        /// <summary>
        /// 请求路径
        /// </summary>

        [Column("PATH")]
        public string Path { get; set; }

        /// <summary>
        /// 用时
        /// </summary>

        [Column("TIMES")]
        public long Times { get; set; }
        
    }
}
