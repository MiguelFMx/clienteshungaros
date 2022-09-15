using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace clienteshungaros.clases
{
    public class clsHerramientasBD
    {
        public static string strConnction = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public static DataTable Existe(string sqlCommand)
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(strConnction);
            SqlCommand cmd = new SqlCommand(sqlCommand, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {

                throw;
            }

            return dt;
        }

        public static string ExecuteSql(string strSql)
        {
            string strError = "";

            SqlConnection conn = new SqlConnection(strConnction);
            SqlCommand cmd = new SqlCommand(strSql, conn);


            conn.Open();

            try
            {
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                strError = ex.Message;
            }

            return strError;
        }


    }
}