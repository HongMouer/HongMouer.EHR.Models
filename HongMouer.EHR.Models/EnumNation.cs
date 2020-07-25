using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 民族代码  参照 GB 3304-1991 民族代码，增加 99 其他民族或外国人 值域
    /// </summary>
    [Serializable]
    public enum EnumNation
    {

        /// <summary>
        /// 汉族
        /// </summary>
        汉族 = 01,

        /// <summary>
        /// 蒙古族
        /// </summary>
        蒙古族 = 02,

        /// <summary>
        /// 回族
        /// </summary>
        回族 = 03,

        /// <summary>
        /// 藏族
        /// </summary>
        藏族 = 04,

        /// <summary>
        /// 维吾尔族
        /// </summary>
        维吾尔族 = 05,

        /// <summary>
        /// 苗族
        /// </summary>
        苗族 = 06,

        /// <summary>
        /// 彝族
        /// </summary>
        彝族 = 07,

        /// <summary>
        /// 壮族
        /// </summary>
        壮族 = 08,

        /// <summary>
        /// 布依族
        /// </summary>
        布依族 = 09,

        /// <summary>
        /// 朝鲜族
        /// </summary>
        朝鲜族 = 10,

        /// <summary>
        /// 满族
        /// </summary>
        满族 = 11,

        /// <summary>
        /// 侗族
        /// </summary>
        侗族 = 12,

        /// <summary>
        /// 瑶族
        /// </summary>
        瑶族 = 13,

        /// <summary>
        /// 白族
        /// </summary>
        白族 = 14,

        /// <summary>
        /// 土家族
        /// </summary>
        土家族 = 15,

        /// <summary>
        /// 哈尼族
        /// </summary>
        哈尼族 = 16,

        /// <summary>
        /// 哈萨克族
        /// </summary>
        哈萨克族 = 17,

        /// <summary>
        /// 傣族
        /// </summary>
        傣族 = 18,

        /// <summary>
        /// 黎族
        /// </summary>
        黎族 = 19,

        /// <summary>
        /// 傈僳族
        /// </summary>
        傈僳族 = 20,

        /// <summary>
        /// 佤族
        /// </summary>
        佤族 = 21,

        /// <summary>
        /// 畲族
        /// </summary>
        畲族 = 22,

        /// <summary>
        /// 高山族
        /// </summary>
        高山族 = 23,

        /// <summary>
        /// 拉祜族
        /// </summary>
        拉祜族 = 24,

        /// <summary>
        /// 水族
        /// </summary>
        水族 = 25,

        /// <summary>
        /// 东乡族
        /// </summary>
        东乡族 = 26,

        /// <summary>
        /// 纳西族
        /// </summary>
        纳西族 = 27,

        /// <summary>
        /// 景颇族
        /// </summary>
        景颇族 = 28,

        /// <summary>
        /// 柯尔克孜族
        /// </summary>
        柯尔克孜族 = 29,

        /// <summary>
        /// 土族
        /// </summary>
        土族 = 30,

        /// <summary>
        /// 达斡尔族
        /// </summary>
        达斡尔族 = 31,

        /// <summary>
        /// 仫佬族
        /// </summary>
        仫佬族 = 32,

        /// <summary>
        /// 羌族
        /// </summary>
        羌族 = 33,

        /// <summary>
        /// 布朗族
        /// </summary>
        布朗族 = 34,

        /// <summary>
        /// 撒拉族
        /// </summary>
        撒拉族 = 35,

        /// <summary>
        /// 毛南族
        /// </summary>
        毛南族 = 36,

        /// <summary>
        /// 仡佬族
        /// </summary>
        仡佬族 = 37,

        /// <summary>
        /// 锡伯族
        /// </summary>
        锡伯族 = 38,

        /// <summary>
        /// 阿昌族
        /// </summary>
        阿昌族 = 39,

        /// <summary>
        /// 普米族
        /// </summary>
        普米族 = 40,

        /// <summary>
        /// 塔吉克族
        /// </summary>
        塔吉克族 = 41,

        /// <summary>
        /// 怒族
        /// </summary>
        怒族 = 42,

        /// <summary>
        /// 乌孜别克族
        /// </summary>
        乌孜别克族 = 43,

        /// <summary>
        /// 俄罗斯族
        /// </summary>
        俄罗斯族 = 44,

        /// <summary>
        /// 鄂温克族
        /// </summary>
        鄂温克族 = 45,

        /// <summary>
        /// 德昂族
        /// </summary>
        德昂族 = 46,

        /// <summary>
        /// 保安族
        /// </summary>
        保安族 = 47,

        /// <summary>
        /// 裕固族
        /// </summary>
        裕固族 = 48,

        /// <summary>
        /// 京族
        /// </summary>
        京族 = 49,

        /// <summary>
        /// 塔塔尔族
        /// </summary>
        塔塔尔族 = 50,

        /// <summary>
        /// 独龙族
        /// </summary>
        独龙族 = 51,

        /// <summary>
        /// 鄂伦春族
        /// </summary>
        鄂伦春族 = 52,

        /// <summary>
        /// 赫哲族
        /// </summary>
        赫哲族 = 53,

        /// <summary>
        /// 门巴族
        /// </summary>
        门巴族 = 54,

        /// <summary>
        /// 珞巴族
        /// </summary>
        珞巴族 = 55,

        /// <summary>
        /// 基诺族
        /// </summary>
        基诺族 = 56,

        /// <summary>
        /// 其它民族或外国人
        /// </summary>
        其它民族或外国人 = 99, 
 
    }
}
