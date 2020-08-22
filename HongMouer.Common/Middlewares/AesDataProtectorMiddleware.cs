using HongMouer.Common.Utility;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Text;


namespace HongMouer.Common
{
    internal class AesDataProtectorMiddleware : IDataProtector
    {

        public IDataProtector CreateProtector(string purpose)
        {
            return this;
        }

        public byte[] Protect(byte[] plaintext)
        {
            return AesHelper.AESEncrypt(plaintext, AesHelper.Key, AesHelper.IV);
        }

        public byte[] Unprotect(byte[] protectedData)
        {
            return AesHelper.AESDecrypt(protectedData, AesHelper.Key, AesHelper.IV);
        }
    }
}
