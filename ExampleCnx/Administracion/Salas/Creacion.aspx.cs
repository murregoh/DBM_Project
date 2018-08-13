using ExampleCnx.BLL;
using ExampleCnx.Modelos;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace ExampleCnx.Administracion.Salas
{
    public partial class Creacion : System.Web.UI.Page
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
            DataTable Cargos = new BLL.SalasBLL().Consultar();
            GridView1.DataSource = Cargos;
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
            SalasBLL oCargos = new SalasBLL();
            Sala sala = new Sala();
            try
            {
                sala.Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex]["Id"]);
                sala.Ubicacion = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtUbicacion")).Text;
                sala.Capacidad = Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtCapacidad")).Text);

                oCargos.Actualizar(sala);

                GridView1.EditIndex = -1;
                CargarGrid();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            SalasBLL oSalas = new SalasBLL();
            Sala sala = new Sala();

            sala.Ubicacion = txtUbicacion.Text;
            sala.Capacidad = Convert.ToInt32(txtCapacidad.Text);

            lblEstado.Text = new SalasBLL().CrearPelicula(sala);
            CargarGrid();
        }
    }
}