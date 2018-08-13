using System.Data;
using System.Data.SqlClient;

namespace ExampleCnx.DAL
{
    public class CategoriasDAL
    {
        public DataTable ConsultarCategorias()
        {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            SqlCommand cmd = new SqlCommand("CategoriasConsultarTodos", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            cn.Open();
            da.Fill(ds);
            cn.Close();

            return ds.Tables[0];
        }

        public bool CrearCategoria(string nomCategoria)
        {

            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("CrearCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NomCategoria", System.Data.SqlDbType.NVarChar, 50) { Value = nomCategoria });

                cn.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
