using ExampleCnx.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace ExampleCnx.DAL
{
    public class EmpleadosDAL
    {
        public DataTable Consultar()
        {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            SqlCommand cmd = new SqlCommand("sp_EmpleadosConsultar", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            cn.Open();
            da.Fill(ds);
            cn.Close();

            return ds.Tables[0];
        }

        public bool Insertar(Empleado empleado) {

            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("CrearEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.NVarChar, 50) { Value = empleado.Nombre });
                cmd.Parameters.Add(new SqlParameter("@Apellido", System.Data.SqlDbType.NVarChar, 50) { Value = empleado.Apellido });
                cmd.Parameters.Add(new SqlParameter("@Identificacion", System.Data.SqlDbType.Int) { Value = empleado.Identificacion });
                cmd.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.NVarChar, 50) { Value = empleado.Telefono });
                cmd.Parameters.Add(new SqlParameter("@Celular", System.Data.SqlDbType.NVarChar, 50) { Value = empleado.Movil });
                cmd.Parameters.Add(new SqlParameter("@Direccion", System.Data.SqlDbType.NVarChar, 50) { Value = empleado.Direccion });
                cmd.Parameters.Add(new SqlParameter("@Usuario", System.Data.SqlDbType.NVarChar, 50) { Value = empleado.login });
                cmd.Parameters.Add(new SqlParameter("@Contrasena", System.Data.SqlDbType.NVarChar, 50) { Value = empleado.contrasena });
                cmd.Parameters.Add(new SqlParameter("@Cargo", System.Data.SqlDbType.Int) { Value = empleado.IdCargo });

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

        public bool Actualizar(Empleado empleado)
        {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_EmpleadosActualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Nombre", System.Data.SqlDbType.NVarChar, 50) { Value = empleado.Nombre });
                cmd.Parameters.Add(new SqlParameter("@Apellido", System.Data.SqlDbType.NVarChar, 50) { Value = empleado.Apellido });
                cmd.Parameters.Add(new SqlParameter("@Identificacion", System.Data.SqlDbType.Int) { Value = empleado.Identificacion });
                cmd.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.NVarChar, 50) { Value = empleado.Telefono });
                cmd.Parameters.Add(new SqlParameter("@Movil", System.Data.SqlDbType.NVarChar, 50) { Value = empleado.Movil });
                cmd.Parameters.Add(new SqlParameter("@IdCargo", System.Data.SqlDbType.VarChar, 50) { Value = empleado.IdCargo });
                cmd.Parameters.Add(new SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 50) { Value = empleado.Direccion });
                cmd.Parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.Int) { Value = empleado.Id });

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

        public bool Eliminar(Empleado empleado) {
            SqlConnection cn = new SqlConnection(Common.CN_NAME);

            if (cn.State == ConnectionState.Open)
                cn.Close();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_EmpleadosEliminar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Id", System.Data.SqlDbType.Int) { Value = empleado.Id });

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
