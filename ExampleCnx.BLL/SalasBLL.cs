using ExampleCnx.DAL;
using ExampleCnx.Modelos;
using System.Data;

namespace ExampleCnx.BLL
{
    public class SalasBLL
    {
        SalasDAL salasDal = new SalasDAL();
        public DataTable Consultar()
        {

            return salasDal.Consultar();
        }

        public bool Actualizar(Sala sala)
        {
            return salasDal.Actualizar(sala);
        }

        public string CrearPelicula(Sala sala) {

            bool CreacionSalas = new SalasDAL().CreacionSala(sala);

            if (CreacionSalas)
            {
                return "Sala Creada correctamente";
            }
            else
            {
                return "Sala no pudo ser creada";
            }
        }

    }
}
