using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace softweb
{
    public partial class _Default : Page
    {
        public string GetVersion { get {return WebConfigurationManager.AppSettings["version"]; } }
        public string GetMailTo { get { return "mailto:" + WebConfigurationManager.AppSettings["mailto"]; } }
        
        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}