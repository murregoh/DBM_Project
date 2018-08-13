using ExampleCnx.BLL;
using ExampleCnx.Modelos;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace ExampleCnx.Administracion.Peliculas
{
    public partial class EdicionEliminacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid();
            }
        }

        public void CargarGrid()
        {
            GridView1.DataSource = new PeliculaBLL().Consultar(); ;
            GridView1.DataBind();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            CargarGrid();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            CargarGrid();
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataBind();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            PeliculaBLL oPelicula = new PeliculaBLL();
            Pelicula pelicula = new Pelicula();

            try
            {
                pelicula.id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]["Id"]);
                pelicula.Nombre = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtNombre")).Text;
                pelicula.Descripcion = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtDescripcion")).Text;
                pelicula.anio = Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtAnio")).Text);
                pelicula.Idioma = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtIdioma")).Text;
                pelicula.Categoria = Convert.ToInt32(((DropDownList)GridView1.Rows[e.RowIndex].FindControl("ddlCategoria")).SelectedValue);
                pelicula.Director = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtDirector")).Text;

                oPelicula.Actualizar(pelicula);


                GridView1.EditIndex = -1;
                CargarGrid();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var dd = e.Row.FindControl("ddlCategoria") as DropDownList;
                if (dd != null)
                {
                    DataTable Categorias = new BLL.CategoriasBLL().ConsultarCategorias();
                    dd.DataSource = Categorias;
                    dd.DataValueField = "Id";
                    dd.DataTextField = "Categoria";
                    dd.DataBind();

                    //dd.SelectedValue = (e.Row.FindControl("lblCategoria") as Label).Text;
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            PeliculaBLL oPelicula = new PeliculaBLL();
            Pelicula pelicula = new Pelicula();

            try
            {
                pelicula.id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]["Id"]);

                oPelicula.Eliminar(pelicula);


                GridView1.EditIndex = -1;
                CargarGrid();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}