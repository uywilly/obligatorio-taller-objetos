<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="PresentacionWeb.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Serializar" />
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Deserializar" />
    <br />
</asp:Content>
