<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="RankingPasajeros.aspx.cs" Inherits="PresentacionWeb.RankingPasajeros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblPasajeros" runat="server" Text="Top 10 Pasajeros"></asp:Label>
    <br />
    <asp:ListBox ID="lbxRanking" runat="server"></asp:ListBox>
    <br />
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
</asp:Content>
