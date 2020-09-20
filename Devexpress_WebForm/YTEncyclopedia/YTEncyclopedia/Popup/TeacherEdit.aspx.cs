using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YTEncyclopedia.Popup
{
    public partial class TeacherEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Teacher teacher         = new Teacher();
            teacher.FirstName       = txFirstName.Text;
            teacher.LastName        =  txLastName.Text;
            teacher.ChannelName     =  txChannelName.Text;
            teacher.Description     =  txDescription.Html;
            //teacher.Image           = fuImage.file
            cDatabase.SaveTeacher(teacher);
        }
    }
}