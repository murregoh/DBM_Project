using ExampleCnx.BLL;
using ExampleCnx.Modelos;
using System;

namespace ExampleCnx
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            BLL.LoginStatus result = new LoginBLL().Login(txtUser.Text, txtPassword.Text);
            SessionUsuario oUsuario = new SessionUsuario();

            if (result.UserResult == Status.Success)
            {
                oUsuario.Nombre = result.data.Tables[0].Rows[0]["Nombre"].ToString();
                oUsuario.Cargo = result.data.Tables[0].Rows[0]["NombreCargo"].ToString();

                Session["SessionUsuario"] = oUsuario;

                if (result.data.Tables[0].Rows[0]["NumCargo"].Equals(1))
                {
                    Response.Redirect("Administracion/AdminPage.aspx");
                }
                else
                {
                    Response.Redirect("Usuarios/UserPage.aspx");
                }

            }
            else
            {
                lblMessage.Text = result.Message;
            }
        }
    }
}