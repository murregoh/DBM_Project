<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="EdicionEliminacion.aspx.cs" Inherits="ExampleCnx.Administracion.Funciones.EdicionEliminacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="content-wrapper" style="min-height: 946px;">
        <div class="container">
            <section class="content-header" runat="server">
                <asp:Label ID="Label1" runat="server"><h1>Actualizacion de Funciones</h1></asp:Label>
            </section>
            <section class="content" runat="server">
                <div class="row">
                    <div class="col-md-10">
                        <form id="form1" runat="server">
                            <div class="fc-grid">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id,idPelicula,idSala" EmptyDataText="No hay registros disponibles" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" CssClass="table table-bordered">
                                    <Columns>
                                        <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                                        <asp:TemplateField HeaderText="IdPelicula" Visible="False">
                                            <EditItemTemplate>
                                                <asp:Label ID="lblIdPelicula" runat="server" Text='<%# Bind("IdPelicula") %>'></asp:Label>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("IdPelicula") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Pelicula">
                                            <EditItemTemplate>
                                                <asp:DropDownList ID="ddlPelicula" runat="server">
                                                </asp:DropDownList>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Pelicula") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Fecha">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtFecha" runat="server" Text='<%# Bind("Fecha") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("Fecha") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Precio">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtPrecio" runat="server" Text='<%# Bind("Precio") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label6" runat="server" Text='<%# Bind("Precio") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Descuento">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtDescuento" runat="server" Text='<%# Bind("Descuento") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label7" runat="server" Text='<%# Bind("Descuento") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="IdSala" Visible="False">
                                            <EditItemTemplate>
                                                <asp:Label ID="lblIdSala" runat="server" Text='<%# Bind("IdSala") %>'></asp:Label>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("IdSala") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Sala">
                                            <EditItemTemplate>
                                                <asp:DropDownList ID="ddlSala" runat="server">
                                                </asp:DropDownList>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Sala") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </form>
                    </div>
                </div>
            </section>
        </div>
    </div>
</asp:Content>
