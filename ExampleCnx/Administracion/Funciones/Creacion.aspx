<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="Creacion.aspx.cs" Inherits="ExampleCnx.Administracion.Funciones.Creacion" %>


<asp:Content ContentPlaceHolderID="ContentBody" runat="server">
    <form id="form1" runat="server">
        <div class="content-wrapper" style="min-height: 946px;">
            <section class="content-header">
                <div class="box-header with-border">
                        <h2>Creación de Funciones</h2>
                </div>
            </section>
            <section class="content">
                <div class="row">
                    <div class="col-md-4">
                        <div class="box-warning">
                            <div class="box-header with-border">
                                <h3>Función</h3>
                            </div>
                            <div class="box-body">
                                <div class="input-group date">
                                    <span class="input-group-addon">Fecha</span>
                                    <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Precio</span>
                                    <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Descuento</span>
                                    <asp:TextBox ID="txtDescuento" runat="server" CssClass="form-control" />
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Pelicula</span>
                                    <asp:DropDownList ID="ddlPelicula" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <br />
                                <div class="input-group">
                                    <span class="input-group-addon">Sala</span>
                                    <asp:DropDownList ID="ddlSala" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-5">
                                <div class="box-warning">
                                    <asp:Button ID="Button1" runat="server" OnClick="btnAgregarPelicula" Text="Agregar Pelicula" CssClass="btn btn-primary" />
                                    &nbsp;
                                    <br />
                                    <asp:Label ID="lblMensajeFuncion" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </form>
</asp:Content>


