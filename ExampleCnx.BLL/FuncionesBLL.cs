using ExampleCnx.DAL;
using ExampleCnx.Modelos;
using System.Data;

namespace ExampleCnx.BLL
{
    public class FuncionesBLL
    {
        public DataTable Consultar() {
            FuncionesDAL cargosDal = new FuncionesDAL();
            return cargosDal.Consultar();
        }

        public bool Actualizar(Funciones funciones)
        {
            FuncionesDAL funcionesDAL = new FuncionesDAL();
            return funcionesDAL.Actualizar(funciones);
        }

        public bool Eliminar(Funciones funciones)
        {
            FuncionesDAL funcionesDAL = new FuncionesDAL();
            return funcionesDAL.Eliminar(funciones);
        }
        public string CrearFuncion(Funciones funciones)
        {
            FuncionesDAL funcionesDAL = new FuncionesDAL();
            bool CrearFuncion = funcionesDAL.CrearFuncion(funciones);

            if (CrearFuncion)
            {
                return "Funcion Creada correctamente";
            }
            else
            {
                return "La funcion no se creo";
            }
        }
    }
}
