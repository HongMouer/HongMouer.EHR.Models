using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace HongMouer.Common.Utility
{
    /// <summary>
    /// AES加密帮助类
    /// </summary>
    public sealed class AesHelper
    {
        public const string Key = "6G-93}j7SxoXo).jm&0uzSXb";

        public const string IV = "0.9I9aDtF/Hp{M(q";

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static byte[] AESEncrypt(string encryptString, string key, string iv)
        {
            return AESEncrypt(Encoding.UTF8.GetBytes(encryptString), key, iv);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static byte[] AESEncrypt(byte[] encryptString, string key, string iv)
        {
            //分组加密算法   
            SymmetricAlgorithm Aes = Rijndael.Create();
            //byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);//得到需要加密的字节数组       
            //设置密钥及密钥向量
            Aes.Key = Encoding.UTF8.GetBytes(key);
            Aes.IV = Encoding.UTF8.GetBytes(iv); ;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, Aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(encryptString, 0, encryptString.Length);
                    cs.FlushFinalBlock();
                    byte[] cipherBytes = ms.ToArray();//得到加密后的字节数组   
                    cs.Close();
                    ms.Close();
                    return cipherBytes;
                    //return Convert.ToBase64String(cipherBytes); //返回字符串
                }
            }
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static string AESEncryptToHex(byte[] encryptString, string key, string iv)
        {
            string ret = "";
            AESEncrypt(encryptString, key, iv).Aggregate(ret, (current, t) => $"{current}{t:X2}");

            return ret;
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static string AESEncryptToHex(string encryptString, string key, string iv)
        {
            string ret = "";
            AESEncrypt(encryptString, key, iv).Aggregate(ret, (current, t) => $"{current}{t:X2}");

            return ret;
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static string AESEncryptToBase64(byte[] encryptString, string key, string iv)
        {
            return Convert.ToBase64String(AESEncrypt(encryptString, key, iv));
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static string AESEncryptToBase64(string encryptString, string key, string iv)
        {
            return Convert.ToBase64String(AESEncrypt(encryptString, key, iv));
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static byte[] AESDecrypt(byte[] decryptString, string key, string iv)
        {
            SymmetricAlgorithm Aes = Rijndael.Create();
            Aes.Key = Encoding.UTF8.GetBytes(key);
            Aes.IV = Encoding.UTF8.GetBytes(iv);
            //byte[] inputByteArray = Convert.FromBase64String(decryptString);//得到需要加密的字节数组
            byte[] decryptBytes = new byte[decryptString.Length];
            using (MemoryStream ms = new MemoryStream(decryptString))
            {
                using (CryptoStream cs = new CryptoStream(ms, Aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cs.Read(decryptBytes, 0, decryptBytes.Length);
                    cs.Close();
                    ms.Close();
                }
            }
            return decryptBytes;
            //return Encoding.UTF8.GetString(decryptBytes); //返回字符串
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static byte[] AESDecryptBase64(string decryptString, string key, string iv)
        {
            return AESDecrypt(Convert.FromBase64String(decryptString), key, iv);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static string AESDecrypBase64(string decryptString, string key, string iv)
        {
            return Encoding.UTF8.GetString(AESDecrypt(Convert.FromBase64String(decryptString), key, iv));
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static string AESDecryptHex(string decryptString, string key, string iv)
        {
            return Encoding.UTF8.GetString(AESDecrypt(StringHelper.HexToByte(decryptString), key, iv));
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="inputdata">输入的数据</param>
        /// <param name="iv">向量128位(Iv的字符串长度为16)</param>
        /// <param name="key">加密密钥(key的长度为32)</param>
        /// <returns></returns>
        public static byte[] AESDecrypHex(string decryptString, string key, string iv)
        {
            return AESDecrypt(StringHelper.HexToByte(decryptString), key, iv);
        }
    }
}
