<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ExampleCnx.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="css/LoginPage.css" rel="stylesheet" type="text/css" />
    <link href="dist/css/AdminLTE.min.css" rel="stylesheet" type="text/css" />
</head>
<body class="hold-transition login-page">
    <div class="login-box">
        <div class="login-logo">
            <a><b>Cinema</b>DB II</a>
        </div>
        <form class="login-box" id="Login" runat="server">
            <div class="loginmodal-container">
                <h1>Inicio de Sesión</h1>
                <br>
                <asp:TextBox ID="txtUser" runat="server" placeholder="Username"></asp:TextBox>
                <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                <asp:Button ID="btnLoginPage" runat="server" OnClick="Login_Click" Text="Login" CssClass="btn btn-primary" />
                <div class="message container col-md-8">
                    <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
                </div>
            </div>
        </form>
    </div>
    <script src="js/bootstrap.js" type="text/javascript"></script>
</body>
</html>
