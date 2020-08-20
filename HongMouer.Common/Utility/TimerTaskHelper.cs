using HongMouer.EntityRelationalCore.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace HongMouer.Common.Utility
{

    /// <summary>
    /// 任务处理定时
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class TimerTaskHelper<T> where T : class, new()
    {
        public static readonly object _lock = new object();

        private static readonly Lazy<T> lazy =new Lazy<T>(() => new T());

        public static T Instance { get { return lazy.Value; } }

        public static IRepository Repository;

        protected Timer _Timer;

        protected abstract void RunTask();

        protected void Interval(int interval)
        {
            _Timer = new Timer();
            _Timer.Interval = interval;
            _Timer.Elapsed += Timer_Elapsed;
            _Timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            RunTask();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="interval">间隔时间</param>
        /// <param name="repository">当前数据库实例</param>
        public virtual void Start(int interval, IRepository repository)
        {
            Repository = repository;
            RunTask();
            Interval(interval);
        }
    }
}
