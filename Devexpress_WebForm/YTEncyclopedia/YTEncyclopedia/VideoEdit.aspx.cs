using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YTEncyclopedia
{
    public partial class VideoEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            cbxTeacher.DataSource = cDatabase.GetTeachers();
            cbxTeacher.DataBind();
            cbxCourse.DataSource = cDatabase.Getcourses();
            cbxCourse.DataBind();

            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString.Get("id"));
                var mvideo = cDatabase.GetvideoById(id);
                txName.Text = mvideo.Name;
                txUrl.Text = mvideo.Url;
                fuImageVideo.NullText = mvideo.Image;
                cbxTeacher.GridView.Selection.SelectRowByKey(mvideo.IDteacher);
                cbxCourse.GridView.Selection.SelectRowByKey(mvideo.IDcourse);
            }
        }
    }
}