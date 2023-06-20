<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebForm_Database.CMS.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h1>Dashboard</h1>

    <asp:HyperLink ID="lnkClienti" NavigateUrl="~/CMS/ElencoClienti.aspx" runat="server">Gestione Clienti</asp:HyperLink>
    <br />
    <asp:HyperLink ID="lnkOrdini" runat="server">Gestione Ordini</asp:HyperLink>



</asp:Content>
