using ExampleCnx.BLL;
using ExampleCnx.Modelos;
using System;
using System.Data;

namespace ExampleCnx.Administracion.Usuarios
{
    public partial class Creacion : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable Cargos = new BLL.CargosBLL().ConsultarCargos();
                ddlCargos.DataSource = Cargos;
                ddlCargos.DataValueField = "ID";
                ddlCargos.DataTextField = "Nombre";
                ddlCargos.DataBind();
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtIdentifiacion.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtCelular.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtLogin.Text = string.Empty;
                txtContrasena.Text = string.Empty;
            }
        }
           
        protected void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            EmpleadosBLL oEmpleado = new EmpleadosBLL();
            Empleado empleado = new Empleado();

            empleado.Nombre = txtNombre.Text;
            empleado.Apellido = txtApellido.Text;
            empleado.Identificacion = Convert.ToInt32(txtIdentifiacion.Text);
            empleado.Telefono = txtTelefono.Text;
            empleado.Movil = txtCelular.Text;
            empleado.Direccion = txtDireccion.Text;
            empleado.login = txtLogin.Text;
            empleado.contrasena = txtContrasena.Text;
            empleado.IdCargo = Convert.ToInt32(ddlCargos.Text);

            if (oEmpleado.Insertar(empleado))
            {
                lblMensaje.Text = "El usuario se creo exitosamente";
            }
            else
            {
                lblMensaje.Text = "El usuario no se pudo crear de manera correcta";
            }
        }
    }
}