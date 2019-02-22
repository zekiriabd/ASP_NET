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
    }
}