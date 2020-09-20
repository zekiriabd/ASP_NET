using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Schema;

namespace LemonwayWebservice.Services
{
    public class ConvertService : IConvertService
    {


        ILog Log = LogManager.GetLogger("root");
        private string BadXml = "Bad Xml format";


        public string XmlToJson(string xml)
        {
            string result = "";
            bool errorXml = false;
            void ValidationEventHandler(object sender, ValidationEventArgs e)
            {
                errorXml = (e.Severity == XmlSeverityType.Error);
            }

            void RemoveAttributes(XmlDocument xmlDoc)
            {
                var root = xmlDoc.FirstChild;
                if (root.Attributes != null)
                {
                    root.Attributes.RemoveAll();
                }
                foreach (XmlNode child in root.ChildNodes)
                {
                    if (child.Attributes != null)
                    {
                        child.Attributes.RemoveAll();
                    }
                }
            }

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(xml);
                RemoveAttributes(doc);
                result = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None);
            }
            catch (Exception ex)
            {
                result = BadXml;
            }
            return result;
        }
    }
}