using ExampleCnx.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace ExampleCnx.DAL
{
    public class SalasDAL
    {
        public DataTable Consultar()
        {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            SqlCommand cmd = new SqlCommand("sp_SalasConsultar", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            cn.Open();
            da.Fill(ds);
            cn.Close();

            return ds.Tables[0];
        }

        public bool Actualizar(Sala sala)
        {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SalasActualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Ubicacion", System.Data.SqlDbType.NVarChar, 50) { Value = sala.Ubicacion});
                cmd.Parameters.Add(new SqlParameter("@Capacidad", System.Data.SqlDbType.NVarChar, 50) { Value = sala.Capacidad});
                cmd.Parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.Int) { Value = sala.Id });
                
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

        public bool CreacionSala(Sala sala) {

            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_SalasInsertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Ubicacion", System.Data.SqlDbType.NVarChar, 50) { Value = sala.Ubicacion });
                cmd.Parameters.Add(new SqlParameter("@Capacidad", System.Data.SqlDbType.NVarChar, 50) { Value = sala.Capacidad });

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
