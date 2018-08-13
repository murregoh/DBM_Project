<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="EdicionEliminacion.aspx.cs" Inherits="ExampleCnx.Administracion.Usuarios.EdicionEliminacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="content-wrapper" style="min-height: 946px;">
        <div class="container">
            <section class="content-header" runat="server">
                <asp:Label ID="Label1" runat="server"><h1>Actualizacion de Empleados</h1></asp:Label>
            </section>
            <section class="content" runat="server">
                <div class="row">
                    <div class="col-md-10">
                        <form id="form1" runat="server">
                            <div class="fc-grid">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" DataKeyNames="Id,IdCargo" OnRowDataBound="GridView1_RowDataBound" CssClass="table table-bordered" OnRowDeleting="GridView1_RowDeleting">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="Identificacion">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtIdentificacion" runat="server" Text='<%# Bind("Identificacion") %>' Width="80px"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Identificacion") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                                        <asp:TemplateField HeaderText="Nombre">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtNombre" runat="server" Text='<%# Bind("Nombre") %>' Width="80px"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Apellido">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtApellido" runat="server" Text='<%# Bind("Apellido") %>' Width="80px"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Apellido") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Telefono">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtTelefono" runat="server" Text='<%# Bind("Telefono") %>' Width="80px"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Telefono") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Movil">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtMovil" runat="server" Text='<%# Bind("Movil") %>' Width="80px"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("Movil") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="IdCargo" Visible="False">
                                            <EditItemTemplate>
                                                <asp:Label ID="lblIdCargo" runat="server" Text='<%# Bind("IdCargo") %>'></asp:Label>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label8" runat="server" Text='<%# Bind("IdCargo") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Cargo">
                                            <EditItemTemplate>
                                                <asp:DropDownList ID="ddlCargo" runat="server">
                                                </asp:DropDownList>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label7" runat="server" Text='<%# Bind("Cargo") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Direccion">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtDireccion" runat="server" Text='<%# Bind("Direccion") %>' Width="80px"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label6" runat="server" Text='<%# Bind("Direccion") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField ShowHeader="False">
                                            <EditItemTemplate>
                                                <asp:LinkButton ID="lnkUpdateRow" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar"></asp:LinkButton>
                                                &nbsp;<asp:LinkButton ID="lnkCancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar"></asp:LinkButton>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkEditRow" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar"></asp:LinkButton>
                                                <asp:LinkButton ID="lnkDeleteRow" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar"></asp:LinkButton>
                                            </ItemTemplate>
                                            <ItemStyle Width="5%" />
                                        </asp:TemplateField>
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
