using ExampleCnx.BLL;
using ExampleCnx.Modelos;
using System;
using System.Data;

namespace ExampleCnx.Administracion.Peliculas
{
    public partial class Creacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable Categorias = new BLL.CategoriasBLL().ConsultarCategorias();
                ddlCategorias.DataSource = Categorias;
                ddlCategorias.DataValueField = "ID";
                ddlCategorias.DataTextField = "Categoria";
                ddlCategorias.DataBind();
            }
        }

        protected void btnAgregarCategoria(object sender, EventArgs e)
        {
            string mensaje  = new BLL.CategoriasBLL().CrearCategoria(txtCategoria.Text);
            lblMensaje.Text = mensaje;
        }

        protected void btnAgregarPelicula(object sender, EventArgs e)
        {
            PeliculaBLL oPeliculas = new PeliculaBLL();
            Pelicula Pelicula = new Pelicula();

            Pelicula.Nombre = txtNombre.Text;
            Pelicula.Descripcion = txtDescripcion.Text;
            Pelicula.anio = Convert.ToInt32(txtAnio.Text);
            Pelicula.Idioma = txtIdioma.Text;
            Pelicula.Director = txtDirector.Text;
            Pelicula.Categoria = Convert.ToInt32(ddlCategorias.Text);

            lblMensajePelicula.Text = oPeliculas.Insertar(Pelicula);

        }
    }
}