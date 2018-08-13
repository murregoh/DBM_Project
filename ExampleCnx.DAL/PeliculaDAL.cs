using ExampleCnx.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace ExampleCnx.DAL
{
    public class PeliculaDAL
    {
        public bool Insertar(Pelicula Pelicula)
        {

            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("CrearPelicula", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.NVarChar, 50) { Value = Pelicula.Nombre });
                cmd.Parameters.Add(new SqlParameter("@Descripcion", System.Data.SqlDbType.NVarChar, 50) { Value = Pelicula.Descripcion });
                cmd.Parameters.Add(new SqlParameter("@Anio", System.Data.SqlDbType.Int) { Value = Pelicula.anio });
                cmd.Parameters.Add(new SqlParameter("@Idioma", System.Data.SqlDbType.NVarChar, 50) { Value = Pelicula.Idioma });
                cmd.Parameters.Add(new SqlParameter("@IdCategoria", System.Data.SqlDbType.Int) { Value = Pelicula.Categoria });
                cmd.Parameters.Add(new SqlParameter("@Director", System.Data.SqlDbType.NVarChar, 50) { Value = Pelicula.Director });

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


        public DataTable Consultar()
        {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            SqlCommand cmd = new SqlCommand("sp_PeliculasConsulta", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            cn.Open();
            da.Fill(ds);
            cn.Close();

            return ds.Tables[0];

        }

        public bool Actualizar(Pelicula pelicula)
        {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_PeliculasActualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.NVarChar, 50) { Value = pelicula.Nombre });
                cmd.Parameters.Add(new SqlParameter("@Descripcion", System.Data.SqlDbType.NVarChar, 50) { Value = pelicula.Descripcion });
                cmd.Parameters.Add(new SqlParameter("@Anio", System.Data.SqlDbType.Int) { Value = pelicula.anio });
                cmd.Parameters.Add(new SqlParameter("@Idioma", System.Data.SqlDbType.NVarChar, 50) { Value = pelicula.Idioma });
                cmd.Parameters.Add(new SqlParameter("@IdCategoria", System.Data.SqlDbType.Int) { Value = pelicula.Categoria });
                cmd.Parameters.Add(new SqlParameter("@Director", System.Data.SqlDbType.VarChar, 50) { Value = pelicula.Director });
                cmd.Parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.Int) { Value = pelicula.id });

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

        public bool Eliminar(Pelicula pelicula) {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_PeliculasEliminar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Original_Id", System.Data.SqlDbType.Int) { Value = pelicula.id });

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
