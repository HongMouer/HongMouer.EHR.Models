using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System.Xml;

namespace HongMouer.Common.Utility
{
    public static class SerializeHelper
    {
        /// <summary>
        /// xml反序列化
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="xmlOrPath">xml字符或者xml文件路径</param>
        /// <returns></returns>
        public static T XmlDeserialize<T>(string xmlOrPath)
        {
            using (FileStream file = new FileStream(xmlOrPath, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                T obj = (T)serializer.Deserialize(file);
                file.Close();
                return obj;
            }
        }

        /// <summary>
        /// xml序列化
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="obj">带有参数的实体</param>
        /// <returns></returns>
        public static string XmlSerialize<T>(T obj)
        {
            using (StringWriter sw = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(sw, obj);
                sw.Close();
                return sw.ToString();
            }
        }


        /// <summary>
        /// json序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize<T>(T obj)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new DateTimeFormatMiddleware());
            options.Encoder = JavaScriptEncoder.Create(UnicodeRanges.All);
            //options.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            options.PropertyNamingPolicy = null;

            return JsonSerializer.Serialize<T>(obj, options);
        }

        /// <summary>
        /// json序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string obj)
        {
            return JsonSerializer.Deserialize<T>(obj);
        }

        /// <summary>
        /// json转xml
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string JsonToXmlDeserialize(string json)
        {
            XmlDocument doc = Newtonsoft.Json.JsonConvert.DeserializeXmlNode(json);
            return doc.OuterXml;
        }

        /// <summary>
        /// xml转json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string XmlToJsonSerialize<T>(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string json = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);
            return json;
        }
    }
}
