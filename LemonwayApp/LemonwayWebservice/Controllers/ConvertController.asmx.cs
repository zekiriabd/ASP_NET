using LemonwayWebservice.Services;
using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Xml;
using System.Xml.Schema;

namespace LemonwayWebservice
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class ConvertController : System.Web.Services.WebService
    {
        private ConvertService convertService = new ConvertService();

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string XmlToJson(XmalObject xml)
        {
            return convertService.XmlToJson(xml.xmlData);
        }
    }
}
