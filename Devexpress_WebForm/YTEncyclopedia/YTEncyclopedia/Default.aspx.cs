using System;

namespace YTEncyclopedia
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            gvVideoListDataBind();
        }

        private void gvVideoListDataBind() {
            gvVideoList.DataSource = cDatabase.Getvideos();
            gvVideoList.DataBind();
        }

        protected void gvVideoList_CustomCallback(object sender, DevExpress.Web.ASPxGridViewCustomCallbackEventArgs e)
        {
            string[] s = e.Parameters.Split('|');
            switch (s[0])
            {
                case "DELETE":
                    int id = Convert.ToInt32(s[1]);
                    cDatabase.Deletevideo(id);
                    gvVideoListDataBind();
                break;
            }
        }
    }
}