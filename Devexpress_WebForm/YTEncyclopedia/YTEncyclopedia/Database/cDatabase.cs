using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace YTEncyclopedia
{
    public static class cDatabase
    {
        private static cDatabaseAccess dbo = new cDatabaseConn(
                                        ConfigurationManager.ConnectionStrings["YTEncyclopedia"].ConnectionString
                                        ).dbo;

        public static DataTable Getvideos()
        {
            SqlParameter[] parameters = new SqlParameter[] { };
            return dbo.RunProcedure("SP_VIDEO_SelectAll", parameters, "VIDEO").Tables[0];
        }

        public static DataTable Getcourses()
        {
            SqlParameter[] parameters = new SqlParameter[] { };
            return dbo.RunProcedure("SP_COURSE_SelectAll", parameters, "COURSE").Tables[0];
        }

        internal static void SaveTeacher(Teacher teacher)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("FirstName", teacher.FirstName),
                new SqlParameter("LastName", teacher.LastName),
                new SqlParameter("Description", teacher.Description),
                new SqlParameter("ChannelName", teacher.ChannelName),
                new SqlParameter("Image", teacher.Image)
            };
            dbo.RunProcedure("SP_TEACHER_Insert", parameters, "TEACHER");
        }

        public static DataTable GetTeachers()
        {
            SqlParameter[] parameters = new SqlParameter[] { };
            return dbo.RunProcedure("SP_TEACHER_SelectAll", parameters, "COURSE").Tables[0];
        }




        public static Video GetvideoById(int id)
        {
            Video mVideo = new Video();
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("IDvideo", id) };
            DataTable tb = dbo.RunProcedure("SP_VIDEO_SelectRow", parameters, "VIDEO").Tables[0];
            if (tb.Rows.Count > 0) {
                mVideo.IDvideo = id;
                mVideo.Name = tb.Rows[0]["Name"].ToString();
                mVideo.Url = tb.Rows[0]["Url"].ToString();
                mVideo.Image = tb.Rows[0]["Image"].ToString();
                mVideo.IDcourse = Convert.ToInt32(tb.Rows[0]["IDcourse"]);
                mVideo.IDteacher = Convert.ToInt32(tb.Rows[0]["IDteacher"]);

            }
            return mVideo;
        }

        public static void Deletevideo(int id)
        {
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("IDvideo",id) };
            dbo.RunProcedure("SP_VIDEO_Delete", parameters, "VIDEO");
        }

        
    }
}