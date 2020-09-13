using NodaTime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HongMouer.Common.Utility
{
    //https://github.com/bing-framework/Bing.NetCore/blob/master/utils/src/Bing.Utils/Bing/Judgments/CollectionJudgment.cs
    /// <summary>
    /// 字符串帮助类
    /// </summary>
    public static class StringHelper
    {

        /// <summary>
        /// Null转成""  非空则移除里面的空白
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string NullToString(object obj)
        {
            if (obj == null)
                return string.Empty;
            else
            {
                return obj.ToString().Trim();
            }
        }

        /// <summary>
        /// 字节数组转16进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }

        /// <summary>
        /// 从汉字转换到16进制
        /// </summary>
        /// <param name="s"></param>
        /// <param name="charset">编码,如"utf-8","gb2312"</param>
        /// <param name="fenge">是否每字符用逗号分隔</param>
        /// <returns></returns>
        public static string ToHex(string s, string charset, bool fenge)
        {
            if ((s.Length % 2) != 0)
            {
                s += " ";//空格
                         //throw new ArgumentException("s is not valid chinese string!");
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding(charset);
            byte[] bytes = chs.GetBytes(s);
            string str = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                str += string.Format("{0:X}", bytes[i]);
                if (fenge && (i != bytes.Length - 1))
                {
                    str += string.Format("{0}", ",");
                }
            }
            return str.ToLower();
        }

        ///<summary>
        /// 从16进制转换成汉字
        /// </summary>
        /// <param name="hex"></param>
        /// <param name="charset">编码,如"utf-8","gb2312"</param>
        /// <returns></returns>
        public static string UnHex(string hex, string charset)
        {
            if (hex == null)
                throw new ArgumentNullException("hex");
            hex = hex.Replace(",", "");
            hex = hex.Replace("\n", "");
            hex = hex.Replace("\\", "");
            hex = hex.Replace(" ", "");
            if (hex.Length % 2 != 0)
            {
                hex += "20";//空格
            }
            // 需要将 hex 转换成 byte 数组。 
            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    // 每两个字符是一个 byte。 
                    bytes[i] = byte.Parse(hex.Substring(i * 2, 2),
                    System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    // Rethrow an exception with custom message. 
                    throw new ArgumentException("hex is not a valid hex number!", "hex");
                }
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding(charset);
            return chs.GetString(bytes);
        }

        private static string StringToHexString(string s, Encoding encode)
        {
            byte[] b = encode.GetBytes(s);//按照指定编码将string编程字节数组
            string result = string.Empty;
            for (int i = 0; i < b.Length; i++)//逐字节变为16进制字符，以%隔开
            {
                result += "%" + Convert.ToString(b[i], 16);
            }
            return result;
        }

        private static string HexStringToString(string hs, Encoding encode)
        {
            //以%分割字符串，并去掉空字符
            string[] chars = hs.Split(new char[] { '%' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] b = new byte[chars.Length];
            //逐个字符变为16进制字节数据
            for (int i = 0; i < chars.Length; i++)
            {
                b[i] = Convert.ToByte(chars[i], 16);
            }
            //按照指定编码将字节数组变为字符串
            return encode.GetString(b);
        }


        /// <summary>
        /// 最小日期
        /// </summary>
        internal static readonly DateTime MinDate = new DateTime(1900, 1, 1);

        /// <summary>
        /// 最大日期
        /// </summary>
        internal static readonly DateTime MaxDate = new DateTime(9999, 12, 31, 23, 59, 59, 999);

        #region IsToday(是否今天)

        /// <summary>
        /// 判断指定时间是否今天
        /// </summary>
        /// <param name="dt">时间</param>
        public static bool IsToday(DateTime dt) => dt.Date == DateTime.Today;

        /// <summary>
        /// 判断指定时间是否今天
        /// </summary>
        /// <param name="dt">时间</param>
        public static bool IsToday(DateTime? dt) => IsToday(dt.GetValueOrDefault());

        /// <summary>
        /// 判断指定时间是否今天
        /// </summary>
        /// <param name="dtOffset">时间偏移</param>
        public static bool IsToday(DateTimeOffset dtOffset) => IsToday(dtOffset.Date);

        /// <summary>
        /// 判断指定时间是否今天
        /// </summary>
        /// <param name="dtOffset">时间偏移</param>
        public static bool IsToday(DateTimeOffset? dtOffset) => IsToday(dtOffset.GetValueOrDefault());

        #endregion

        #region IsWeekend(是否周末)

        /// <summary>
        /// 判断指定时间是否周末
        /// </summary>
        /// <param name="dt">时间</param>
        public static bool IsWeekend(DateTime dt) => dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday;

        /// <summary>
        /// 判断指定时间是否周末
        /// </summary>
        /// <param name="dt">时间</param>
        public static bool IsWeekend(DateTime? dt) => IsWeekend(dt.GetValueOrDefault());

        /// <summary>
        /// 判断指定时间是否周末
        /// </summary>
        /// <param name="dtOffset">时间偏移</param>
        public static bool IsWeekend(DateTimeOffset dtOffset) => IsWeekend(dtOffset.Date);

        /// <summary>
        /// 判断指定时间是否周末
        /// </summary>
        /// <param name="dtOffset">时间偏移</param>
        public static bool IsWeekend(DateTimeOffset? dtOffset) => IsWeekend(dtOffset.GetValueOrDefault());

        #endregion

        #region IsValid(是否有效时间)

        /// <summary>
        /// 判断指定时间是否有效时间
        /// </summary>
        /// <param name="dt">时间</param>
        public static bool IsValid(DateTime dt) => dt >= MinDate && dt <= MaxDate;

        #endregion


        /// <summary>
        /// 判断 <see cref="IEnumerable"/> 是否为 null
        /// </summary>
        /// <param name="enumerable">集合</param>
        public static bool IsNull(IEnumerable enumerable) => enumerable is null;

        /// <summary>
        /// 判断 <see cref="IEnumerable"/> 是否为空、null
        /// </summary>
        /// <param name="enumerable">集合</param>
        public static bool IsNullOrEmpty(IEnumerable enumerable)
        {
            if (enumerable is null)
                return true;
            return !enumerable.Cast<object>().Any();
        }

        /// <summary>
        /// 判断 <see cref="IEnumerable{T}"/> 是否为空、null
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="enumerable">集合</param>
        public static bool IsNullOrEmpty<T>(IEnumerable<T> enumerable) => enumerable is null || !enumerable.Any();

        /// <summary>
        /// 判断 一个集合 是否至少包含指定数量的元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="collection">集合</param>
        /// <param name="count">数量</param>
        public static bool ContainsAtLeast<T>(ICollection<T> collection, int count) => collection?.Count >= count;

        /// <summary>
        /// 判断 两个集合 是否包含相同数量的元素
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="leftCollection">集合</param>
        /// <param name="rightCollection">集合</param>
        public static bool ContainsEqualCount<T>(ICollection<T> leftCollection, ICollection<T> rightCollection)
        {
            if (leftCollection is null && rightCollection is null)
                return true;
            if (leftCollection is null || rightCollection is null)
                return false;
            return leftCollection.Count.Equals(rightCollection.Count);
        }

        /// <summary>
        /// 间隔天数
        /// </summary>
        /// <param name="left">星期几</param>
        /// <param name="right">星期几</param>
        public static int DaysBetween(DayOfWeek left, DayOfWeek right)
        {
            var leftVal = left.ToWeekInt();
            var rightVal = right.ToWeekInt();

            if (leftVal <= rightVal)
                return rightVal - leftVal;
            return leftVal + 7 - rightVal;
        }

        /// <summary>
        /// 间隔天数
        /// </summary>
        /// <param name="left">星期几</param>
        /// <param name="right">星期几</param>
        public static int DaysBetween(IsoDayOfWeek left, IsoDayOfWeek right)
        {
            if (left == IsoDayOfWeek.None || right == IsoDayOfWeek.None)
                return 0;
            return DaysBetween(ToSystemWeek(left), ToSystemWeek(right));
        }

        /// <summary>
        /// 尝试获取间隔天数
        /// </summary>
        /// <param name="left">星期几</param>
        /// <param name="right">星期几</param>
        /// <param name="days">间隔天数</param>
        public static bool TryDaysBetween(DayOfWeek left, DayOfWeek right, out int days)
        {
            days = DaysBetween(left, right);
            return true;
        }

        /// <summary>
        /// 尝试获取间隔天数
        /// </summary>
        /// <param name="left">星期几</param>
        /// <param name="right">星期几</param>
        /// <param name="days">间隔天数</param>
        public static bool TryDaysBetween(IsoDayOfWeek left, IsoDayOfWeek right, out int days)
        {
            days = 0;
            if (left == IsoDayOfWeek.None || right == IsoDayOfWeek.None)
                return false;
            return TryDaysBetween(ToSystemWeek(left), ToSystemWeek(right), out days);
        }

        /// <summary>
        /// 转换为 NodaTime 星期几
        /// </summary>
        /// <param name="week">系统星期几</param>
        public static IsoDayOfWeek ToNodaTimeWeek(DayOfWeek week) =>
            week switch
            {
                DayOfWeek.Sunday => IsoDayOfWeek.Sunday,
                DayOfWeek.Monday => IsoDayOfWeek.Monday,
                DayOfWeek.Tuesday => IsoDayOfWeek.Tuesday,
                DayOfWeek.Wednesday => IsoDayOfWeek.Wednesday,
                DayOfWeek.Thursday => IsoDayOfWeek.Thursday,
                DayOfWeek.Friday => IsoDayOfWeek.Friday,
                DayOfWeek.Saturday => IsoDayOfWeek.Saturday,
                _ => IsoDayOfWeek.None
            };

        /// <summary>
        /// 转换为 系统星期几
        /// </summary>
        /// <param name="week">NodaTime 星期几</param>
        public static DayOfWeek ToSystemWeek(IsoDayOfWeek week) =>
            week switch
            {
                IsoDayOfWeek.Sunday => DayOfWeek.Sunday,
                IsoDayOfWeek.Monday => DayOfWeek.Monday,
                IsoDayOfWeek.Tuesday => DayOfWeek.Tuesday,
                IsoDayOfWeek.Wednesday => DayOfWeek.Wednesday,
                IsoDayOfWeek.Thursday => DayOfWeek.Thursday,
                IsoDayOfWeek.Friday => DayOfWeek.Friday,
                IsoDayOfWeek.Saturday => DayOfWeek.Saturday,
                _ => throw new InvalidOperationException("Unknown day of week")
            };

        #region ToDateTimeString(yyyy-MM-dd HH:mm:ss)

        /// <summary>
        /// 获取格式化字符串，带时分秒，格式："yyyy-MM-dd HH:mm:ss"
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="isRemoveSecond">是否移除秒,true:是,false:否</param>
        public static string ToDateTimeString(this DateTime dateTime, bool isRemoveSecond = false) => dateTime.ToString(isRemoveSecond ? "yyyy-MM-dd HH:mm" : "yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 获取格式化字符串，带时分秒，格式："yyyy-MM-dd HH:mm:ss"
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="isRemoveSecond">是否移除秒,true:是,false:否</param>
        public static string ToDateTimeString(this DateTime? dateTime, bool isRemoveSecond = false) => dateTime == null ? string.Empty : ToDateTimeString(dateTime.Value, isRemoveSecond);

        #endregion

        #region ToDateString(yyyy-MM-dd)

        /// <summary>
        /// 获取格式化字符串，不带时分秒，格式："yyyy-MM-dd"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToDateString(this DateTime dateTime) => dateTime.ToString("yyyy-MM-dd");

        /// <summary>
        /// 获取格式化字符串，不带时分秒，格式："yyyy-MM-dd"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToDateString(this DateTime? dateTime) => dateTime == null ? string.Empty : ToDateString(dateTime.Value);

        #endregion

        #region ToTimeString(HH:mm:ss)

        /// <summary>
        /// 获取格式化字符串，不带年月日，格式："HH:mm:ss"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToTimeString(this DateTime dateTime) => dateTime.ToString("HH:mm:ss");

        /// <summary>
        /// 获取格式化字符串，不带年月日，格式："HH:mm:ss"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToTimeString(this DateTime? dateTime) => dateTime == null ? string.Empty : ToTimeString(dateTime.Value);

        #endregion

        #region ToMillisecondString(yyyy-MM-dd HH:mm:ss.fff)

        /// <summary>
        /// 获取格式化字符串，带毫秒，格式："yyyy-MM-dd HH:mm:ss.fff"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToMillisecondString(this DateTime dateTime) => dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

        /// <summary>
        /// 获取格式化字符串，带毫秒，格式："yyyy-MM-dd HH:mm:ss.fff"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToMillisecondString(this DateTime? dateTime) => dateTime == null ? string.Empty : ToMillisecondString(dateTime.Value);

        #endregion

        #region ToChineseDateString(yyyy年MM月dd日)

        /// <summary>
        /// 获取格式化字符串，不带时分秒，格式："yyyy年MM月dd日"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToChineseDateString(this DateTime dateTime) => $"{dateTime.Year}年{dateTime.Month}月{dateTime.Day}日";

        /// <summary>
        /// 获取格式化字符串，不带时分秒，格式："yyyy年MM月dd日"
        /// </summary>
        /// <param name="dateTime">日期</param>
        public static string ToChineseDateString(this DateTime? dateTime) => dateTime == null ? string.Empty : ToChineseDateString(dateTime.Value);

        #endregion

        #region ToChineseDateTimeString(yyyy年MM月dd日 HH时mm分)

        /// <summary>
        /// 获取格式化字符串，带时分秒，格式："yyyy年MM月dd日 HH时mm分"
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="isRemoveSecond">是否移除秒</param>
        public static string ToChineseDateTimeString(this DateTime dateTime, bool isRemoveSecond = false)
        {
            var result = new StringBuilder();
            result.AppendFormat("{0}年{1}月{2}日", dateTime.Year, dateTime.Month, dateTime.Day);
            result.AppendFormat(" {0}时{1}分", dateTime.Hour, dateTime.Minute);
            if (isRemoveSecond == false)
                result.AppendFormat("{0}秒", dateTime.Second);
            return result.ToString();
        }

        /// <summary>
        /// 获取格式化字符串，带时分秒，格式："yyyy年MM月dd日 HH时mm分"
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="isRemoveSecond">是否移除秒</param>
        public static string ToChineseDateTimeString(this DateTime? dateTime, bool isRemoveSecond = false) => dateTime == null ? string.Empty : ToChineseDateTimeString(dateTime.Value, isRemoveSecond);

        #endregion

        #region ToDateTimeOffset(将时间转换为时间点)

        /// <summary>
        /// 将时间转换为时间点
        /// </summary>
        /// <param name="localDateTime">DateTime</param>
        public static DateTimeOffset ToDateTimeOffset(this DateTime localDateTime) =>
            localDateTime.ToDateTimeOffset(null);

        /// <summary>
        /// 将时间转换为时间点
        /// </summary>
        /// <param name="localDateTime">DateTime</param>
        /// <param name="localTimeZone">时区</param>
        public static DateTimeOffset ToDateTimeOffset(this DateTime localDateTime, TimeZoneInfo localTimeZone)
        {
            if (localDateTime.Kind != DateTimeKind.Unspecified)
                localDateTime = new DateTime(localDateTime.Ticks, DateTimeKind.Unspecified);
            return TimeZoneInfo.ConvertTime(localDateTime, localTimeZone ?? TimeZoneInfo.Local);
        }

        #endregion

        #region ToLocalDateTime(将时间点转换为时间)

        /// <summary>
        /// 将时间点转换为时间
        /// </summary>
        /// <param name="dateTimeUtc">DateTimeOffset</param>
        public static DateTime ToLocalDateTime(this DateTimeOffset dateTimeUtc) => dateTimeUtc.ToLocalDateTime(null);

        /// <summary>
        /// 将时间点转换为时间
        /// </summary>
        /// <param name="dateTimeUtc">DateTimeOffset</param>
        /// <param name="localTimeZone">时区</param>
        public static DateTime ToLocalDateTime(this DateTimeOffset dateTimeUtc, TimeZoneInfo localTimeZone) =>
            TimeZoneInfo.ConvertTime(dateTimeUtc, localTimeZone ?? TimeZoneInfo.Local).DateTime;

        #endregion
    }
}
