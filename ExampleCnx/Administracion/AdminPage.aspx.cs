using System;

namespace ExampleCnx.Administracion
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToString();
            
        }
    }
}