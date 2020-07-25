using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参照 CV5301.06 药物类型代码
    /// </summary>
    [Serializable]
    public enum EnumDrugType
    {

        /// <summary>
        /// 抗生素类抗感染药物
        /// </summary>
        抗生素类抗感染药物 = 0100,

        /// <summary>
        /// 青霉素类抗生素
        /// </summary>
        青霉素类抗生素 = 0101,

        /// <summary>
        /// 头孢菌素类抗生素
        /// </summary>
        头孢菌素类抗生素 = 0102,

        /// <summary>
        /// 氨基糖苷类抗生素
        /// </summary>
        氨基糖苷类抗生素 = 0103,

        /// <summary>
        /// 酰胺醇类抗生素
        /// </summary>
        酰胺醇类抗生素 = 0104,

        /// <summary>
        /// 四环素类抗生素
        /// </summary>
        四环素类抗生素 = 0105,

        /// <summary>
        /// 大环内酯类抗生素
        /// </summary>
        大环内酯类抗生素 = 0106,

        /// <summary>
        /// 多肽类抗生素
        /// </summary>
        多肽类抗生素 = 0107,

        /// <summary>
        /// β内酰胺酶抑制剂
        /// </summary>
        β内酰胺酶抑制剂 = 0108,

        /// <summary>
        /// 林可胺类抗生素
        /// </summary>
        林可胺类抗生素 = 0109,

        /// <summary>
        /// 利福霉素类抗生素
        /// </summary>
        利福霉素类抗生素 = 0110,

        /// <summary>
        /// 多烯类抗生素
        /// </summary>
        多烯类抗生素 = 0111,

        /// <summary>
        /// 其它抗生素类抗感染药
        /// </summary>
        其它抗生素类抗感染药 = 0199,

        /// <summary>
        /// 非抗生素类抗感染药物
        /// </summary>
        非抗生素类抗感染药物 = 0200,

        /// <summary>
        /// 磺胺类药及增效剂
        /// </summary>
        磺胺类药及增效剂 = 0201,

        /// <summary>
        /// 喹诺酮类抗感染药
        /// </summary>
        喹诺酮类抗感染药 = 0202,

        /// <summary>
        /// 抗结核麻风分枝杆菌类药
        /// </summary>
        抗结核麻风分枝杆菌类药 = 0203,

        /// <summary>
        /// 抗真菌类药
        /// </summary>
        抗真菌类药 = 0204,

        /// <summary>
        /// 抗病毒类药
        /// </summary>
        抗病毒类药 = 0205,

        /// <summary>
        /// 抗螺旋体类药
        /// </summary>
        抗螺旋体类药 = 0206,

        /// <summary>
        /// 天然来源抗感染药
        /// </summary>
        天然来源抗感染药 = 0207,

        /// <summary>
        /// 硝基呋喃类抗感染药
        /// </summary>
        硝基呋喃类抗感染药 = 0208,

        /// <summary>
        /// 消毒防腐药
        /// </summary>
        消毒防腐药 = 0209,

        /// <summary>
        /// 其它非抗生素类抗感染药
        /// </summary>
        其它非抗生素类抗感染药 = 0299,

        /// <summary>
        /// 抗寄生虫病药物
        /// </summary>
        抗寄生虫病药物 = 0300,

        /// <summary>
        /// 抗吸虫病药
        /// </summary>
        抗吸虫病药 = 0301,

        /// <summary>
        /// 抗疟药
        /// </summary>
        抗疟药 = 0302,

        /// <summary>
        /// 驱肠虫药
        /// </summary>
        驱肠虫药 = 0303,

        /// <summary>
        /// 抗丝虫病及抗黑热病药
        /// </summary>
        抗丝虫病及抗黑热病药 = 0304,

        /// <summary>
        /// 抗阿米巴及抗滴虫病药
        /// </summary>
        抗阿米巴及抗滴虫病药 = 0305,

        /// <summary>
        /// 其它抗寄生虫病药
        /// </summary>
        其它抗寄生虫病药 = 0399,

        /// <summary>
        /// 解热镇痛药物
        /// </summary>
        解热镇痛药物 = 0400,

        /// <summary>
        /// 解热镇痛药
        /// </summary>
        解热镇痛药 = 0401,

        /// <summary>
        /// 非成瘾性镇痛药
        /// </summary>
        非成瘾性镇痛药 = 0402,

        /// <summary>
        /// 抗炎镇痛药
        /// </summary>
        抗炎镇痛药 = 0403,

        /// <summary>
        /// 抗痛风药
        /// </summary>
        抗痛风药 = 0404,

        /// <summary>
        /// 抗偏头痛药
        /// </summary>
        抗偏头痛药 = 0405,

        /// <summary>
        /// 其它解热镇痛药
        /// </summary>
        其它解热镇痛药 = 0499,

        /// <summary>
        /// 麻醉用药物
        /// </summary>
        麻醉用药物 = 0500,

        /// <summary>
        /// 全身麻醉药
        /// </summary>
        全身麻醉药 = 0501,

        /// <summary>
        /// 局部麻醉药
        /// </summary>
        局部麻醉药 = 0502,

        /// <summary>
        /// 麻醉辅助药
        /// </summary>
        麻醉辅助药 = 0503,

        /// <summary>
        /// 其它麻醉用药
        /// </summary>
        其它麻醉用药 = 0599,

        /// <summary>
        /// 维生素类与矿物质类药物
        /// </summary>
        维生素类与矿物质类药物 = 0600,

        /// <summary>
        /// 维生素AD属
        /// </summary>
        维生素AD属 = 0601,

        /// <summary>
        /// 维生素B属
        /// </summary>
        维生素B属 = 0602,

        /// <summary>
        /// 维生素C属及其它属
        /// </summary>
        维生素C属及其它属 = 0603,

        /// <summary>
        /// 复合维生素类
        /// </summary>
        复合维生素类 = 0604,

        /// <summary>
        /// 微量元素与矿物质
        /// </summary>
        微量元素与矿物质 = 0605,

        /// <summary>
        /// 滋补营养药
        /// </summary>
        滋补营养药 = 0606,

        /// <summary>
        /// 其它营养类药
        /// </summary>
        其它营养类药 = 0699,

        /// <summary>
        /// 酶类及其它生化药物
        /// </summary>
        酶类及其它生化药物 = 0700,

        /// <summary>
        /// 酶及辅酶类药
        /// </summary>
        酶及辅酶类药 = 0701,

        /// <summary>
        /// 氨基酸及蛋白质类药
        /// </summary>
        氨基酸及蛋白质类药 = 0702,

        /// <summary>
        /// 复方氨基酸类药
        /// </summary>
        复方氨基酸类药 = 0703,

        /// <summary>
        /// 多糖及脂类药
        /// </summary>
        多糖及脂类药 = 0704,

        /// <summary>
        /// 核酸类药
        /// </summary>
        核酸类药 = 0705,

        /// <summary>
        /// 其他生化药
        /// </summary>
        其他生化药 = 0799,

        /// <summary>
        /// 激素及调节内分泌功能类药物
        /// </summary>
        激素及调节内分泌功能类药物 = 0800,

        /// <summary>
        /// 肾上腺皮质激素类药
        /// </summary>
        肾上腺皮质激素类药 = 0801,

        /// <summary>
        /// 促肾上腺皮质激素类药
        /// </summary>
        促肾上腺皮质激素类药 = 0802,

        /// <summary>
        /// 雄激素及同化激素类药
        /// </summary>
        雄激素及同化激素类药 = 0803,

        /// <summary>
        /// 雌激素及孕激素类药
        /// </summary>
        雌激素及孕激素类药 = 0804,

        /// <summary>
        /// 促性激素类药
        /// </summary>
        促性激素类药 = 0805,

        /// <summary>
        /// 避孕药
        /// </summary>
        避孕药 = 0806,

        /// <summary>
        /// 子宫收缩药及抗生育药
        /// </summary>
        子宫收缩药及抗生育药 = 0807,

        /// <summary>
        /// 胰腺激素及其它调节血糖药
        /// </summary>
        胰腺激素及其它调节血糖药 = 0808,

        /// <summary>
        /// 甲状腺激素及抗甲状腺药
        /// </summary>
        甲状腺激素及抗甲状腺药 = 0809,

        /// <summary>
        /// 前列腺素类药
        /// </summary>
        前列腺素类药 = 0810,

        /// <summary>
        /// 调节免疫功能药物
        /// </summary>
        调节免疫功能药物 = 0900,

        /// <summary>
        /// 其它激素及调节内分泌功能类药
        /// </summary>
        其它激素及调节内分泌功能类药 = 0899,

        /// <summary>
        /// 免疫抑制剂
        /// </summary>
        免疫抑制剂 = 0901,

        /// <summary>
        /// 生物反应调节剂
        /// </summary>
        生物反应调节剂 = 0902,

        /// <summary>
        /// 其它调节免疫功能药
        /// </summary>
        其它调节免疫功能药 = 0999,

        /// <summary>
        /// 抗肿瘤药物
        /// </summary>
        抗肿瘤药物 = 1000,

        /// <summary>
        /// 烷化剂类抗肿瘤药
        /// </summary>
        烷化剂类抗肿瘤药 = 1001,

        /// <summary>
        /// 抗代谢类抗肿瘤药物
        /// </summary>
        抗代谢类抗肿瘤药物 = 1002,

        /// <summary>
        /// 抗生素类抗肿瘤药
        /// </summary>
        抗生素类抗肿瘤药 = 1003,

        /// <summary>
        /// 天然来源类抗肿瘤药
        /// </summary>
        天然来源类抗肿瘤药 = 1004,

        /// <summary>
        /// 激素类抗肿瘤药
        /// </summary>
        激素类抗肿瘤药 = 1005,

        /// <summary>
        /// 其它抗肿瘤药
        /// </summary>
        其它抗肿瘤药 = 1099,

        /// <summary>
        /// 抗变态反应药物
        /// </summary>
        抗变态反应药物 = 1100,

        /// <summary>
        /// 抗组织胺药
        /// </summary>
        抗组织胺药 = 1101,

        /// <summary>
        /// 过敏反应介质阻滞剂
        /// </summary>
        过敏反应介质阻滞剂 = 1102,

        /// <summary>
        /// 其它抗变态反应药
        /// </summary>
        其它抗变态反应药 = 1199,

        /// <summary>
        /// 神经系统用药物
        /// </summary>
        神经系统用药物 = 1200,

        /// <summary>
        /// 中枢兴奋药
        /// </summary>
        中枢兴奋药 = 1201,

        /// <summary>
        /// 镇静催眠药
        /// </summary>
        镇静催眠药 = 1202,

        /// <summary>
        /// 抗精神病药
        /// </summary>
        抗精神病药 = 1203,

        /// <summary>
        /// 抗抑郁躁狂药
        /// </summary>
        抗抑郁躁狂药 = 1204,

        /// <summary>
        /// 抗焦虑药
        /// </summary>
        抗焦虑药 = 1205,

        /// <summary>
        /// 抗癫痫及抗惊厥药
        /// </summary>
        抗癫痫及抗惊厥药 = 1206,

        /// <summary>
        /// 抗震颤麻痹药
        /// </summary>
        抗震颤麻痹药 = 1207,

        /// <summary>
        /// 作用于植物神经系统药
        /// </summary>
        作用于植物神经系统药 = 1209,

        /// <summary>
        /// 其它神经系统用药
        /// </summary>
        其它神经系统用药 = 1299,

        /// <summary>
        /// 呼吸系统用药物
        /// </summary>
        呼吸系统用药物 = 1300,

        /// <summary>
        /// 祛痰药
        /// </summary>
        祛痰药 = 1301,

        /// <summary>
        /// 镇咳药
        /// </summary>
        镇咳药 = 1302,

        /// <summary>
        /// 平喘药
        /// </summary>
        平喘药 = 1303,

        /// <summary>
        /// 其它呼吸系统用药
        /// </summary>
        其它呼吸系统用药 = 1399,

        /// <summary>
        /// 消化系统用药物
        /// </summary>
        消化系统用药物 = 1400,

        /// <summary>
        /// 抗酸及治溃疡病药
        /// </summary>
        抗酸及治溃疡病药 = 1401,

        /// <summary>
        /// 健胃助消化药
        /// </summary>
        健胃助消化药 = 1402,

        /// <summary>
        /// 胃肠解痉药
        /// </summary>
        胃肠解痉药 = 1403,

        /// <summary>
        /// 止吐催吐药
        /// </summary>
        止吐催吐药 = 1404,

        /// <summary>
        /// 泻药止泻药
        /// </summary>
        泻药止泻药 = 1405,

        /// <summary>
        /// 食欲抑制药及其它减肥药
        /// </summary>
        食欲抑制药及其它减肥药 = 1406,

        /// <summary>
        /// 肝病辅助药
        /// </summary>
        肝病辅助药 = 1407,

        /// <summary>
        /// 利胆药
        /// </summary>
        利胆药 = 1408,

        /// <summary>
        /// 治痔药
        /// </summary>
        治痔药 = 1409,

        /// <summary>
        /// 其它消化系统用药
        /// </summary>
        其它消化系统用药 = 1499,

        /// <summary>
        /// 循环系统用药物
        /// </summary>
        循环系统用药物 = 1500,

        /// <summary>
        /// 强心药
        /// </summary>
        强心药 = 1501,

        /// <summary>
        /// 抗心律失常药
        /// </summary>
        抗心律失常药 = 1502,

        /// <summary>
        /// 防治心绞痛药
        /// </summary>
        防治心绞痛药 = 1503,

        /// <summary>
        /// 抗高血压病药
        /// </summary>
        抗高血压病药 = 1504,

        /// <summary>
        /// 抗休克血管活性药
        /// </summary>
        抗休克血管活性药 = 1505,

        /// <summary>
        /// 周围血管扩张药
        /// </summary>
        周围血管扩张药 = 1506,

        /// <summary>
        /// 调节血脂药
        /// </summary>
        调节血脂药 = 1507,

        /// <summary>
        /// 其它循环系统用药
        /// </summary>
        其它循环系统用药 = 1599,

        /// <summary>
        /// 泌尿系统用药物
        /// </summary>
        泌尿系统用药物 = 1600,

        /// <summary>
        /// 利尿药
        /// </summary>
        利尿药 = 1601,

        /// <summary>
        /// 脱水药
        /// </summary>
        脱水药 = 1602,

        /// <summary>
        /// 尿崩症用药
        /// </summary>
        尿崩症用药 = 1603,

        /// <summary>
        /// 其它泌尿系统用药
        /// </summary>
        其它泌尿系统用药 = 1699,

        /// <summary>
        /// 血液系统用药物
        /// </summary>
        血液系统用药物 = 1700,

        /// <summary>
        /// 止血药
        /// </summary>
        止血药 = 1701,

        /// <summary>
        /// 血浆及血容量扩充制
        /// </summary>
        血浆及血容量扩充制 = 1702,

        /// <summary>
        /// 抗贫血药
        /// </summary>
        抗贫血药 = 1703,

        /// <summary>
        /// 促白细胞增生药
        /// </summary>
        促白细胞增生药 = 1704,

        /// <summary>
        /// 促血小板增生药
        /// </summary>
        促血小板增生药 = 1705,

        /// <summary>
        /// 其它血液系统用药
        /// </summary>
        其它血液系统用药 = 1799,

        /// <summary>
        /// 葡萄糖类药
        /// </summary>
        葡萄糖类药 = 1801,

        /// <summary>
        /// 电解质平衡调节药
        /// </summary>
        电解质平衡调节药 = 1802,

        /// <summary>
        /// 酸硷平衡调节药
        /// </summary>
        酸硷平衡调节药 = 1803,

        /// <summary>
        /// 专科用药物
        /// </summary>
        专科用药物 = 1900,

        /// <summary>
        /// 外科用药
        /// </summary>
        外科用药 = 1901,

        /// <summary>
        /// 皮肤科用药
        /// </summary>
        皮肤科用药 = 1902,

        /// <summary>
        /// 眼科用药
        /// </summary>
        眼科用药 = 1903,

        /// <summary>
        /// 耳鼻喉科用药
        /// </summary>
        耳鼻喉科用药 = 1904,

        /// <summary>
        /// 口腔科用药
        /// </summary>
        口腔科用药 = 1905,

        /// <summary>
        /// 妇产科用药
        /// </summary>
        妇产科用药 = 1906,

        /// <summary>
        /// 解毒药
        /// </summary>
        解毒药 = 1907,

        /// <summary>
        /// 放射性同位素药
        /// </summary>
        放射性同位素药 = 1908,

        /// <summary>
        /// 其它专科用药
        /// </summary>
        其它专科用药 = 1999,

        /// <summary>
        /// 诊断用药物
        /// </summary>
        诊断用药物 = 2000,

        /// <summary>
        /// X线造影剂
        /// </summary>
        X线造影剂 = 2001,

        /// <summary>
        /// 水电解质及酸碱平衡调节药物
        /// </summary>
        水电解质及酸碱平衡调节药物 = 1800,

        /// <summary>
        /// 其它水电解质及酸碱平衡调节药
        /// </summary>
        其它水电解质及酸碱平衡调节药 = 1899,

        /// <summary>
        /// 器官功能检查剂
        /// </summary>
        器官功能检查剂 = 2002,

        /// <summary>
        /// 其它诊断用药
        /// </summary>
        其它诊断用药 = 2099,

        /// <summary>
        /// 生物制品
        /// </summary>
        生物制品 = 2100,

        /// <summary>
        /// 菌苗
        /// </summary>
        菌苗 = 2101,

        /// <summary>
        /// 疫苗
        /// </summary>
        疫苗 = 2102,

        /// <summary>
        /// 毒素
        /// </summary>
        毒素 = 2103,

        /// <summary>
        /// 类毒素
        /// </summary>
        类毒素 = 2104,

        /// <summary>
        /// 抗毒素
        /// </summary>
        抗毒素 = 2105,

        /// <summary>
        /// 抗血清
        /// </summary>
        抗血清 = 2106,

        /// <summary>
        /// 血液制品
        /// </summary>
        血液制品 = 2107,

        /// <summary>
        /// 细胞因子
        /// </summary>
        细胞因子 = 2108,

        /// <summary>
        /// 体内诊断用生物制品
        /// </summary>
        体内诊断用生物制品 = 2109,

        /// <summary>
        /// 细菌类体外诊断用生物制品
        /// </summary>
        细菌类体外诊断用生物制品 = 2110,

        /// <summary>
        /// 病毒类体外诊断用生物制品
        /// </summary>
        病毒类体外诊断用生物制品 = 2111,

        /// <summary>
        /// 其它类体外诊断用生物制品
        /// </summary>
        其它类体外诊断用生物制品 = 2114,

        /// <summary>
        /// 其它生物制品
        /// </summary>
        其它生物制品 = 2199,

        /// <summary>
        /// 立克次代本类体外诊断用生物制品
        /// </summary>
        立克次代本类体外诊断用生物制品 = 2112,

        /// <summary>
        /// 血液免疫类体外诊断用生物制品
        /// </summary>
        血液免疫类体外诊断用生物制品 = 2113,

        /// <summary>
        /// 制剂辅料
        /// </summary>
        制剂辅料 = 2200,

        /// <summary>
        /// 制剂稳定性辅料
        /// </summary>
        制剂稳定性辅料 = 2201,

        /// <summary>
        /// 固体制剂辅料
        /// </summary>
        固体制剂辅料 = 2202,

        /// <summary>
        /// 半固体制剂辅料
        /// </summary>
        半固体制剂辅料 = 2203,

        /// <summary>
        /// 液体制剂辅料
        /// </summary>
        液体制剂辅料 = 2204,

        /// <summary>
        /// 其它制剂辅料
        /// </summary>
        其它制剂辅料 = 2299,

        /// <summary>
        /// 特殊管理药物
        /// </summary>
        特殊管理药物 = 2300,

        /// <summary>
        /// 麻醉药品
        /// </summary>
        麻醉药品 = 2301,

        /// <summary>
        /// 精神药品第一类
        /// </summary>
        精神药品第一类 = 2302,

        /// <summary>
        /// 精神药品第二类
        /// </summary>
        精神药品第二类 = 2303,

        /// <summary>
        /// 其它特殊管理药品
        /// </summary>
        其它特殊管理药品 = 2399,

        /// <summary>
        /// 其它化学药物
        /// </summary>
        其它化学药物 = 9900,

        /// <summary>
        /// 三防特殊用药
        /// </summary>
        三防特殊用药 = 9901,

        /// <summary>
        /// 卫生防疫用药
        /// </summary>
        卫生防疫用药 = 9902,

        /// <summary>
        /// 其它化学药
        /// </summary>
        其它化学药 = 9999,

    }
}
