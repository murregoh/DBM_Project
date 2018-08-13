using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ExampleCnx.DAL
{
    public class LoginDAL
    {
        string CN_NAME = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
        public DataSet Login(string user, string password)
        {

            SqlConnection cn = new SqlConnection(CN_NAME);
            if (cn.State == ConnectionState.Open)
                cn.Close();
            
            SqlCommand cmd = new SqlCommand("Login", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@User", System.Data.SqlDbType.VarChar, 50) { Value = user });
            cmd.Parameters.Add(new SqlParameter("@Password", System.Data.SqlDbType.VarChar, 50) { Value = password });
                

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            cn.Open();
            da.Fill(ds);
            cn.Close();

            return ds;
        }
    }
}
