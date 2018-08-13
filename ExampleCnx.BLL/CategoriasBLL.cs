using ExampleCnx.DAL;
using System.Data;

namespace ExampleCnx.BLL
{
    public class CategoriasBLL
    {
        public DataTable ConsultarCategorias() {
            CategoriasDAL categoriasDal = new CategoriasDAL();
            return categoriasDal.ConsultarCategorias();
        }

        public string CrearCategoria(string categoria) {

            bool CrearCategoriasDal = new CategoriasDAL().CrearCategoria(categoria);

            if (CrearCategoriasDal)
            {
                return "La Categoria se creo correctamente";
            }
            else
            {
                return "La Categoria no se pudo crear";
            }
        }
    }
}
