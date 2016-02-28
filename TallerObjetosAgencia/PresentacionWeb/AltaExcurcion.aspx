<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="AltaExcurcion.aspx.cs" Inherits="PresentacionWeb.AltaExcurcion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbl1" runat="server" Text="Codigo"></asp:Label>
&nbsp;<asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCodigo" ErrorMessage="Error al ingresar el codigo">*</asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblDesc" runat="server" Text="Descripcion"></asp:Label>
    <br />
    <asp:TextBox ID="txtDesc" runat="server" Height="120px" TextMode="MultiLine" Width="250px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblFecha" runat="server" Text="Fecha Inicio"></asp:Label>
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
        <NextPrevStyle VerticalAlign="Bottom" />
        <OtherMonthDayStyle ForeColor="#808080" />
        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
        <SelectorStyle BackColor="#CCCCCC" />
        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
        <WeekendDayStyle BackColor="#FFFFCC" />
    </asp:Calendar>
    <br />
    <asp:Label ID="lblHRuta" runat="server" Text="Destinos"></asp:Label>
    <asp:GridView ID="grdDestinos" runat="server">
    </asp:GridView>
    <br />
    <asp:Label ID="lblTraslado" runat="server" Text="Dias Traslado"></asp:Label>
&nbsp;<asp:TextBox ID="txtTraslado" runat="server"></asp:TextBox>
    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtTraslado" ErrorMessage="Error al ingresar los dias de traslado" ValidateEmptyText="True">*</asp:CustomValidator>
    <br />
    <asp:Label ID="lblStock" runat="server" Text="Stock"></asp:Label>
&nbsp;<asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
    <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="txtStock" ErrorMessage="Error al ingresar el stock" ValidateEmptyText="True">*</asp:CustomValidator>
    <br />
    <asp:Label ID="lblPuntos" runat="server" Text="Puntos"></asp:Label>
&nbsp;<asp:TextBox ID="txtPuntos" runat="server"></asp:TextBox>
&nbsp;<asp:CustomValidator ID="CustomValidator3" runat="server" ControlToValidate="txtPuntos" ErrorMessage="Error al ingresar los puntos" ValidateEmptyText="True">*</asp:CustomValidator>
    <br />
    <br />
    <asp:Button ID="btnAlta" runat="server" Text="Crear Excursion" />
    <br />
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <br />
    <br />
    <br />
    <br />
    <br />
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
