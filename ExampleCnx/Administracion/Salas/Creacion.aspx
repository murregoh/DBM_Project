<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="Creacion.aspx.cs" Inherits="ExampleCnx.Administracion.Salas.Creacion" %>

<asp:Content ContentPlaceHolderID="ContentBody" runat="server">
    <div class="content-wrapper">
        <div class="container">
            <form id="form2" runat="server">
                <section class="content-header" runat="server">
                    <asp:Label ID="Label2" runat="server"><h1>Creación de Salas</h1></asp:Label>
                    <div class="input-group col-lg-4">
                        <span class="input-group-addon">Ubicación</span>
                        <asp:TextBox ID="txtUbicacion" runat="server" CssClass="form-control" />
                    </div>
                    <br />
                    <div class="input-group col-lg-4">
                        <span class="input-group-addon">Capacidad</span>
                        <asp:TextBox ID="txtCapacidad" runat="server" CssClass="form-control" />
                    </div>
                    <br />
                    <div>
                        <asp:Button ID="btnAgregar" class="btn btn-primary" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                        <asp:Label ID="lblEstado" runat="server"></asp:Label>
                    </div>
                    <br />
                </section>
                <section class="content" runat="server">
                    <div class="row">
                        <div class="col-md-10">
                            <div class="fc-grid">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" Width="100%" EmptyDataText="No se encontraron registros" CssClass="table col-lg-8">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                                        <asp:TemplateField HeaderText="Ubicacion">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtUbicacion" runat="server" Text='<%# Bind("Ubicacion") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Ubicacion") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Capacidad">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtCapacidad" runat="server" Text='<%# Bind("Capacidad") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Capacidad") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:CommandField ShowEditButton="True" CancelText="Cancelar" DeleteText="Eliminar" EditText="Editar" UpdateText="Actualizar" />
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
                        </div>
                    </div>
                </section>
            </form>
        </div>
    </div>
</asp:Content>
