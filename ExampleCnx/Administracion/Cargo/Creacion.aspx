<%@ Page Title="" Language="C#"
    MasterPageFile="~/MasterAdministrador.Master"
    AutoEventWireup="true"
    CodeBehind="Creacion.aspx.cs"
    Inherits="ExampleCnx.Administracion.Cargo.Creacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="content-wrapper">
        <div class="container">
            <form id="form2" runat="server">
                <section class="content-header" runat="server">
                    <asp:Label ID="Label2" runat="server"><h1>Creación de Cargos</h1></asp:Label>
                    <div class="input-group col-lg-4">
                        <span class="input-group-addon">Nombre del Cargo</span>
                        <asp:TextBox ID="txtCargo" runat="server" CssClass="form-control" />
                    </div>
                    <br />
                    <div>
                        <asp:Button ID="btnAgregar" class="btn btn-primary" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                        <asp:Label ID="lblEstado" runat="server" Text="Label"></asp:Label>
                    </div>
                    <br />
                </section>
                <section class="content" runat="server">
                    <div class="row">
                        <div class="col-md-10">

                            <div class="fc-grid">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" DataKeyNames="Id" EmptyDataText="No se encontraron registros" CssClass="table col-lg-8">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="Id" Visible="False">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtId" runat="server" Text='<%# Bind("ID") %>' Enabled="False"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblId" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Nombre">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtNombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="lblNombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Width="95%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField ShowHeader="False">
                                            <EditItemTemplate>
                                                <asp:LinkButton ID="lnkUpdateRow" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar"></asp:LinkButton>
                                                &nbsp;<asp:LinkButton ID="lnkCancel" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar"></asp:LinkButton>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkEditRow" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar"></asp:LinkButton>
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

                        </div>
                    </div>
                </section>
            </form>
        </div>
    </div>
</asp:Content>
