using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;

namespace HongMouer.Common.Utility
{

    /// <summary>
    /// 单例对象操作。定义一个指定类型的单例，该实例的声明周期将跟随整个应用程序
    /// </summary>
    /// <typeparam name="T">单例类型</typeparam>
    public class Singleton<T> where T : class, new()
    {

        private static readonly object _lock = new object();
        private static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new T();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
