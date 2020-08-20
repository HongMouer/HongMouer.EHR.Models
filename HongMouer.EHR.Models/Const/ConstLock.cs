using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 全局常量
    /// </summary>
    public static class ConstLock
    {
        public static object syncRoot = new object();//加锁对象  
    }
}
