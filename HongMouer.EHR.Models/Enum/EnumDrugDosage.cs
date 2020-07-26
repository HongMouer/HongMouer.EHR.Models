using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV08.50.002 药物剂型代码，【卫生信息数据元值域 代码 第 16 部分:药品、设备与材料】
    /// </summary>
    [Serializable]
    public enum EnumDrugDosage
    {

        /// <summary>
        /// 原料
        /// </summary>
        原料 = 00,

        /// <summary>
        /// 片剂
        /// </summary>
        片剂 = 01,

        /// <summary>
        /// 素片
        /// </summary>
        素片 = 0101,

        /// <summary>
        /// 压制片
        /// </summary>
        压制片 = 0102,

        /// <summary>
        /// 浸膏片
        /// </summary>
        浸膏片 = 0103,

        /// <summary>
        /// 非包衣片
        /// </summary>
        非包衣片 = 0104,

        /// <summary>
        /// 糖衣片
        /// </summary>
        糖衣片 = 0201,

        /// <summary>
        /// 包衣片
        /// </summary>
        包衣片 = 0202,

        /// <summary>
        /// 薄膜衣片
        /// </summary>
        薄膜衣片 = 0203,

        /// <summary>
        /// 咀嚼片
        /// </summary>
        咀嚼片 = 0301,

        /// <summary>
        /// 糖片
        /// </summary>
        糖片 = 0302,

        /// <summary>
        /// 异型片
        /// </summary>
        异型片 = 0303,

        /// <summary>
        /// 糖胶片
        /// </summary>
        糖胶片 = 03,

        /// <summary>
        /// (肠衣片)
        /// </summary>
        肠溶片 = 04,

        /// <summary>
        /// 肠衣片
        /// </summary>
        肠衣片 = 0401,

        /// <summary>
        /// 调释片
        /// </summary>
        调释片 = 0501,

        /// <summary>
        /// 缓释片
        /// </summary>
        缓释片 = 0502,

        /// <summary>
        /// 控释片
        /// </summary>
        控释片 = 0503,

        /// <summary>
        /// 长效片
        /// </summary>
        长效片 = 05,

        /// <summary>
        /// 泡腾片
        /// </summary>
        泡腾片 = 06,

        /// <summary>
        /// 舌下片
        /// </summary>
        舌下片 = 07,

        /// <summary>
        /// 外用片
        /// </summary>
        外用片 = 0901,

        /// <summary>
        /// 外用膜
        /// </summary>
        外用膜 = 0902,

        /// <summary>
        /// 坐药片
        /// </summary>
        坐药片 = 0903,

        /// <summary>
        /// 环型片
        /// </summary>
        环型片 = 09,

        /// <summary>
        /// 含片
        /// </summary>
        含片 = 0801,

        /// <summary>
        /// 嗽口片
        /// </summary>
        嗽口片 = 0802,

        /// <summary>
        /// 含嗽片
        /// </summary>
        含嗽片 = 0803,

        /// <summary>
        /// 喉症片
        /// </summary>
        喉症片 = 0804,

        /// <summary>
        /// 喉片
        /// </summary>
        喉片 = 0805,

        /// <summary>
        /// 口腔粘附片
        /// </summary>
        口腔粘附片 = 08,

        /// <summary>
        /// 阴道片
        /// </summary>
        阴道片 = 10,

        /// <summary>
        /// 外用阴道膜
        /// </summary>
        外用阴道膜 = 1001,

        /// <summary>
        /// 阴道用药
        /// </summary>
        阴道用药 = 1002,

        /// <summary>
        /// 阴道栓片
        /// </summary>
        阴道栓片 = 1003,

        /// <summary>
        /// 水溶片
        /// </summary>
        水溶片 = 11,

        /// <summary>
        /// 眼药水片
        /// </summary>
        眼药水片 = 1101,

        /// <summary>
        /// 分散片
        /// </summary>
        分散片 = 12,

        /// <summary>
        /// 适应片
        /// </summary>
        适应片 = 1201,

        /// <summary>
        /// 纸片
        /// </summary>
        纸片 = 13,

        /// <summary>
        /// 纸型片
        /// </summary>
        纸型片 = 1301,

        /// <summary>
        /// 膜片
        /// </summary>
        膜片 = 1302,

        /// <summary>
        /// 薄膜片
        /// </summary>
        薄膜片 = 1303,

        /// <summary>
        /// 粉针剂
        /// </summary>
        粉针剂 = 15,

        /// <summary>
        /// 冻干粉针剂
        /// </summary>
        冻干粉针剂 = 1501,

        /// <summary>
        /// 冻干粉
        /// </summary>
        冻干粉 = 1502,

        /// <summary>
        /// 注射液
        /// </summary>
        注射液 = 16,

        /// <summary>
        /// 水针剂
        /// </summary>
        水针剂 = 1601,

        /// <summary>
        /// 油针剂
        /// </summary>
        油针剂 = 1602,

        /// <summary>
        /// 混悬针剂
        /// </summary>
        混悬针剂 = 1603,

        /// <summary>
        /// 输液剂
        /// </summary>
        输液剂 = 18,

        /// <summary>
        /// 血浆代用品
        /// </summary>
        血浆代用品 = 1801,

        /// <summary>
        /// 胶囊剂
        /// </summary>
        胶囊剂 = 19,

        /// <summary>
        /// 硬胶囊
        /// </summary>
        硬胶囊 = 1901,

        /// <summary>
        /// 软胶囊
        /// </summary>
        软胶囊 = 20,

        /// <summary>
        /// 滴丸
        /// </summary>
        滴丸 = 2001,

        /// <summary>
        /// 胶丸
        /// </summary>
        胶丸 = 2002,

        /// <summary>
        /// 肠溶胶囊
        /// </summary>
        肠溶胶囊 = 21,

        /// <summary>
        /// 肠溶胶丸
        /// </summary>
        肠溶胶丸 = 2101,

        /// <summary>
        /// 调释胶囊
        /// </summary>
        调释胶囊 = 22,

        /// <summary>
        /// 控释胶囊
        /// </summary>
        控释胶囊 = 2201,

        /// <summary>
        /// 缓释胶囊
        /// </summary>
        缓释胶囊 = 2202,

        /// <summary>
        /// 溶液剂
        /// </summary>
        溶液剂 = 23,

        /// <summary>
        /// 含漱液
        /// </summary>
        含漱液 = 2301,

        /// <summary>
        /// 内服混悬液
        /// </summary>
        内服混悬液 = 2302,

        /// <summary>
        /// 合剂
        /// </summary>
        合剂 = 24,

        /// <summary>
        /// 乳剂
        /// </summary>
        乳剂 = 25,

        /// <summary>
        /// 乳胶
        /// </summary>
        乳胶 = 2501,

        /// <summary>
        /// 凝胶剂
        /// </summary>
        凝胶剂 = 26,

        /// <summary>
        /// 胶剂
        /// </summary>
        胶剂 = 2601,

        /// <summary>
        /// 胶体
        /// </summary>
        胶体 = 2602,

        /// <summary>
        /// 胶冻
        /// </summary>
        胶冻 = 2603,

        /// <summary>
        /// 胶体微粒
        /// </summary>
        胶体微粒 = 2604,

        /// <summary>
        /// 胶浆剂
        /// </summary>
        胶浆剂 = 27,

        /// <summary>
        /// 丸剂
        /// </summary>
        丸剂 = 14,

        /// <summary>
        /// 药丸
        /// </summary>
        药丸 = 1401,

        /// <summary>
        /// 眼丸
        /// </summary>
        眼丸 = 1402,

        /// <summary>
        /// 耳丸
        /// </summary>
        耳丸 = 1403,

        /// <summary>
        /// 糖丸
        /// </summary>
        糖丸 = 1404,

        /// <summary>
        /// 糖衣丸
        /// </summary>
        糖衣丸 = 1405,

        /// <summary>
        /// 浓缩丸
        /// </summary>
        浓缩丸 = 1406,

        /// <summary>
        /// 调释丸
        /// </summary>
        调释丸 = 1407,

        /// <summary>
        /// 水丸
        /// </summary>
        水丸 = 1408,

        /// <summary>
        /// 注射溶媒
        /// </summary>
        注射溶媒 = 17,

        /// <summary>
        /// 芳香水剂
        /// </summary>
        芳香水剂 = 28,

        /// <summary>
        /// 露剂
        /// </summary>
        露剂 = 2801,

        /// <summary>
        /// 滴剂
        /// </summary>
        滴剂 = 29,

        /// <summary>
        /// 糖浆剂
        /// </summary>
        糖浆剂 = 30,

        /// <summary>
        /// 蜜浆剂
        /// </summary>
        蜜浆剂 = 3001,

        /// <summary>
        /// 口服液
        /// </summary>
        口服液 = 31,

        /// <summary>
        /// 浸膏剂
        /// </summary>
        浸膏剂 = 32,

        /// <summary>
        /// 流浸膏剂
        /// </summary>
        流浸膏剂 = 33,

        /// <summary>
        /// 酊剂
        /// </summary>
        酊剂 = 34,

        /// <summary>
        /// 醑剂
        /// </summary>
        醑剂 = 35,

        /// <summary>
        /// 酏剂
        /// </summary>
        酏剂 = 36,

        /// <summary>
        /// 洗剂
        /// </summary>
        洗剂 = 37,

        /// <summary>
        /// 阴道冲洗剂
        /// </summary>
        阴道冲洗剂 = 3701,

        /// <summary>
        /// 搽剂
        /// </summary>
        搽剂 = 38,

        /// <summary>
        /// 涂剂
        /// </summary>
        涂剂 = 3801,

        /// <summary>
        /// 擦剂
        /// </summary>
        擦剂 = 3802,

        /// <summary>
        /// 外用混悬液剂
        /// </summary>
        外用混悬液剂 = 3803,

        /// <summary>
        /// 油剂
        /// </summary>
        油剂 = 39,

        /// <summary>
        /// 甘油剂
        /// </summary>
        甘油剂 = 3901,

        /// <summary>
        /// 棉胶剂
        /// </summary>
        棉胶剂 = 40,

        /// <summary>
        /// 火棉胶剂
        /// </summary>
        火棉胶剂 = 4001,

        /// <summary>
        /// 涂膜剂
        /// </summary>
        涂膜剂 = 41,

        /// <summary>
        /// 涂布剂
        /// </summary>
        涂布剂 = 42,

        /// <summary>
        /// 滴眼剂
        /// </summary>
        滴眼剂 = 43,

        /// <summary>
        /// 洗眼剂
        /// </summary>
        洗眼剂 = 4301,

        /// <summary>
        /// 粉剂眼花缭乱药
        /// </summary>
        粉剂眼花缭乱药 = 4302,

        /// <summary>
        /// 滴鼻剂
        /// </summary>
        滴鼻剂 = 44,

        /// <summary>
        /// 洗鼻剂
        /// </summary>
        洗鼻剂 = 4401,

        /// <summary>
        /// 滴耳剂
        /// </summary>
        滴耳剂 = 45,

        /// <summary>
        /// 洗耳剂
        /// </summary>
        洗耳剂 = 4501,

        /// <summary>
        /// 口腔药剂
        /// </summary>
        口腔药剂 = 46,

        /// <summary>
        /// 口腔用药
        /// </summary>
        口腔用药 = 4601,

        /// <summary>
        /// 牙科用药
        /// </summary>
        牙科用药 = 4602,

        /// <summary>
        /// 灌肠剂
        /// </summary>
        灌肠剂 = 47,

        /// <summary>
        /// 软膏剂
        /// </summary>
        软膏剂 = 48,

        /// <summary>
        /// 油膏剂
        /// </summary>
        油膏剂 = 4801,

        /// <summary>
        /// 水膏剂
        /// </summary>
        水膏剂 = 4802,

        /// <summary>
        /// 霜剂
        /// </summary>
        霜剂 = 49,

        /// <summary>
        /// 乳膏剂
        /// </summary>
        乳膏剂 = 4901,

        /// <summary>
        /// 糊剂
        /// </summary>
        糊剂 = 50,

        /// <summary>
        /// 硬膏剂
        /// </summary>
        硬膏剂 = 51,

        /// <summary>
        /// 橡皮膏
        /// </summary>
        橡皮膏 = 5101,

        /// <summary>
        /// 眼膏剂
        /// </summary>
        眼膏剂 = 52,

        /// <summary>
        /// 散剂
        /// </summary>
        散剂 = 53,

        /// <summary>
        /// 内服散剂
        /// </summary>
        内服散剂 = 5301,

        /// <summary>
        /// 外用散剂
        /// </summary>
        外用散剂 = 5302,

        /// <summary>
        /// 粉剂
        /// </summary>
        粉剂 = 5303,

        /// <summary>
        /// 撒布粉
        /// </summary>
        撒布粉 = 5304,

        /// <summary>
        /// 颗粒剂
        /// </summary>
        颗粒剂 = 54,

        /// <summary>
        /// 冲剂
        /// </summary>
        冲剂 = 5401,

        /// <summary>
        /// 晶剂
        /// </summary>
        晶剂 = 5402,

        /// <summary>
        /// 结晶
        /// </summary>
        结晶 = 5403,

        /// <summary>
        /// 晶体
        /// </summary>
        晶体 = 5404,

        /// <summary>
        /// 干糖浆
        /// </summary>
        干糖浆 = 5405,

        /// <summary>
        /// 泡腾颗粒剂
        /// </summary>
        泡腾颗粒剂 = 55,

        /// <summary>
        /// 调释颗粒剂
        /// </summary>
        调释颗粒剂 = 5601,

        /// <summary>
        /// 缓释颗粒剂
        /// </summary>
        缓释颗粒剂 = 56,

        /// <summary>
        /// 气雾剂
        /// </summary>
        气雾剂 = 57,

        /// <summary>
        /// 水雾剂
        /// </summary>
        水雾剂 = 5701,

        /// <summary>
        /// 加抛射剂
        /// </summary>
        加抛射剂 = 5702,

        /// <summary>
        /// 喷雾剂
        /// </summary>
        喷雾剂 = 58,

        /// <summary>
        /// 不加抛射剂
        /// </summary>
        不加抛射剂 = 5801,

        /// <summary>
        /// 混悬雾剂
        /// </summary>
        混悬雾剂 = 59,

        /// <summary>
        /// 水
        /// </summary>
        水 = 5901,

        /// <summary>
        /// 气
        /// </summary>
        气 = 5902,

        /// <summary>
        /// 粉三相
        /// </summary>
        粉三相 = 5903,

        /// <summary>
        /// 吸入药剂
        /// </summary>
        吸入药剂 = 60,

        /// <summary>
        /// 鼻吸式
        /// </summary>
        鼻吸式 = 6001,

        /// <summary>
        /// 粉雾剂
        /// </summary>
        粉雾剂 = 6002,

        /// <summary>
        /// 膜剂
        /// </summary>
        膜剂 = 6101,

        /// <summary>
        /// 口腔膜
        /// </summary>
        口腔膜 = 6102,

        /// <summary>
        /// 海绵剂
        /// </summary>
        海绵剂 = 62,

        /// <summary>
        /// 栓剂
        /// </summary>
        栓剂 = 6301,

        /// <summary>
        /// 痔疮栓
        /// </summary>
        痔疮栓 = 6302,

        /// <summary>
        /// 耳栓
        /// </summary>
        耳栓 = 63,

        /// <summary>
        /// 植入栓
        /// </summary>
        植入栓 = 64,

        /// <summary>
        /// 透皮剂
        /// </summary>
        透皮剂 = 6501,

        /// <summary>
        /// 贴剂
        /// </summary>
        贴剂 = 6502,

        /// <summary>
        /// 贴膏
        /// </summary>
        贴膏 = 6503,

        /// <summary>
        /// 贴膜
        /// </summary>
        贴膜 = 6504,

        /// <summary>
        /// 贴片
        /// </summary>
        贴片 = 65,

        /// <summary>
        /// 控释透皮剂
        /// </summary>
        控释透皮剂 = 6601,

        /// <summary>
        /// 控释贴片
        /// </summary>
        控释贴片 = 6602,

        /// <summary>
        /// 控释口颊片
        /// </summary>
        控释口颊片 = 66,

        /// <summary>
        /// 划痕剂
        /// </summary>
        划痕剂 = 67,

        /// <summary>
        /// 珠链
        /// </summary>
        珠链 = 68,

        /// <summary>
        /// 泥珠链
        /// </summary>
        泥珠链 = 6801,

        /// <summary>
        /// 锭剂
        /// </summary>
        锭剂 = 69,

        /// <summary>
        /// 糖锭
        /// </summary>
        糖锭 = 6901,

        /// <summary>
        /// 微囊胶囊
        /// </summary>
        微囊胶囊 = 70,

        /// <summary>
        /// 微丸胶囊
        /// </summary>
        微丸胶囊 = 7001,

        /// <summary>
        /// 干混悬剂
        /// </summary>
        干混悬剂 = 71,

        /// <summary>
        /// 干悬乳剂
        /// </summary>
        干悬乳剂 = 7101,

        /// <summary>
        /// 口服乳干粉
        /// </summary>
        口服乳干粉 = 7102,

        /// <summary>
        /// 吸放剂
        /// </summary>
        吸放剂 = 72,

        /// <summary>
        /// 气体
        /// </summary>
        气体 = 7201,

        /// <summary>
        /// /试剂盒
        /// </summary>
        试剂盒 = 90,

        /// <summary>
        /// 诊断用试剂
        /// </summary>
        诊断用试剂 = 9001,

        /// <summary>
        /// 药盒
        /// </summary>
        药盒 = 9002,

        /// <summary>
        /// 其它剂型
        /// </summary>
        其它剂型 = 99,

        /// <summary>
        /// 空心胶囊
        /// </summary>
        空心胶囊 = 9901,

        /// <summary>
        /// 绷带
        /// </summary>
        绷带 = 9902,

        /// <summary>
        /// 纱布
        /// </summary>
        纱布 = 9903,

        /// <summary>
        /// 胶布
        /// </summary>
        胶布 = 9904
    }
}
