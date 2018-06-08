<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DemoSQLDataSource.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Advanced Search</h1>

            <asp:DropDownList ID="ddlFieldSelect" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="SQLdsCustomerFields" DataTextField="COLUMN_NAME" DataValueField="COLUMN_NAME">
                <asp:ListItem>Please Select a field to search</asp:ListItem>
            </asp:DropDownList>


            <asp:SqlDataSource ID="SQLdsCustomerFields" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='Customers'"></asp:SqlDataSource>
            <asp:TextBox ID="txbSearch" runat="server"></asp:TextBox>


            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />


        </div>
        <asp:GridView ID="grdResults" runat="server" DataSourceID="SQLdsUserSearch" AutoGenerateColumns="False" DataKeyNames="CustomerID">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="ContactName" HeaderText="ContactName" SortExpression="ContactName" />
                <asp:BoundField DataField="ContactTitle" HeaderText="ContactTitle" SortExpression="ContactTitle" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Region" HeaderText="Region" SortExpression="Region" />
                <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax" />
            </Columns>
        </asp:GridView>
        
        <asp:SqlDataSource ID="SQLdsUserSearch" runat="server" SelectCommand="SELECT * FROM [Customers] WHERE ([CustomerID] = @CustomerID)" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>">
            <SelectParameters>
                <asp:ControlParameter ControlID="txbSearch" DefaultValue="null" Name="CustomerID" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="OrderID" DataSourceID="SQLdsCustomerOrders">
            <Columns>
                <asp:BoundField DataField="OrderID" HeaderText="OrderID" InsertVisible="False" ReadOnly="True" SortExpression="OrderID" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" SortExpression="EmployeeID" />
                <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" SortExpression="OrderDate" />
                <asp:BoundField DataField="RequiredDate" HeaderText="RequiredDate" SortExpression="RequiredDate" />
                <asp:BoundField DataField="ShippedDate" HeaderText="ShippedDate" SortExpression="ShippedDate" />
                <asp:BoundField DataField="ShipVia" HeaderText="ShipVia" SortExpression="ShipVia" />
                <asp:BoundField DataField="Freight" HeaderText="Freight" SortExpression="Freight" />
                <asp:BoundField DataField="ShipName" HeaderText="ShipName" SortExpression="ShipName" />
                <asp:BoundField DataField="ShipAddress" HeaderText="ShipAddress" SortExpression="ShipAddress" />
                <asp:BoundField DataField="ShipCity" HeaderText="ShipCity" SortExpression="ShipCity" />
                <asp:BoundField DataField="ShipRegion" HeaderText="ShipRegion" SortExpression="ShipRegion" />
                <asp:BoundField DataField="ShipPostalCode" HeaderText="ShipPostalCode" SortExpression="ShipPostalCode" />
                <asp:BoundField DataField="ShipCountry" HeaderText="ShipCountry" SortExpression="ShipCountry" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SQLdsCustomerOrders" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT * FROM [Orders] WHERE ([CustomerID] = @CustomerID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="grdResults" Name="CustomerID" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>

    </form>
</body>
</html>
