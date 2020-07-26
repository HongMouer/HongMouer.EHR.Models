using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.EHR.Models
{

    /// <summary>
    /// 参见 2018 国家卫生健康统计调查制度【医疗卫生机构业务科室分类与代码】
    /// </summary>
    [Serializable]
    public static class EnumDeptInfo
    {

        /// <summary>
        /// 传染病预防控制科中心
        /// </summary>
        public const string 传染病预防控制科中心 = "B01";

        public const string 预防保健科 = "A01";
        public const string 全科医疗科 = "A02";
        public const string 内科 = "A03";
        public const string 呼吸内科专业 = "A03.01";
        public const string 消化内科专业 = "A03.02";
        public const string 神经内科专业 = "A03.03";
        public const string 心血管内科专业 = "A03.04";
        public const string 血液内科专业 = "A03.05";
        public const string 肾病学专业 = "A03.06";
        public const string 内分泌专业 = "A03.07";
        public const string 免疫学专业 = "A03.08";
        public const string 变态反应专业 = "A03.09";
        public const string 老年病专业 = "A03.10";
        public const string 其他 = "A03.11";
        public const string 外科 = "A04";
        public const string 普通外科专业 = "A04.01";
        public const string 肝脏移植项目 = "A04.01.01";
        public const string 胰腺移植项目 = "A04.01.02";
        public const string 小肠移植项目 = "A04.01.03";
        public const string 神经外科专业 = "A04.02";
        public const string 骨科专业 = "A04.03";
        public const string 泌尿外科专业 = "A04.04";

        public const string 肾脏移植项目 = "A04.04.01";
        public const string 胸外科专业 = "A04.05";
        public const string 肺脏移植项目 = "A04.05.01";
        public const string 心脏大血管外科专业 = "A04.06";
        public const string 心脏移植项目 = "A04.06.01";
        public const string 烧伤科专业 = "A04.07";
        public const string 整形外科专业 = "A04.08";
        //public const string 其他 = "A04.09";
        public const string 妇产科 = "A05";
        public const string 妇科专业 = "A05.01";
        public const string 产科专业 = "A05.02";
        public const string 计划生育专业 = "A05.03";
        public const string 优生学专业 = "A05.04";
        public const string 生殖健康与不孕症专业 = "A05.05";
        //public const string 其他= "A05.06";
        public const string 妇女保健科 = "A06";
        public const string 青春期保健专业 = "A06.01";
        public const string 围产期保健专业 = "A06.02";
        public const string 更年期保健专业 = "A06.03";
        public const string 妇女心理卫生专业 = "A06.04";

        public const string 妇女营养专业 = "A06.05";
        //public const string 其他= "A06.06";
        public const string 儿科 = "A07";
        public const string 新生儿专业 = "A07.01";
        public const string 小儿传染病专业 = "A07.02";
        public const string 小儿消化专业 = "A07.03";
        public const string 小儿呼吸专业 = "A07.04";
        public const string 小儿心脏病专业 = "A07.05";
        public const string 小儿肾病专业 = "A07.06";
        public const string 小儿血液病专业 = "A07.07";
        public const string 小儿神经病学专业 = "A07.08";
        public const string 小儿内分泌专业 = "A07.09";
        public const string 小儿遗传病专业 = "A07.10";
        public const string 小儿免疫专业 = "A07.11";
        // public const string 其他= "A07.12";
        public const string 小儿外科 = "A08";
        public const string 小儿普通外科专业 = "A08.01";
        public const string 小儿骨科专业 = "A08.02";
        public const string 小儿泌尿外科专业 = "A08.03";
        public const string 小儿胸心外科专业 = "A08.04";

        public const string 小儿神经外科专业 = "A08.05";
        //public const string 其他= "A08.06";
        public const string 儿童保健科 = "A09";
        public const string 儿童生长发育专业 = "A09.01";
        public const string 儿童营养专业 = "A09.02";
        public const string 儿童心理卫生专业 = "A09.03";
        public const string 儿童五官保健专业 = "A09.04";
        public const string 儿童康复专业 = "A09.05";
        //public const string 其他= "A09.06";
        public const string 眼科 = "A10";
        public const string 耳鼻咽喉科 = "A11";
        public const string 耳科专业 = "A11.01";
        public const string 鼻科专业 = "A11.02";
        public const string 咽喉科专业 = "A11.03";
        //public const string 其他= "A11.04";
        public const string 口腔科 = "A12";
        public const string 牙体牙髓病专业 = "A12.01";
        public const string 牙周病专业 = "A12.02";
        public const string 口腔黏膜病专业 = "A12.03";
        public const string 儿童口腔专业 = "A12.04";

        public const string 口腔颌骨外科专业 = "A12.05";
        public const string 口腔修复专业 = "A12.06";
        public const string 口腔正畸专业 = "A12.07";
        public const string 口腔种植专业 = "A12.08";
        public const string 口腔麻醉专业 = "A12.09";
        public const string 口腔颌面医学影像专业 = "A12.10";
        public const string 皮肤科 = "A13";
        public const string 皮肤病专业 = "A13.01";
        public const string 性传播疾病专业 = "A13.02";
        //public const string 其他= "A13.03";
        public const string 医疗美容科 = "A14";
        public const string 精神科 = "A15";
        public const string 精神病专业 = "A15.01";
        public const string 精神卫生专业 = "A15.02";
        public const string 药物依赖专业 = "A15.03";
        public const string 精神康复专业 = "A15.04";
        public const string 社区防治专业 = "A15.05";
        public const string 临床心理专业 = "A15.06";
        public const string 司法精神专业 = "A15.07";
        //public const string 其他 = "A15.08"; 

        public const string 传染科 = "A16";
        public const string 肠道传染病专业 = "A16.01";
        public const string 呼吸道传染病专业 = "A16.02";
        public const string 肝炎专业 = "A16.03";
        public const string 虫媒传染病专业 = "A16.04";
        public const string 动物源性传染病专业 = "A16.05";
        public const string 蠕虫病专业 = "A16.06";
        public const string 其它 = "A16.07";
        public const string 结核病科 = "A17";
        public const string 地方病科 = "A18";
        public const string 肿瘤科 = "A19";
        public const string 急诊医学科 = "A20";
        public const string 康复医学科 = "A21";
        public const string 运动医学科 = "A22";
        public const string 职业病科 = "A23";
        public const string 职业中毒专业 = "A23.01";
        public const string 尘肺专业 = "A23.02";
        public const string 放射病专业 = "A23.03";
        public const string 物理因素损伤专业 = "A23.04";
        public const string 职业健康监护专业 = "A23.05";

        //public const string 其他= "A23.06";
        public const string 临终关怀科 = "A24";
        public const string 特种医学与军事医学科 = "A25";
        public const string 麻醉科 = "A26";
        public const string 疼痛科 = "A27";
        public const string 重症医学科 = "A28";
        public const string 医学检验科 = "A30";
        public const string 临床体液血液专业 = "A30.01";
        public const string 临床微生物学专业 = "A30.02";
        public const string 临床生化检验专业 = "A30.03";
        public const string 临床免疫血清学专业 = "A30.04";
        public const string 临床细胞分子遗传学专业 = "A30.05";
        //public const string 其他= "A30.06";
        public const string 病理科 = "A31";
        public const string 医学影像科 = "A32";
        public const string X线诊断专业 = "A32.01";
        public const string CT诊断专业 = "A32.02";
        public const string 磁共振成像诊断专业 = "A32.03";
        public const string 核医学专业 = "A32.04";
        public const string 超声诊断专业 = "A32.05";

        public const string 心电诊断专业 = "A32.06";
        public const string 脑电及脑血流图诊断专业 = "A32.07";
        public const string 神经肌肉电图专业 = "A32.08";
        public const string 介入放射学专业 = "A32.09";
        public const string 放射治疗专业 = "A32.10";
        //public const string 其他= "A32.11";
        public const string 中医科 = "A50";
        public const string 内科专业 = "A50.01";
        public const string 外科专业 = "A50.02";
        public const string 妇产科专业 = "A50.03";
        public const string 儿科专业 = "A50.04";
        public const string 皮肤科专业 = "A50.05";
        public const string 眼科专业 = "A50.06";
        public const string 耳鼻咽喉科专业 = "A50.07";
        public const string 口腔科专业 = "A50.08";
        public const string 肿瘤科专业 = "A50.09";
        public const string 骨伤科专业 = "A50.10";
        public const string 肛肠科专业 = "A50.11";
        public const string 老年病科专业 = "A50.12";
        public const string 针灸科专业 = "A50.13";

        public const string 推拿科专业 = "A50.14";
        public const string 康复医学专业 = "A50.15";
        public const string 急诊科专业 = "A50.16";
        public const string 预防保健科专业 = "A50.17";
        //public const string 其他= "A50.18";
        public const string 民族医学科 = "A51";
        public const string 维吾尔医学 = "A51.01";
        public const string 藏医学 = "A51.02";
        public const string 蒙医学 = "A51.03";
        public const string 彝医学 = "A51.04";
        public const string 傣医学 = "A51.05";
        //public const string 其他 = "A51.06";
        public const string 中西医结合科 = "A52";
        public const string 其他业务科室 = "A69";
        //public const string 传染病预防控制科中心= "B01";
        public const string 性病艾滋病预防控制科中心 = "B02";
        public const string 结核病预防控制科中心 = "B03";
        public const string 血吸虫预防控制科中心 = "B04";

        public const string 慢性非传染性疾病预防控制科中心 = "B05";

        public const string 寄生虫病预防控制科中心 = "B06";
        public const string 地方病控制科中心 = "B07";
        public const string 精神卫生科中心 = "B08";
        public const string 妇幼保健科 = "B09";
        public const string 免疫规划科中心 = "B10";
        public const string 农村改水技术指导科中心 = "B11";
        public const string 疾病控制与应急处理办公室 = "B12";
        public const string 食品卫生科 = "B13";
        public const string 环境卫生所 = "B14";
        public const string 职业卫生科 = "B15";
        public const string 放射卫生科 = "B16";
        public const string 学校卫生科 = "B17";
        public const string 健康教育科中心 = "B18";
        public const string 预防医学门诊 = "B19";
        //public const string 其他业务科室= "B69";
        public const string 综合卫生监督科 = "C01";
        public const string 产品卫生监督科 = "C02";
        public const string 职业卫生监督科 = "C03";
        public const string 环境卫生监督科 = "C04";
        public const string 传染病执法监督科 = "C05";

        public const string 医疗服务监督科 = "C06";
        public const string 稽查科大队 = "C07";
        public const string 许可受理科 = "C08";
        public const string 放射卫生监督科 = "C09";
        public const string 学校卫生监督科 = "C10";
        public const string 食品安全监督科 = "C11";
        //public const string 其他="C69 
        public const string 护理部 = "D71";
        public const string 药剂科药房 = "D72";
        public const string 感染科 = "D73";
        public const string 输血科血库 = "D74";
        public const string 办公室 = "D81";
        public const string 人事科 = "D82";
        public const string 财务科 = "D83";
        public const string 设备科 = "D84";
        public const string 信息科中心 = "D85";
        public const string 医政科 = "D86";
        public const string 教育培训科 = "D87";
        public const string 总务科 = "D88";
        public const string 新农合管理办公室 = "D89";

        public const string 其他科室 = "D99";
    }
}
