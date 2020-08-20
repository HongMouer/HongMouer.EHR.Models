using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HongMouer.EHR.Models
{
    /// <summary>
    /// HongMouerException
    /// </summary>
    [Serializable]
    public class HongMouerException : Exception
    {
        public HongMouerException()
        {
        }

        public HongMouerException(string message) : base(message)
        {
        }

        public HongMouerException(string messageFormat, params object[] args) : base(string.Format(messageFormat, args))
        {
            //Log.Error(string.Format(messageFormat, args), () => { });
        }

        public HongMouerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HongMouerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }


        /// <summary>
        ///  重写GetObjectData方法。如果添加了自定义字段，一定要重写基类GetObjectData方法的实现
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // 序列化自定义数据成员
            //info.AddValue("StringInfo", stringInfo);

            // 调用基类方法，序列化它的成员
            base.GetObjectData(info, context);
        }
    }
}
