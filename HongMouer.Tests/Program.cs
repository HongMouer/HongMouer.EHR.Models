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

            string a = Convert.ToBase64String(AesHelper.AESEncrypt(inputByteArray, Key, IV));


            Console.WriteLine(a);

            Console.WriteLine("Hello World!");
        }
    }
}
