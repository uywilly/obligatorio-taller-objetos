<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ExcurcionDestino.aspx.cs" Inherits="PresentacionWeb.ExcurcionDestino" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label ID="lblDestinos" runat="server" Text="Destinos"></asp:Label>
     <br />
     <asp:ListBox ID="lbxDestinos" runat="server" Height="200px"></asp:ListBox>
        <br />
        <asp:Label ID="LblExcurciones" runat="server" Text="Excursiones"></asp:Label>
        <br />
        <asp:ListBox ID="lbxExcurciones" runat="server" Height="200px"></asp:ListBox>
     <br />
     <asp:Button ID="btnListar" runat="server" OnClick="btnListar_Click" Text="Listar" />
     <br />
     <br />
     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    
</asp:Content>
