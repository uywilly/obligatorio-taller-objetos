<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="AltaContrato.aspx.cs" Inherits="PresentacionWeb.AltaContrato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbClientes" runat="server" Text="Clientes"></asp:Label>




    <asp:GridView ID="grClientes" runat="server">
    </asp:GridView>
    <asp:Button ID="btnAgregarCliente" runat="server" Text="Agregar Cliente" />
    <br />
    <br />
    <asp:Label ID="lblExcurciones" runat="server" Text="Excursiones"></asp:Label>
    <asp:GridView ID="grExcurciones" runat="server">
    </asp:GridView>
    <br />
    <asp:Label ID="lblPasajeros" runat="server" Text="Pasajeros"></asp:Label>
    <asp:GridView ID="grPasajeros" runat="server">
    </asp:GridView>
    <asp:Button ID="btnPasajeros" runat="server" Text="Agregar Pasajero" />
    <br />
    <br />
    <br />
    <asp:Button ID="btnAgregar" runat="server" Text="Alta Excursion" />
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
