<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="Creacion.aspx.cs" Inherits="ExampleCnx.Administracion.Peliculas.Creacion" %>

<asp:Content ContentPlaceHolderID="ContentBody" runat="server">
    <form id="form1" runat="server">
        <div class="content-wrapper" style="min-height: 946px;">
            <section class="content-header">
                <div class="box-header with-border">
                        <h2>Creacion de Peliculas y Categorias</h2>
                </div>
            </section>
            <section class="content">
                <div class="row">
                    <div class="col-md-4">
                        <div class="box-warning">
                            <div class="box-header with-border">
                                <h3>Agregar Categoria</h3>
                            </div>
                            <div class="box-body">
                                <div class="input-group">
                                    <span class="input-group-addon">Categoria</span>
                                    <asp:TextBox ID="txtCategoria" runat="server" CssClass="form-control" />
                                </div>
                                <br />

                            </div>
                            <div class="col-md-5">
                                <div class="box-warning">
                                    <asp:Button ID="btnAgregarUsuario" runat="server" OnClick="btnAgregarCategoria" Text="Agregar Categoria" CssClass="btn btn-primary" />
                                    &nbsp;
                                    <br />
                                    <br />
                                    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="box-warning">
                            <div class="box-header with-border">
                                <h3>Pelicula</h3>
                            </div>
                            <div class="box-body">
                                <div class="input-group">
                                    <span class="input-group-addon">Nombre</span>
                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Descripcion</span>
                                    <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Año</span>
                                    <asp:TextBox ID="txtAnio" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Idioma</span>
                                    <asp:TextBox ID="txtIdioma" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Director</span>
                                    <asp:TextBox ID="txtDirector" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Categoria</span>
                                    <asp:DropDownList ID="ddlCategorias" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-5">
                                <div class="box-warning">
                                    <asp:Button ID="Button1" runat="server" OnClick="btnAgregarPelicula" Text="Agregar Pelicula" CssClass="btn btn-primary" />
                                    &nbsp;
                                    <br />
                                    <br />
                                    <asp:Label ID="lblMensajePelicula" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </form>
</asp:Content>
