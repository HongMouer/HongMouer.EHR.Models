//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HongMouer.Common.Utility
//{

//    /// <summary>
//    /// shen
//    /// </summary>
//    public class ObjectIdInt
//    {
//        private readonly static ObjectIdFactory factory = new ObjectIdFactory();

//        public ObjectIdInt(byte[] hexData)
//        {
//            this.Hex = hexData;
//            ReverseHex();
//        }

//        public override string ToString()
//        {
//            if (Hex == null)
//                Hex = new byte[12];
//            StringBuilder hexText = new StringBuilder();
//            for (int i = 0; i < this.Hex.Length; i++)
//            {
//                hexText.Append(this.Hex[i].ToString("x2"));
//            }
//            return hexText.ToString();
//        }

//        public override int GetHashCode() => ToString().GetHashCode();

//        public ObjectIdInt(string value)
//        {
//            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("value");
//            if (value.Length != 24) throw new ArgumentOutOfRangeException("value should be 24 characters");
//            Hex = new byte[12];
//            for (int i = 0; i < value.Length; i += 2)
//            {
//                try
//                {
//                    Hex[i / 2] = Convert.ToByte(value.Substring(i, 2), 16);
//                }
//                catch
//                {
//                    Hex[i / 2] = 0;
//                }
//            }
//            ReverseHex();
//        }

//        private void ReverseHex()
//        {
//            int copyIdx = 0;
//            byte[] time = new byte[4];
//            Array.Copy(Hex, copyIdx, time, 0, 4);
//            Array.Reverse(time);
//            this.Timestamp = BitConverter.ToInt32(time, 0);
//            copyIdx += 4;
//            byte[] mid = new byte[4];
//            Array.Copy(Hex, copyIdx, mid, 0, 3);
//            this.Machine = BitConverter.ToInt32(mid, 0);
//            copyIdx += 3;
//            byte[] pids = new byte[4];
//            Array.Copy(Hex, copyIdx, pids, 0, 2);
//            Array.Reverse(pids);
//            this.ProcessId = BitConverter.ToInt32(pids, 0);
//            copyIdx += 2;
//            byte[] inc = new byte[4];
//            Array.Copy(Hex, copyIdx, inc, 0, 3);
//            Array.Reverse(inc);
//            this.Increment = BitConverter.ToInt32(inc, 0);
//        }

//        public static ObjectIdInt NewId() => factory.NewId();

//        public int CompareTo(ObjectIdInt other)
//        {
//            if (other is null)
//                return 1;
//            for (int i = 0; i < Hex.Length; i++)
//            {
//                if (Hex[i] < other.Hex[i])
//                    return -1;
//                else if (Hex[i] > other.Hex[i])
//                    return 1;
//            }
//            return 0;
//        }

//        public bool Equals(ObjectIdInt other) => CompareTo(other) == 0;
//        public static bool operator <(ObjectIdInt a, ObjectIdInt b) => a.CompareTo(b) < 0;
//        public static bool operator <=(ObjectIdInt a, ObjectIdInt b) => a.CompareTo(b) <= 0;
//        public static bool operator ==(ObjectIdInt a, ObjectIdInt b) => a.Equals(b);
//        public override bool Equals(object obj) => base.Equals(obj);
//        public static bool operator !=(ObjectIdInt a, ObjectIdInt b) => !(a == b);
//        public static bool operator >=(ObjectIdInt a, ObjectIdInt b) => a.CompareTo(b) >= 0;
//        public static bool operator >(ObjectIdInt a, ObjectIdInt b) => a.CompareTo(b) > 0;
//        public static implicit operator string(ObjectIdInt objectId) => objectId.ToString();
//        public static implicit operator ObjectIdInt(string objectId) => new ObjectIdInt(objectId);
//        public static ObjectIdInt Empty { get { return new ObjectIdInt("000000000000000000000000"); } }
//        public byte[] Hex { get; private set; }
//        public int Timestamp { get; private set; }
//        public int Machine { get; private set; }
//        public int ProcessId { get; private set; }
//        public int Increment { get; private set; }
//    }
//}
