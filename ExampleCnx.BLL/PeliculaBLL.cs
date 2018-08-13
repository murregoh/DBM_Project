using ExampleCnx.DAL;
using ExampleCnx.Modelos;
using System.Data;

namespace ExampleCnx.BLL
{
    public class PeliculaBLL
    {
        public string Insertar(Pelicula Pelicula)
        {

            bool creacionPelicula = new PeliculaDAL().Insertar(Pelicula);

            if (creacionPelicula)
            {
                return "Pelicula creada exitosamente";
            }
            else
            {
                return "Pelicula no pudo ser creada";
            }
        }

        public DataTable Consultar()
        {

            PeliculaDAL PeliculasDal = new PeliculaDAL();
            return PeliculasDal.Consultar();

        }

        public bool Actualizar(Pelicula pelicula)
        {
            PeliculaDAL pel = new PeliculaDAL();
            return pel.Actualizar(pelicula);
        }

        public bool Eliminar(Pelicula pelicula) {
            PeliculaDAL PeliculaDal = new PeliculaDAL();
            return PeliculaDal.Eliminar(pelicula);
        }
    }
}
