using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace DAL
{
    public class DataProvider
    {

        public static SqlConnection Openconnect()
        {
            string sChuoiKetNoi = @"Data Source=LAPTOP-BJKTHL97\SQLEXPRESS;Initial Catalog=WatchStoreC#;Integrated Security=True;TrustServerCertificate=True";
            //  string sChuoiKetNoi = @"Data Source=DESKTOP-FA34S7I\SQLEXPRESS;Initial Catalog=TOYSTOREPOS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            con.Open();
            return con;
        }
        public static void Disconnect(SqlConnection con)
        {
            con.Close();
        }
        public static int JustExcuteNoParameter(string sql)
        {
            SqlConnection con = Openconnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            int rows = cmd.ExecuteNonQuery();
            Disconnect(con);
            if (rows > 0)
            {
                return rows;
            }
            else
            {
                return -1;
            }
        }

        public static int JustExcuteWithParameter(string sql, params SqlParameter[] parameters)
        {
            string connectionString = @"Data Source=LAPTOP-BJKTHL97\SQLEXPRESS;Initial Catalog=WatchStoreC#;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString)) // Chuỗi kết nối phải được đưa vào đây, không phải sql
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }


        public static DataTable GetTable(string sql)
        {
            SqlConnection con = Openconnect();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Disconnect(con);
            return dt;
        }


        // Hàm lấy dữ liệu với tham số
        public static DataTable GetTableWithParameters(string sql, SqlParameter[] parameters)
        {
            string connectionString = @"Data Source=LAPTOP-BJKTHL97\SQLEXPRESS;Initial Catalog=WatchStoreC#;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddRange(parameters);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        //ktra email
        public static object ExecuteScalar(string sql, SqlParameter[] parameters)
        {
            string connectionString = @"Data Source=LAPTOP-BJKTHL97\SQLEXPRESS;Initial Catalog=WatchStoreC#;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))  
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddRange(parameters);
                        return cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi thực thi câu lệnh SQL: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
