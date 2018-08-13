using ExampleCnx.BLL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace ExampleCnx.Administracion.Funciones
{
    public partial class EdicionEliminacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                CargarGrid();
            }
        }

        private void CargarGrid()
        {
            GridView1.DataSource = new FuncionesBLL().Consultar();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            FuncionesBLL oFunciones = new FuncionesBLL();
            Modelos.Funciones funcion = new Modelos.Funciones();

            try
            {
                funcion.id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]["Id"]);

                oFunciones.Eliminar(funcion);

                GridView1.EditIndex = -1;
                CargarGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            CargarGrid();
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            FuncionesBLL oFunciones = new FuncionesBLL();
            Modelos.Funciones funcion = new Modelos.Funciones();

            try
            {
                funcion.id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]["Id"]);
                funcion.IdPelicula = Convert.ToInt32(((DropDownList)GridView1.Rows[e.RowIndex].FindControl("ddlPelicula")).SelectedValue);
                funcion.IdSala = Convert.ToInt32(((DropDownList)GridView1.Rows[e.RowIndex].FindControl("ddlSala")).SelectedValue);
                funcion.precio = Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPrecio")).Text);
                funcion.descuento = Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtDescuento")).Text);
                funcion.fecha = Convert.ToDateTime(((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtFecha")).Text);
                
                oFunciones.Actualizar(funcion);


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
                var dd = e.Row.FindControl("ddlSala") as DropDownList;
                if (dd != null)
                {
                    DataTable Salas = new BLL.SalasBLL().Consultar();
                    dd.DataSource = Salas;
                    dd.DataValueField = "Id";
                    dd.DataTextField = "Ubicacion";
                    dd.DataBind();

                    dd.SelectedValue = (e.Row.FindControl("lblIdSala") as Label).Text;
                }

                var ddP = e.Row.FindControl("ddlPelicula") as DropDownList;
                if (ddP != null)
                {
                    DataTable Peliculas = new BLL.PeliculaBLL().Consultar();
                    ddP.DataSource = Peliculas;
                    ddP.DataValueField = "Id";
                    ddP.DataTextField = "Nombre";
                    ddP.DataBind();

                    ddP.SelectedValue = (e.Row.FindControl("lblIdPelicula") as Label).Text;
                }
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            CargarGrid();
        }
    }
}