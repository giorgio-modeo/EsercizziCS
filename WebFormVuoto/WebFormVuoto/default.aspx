﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebFormVuoto._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblTesto" runat="server" Text="inserisci un testo"></asp:Label>
            <asp:TextBox ID="txtTesto" runat="server"></asp:TextBox>
            <asp:Button ID="btnInvia" runat="server" Text="Button" OnClick="btnInvia_Click" />
            <br />
            <asp:Label ID="LblRisultato" runat="server" Text=" "></asp:Label>
            <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
        </div>
    </form>
</body>
</html>
