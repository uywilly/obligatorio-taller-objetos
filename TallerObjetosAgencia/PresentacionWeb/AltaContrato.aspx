<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="AltaContrato.aspx.cs" Inherits="PresentacionWeb.AltaContrato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbClientes" runat="server" Text="Clientes"></asp:Label>




    <asp:GridView ID="grClientes" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
            <asp:BoundField DataField="Id" HeaderText="Ci" />
            <asp:TemplateField HeaderText="Seleccionar">
                <ItemTemplate>
                    <asp:CheckBox ID="chkCliente" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <asp:Label ID="lblExcurciones" runat="server" Text="Excursiones"></asp:Label>
    <asp:GridView ID="grExcurciones" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
            <asp:BoundField DataField="FechaComienzo" HeaderText="Fecha" />
            <asp:BoundField DataField="Stock" HeaderText="Stock" />
            <asp:TemplateField HeaderText="Seleccionar">
                <ItemTemplate>
                    <asp:CheckBox ID="chkExcurcion" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="lblPasajeros" runat="server" Text="Pasajeros"></asp:Label>
    <asp:GridView ID="grPasajeros" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
            <asp:BoundField DataField="Ci" HeaderText="Ci" />
            <asp:BoundField DataField="Puntos" HeaderText="Puntos" />
            <asp:TemplateField HeaderText="Seleccionar">
                <ItemTemplate>
                    <asp:CheckBox ID="chkPasajeros" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <br />
    <br />
    <asp:Button ID="btnAgregar" runat="server" Text="Alta Contrato" OnClick="btnAgregar_Click" />
    <br />
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />




</asp:Content>
