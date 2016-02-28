<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ExcurcionDestino.aspx.cs" Inherits="PresentacionWeb.ExcurcionDestino" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:GridView ID="grdDestinos" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="LblExcurciones" runat="server" Text="Excursiones"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
     <br />
    <br />
    
</asp:Content>
