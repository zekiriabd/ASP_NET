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

            gvVideoList.DataSource = cDatabase.Getvideos();
            gvVideoList.DataBind();
        }
    }
}