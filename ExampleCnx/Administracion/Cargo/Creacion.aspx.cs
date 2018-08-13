using ExampleCnx.BLL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace ExampleCnx.Administracion.Cargo
{
    public partial class Creacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack) {
                lblEstado.Text = string.Empty;
                CargarGrid();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            String Mensaje = new BLL.CargosBLL().CrearCargo(txtCargo.Text);
            CargarGrid();
            lblEstado.Text = Mensaje;
        }

       

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            CargarGrid();

        }
        
        private void CargarGrid()
        {
            DataTable Cargos = new BLL.CargosBLL().ConsultarCargos();
            GridView1.DataSource = Cargos;
            GridView1.DataBind();
        }
        
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            CargarGrid();
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            CargosBLL oCargos = new CargosBLL();
            try
            {
                var id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]["Id"]);
                var cargo = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtNombre")).Text;

                oCargos.ActualizarCargo(id, cargo);

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