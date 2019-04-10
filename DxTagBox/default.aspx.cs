using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    class dxItem {
        public string Text { get; set; }
        public dxItem(string t) {
            this.Text = t;
        }
    }

    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
                Session["List"] = new List<dxItem>();
                ASPxDataViewDataBind();
            }
        }
        public void ASPxDataViewDataBind() {
            ASPxDataView1.DataSource = Session["List"];
            ASPxDataView1.DataBind();
        }

        protected void ASPxDataView1_CustomCallback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            if (e.Parameter != null)
            {
                string[] s = e.Parameter.Split('|');
                switch (s[0]) {
                    case "DELETE":
                        List<dxItem> list = (List<dxItem>)Session["List"];
                        dxItem item = list.FirstOrDefault(x => x.Text == s[1]);
                        list.Remove(item);
                        ASPxDataViewDataBind();
                    break;
                    case "ADD":
                        ((List<dxItem>)Session["List"]).Add(new dxItem(s[1]));
                        ASPxDataViewDataBind();
                    break;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            List<dxItem> list = (List<dxItem>)Session["List"];
            string str = string.Join("|",list.Select(x => x.Text).ToArray());

        }
    }
}