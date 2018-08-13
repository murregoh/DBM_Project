using ExampleCnx.Modelos;
using System;

namespace ExampleCnx
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombre.Text = ((SessionUsuario)Session["SessionUsuario"]).Nombre;
            lblNombreCargo.Text = ((SessionUsuario)Session["SessionUsuario"]).Cargo;
        }
    }
}