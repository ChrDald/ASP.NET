<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckoutForm.aspx.cs" Inherits="CD_Assigment1.CheckoutForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Check Out Form</title>

    <link rel="stylesheet" href="css/css.css" />
</head>
<body>
    <form id="frmCheckout" runat="server" class="checkoutForm">
        <div>
            <h1>Check Out Page</h1>
            <asp:ValidationSummary ID="vlsumCheckout" runat="server" CssClass="errorMessage" />

            <!-- contact info section -->
            <h2>Contact Information</h2>

            <!-- first container div -->
            <div class="sectionDiv">
                <!-- label div -->
                <div class="labelDiv">
                    <label for="txbEmail">Email Address:</label>
                    <label for="txbEmailReEntry">Email Re-entry:</label>
                    <label for="txbFirstName">First Name:</label>
                    <label for="txbLastName">Last Name:</label>
                    <label for="txbPhone">Phone Number:</label>
                </div>
            

                <!-- text box div -->
                <div class="inputDiv">
                    <asp:TextBox ID="txbEmail" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txbEmailReEntry" runat="server"></asp:TextBox>          
                    <asp:TextBox ID="txbFirstName" runat="server"></asp:TextBox>           
                    <asp:TextBox ID="txbLastName" runat="server"></asp:TextBox>            
                    <asp:TextBox ID="txbPhone" runat="server"></asp:TextBox>
                </div>
            </div>
            
            

            <!-- billing address section -->
            <h2>Billing Address</h2>
            <label for="txbAddress">Address:</label>
            <asp:TextBox ID="txbAddress" runat="server"></asp:TextBox>
            <br />
            <label for="txbCity">Last Name:</label>
            <asp:TextBox ID="txbCity" runat="server"></asp:TextBox>
            <br />
            <label for="ddlState">State:</label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <label for="txbZip">Zip Code:</label>
            <asp:TextBox ID="txbZip" runat="server"></asp:TextBox>
            <br />
            <!-- shipping address section -->
            <h2>Shipping Address</h2>
            <asp:CheckBox ID="chbSameAddress" runat="server" Text="Same as billing address"/>
            <br />
            <label for="txbAddress">Address:</label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <label for="txbCity">Last Name:</label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <label for="ddlState">State:</label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <label for="txbZip">Zip Code:</label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnCheckOut" runat="server" Text="Check Out" />
        </div>
    </form>
</body>
</html>
