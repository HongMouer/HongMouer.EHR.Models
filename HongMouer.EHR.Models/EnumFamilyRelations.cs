using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参考 GB/T 4761-2008 家庭关系代码
    /// </summary>
    [Serializable]
    public enum EnumFamilyRelations
    {

        /// <summary>
        /// 本人
        /// </summary>
        本人 = 01,

        /// <summary>
        /// 户主
        /// </summary>
        户主 = 02,

        /// <summary>
        /// 配偶
        /// </summary>
        配偶 = 10,

        /// <summary>
        /// 夫
        /// </summary>
        夫 = 11,

        /// <summary>
        /// 妻
        /// </summary>
        妻 = 12,

        /// <summary>
        /// 子
        /// </summary>
        子 = 20,

        /// <summary>
        /// 独生子
        /// </summary>
        独生子 = 21,

        /// <summary>
        /// 长子
        /// </summary>
        长子 = 22,

        /// <summary>
        /// 次子
        /// </summary>
        次子 = 23,

        /// <summary>
        /// 三子
        /// </summary>
        三子 = 24,

        /// <summary>
        /// 四子
        /// </summary>
        四子 = 25,

        /// <summary>
        /// 五子
        /// </summary>
        五子 = 26,

        /// <summary>
        /// 养子或继子
        /// </summary>
        养子或继子 = 27,

        /// <summary>
        /// 女婿
        /// </summary>
        女婿 = 28,

        /// <summary>
        /// 其他儿子
        /// </summary>
        其他儿子 = 29,

        /// <summary>
        /// 女
        /// </summary>
        女 = 30,

        /// <summary>
        /// 独生女
        /// </summary>
        独生女 = 31,

        /// <summary>
        /// 长女
        /// </summary>
        长女 = 32,

        /// <summary>
        /// 次女
        /// </summary>
        次女 = 33,

        /// <summary>
        /// 三女
        /// </summary>
        三女 = 34,

        /// <summary>
        /// 四女
        /// </summary>
        四女 = 35,

        /// <summary>
        /// 五女
        /// </summary>
        五女 = 36,

        /// <summary>
        /// 养女或继女
        /// </summary>
        养女或继女 = 37,

        /// <summary>
        /// 儿媳
        /// </summary>
        儿媳 = 38,

        /// <summary>
        /// 其他女儿
        /// </summary>
        其他女儿 = 39,

        /// <summary>
        /// 孙子_孙女或外孙子_外孙女
        /// </summary>
        孙子_孙女或外孙子_外孙女 = 40,

        /// <summary>
        /// 孙子
        /// </summary>
        孙子 = 41,

        /// <summary>
        /// 孙女
        /// </summary>
        孙女 = 42,

        /// <summary>
        /// 外孙子
        /// </summary>
        外孙子 = 43,

        /// <summary>
        /// 外孙女
        /// </summary>
        外孙女 = 44,

        /// <summary>
        /// 孙媳妇或外孙媳妇
        /// </summary>
        孙媳妇或外孙媳妇 = 45,

        /// <summary>
        /// 孙女婿或外孙女婿
        /// </summary>
        孙女婿或外孙女婿 = 46,

        /// <summary>
        /// 曾孙子或曾外孙子
        /// </summary>
        曾孙子或曾外孙子 = 47,

        /// <summary>
        /// 曾孙女或曾外孙女
        /// </summary>
        曾孙女或曾外孙女 = 48,

        /// <summary>
        /// 父母
        /// </summary>
        父母 = 50,

        /// <summary>
        /// 父亲
        /// </summary>
        父亲 = 51,

        /// <summary>
        /// 其他孙子_孙女或外孙子_外_孙女
        /// </summary>
        其他孙子_孙女或外孙子_外_孙女 = 49,

        /// <summary>
        /// 母亲
        /// </summary>
        母亲 = 52,

        /// <summary>
        /// 公公
        /// </summary>
        公公 = 53,

        /// <summary>
        /// 婆婆
        /// </summary>
        婆婆 = 54,

        /// <summary>
        /// 岳父
        /// </summary>
        岳父 = 55,

        /// <summary>
        /// 岳母
        /// </summary>
        岳母 = 56,

        /// <summary>
        /// 继父或养父
        /// </summary>
        继父或养父 = 57,

        /// <summary>
        /// 继母或养母
        /// </summary>
        继母或养母 = 58,

        /// <summary>
        /// 其他父母关系
        /// </summary>
        其他父母关系 = 59,

        /// <summary>
        /// 祖父母或外祖父母
        /// </summary>
        祖父母或外祖父母 = 60,

        /// <summary>
        /// 祖父
        /// </summary>
        祖父 = 61,

        /// <summary>
        /// 祖母
        /// </summary>
        祖母 = 62,

        /// <summary>
        /// 外祖父
        /// </summary>
        外祖父 = 63,

        /// <summary>
        /// 外祖母
        /// </summary>
        外祖母 = 64,

        /// <summary>
        /// 配偶的祖父母或外祖父母
        /// </summary>
        配偶的祖父母或外祖父母 = 65,

        /// <summary>
        /// 曾祖父
        /// </summary>
        曾祖父 = 66,

        /// <summary>
        /// 曾祖母
        /// </summary>
        曾祖母 = 67,

        /// <summary>
        /// 配偶的曾祖父母或外曾祖父母
        /// </summary>
        配偶的曾祖父母或外曾祖父母 = 68,

        /// <summary>
        /// 其他祖父母或外祖父母关系
        /// </summary>
        其他祖父母或外祖父母关系 = 69,

        /// <summary>
        /// 兄弟姐妹
        /// </summary>
        兄弟姐妹 = 70,

        /// <summary>
        /// 兄
        /// </summary>
        兄 = 71,

        /// <summary>
        /// 嫂
        /// </summary>
        嫂 = 72,

        /// <summary>
        /// 弟
        /// </summary>
        弟 = 73,

        /// <summary>
        /// 弟媳
        /// </summary>
        弟媳 = 74,

        /// <summary>
        /// 姐姐
        /// </summary>
        姐姐 = 75,

        /// <summary>
        /// 姐夫
        /// </summary>
        姐夫 = 76,

        /// <summary>
        /// 妹妹
        /// </summary>
        妹妹 = 77,

        /// <summary>
        /// 妹夫
        /// </summary>
        妹夫 = 78,

        /// <summary>
        /// 其他兄弟姐妹
        /// </summary>
        其他兄弟姐妹 = 79,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 80,

        /// <summary>
        /// 伯父
        /// </summary>
        伯父 = 81,

        /// <summary>
        /// 伯母
        /// </summary>
        伯母 = 82,

        /// <summary>
        /// 叔父
        /// </summary>
        叔父 = 83,

        /// <summary>
        /// 婶母
        /// </summary>
        婶母 = 84,

        /// <summary>
        /// 舅父
        /// </summary>
        舅父 = 85,

        /// <summary>
        /// 舅母
        /// </summary>
        舅母 = 86,

        /// <summary>
        /// 姨父
        /// </summary>
        姨父 = 87,

        /// <summary>
        /// 姨母
        /// </summary>
        姨母 = 88,

        /// <summary>
        /// 姑父
        /// </summary>
        姑父 = 89,

        /// <summary>
        /// 姑母
        /// </summary>
        姑母 = 90,

        /// <summary>
        /// 堂兄弟_堂姐妹
        /// </summary>
        堂兄弟_堂姐妹 = 91,

        /// <summary>
        /// 表兄弟_表姐妹
        /// </summary>
        表兄弟_表姐妹 = 92,

        /// <summary>
        /// 侄子
        /// </summary>
        侄子 = 93,

        /// <summary>
        /// 侄女
        /// </summary>
        侄女 = 94,

        /// <summary>
        /// 外甥
        /// </summary>
        外甥 = 95,

        /// <summary>
        /// 外甥女
        /// </summary>
        外甥女 = 96,

        /// <summary>
        /// 其他亲属
        /// </summary>
        其他亲属 = 97,

        /// <summary>
        /// 非亲属
        /// </summary>
        非亲属 = 99
    }
}
