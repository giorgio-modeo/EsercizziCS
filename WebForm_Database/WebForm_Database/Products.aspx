<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="WebForm_Database.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Elenco prodotti</h1>

    <asp:SqlDataSource ID="sdsProducts" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>"
        SelectCommand="SELECT c.CategoryName, p.[ProductName], p.[UnitPrice], p.[UnitsInStock], p.[ProductID] FROM [Products] p INNER JOIN Categories c ON c.CategoryID=p.CategoryID ORDER BY [ProductName]" OnSelecting="sdsProducts_Selecting"></asp:SqlDataSource>

    <asp:GridView ID="gvProducts" runat="server" Width="90%" DataSourceID="sdsProducts" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ProductID" HorizontalAlign="Center" PagerStyle-HorizontalAlign="Center" PageSize="50" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="CategoryName" HeaderText="Category Name" SortExpression="CategoryName"></asp:BoundField>
            <asp:BoundField DataField="ProductName" HeaderText="Product Name" SortExpression="ProductName"></asp:BoundField>
            <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" SortExpression="UnitPrice"></asp:BoundField>
            <asp:BoundField DataField="UnitsInStock" HeaderText="Units In Stock" SortExpression="UnitsInStock"></asp:BoundField>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" InsertVisible="False" SortExpression="ProductID" Visible="False"></asp:BoundField>
            
            <asp:TemplateField HeaderText="Azioni" ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="lbtDettaglio" runat="server" CausesValidation="false" PostBackUrl='<%# Bind("ProductID","~/DetailsProduct.aspx?id={0}") %>' CommandName="" Text="Dettaglio"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>

        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />

<PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>

</asp:Content>
