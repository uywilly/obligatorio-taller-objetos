<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ListadosGenerales.aspx.cs" Inherits="PresentacionWeb.ListadosGenerales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    <br />
    <br />
    <asp:ListBox ID="ListBox2" runat="server" Height="120px"></asp:ListBox>
    <br />
    <br />
    <asp:ListBox ID="ListBox3" runat="server" Height="120px"></asp:ListBox>
    <br />
    <br />
    <asp:ListBox ID="ListBox4" runat="server" Height="120px"></asp:ListBox>
    <br />
    <br />
    <asp:ListBox ID="ListBox5" runat="server" Height="120px"></asp:ListBox>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Alta pasajero" />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cargar Datos" />
    <br />
</asp:Content>
