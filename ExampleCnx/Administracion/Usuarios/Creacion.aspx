<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="Creacion.aspx.cs" Inherits="ExampleCnx.Administracion.Usuarios.Creacion" %>

<asp:Content ContentPlaceHolderID="ContentBody" runat="server">
    <form id="form1" runat="server">
        <div class="content-wrapper" style="min-height: 946px;">
            <section class="content-header">
                <div class="box-header with-border">
                    <h2>Creacion de Usuarios</h2>
                </div>
            </section>
            <section class="content">
                <div class="row">
                    <div class="col-md-4">
                        <div class="box-warning">
                            <div class="box-header with-border">
                                <h3>Datos del Empleado</h3>
                            </div>
                            <div class="box-body">
                                <div class="input-group">
                                    <span class="input-group-addon">Nombre</span>
                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Apellido</span>
                                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Identificación</span>
                                    <asp:TextBox ID="txtIdentifiacion" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Telefono</span>
                                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Celular</span>
                                    <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Direccion</span>
                                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="box-warning">
                            <div class="box-header with-border">
                                <h3>Datos del Usuario</h3>
                            </div>
                            <div class="box-body">
                                <div class="input-group">
                                    <span class="input-group-addon">Login</span>
                                    <asp:TextBox ID="txtLogin" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Contraseña</span>
                                    <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="form-group">
                                    <asp:Label runat="server"><h3>Cargo</h3></asp:Label>
                                    <asp:DropDownList ID="ddlCargos" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-5">
                        <div class="box-warning">
                            <asp:Button ID="btnAgregarUsuario" runat="server" OnClick="btnAgregarUsuario_Click" Text="Agregar" CssClass="btn btn-primary" />
                            &nbsp;
                            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </form>
</asp:Content>
