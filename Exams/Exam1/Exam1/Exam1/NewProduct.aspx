<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewProduct.aspx.cs" Inherits="Exam1.NewProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>New Product Page
            </h1>
            <asp:Button ID="btnReturn" runat="server" Text="Return to previous page" Width="147px" OnClick="btnReturn_Click" /> <br />

            <label for="lblSupplierId">Supplier ID:</label>
            <asp:Label ID="lblSupplierId" runat="server" Text="Label"></asp:Label> <br /><br />

            <label for="ddlCategories">Category: </label>
            <asp:DropDownList ID="ddlCategory" runat="server" DataSourceID="SqlDataSource1" DataTextField="CategoryName" DataValueField="CategoryID" AppendDataBoundItems="True">
                <asp:ListItem>Select a Category</asp:ListItem>
            </asp:DropDownList> 
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT DISTINCT [CategoryID], [CategoryName] FROM [Categories]"></asp:SqlDataSource>
            <br /> <br />


            <label for="txbProdName">Product Name: </label>
            <asp:TextBox ID="txbProdName" runat="server"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required Field" ControlToValidate="txbProdName" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />

            <label for="txbQtyPerUnit">Quantity Per Unit: </label>
            <asp:TextBox ID="txbQtyPerUnit" runat="server"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required Field" ControlToValidate="txbQtyPerUnit" Display="Dynamic"></asp:RequiredFieldValidator>

            <br />

            <label for="txbUnitPrice">Unit Price: </label>
            <asp:TextBox ID="txbUnitPrice" runat="server"></asp:TextBox> 
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Must a valid price" Operator="DataTypeCheck" Type="Double" ControlToValidate="txbUnitPrice" Display="Dynamic"></asp:CompareValidator>
            <br />

            <label for="txbUnitsInStock">Units in Stock: </label>
            <asp:TextBox ID="txbUnitsInStock" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Must a valid number" Operator="DataTypeCheck" Type="Integer" ControlToValidate="txbUnitsInStock" Display="Dynamic"></asp:CompareValidator>
            <br />
            
            <label for="txbUnitsOnOrder">Units on Order: </label>
            <asp:TextBox ID="txbUnitsOnOrder" runat="server"></asp:TextBox> 
            <asp:CompareValidator ID="CompareValidator3" runat="server" ErrorMessage="Must a valid number" Operator="DataTypeCheck" Type="Integer" ControlToValidate="txbUnitsOnOrder" Display="Dynamic"></asp:CompareValidator>
            <br />
            
            <label for="txbOrderLevel">Order Level: </label>
            <asp:TextBox ID="txbOrderLevel" runat="server"></asp:TextBox> 
            <asp:CompareValidator ID="CompareValidator4" runat="server" ErrorMessage="Must a valid number" Operator="DataTypeCheck" Type="Integer" ControlToValidate="txbOrderLevel" Display="Dynamic"></asp:CompareValidator>
            <br />

            <label for="chkbDiscontinued">Discontinued: </label>
            <asp:CheckBox ID="chkbDiscontinued" runat="server" /> 
            <br /> <br />

            <asp:Button ID="btnAddProduct" runat="server" Text="Add New Product" OnClick="btnAddProduct_Click" />
        </div>
    </form>
</body>
</html>
