using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{
	/// <summary>
	/// 本实例为满足layui table组件返回值使用
	/// </summary>
	/// <typeparam name="T"></typeparam>
	[Serializable]
    public class ResponseMessage<T> where T : class, new()
	{

		/// <summary>
		/// /// <summary>
		/// 返回代码 0：成功，1失败
		/// </summary>
		/// </summary>
		public int code { get; set; }

		/// <summary>
		/// 	/// <summary>
		/// 返回消息
		/// </summary>
		/// </summary>
		public string msg { get; set; }

		/// <summary>
		/// 返回总条数
		/// </summary>
		public long count { get; set; }

		/// <summary>
		/// 返回数据
		/// </summary>
		public T data { get; set; }

		/// <summary>
		/// 失败
		/// </summary>
		/// <param name="value"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		public ResponseMessage(long count, int code = -1, string msg = "获取数据失败")
		{
			this.code = code;
			this.msg = msg;
			this.count = count;
			this.data = null;
		}

		/// <summary>
		/// 成功
		/// </summary>
		/// <param name="code"></param>
		/// <param name="msg"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public ResponseMessage(long count, T data, int code = 0, string msg = "")
		{
			this.code = code;
			this.msg = msg;
			this.count = count;
			this.data = data;
		}
	}
}
