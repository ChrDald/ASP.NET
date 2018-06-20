<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierSearch.aspx.cs" Inherits="Exam1.SupplierSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier Search Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Supplier Search Form</h1>
            <asp:DropDownList ID="ddlSuppliers" runat="server" DataSourceID="ObjectDataSource1" AppendDataBoundItems="True" DataValueField="SupplierID" AutoPostBack="True" DataTextField="CompanyName" OnSelectedIndexChanged="ddlSuppliers_SelectedIndexChanged"></asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetSuppliers" TypeName="Exam1.BAL.SupplierBAL"></asp:ObjectDataSource>

            <h2>Search By City:</h2>
            <asp:TextBox ID="txbCitySearch" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearchCity" runat="server" Text="Search" OnClick="btnSearchCity_Click" />
        </div>
        <asp:GridView ID="grdvSupplierByCity" runat="server" OnSelectedIndexChanged="grdvSupplierByCity_SelectedIndexChanged" DataKeyNames="SupplierID">
        </asp:GridView>
    </form>
</body>
</html>
