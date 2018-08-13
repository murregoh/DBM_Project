using ExampleCnx.DAL;
using ExampleCnx.Modelos;
using System.Data;

namespace ExampleCnx.BLL
{
    public class EmpleadosBLL
    {
        public DataTable Consultar()
        {
            EmpleadosDAL cargosDal = new EmpleadosDAL();
            return cargosDal.Consultar();   
        }

        public bool Actualizar(Empleado empleado)
        {
            EmpleadosDAL cargosDal = new EmpleadosDAL();
            return cargosDal.Actualizar(empleado);
        }

        public bool Insertar(Empleado empleado)
        {
            DAL.EmpleadosDAL empleados = new EmpleadosDAL();
            return empleados.Insertar(empleado);
        }

        public bool Eliminar(Empleado empleado)
        {
            EmpleadosDAL cargosDal = new EmpleadosDAL();
            return cargosDal.Eliminar(empleado);
        }
    }
}
