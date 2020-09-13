using HongMouer.Common.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HongMouer.Common.Utility
{
    /// <summary>
    /// 参数检查 操作
    /// </summary>
    public static  class Check
    {
        #region Required(断言)

        /// <summary>
        /// 验证指定值的断言<paramref name="assertion"/>是否为真，如果不为真，抛出指定消息<paramref name="message"/>的指定类型<typeparamref name="TException"/>异常
        /// </summary>
        /// <typeparam name="TException">异常类型</typeparam>
        /// <param name="assertion">要验证的断言</param>
        /// <param name="message">异常消息</param>
        /// <exception cref="ArgumentNullException"></exception>
        private static void Require<TException>(bool assertion, string message) where TException : Exception
        {
            if (assertion)
                return;
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentNullException(nameof(message));
            var exception = (TException)Activator.CreateInstance(typeof(TException), message);
            throw exception;
        }

        /// <summary>
        /// 验证指定值的断言表达式是否为真，不为值抛出<see cref="Exception"/>异常
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">要判断的值</param>
        /// <param name="assertionFunc">要验证的断言</param>
        /// <param name="message">异常消息</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void Required<T>(T value, Func<T, bool> assertionFunc, string message)
        {
            if (assertionFunc == null)
                throw new ArgumentNullException(nameof(assertionFunc));
            Require<Exception>(assertionFunc(value), message);
        }

        /// <summary>
        /// 验证指定值的断言表达式是否为真，不为真抛出<see cref="Exception"/>异常
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <typeparam name="TException">异常类型</typeparam>
        /// <param name="value">要判断的值</param>
        /// <param name="assertionFunc">要验证的断言</param>
        /// <param name="message">异常消息</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void Required<T, TException>(T value, Func<T, bool> assertionFunc, string message)
            where TException : Exception
        {
            if (assertionFunc == null)
                throw new ArgumentNullException(nameof(assertionFunc));
            Require<TException>(assertionFunc(value), message);
        }

        #endregion

        #region NotNull(不可空检查)

        /// <summary>
        /// 检查参数不能为空引用，否则抛出<see cref="ArgumentNullException"/>异常
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">要判断的值</param>
        /// <param name="paramName">参数名</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static T NotNull<T>(T value, string paramName)
        {
            Require<ArgumentNullException>(value != null, string.Format(R.ParameterCheck_NotNull, paramName));
            return value;
        }

        /// <summary>
        /// 检查字符串不能为空引用或空字符串，否则抛出<see cref="ArgumentNullException"/>异常或<see cref="ArgumentException"/>异常
        /// </summary>
        /// <param name="value">要判断的值</param>
        /// <param name="paramName">参数名</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static void NotNullOrEmpty(string value, string paramName)
        {
            NotNull(value, paramName);
            Require<ArgumentException>(!string.IsNullOrEmpty(value), string.Format(R.ParameterCheck_NotNullOrEmpty_String, paramName));
        }

        /// <summary>
        /// 检查Guid值不能为Guid.Empty，否则抛出<see cref="ArgumentException"/>异常
        /// </summary>
        /// <param name="value">要判断的值</param>
        /// <param name="paramName">参数名</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static void NotEmpty(Guid value, string paramName) => Require<ArgumentException>(value != Guid.Empty, string.Format(R.ParameterCheck_NotEmpty_Guid, paramName));

        /// <summary>
        /// 检查集合不能为空引用或空集合，否则抛出<see cref="ArgumentNullException"/>异常或<see cref="ArgumentException"/>异常。
        /// </summary>
        /// <typeparam name="T">集合项的类型</typeparam>
        /// <param name="collection">要判断的值</param>
        /// <param name="paramName">参数名</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static void NotNullOrEmpty<T>(IEnumerable<T> collection, string paramName)
        {
            NotNull(collection, paramName);
            Require<ArgumentException>(collection.Any(), string.Format(R.ParameterCheck_NotNullOrEmpty_Collection, paramName));
        }

        /// <summary>
        /// 检查字典不能为空引用或空字典，否则抛出<see cref="ArgumentNullException"/>异常或<see cref="ArgumentException"/>异常。
        /// </summary>
        /// <typeparam name="T">值类型</typeparam>
        /// <param name="dictionary">字典</param>
        /// <param name="paramName">参数名</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static void NotNullOrEmpty<T>(IDictionary<string, T> dictionary, string paramName)
        {
            NotNull(dictionary, paramName);
            Require<ArgumentException>(dictionary.Any(), string.Format(R.ParameterCheck_NotNullOrEmpty_Collection));
        }

        #endregion

        #region Between(范围检查)

        /// <summary>
        /// 检查参数必须小于[或可等于，参数canEqual]指定值，否则抛出<see cref="ArgumentOutOfRangeException"/>异常
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="value">要判断的值</param>
        /// <param name="paramName">参数名</param>
        /// <param name="target">要比较的值</param>
        /// <param name="canEqual">是否可等于</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void LessThan<T>(T value, string paramName, T target, bool canEqual = false)
            where T : IComparable<T>
        {
            bool flag = canEqual ? value.CompareTo(target) <= 0 : value.CompareTo(target) < 0;
            string format = canEqual ? R.ParameterCheck_NotLessThanOrEqual : R.ParameterCheck_NotLessThan;
            Require<ArgumentOutOfRangeException>(flag, string.Format(format, paramName, target));
        }

        /// <summary>
        /// 检查参数必须大于[或可等于，参数canEqual]指定值，否则抛出<see cref="ArgumentOutOfRangeException"/>异常
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="value">要判断的值</param>
        /// <param name="paramName">参数名</param>
        /// <param name="target">要比较的值</param>
        /// <param name="canEqual">是否可等于</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void GreaterThan<T>(T value, string paramName, T target, bool canEqual = false)
            where T : IComparable<T>
        {
            bool flag = canEqual ? value.CompareTo(target) >= 0 : value.CompareTo(target) > 0;
            string format = canEqual ? R.ParameterCheck_NotGreaterThanOrEqual : R.ParameterCheck_NotGreaterThan;
            Require<ArgumentOutOfRangeException>(flag, string.Format(format, paramName, target));
        }

        /// <summary>
        /// 检查参数必须在指定范围之间，否则抛出<see cref="ArgumentOutOfRangeException"/>异常
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="value">要判断的值</param>
        /// <param name="paramName">参数名</param>
        /// <param name="start">比较范围的起始值</param>
        /// <param name="end">比较范围的结束值</param>
        /// <param name="startEqual">是否可等于起始值</param>
        /// <param name="endEqual">是否可等于结束值</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void Between<T>(T value, string paramName, T start, T end, bool startEqual = false,
            bool endEqual = false) where T : IComparable<T>
        {
            bool flag = startEqual ? value.CompareTo(start) >= 0 : value.CompareTo(start) > 0;
            string message = startEqual
                ? string.Format(R.ParameterCheck_Between, paramName, start, end)
                : string.Format(R.ParameterCheck_BetweenNotEqual, paramName, start, end, start);
            Require<ArgumentOutOfRangeException>(flag, message);

            flag = endEqual ? value.CompareTo(end) <= 0 : value.CompareTo(end) < 0;
            message = endEqual
                ? string.Format(R.ParameterCheck_Between, paramName, start, end)
                : string.Format(R.ParameterCheck_BetweenNotEqual, paramName, start, end, end);
            Require<ArgumentOutOfRangeException>(flag, message);
        }

        /// <summary>
        /// 检查参数不能为负数或零，否则抛出<see cref="ArgumentOutOfRangeException"/>异常
        /// </summary>
        /// <param name="timeSpan">时间戳</param>
        /// <param name="paramName">参数名</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void NotNegativeOrZero(TimeSpan timeSpan, string paramName) => Require<ArgumentOutOfRangeException>(timeSpan > TimeSpan.Zero, paramName);

        #endregion

        #region IO(文件检查)

        /// <summary>
        /// 检查指定路径的文件夹必须存在，否则抛出<see cref="DirectoryNotFoundException"/>异常
        /// </summary>
        /// <param name="directory">目录路径</param>
        /// <param name="paramName">参数名</param>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public static void DirectoryExists(string directory, string paramName = null)
        {
            NotNull(directory, paramName);
            Require<DirectoryNotFoundException>(Directory.Exists(directory), string.Format(R.ParameterCheck_DirectoryNotExists, directory));
        }

        /// <summary>
        /// 检查指定路径的文件必须存在，否则抛出<see cref="FileNotFoundException"/>异常。
        /// </summary>
        /// <param name="fileName">文件路径，包含文件名</param>
        /// <param name="paramName">参数名</param>
        /// <exception cref="FileNotFoundException"></exception>
        public static void FileExists(string fileName, string paramName = null)
        {
            NotNull(fileName, paramName);
            Require<FileNotFoundException>(File.Exists(fileName), string.Format(R.ParameterCheck_FileNotExists, fileName));
        }

        #endregion

        #region CheckNull(检查对象是否为null)

        /// <summary>
        /// 检查对象是否为null，为null则抛出<see cref="ArgumentNullException"/>异常
        /// </summary>
        /// <param name="obj">对象</param>
        /// <param name="parameterName">参数名</param>
        public static void CheckNull(this object obj, string parameterName)
        {
            if (obj == null)
                throw new ArgumentNullException(parameterName);
        }

        #endregion

        #region IsEmpty(是否为空)

        /// <summary>
        /// 判断 字符串 是否为空、null或空白字符串
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsEmpty(this string value) => string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// 判断 Guid 是否为空、null或Guid.Empty
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsEmpty(this Guid value) => value == Guid.Empty;

        /// <summary>
        /// 判断 Guid 是否为空、null或Guid.Empty
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsEmpty(this Guid? value) => value == null || IsEmpty(value.Value);

        /// <summary>
        /// 判断 StringBuilder 是否为空
        /// </summary>
        /// <param name="sb">数据</param>
        public static bool IsEmpty(this StringBuilder sb) => sb == null || sb.Length == 0 || sb.ToString().IsEmpty();

        /// <summary>
        /// 判断 迭代集合 是否为空
        /// </summary>
        /// <typeparam name="T">泛型对象</typeparam>
        /// <param name="list">数据</param>
        public static bool IsEmpty<T>(this IEnumerable<T> list) => null == list || !list.Any();

        /// <summary>
        /// 判断 字典 是否为空
        /// </summary>
        /// <typeparam name="TKey">键类型</typeparam>
        /// <typeparam name="TValue">值类型</typeparam>
        /// <param name="dictionary">数据</param>
        public static bool IsEmpty<TKey, TValue>(this IDictionary<TKey, TValue> dictionary) => null == dictionary || dictionary.Count == 0;

        /// <summary>
        /// 判断 字典 是否为空
        /// </summary>
        /// <param name="dictionary">数据</param>
        public static bool IsEmpty(this IDictionary dictionary) => null == dictionary || dictionary.Count == 0;

        #endregion

        #region IsNull(是否为空)

        /// <summary>
        /// 判断目标对象是否为空
        /// </summary>
        /// <param name="target">目标对象</param>
        public static bool IsNull(this object target) => target.IsNull<object>();

        /// <summary>
        /// 判断目标对象是否为空
        /// </summary>
        /// <typeparam name="T">目标对象类型</typeparam>
        /// <param name="target">目标对象</param>
        public static bool IsNull<T>(this T target) => ReferenceEquals(target, null);

        #endregion

        #region NotEmpty(是否非空)

        /// <summary>
        /// 判断 字符串 是否非空
        /// </summary>
        /// <param name="value">数据</param>
        public static bool NotEmpty(this string value) => !string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// 判断 Guid 是否非空
        /// </summary>
        /// <param name="value">数据</param>
        public static bool NotEmpty(this Guid value) => value != Guid.Empty;

        /// <summary>
        /// 判断 Guid? 是否非空
        /// </summary>
        /// <param name="value">数据</param>
        public static bool NotEmpty(this Guid? value) => value != null && value != Guid.Empty;

        /// <summary>
        /// 判断 StringBuilder 是否为空
        /// </summary>
        /// <param name="sb">数据</param>
        public static bool NotEmpty(this StringBuilder sb) => sb != null && sb.Length != 0 && sb.ToString().NotEmpty();

        /// <summary>
        /// 判断 迭代集合 是否非空
        /// </summary>
        /// <typeparam name="T">泛型对象</typeparam>
        /// <param name="enumerable">数据</param>
        public static bool NotEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
                return false;
            if (enumerable.Any())
                return true;
            return false;
        }

        #endregion

        #region IsZeroOrMinus(是否为0或负数)

        /// <summary>
        /// 判断 short 是否为0或负数
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsZeroOrMinus(this short value) => value <= 0;

        /// <summary>
        /// 判断 int 是否为0或负数
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsZeroOrMinus(this int value) => value <= 0;

        /// <summary>
        /// 判断 long 是否为0或负数
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsZeroOrMinus(this long value) => value <= 0;

        /// <summary>
        /// 判断 float 是否为0或负数
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsZeroOrMinus(this float value) => value <= 0;

        /// <summary>
        /// 判断 double 是否为0或负数
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsZeroOrMinus(this double value) => value <= 0;

        /// <summary>
        /// 判断 decimal 是否为0或负数
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsZeroOrMinus(this decimal value) => value <= 0;

        #endregion

        #region IsPercentage(是否为百分数)

        /// <summary>
        /// 判断 float 是否为百分数
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsPercentage(this float value) => value > 0 && value <= 1;

        /// <summary>
        /// 判断 double 是否为百分数
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsPercentage(this double value) => value > 0 && value <= 1;

        /// <summary>
        /// 判断 decimal 是否为百分数
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsPercentage(this decimal value) => value > 0 && value <= 1;

        #endregion

        #region IsZeroOrPercentage(是否为0或百分数)

        /// <summary>
        /// 判断 float 是否为0或百分数
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsZeroOrPercentage(this float value) => value.IsPercentage() || value.Equals(0f);

        /// <summary>
        /// 判断 double 是否为0或百分数
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsZeroOrPercentage(this double value) => value.IsPercentage() || value.Equals(0d);

        /// <summary>
        /// 判断 decimal 是否为0或百分数
        /// </summary>
        /// <param name="value">数据</param>
        public static bool IsZeroOrPercentage(this decimal value) => value.IsPercentage() || value.Equals(0m);

        #endregion

        //#region Required(断言)

        ///// <summary>
        ///// 验证指定值的断言表达式是否为真，不为值抛出<see cref="Exception"/>异常
        ///// </summary>
        ///// <typeparam name="T">对象类型</typeparam>
        ///// <param name="value">要判断的值</param>
        ///// <param name="assertionFunc">要验证的断言</param>
        ///// <param name="message">异常消息</param>
        //public static void Required<T>(this T value, Func<T, bool> assertionFunc, string message) => Check.Required<T>(value, assertionFunc, message);

        ///// <summary>
        ///// 验证指定值的断言表达式是否为真，不为真抛出<see cref="Exception"/>异常
        ///// </summary>
        ///// <typeparam name="T">对象类型</typeparam>
        ///// <typeparam name="TException">异常类型</typeparam>
        ///// <param name="value">要判断的值</param>
        ///// <param name="assertionFunc">要验证的断言</param>
        ///// <param name="message">异常消息</param>
        //public static void Required<T, TException>(this T value, Func<T, bool> assertionFunc, string message)
        //    where TException : Exception =>
        //    Check.Required<T, TException>(value, assertionFunc, message);

        //#endregion

        #region CheckNotNull(不可空检查)

        /// <summary>
        /// 检查参数不能为空引用，否则抛出<see cref="ArgumentNullException"/>异常
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">要判断的值</param>
        /// <param name="paramName">参数名</param>
        public static void CheckNotNull<T>(this T value, string paramName) where T : class => Check.NotNull<T>(value, paramName);

        /// <summary>
        /// 检查字符串不能为空引用或空字符串，否则抛出<see cref="ArgumentNullException"/>异常或<see cref="ArgumentException"/>异常
        /// </summary>
        /// <param name="value">要判断的值</param>
        /// <param name="paramName">参数名</param>
        public static void CheckNotNullOrEmpty(this string value, string paramName) => Check.NotNullOrEmpty(value, paramName);

        /// <summary>
        /// 检查Guid值不能为Guid.Empty，否则抛出<see cref="ArgumentException"/>异常
        /// </summary>
        /// <param name="value">要判断的值</param>
        /// <param name="paramName">参数名</param>
        public static void CheckNotEmpty(this Guid value, string paramName) => Check.NotEmpty(value, paramName);

        /// <summary>
        /// 检查集合不能为空引用或空集合，否则抛出<see cref="ArgumentNullException"/>异常或<see cref="ArgumentException"/>异常。
        /// </summary>
        /// <typeparam name="T">集合项的类型</typeparam>
        /// <param name="collection">要判断的值</param>
        /// <param name="paramName">参数名</param>
        public static void CheckNotNullOrEmpty<T>(this IEnumerable<T> collection, string paramName) => Check.NotNullOrEmpty<T>(collection, paramName);

        #endregion

        #region CheckBetween(范围检查)

        /// <summary>
        /// 检查参数必须小于[或可等于，参数canEqual]指定值，否则抛出<see cref="ArgumentOutOfRangeException"/>异常
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="value">要判断的值</param>
        /// <param name="paramName">参数名</param>
        /// <param name="target">要比较的值</param>
        /// <param name="canEqual">是否可等于</param>
        public static void CheckLessThan<T>(this T value, string paramName, T target, bool canEqual = false)
            where T : IComparable<T> =>
            Check.LessThan<T>(value, paramName, target, canEqual);

        /// <summary>
        /// 检查参数必须大于[或可等于，参数canEqual]指定值，否则抛出<see cref="ArgumentOutOfRangeException"/>异常
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="value">要判断的值</param>
        /// <param name="paramName">参数名</param>
        /// <param name="target">要比较的值</param>
        /// <param name="canEqual">是否可等于</param>
        public static void CheckGreaterThan<T>(this T value, string paramName, T target, bool canEqual = false)
            where T : IComparable<T> =>
            Check.GreaterThan<T>(value, paramName, target, canEqual);

        /// <summary>
        /// 检查参数必须在指定范围之间，否则抛出<see cref="ArgumentOutOfRangeException"/>异常
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="value">要判断的值</param>
        /// <param name="paramName">参数名</param>
        /// <param name="start">比较范围的起始值</param>
        /// <param name="end">比较范围的结束值</param>
        /// <param name="startEqual">是否可等于起始值</param>
        /// <param name="endEqual">是否可等于结束值</param>
        public static void CheckBetween<T>(this T value, string paramName, T start, T end, bool startEqual = false,
            bool endEqual = false) where T : IComparable<T> =>
            Check.Between<T>(value, paramName, start, end, startEqual, endEqual);

        #endregion

        #region CheckIO(文件检查)

        /// <summary>
        /// 检查指定路径的文件夹必须存在，否则抛出<see cref="DirectoryNotFoundException"/>异常
        /// </summary>
        /// <param name="directory">目录路径</param>
        /// <param name="paramName">参数名</param>
        public static void CheckDirectoryExists(this string directory, string paramName = null) => Check.DirectoryExists(directory, paramName);

        /// <summary>
        /// 检查指定路径的文件必须存在，否则抛出<see cref="FileNotFoundException"/>异常。
        /// </summary>
        /// <param name="fileName">文件路径，包含文件名</param>
        /// <param name="paramName">参数名</param>
        public static void CheckFileExists(this string fileName, string paramName = null) => Check.FileExists(fileName, paramName);

        #endregion
    }
}
