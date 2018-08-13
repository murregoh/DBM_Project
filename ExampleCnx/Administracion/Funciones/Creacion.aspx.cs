using ExampleCnx.BLL;
using System;
using System.Data;

namespace ExampleCnx.Administracion.Funciones
{
    public partial class Creacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable Pelicula = new BLL.PeliculaBLL().Consultar();
                ddlPelicula.DataSource = Pelicula;
                ddlPelicula.DataValueField = "Id";
                ddlPelicula.DataTextField = "Nombre";
                ddlPelicula.DataBind();

                DataTable Sala = new BLL.SalasBLL().Consultar();
                ddlSala.DataSource = Sala;
                ddlSala.DataValueField = "Id";
                ddlSala.DataTextField = "Ubicacion";
                ddlSala.DataBind();
            }
        }

        protected void btnAgregarPelicula(object sender, EventArgs e)
        {
            FuncionesBLL oFuncion = new FuncionesBLL();
            Modelos.Funciones funcion = new Modelos.Funciones();
            

            funcion.fecha = Convert.ToDateTime(txtFecha.Text);
            funcion.precio = Convert.ToDouble(txtPrecio.Text);
            funcion.descuento = Convert.ToDouble(txtDescuento.Text);
            funcion.IdPelicula = Convert.ToInt32(ddlPelicula.Text);
            funcion.IdSala = Convert.ToInt32(ddlSala.Text);

            lblMensajeFuncion.Text = oFuncion.CrearFuncion(funcion);





        }
    }
}