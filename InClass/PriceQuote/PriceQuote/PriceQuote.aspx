<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PriceQuote.aspx.cs" Inherits="PriceQuote.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Price Quotation</h1>
        <div>
            <label id="lblSalesPrice" runat="server">Sales Price</label>
            <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>

            <label id="lblDiscountPerc" runat="server">Discount Percent</label>
            <asp:TextBox ID="tbDiscountPerc" runat="server"></asp:TextBox>
            
            <br /><br />

            <label>Discount Amount</label>
            <asp:Label ID="lblDiscountAmount" runat="server" Text="$0.00"></asp:Label>

            <br /><br />

            <label>Total Price</label>
            <asp:Label ID="lblTotalPrice" runat="server" Text="$0.00"></asp:Label>

            <br /><br />
            <asp:Button ID="btnCalc" runat="server" Text="Calculate" OnClick="btnCalc_Click" />
        </div>
        
    </form>
</body>
</html>
