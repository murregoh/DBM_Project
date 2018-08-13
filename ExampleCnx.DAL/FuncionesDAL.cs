using ExampleCnx.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace ExampleCnx.DAL
{
    public class FuncionesDAL
    {
        public DataTable Consultar()
        {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            SqlCommand cmd = new SqlCommand("sp_FuncionesConsultar", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            cn.Open();
            da.Fill(ds);
            cn.Close();

            return ds.Tables[0];
        }

        public bool Actualizar(Funciones funciones)
        {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_FuncionesActualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdPelicula", System.Data.SqlDbType.Int) { Value = funciones.IdPelicula });
                cmd.Parameters.Add(new SqlParameter("@Fecha", System.Data.SqlDbType.Date) { Value = funciones.fecha });
                cmd.Parameters.Add(new SqlParameter("@Precio", System.Data.SqlDbType.Int) { Value = funciones.precio });
                cmd.Parameters.Add(new SqlParameter("@Descuento", System.Data.SqlDbType.Int) { Value = funciones.descuento });
                cmd.Parameters.Add(new SqlParameter("@IdSala", System.Data.SqlDbType.Int) { Value = funciones.IdSala });
                cmd.Parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.Int) { Value = funciones.id });

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

        public bool Eliminar(Funciones funciones)
        {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_FuncionesEliminar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int) { Value = funciones.id });

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

        public bool CrearFuncion(Funciones fun) {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_FuncionesInsertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdPelicula", System.Data.SqlDbType.Int) { Value = fun.IdPelicula });
                cmd.Parameters.Add(new SqlParameter("@Fecha", System.Data.SqlDbType.Date) { Value = fun.fecha });
                cmd.Parameters.Add(new SqlParameter("@Precio", System.Data.SqlDbType.Int) { Value = fun.precio });
                cmd.Parameters.Add(new SqlParameter("@Descuento", System.Data.SqlDbType.Int) { Value = fun.descuento });
                cmd.Parameters.Add(new SqlParameter("@IdSala", System.Data.SqlDbType.Int) { Value = fun.IdSala });

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
