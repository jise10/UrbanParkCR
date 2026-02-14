<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.vb" Inherits="UrbanParkCR.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Login de Usuario
    <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>

    <asp:Panel ID="pnlLogin" runat="server">
        <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Contraseña:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" OnClick="btnLogin_Click" />

        </asp:Panel>
</asp:Content>
