using System.Data;
using System.Data.SqlClient;

namespace ExampleCnx.DAL
{
    public class CargosDAL
    {
        public DataTable ConsultarCargos() {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            SqlCommand cmd = new SqlCommand("CargosConsultarTodos", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            cn.Open();
            da.Fill(ds);
            cn.Close();

            return ds.Tables[0];
        }

        public bool InsertarCargo(string nomCargo) {

            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("CrearCargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nomCargo", System.Data.SqlDbType.VarChar, 50) { Value = nomCargo });

                cn.Open();
                cmd.ExecuteNonQuery();


                return true;
            }
            catch 
            {
                return false;
            }
            finally {
                cn.Close();
            }
        }

        public bool ActualizarCargo(int id, string cargo)
        {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("CargosActualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 50) { Value = cargo });
                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });

                if(cn.State == ConnectionState.Closed)
                    cn.Open();
                cmd.ExecuteNonQuery();
                

                return true;
            }
            catch 
            {
                return false;
            }
            finally {
                cn.Close();
            }
        }
    }
}
