<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="EdicionEliminacion.aspx.cs" Inherits="ExampleCnx.Administracion.Peliculas.EdicionEliminacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="content-wrapper" style="min-height: 946px;">
        <div class="container">
            <section class="content-header" runat="server">
                <asp:Label ID="Label1" runat="server"><h1>Actualizacion de Peliculas</h1></asp:Label>
            </section>
            <section class="content" runat="server">
                <div class="row">
                    <div class="col-md-10">
                        <form id="form1" runat="server">
                            <div class="fc-grid">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EmptyDataText="No se encontraron registros" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" CssClass="table table-bordered" OnRowUpdating="GridView1_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="Id" OnRowDataBound="GridView1_RowDataBound">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                                        <asp:TemplateField HeaderText="Nombre">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtNombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Descripcion">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtDescripcion" runat="server" Text='<%# Bind("Descripcion") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Descripcion") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Año">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtAnio" runat="server" Text='<%# Bind("Anio") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Anio") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Idioma">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtIdioma" runat="server" Text='<%# Bind("Idioma") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Idioma") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="IdCategoria" Visible="False">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="lblCategoria" runat="server" Text='<%# Bind("IdCategoria") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label7" runat="server" Text='<%# Bind("IdCategoria") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Categoria">
                                            <EditItemTemplate>
                                                <asp:DropDownList ID="ddlCategoria" runat="server">
                                                </asp:DropDownList>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label6" runat="server" Text='<%# Bind("Categoria") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Director">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtDirector" runat="server" Text='<%# Bind("Director") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("Director") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                                    </Columns>
                                    <EditRowStyle BackColor="#2461BF" />
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                </asp:GridView>
                            </div>
                        </form>
                    </div>
                </div>
            </section>
        </div>
    </div>
</asp:Content>
