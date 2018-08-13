using ExampleCnx.BLL;
using ExampleCnx.Modelos;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace ExampleCnx.Administracion.Usuarios
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

        private void CargarGrid()
        {
            GridView1.DataSource =  new EmpleadosBLL().Consultar();
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
            EmpleadosBLL oEmpleado = new EmpleadosBLL();
            Empleado empleado = new Empleado();

            try
            {
                empleado.Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]["Id"]);
                empleado.Nombre = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtNombre")).Text;
                empleado.Apellido = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtApellido")).Text;
                empleado.Identificacion = Convert.ToInt32( ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtIdentificacion")).Text);
                empleado.Telefono = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtTelefono")).Text;
                empleado.Movil = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtMovil")).Text;
                empleado.IdCargo = Convert.ToInt32(((DropDownList)GridView1.Rows[e.RowIndex].FindControl("ddlCargo")).SelectedValue);
                empleado.Direccion = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtDireccion")).Text;

                oEmpleado.Actualizar(empleado);


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
                var dd = e.Row.FindControl("ddlCargo") as DropDownList;
                if (dd != null)
                {
                    DataTable Cargos = new BLL.CargosBLL().ConsultarCargos();
                    dd.DataSource = Cargos;
                    dd.DataValueField = "ID";
                    dd.DataTextField = "Nombre";
                    dd.DataBind();

                    dd.SelectedValue = (e.Row.FindControl("lblIdCargo") as Label).Text;
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            EmpleadosBLL oEmpleado = new EmpleadosBLL();
            Empleado empleado = new Empleado();

            try
            {
                empleado.Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]["Id"]);
                
                oEmpleado.Eliminar(empleado);


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