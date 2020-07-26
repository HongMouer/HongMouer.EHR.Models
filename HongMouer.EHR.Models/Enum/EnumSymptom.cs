using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV5101.27 症状代码
    /// </summary>
    [Serializable]
    public enum EnumSymptom
    {

        /// <summary>
        /// 通用
        /// </summary>
        通用 = 01,

        /// <summary>
        /// 头痛
        /// </summary>
        头痛 = 0101,

        /// <summary>
        /// 头晕
        /// </summary>
        头晕 = 0102,

        /// <summary>
        /// 心悸
        /// </summary>
        心悸 = 0103,

        /// <summary>
        /// 胸闷
        /// </summary>
        胸闷 = 0104,

        /// <summary>
        /// 胸痛
        /// </summary>
        胸痛 = 0105,

        /// <summary>
        /// 咳嗽
        /// </summary>
        咳嗽 = 0106,

        /// <summary>
        /// 咳痰
        /// </summary>
        咳痰 = 0107,

        /// <summary>
        /// 呼吸困难
        /// </summary>
        呼吸困难 = 0108,

        /// <summary>
        /// 多饮
        /// </summary>
        多饮 = 0109,

        /// <summary>
        /// 多尿
        /// </summary>
        多尿 = 0110,

        /// <summary>
        /// 体重下降
        /// </summary>
        体重下降 = 0111,

        /// <summary>
        /// 乏力
        /// </summary>
        乏力 = 0112,

        /// <summary>
        /// 关节肿痛
        /// </summary>
        关节肿痛 = 0113,

        /// <summary>
        /// 视力模糊
        /// </summary>
        视力模糊 = 0114,

        /// <summary>
        /// 四肢麻木
        /// </summary>
        四肢麻木 = 0115,

        /// <summary>
        /// 消瘦
        /// </summary>
        消瘦 = 0116,

        /// <summary>
        /// 尿痛
        /// </summary>
        尿痛 = 0117,

        /// <summary>
        /// 便秘
        /// </summary>
        便秘 = 0118,

        /// <summary>
        /// 腹泻
        /// </summary>
        腹泻 = 0119,

        /// <summary>
        /// 恶心呕吐
        /// </summary>
        恶心呕吐 = 0120,

        /// <summary>
        /// 眼花
        /// </summary>
        眼花 = 0121,

        /// <summary>
        /// 耳鸣
        /// </summary>
        耳鸣 = 0122,

        /// <summary>
        /// 发热
        /// </summary>
        发热 = 0123,

        /// <summary>
        /// 鼻衄
        /// </summary>
        鼻衄 = 0124,

        /// <summary>
        /// 浮肿
        /// </summary>
        浮肿 = 0125,

        /// <summary>
        /// 多食
        /// </summary>
        多食 = 0126,

        /// <summary>
        /// 皮疹
        /// </summary>
        皮疹 = 0127,

        /// <summary>
        /// 其他
        /// </summary>
        其他 = 0199,

        /// <summary>
        /// 高血压
        /// </summary>
        高血压 = 02,

        /// <summary>
        /// 无症状
        /// </summary>
        无症状 = 0201,

        /// <summary>
        /// 头痛头晕
        /// </summary>
        头痛头晕 = 0202,

        /// <summary>
        /// 高血压恶心呕吐
        /// </summary>
        高血压恶心呕吐 = 0203,

        /// <summary>
        /// 眼花耳鸣
        /// </summary>
        眼花耳鸣 = 0204,

        /// <summary>
        /// 高血压呼吸困难
        /// </summary>
        高血压呼吸困难 = 0205,

        /// <summary>
        /// 心悸胸闷
        /// </summary>
        心悸胸闷 = 0206,

        /// <summary>
        /// 鼻衄出血不止
        /// </summary>
        鼻衄出血不止 = 0207,

        /// <summary>
        /// 四肢发麻
        /// </summary>
        四肢发麻 = 0208,

        /// <summary>
        /// 下肢水肿
        /// </summary>
        下肢水肿 = 0209,

        /// <summary>
        /// 糖尿病
        /// </summary>
        糖尿病 = 03,

        /// <summary>
        /// 糖尿病无症状
        /// </summary>
        糖尿病无症状 = 0301,

        /// <summary>
        /// 糖尿病多饮
        /// </summary>
        糖尿病多饮 = 0302,

        /// <summary>
        /// 糖尿病多食
        /// </summary>
        糖尿病多食 = 0303,

        /// <summary>
        /// 糖尿病多尿
        /// </summary>
        糖尿病多尿 = 0304,

        /// <summary>
        /// 糖尿病视力模糊
        /// </summary>
        糖尿病视力模糊 = 0305,

        /// <summary>
        /// 感染
        /// </summary>
        感染 = 0306,

        /// <summary>
        /// 手脚麻木
        /// </summary>
        手脚麻木 = 0307,

        /// <summary>
        /// 下肢浮肿
        /// </summary>
        下肢浮肿 = 0308,

        /// <summary>
        /// 体重明显下降
        /// </summary>
        体重明显下降 = 0309,

        /// <summary>
        /// 健康体检
        /// </summary>
        健康体检 = 04,

        /// <summary>
        /// 健康体检无症状
        /// </summary>
        健康体检无症状 = 0401,

        /// <summary>
        /// 健康体检头痛
        /// </summary>
        健康体检头痛 = 0402,

        /// <summary>
        /// 健康体检头晕
        /// </summary>
        健康体检头晕 = 0403,

        /// <summary>
        /// 健康体检心悸
        /// </summary>
        健康体检心悸 = 0404,

        /// <summary>
        /// 健康体检胸闷
        /// </summary>
        健康体检胸闷 = 0405,

        /// <summary>
        /// 健康体检胸痛
        /// </summary>
        健康体检胸痛 = 0406,

        /// <summary>
        /// 慢性咳嗽
        /// </summary>
        慢性咳嗽 = 0407,

        /// <summary>
        /// 健康体检咳痰
        /// </summary>
        健康体检咳痰 = 0408,

        /// <summary>
        /// 健康体检呼吸困难
        /// </summary>
        健康体检呼吸困难 = 0409,

        /// <summary>
        /// 健康体检多饮
        /// </summary>
        健康体检多饮 = 0410,

        /// <summary>
        /// 健康体检多尿
        /// </summary>
        健康体检多尿 = 0411,

        /// <summary>
        /// 健康体检体重下降
        /// </summary>
        健康体检体重下降 = 0412,

        /// <summary>
        /// 健康体检乏力
        /// </summary>
        健康体检乏力 = 0413,

        /// <summary>
        /// 健康体检关节肿痛
        /// </summary>
        健康体检关节肿痛 = 0414,

        /// <summary>
        /// 健康体检视力模糊
        /// </summary>
        健康体检视力模糊 = 0415,

        /// <summary>
        /// 健康体检手脚麻木
        /// </summary>
        健康体检手脚麻木 = 0416,

        /// <summary>
        /// 尿急
        /// </summary>
        尿急 = 0417,

        /// <summary>
        /// 健康体检尿痛
        /// </summary>
        健康体检尿痛 = 0418,

        /// <summary>
        /// 健康体检便秘
        /// </summary>
        健康体检便秘 = 0419,

        /// <summary>
        /// 健康体检腹泻
        /// </summary>
        健康体检腹泻 = 0420,

        /// <summary>
        /// 健康体检恶心呕吐
        /// </summary>
        健康体检恶心呕吐 = 0421,

        /// <summary>
        /// 健康体检眼花
        /// </summary>
        健康体检眼花 = 0422,

        /// <summary>
        /// 健康体检耳鸣
        /// </summary>
        健康体检耳鸣 = 0423,

        /// <summary>
        /// 乳房肿痛
        /// </summary>
        乳房肿痛 = 0424,

        /// <summary>
        /// 健康体检其他
        /// </summary>
        健康体检其他 = 0425,
    }
}
