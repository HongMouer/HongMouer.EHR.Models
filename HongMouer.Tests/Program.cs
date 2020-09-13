using HongMouer.Common.Utility;
using System;
using System.Text;

namespace HongMouer.Tests
{
    class Program
    {
        private const string Key = "6G-93}j7SxoXo).jm&0uzSXb";

        private const string IV = "0.9I9aDtF/Hp{M(q";

        static void Main(string[] args)
        {



            byte[] inputByteArray = Encoding.UTF8.GetBytes("1升等于多少斤");

            var _Aes = AesHelper.AESEncrypt(inputByteArray, Key, IV);

            string a = Convert.ToBase64String(_Aes);

            Console.WriteLine("SnowflakeHelper.NextId:" + SnowflakeHelper.NextId());

            Console.WriteLine(a);

            Console.WriteLine(Encoding.UTF8.GetString(_Aes));


            //for (long i = 0; i < long.MaxValue; i++)
            //{
            //Console.WriteLine("ObjectId.NewId:" + ObjectIdInt.NewId());
            //}
            //for (long i = 0; i < long.MaxValue; i++)
            //{
            //    Console.WriteLine("ObjectId.GenerateNewStringId:" + ObjectId.NewId());
            //}

            for (long i = 0; i < 1000; i++)
            {
                Console.WriteLine("TimestampId.GetInstance1:" + TimestampId.Instance.GetId());
                Console.WriteLine("TimestampId.GetInstance2:" + TimestampId.Instance.GetId());
                Console.WriteLine("TimestampId.GetInstance3:" + TimestampId.Instance.GetId());
                Console.WriteLine("TimestampId.GetInstance4:" + TimestampId.Instance.GetId());
            }
            Console.WriteLine("Hello World!");
        }
    }
}
