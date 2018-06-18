<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CD_Assignment1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <!-- bootstrap cdns -->
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous" />
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js" integrity="sha384-smHYKdLADwkXOn1EmN1qk/HfnUcbVRZyYmZ4qpPea6sjB/pTJ0euyQp0Mk8ck+5T" crossorigin="anonymous"></script>


    <link rel="stylesheet" href="css/css.css" />
</head>

<body>
    <div class="container-fluid w-75 mt-4 mb-4 border mainContainer">
      
        <form id="frmCheckout" runat="server" class="checkoutForm">

            <h1 class="display-4 mb-4">Checkout Page</h1>
            <asp:ValidationSummary ID="vsumSummary" runat="server" CssClass="text-danger"/>

            <h2>Contact Information</h2>
            
            <div class="form-group row">
                
                <label for="txbEmail" class="col-sm-2 col-form-label">Email:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txbEmail" runat="server" CssClass="form-control" Text="placeholder@placeholder.com"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqfieldEmail" runat="server" ErrorMessage="Required Field <br />" ControlToValidate="txbEmail" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="regexpValEmail" runat="server" ErrorMessage="Enter a valid email <br/>" ControlToValidate="txbEmail" Display="Dynamic" CssClass="text-danger" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="form-group row">
                <label for="txbEmailRe" class="col-sm-2 col-form-label">Re-enter Email:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txbEmailRe" runat="server" CssClass="form-control" Text="Re-enter Email"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqfieldEmailRe" runat="server" ErrorMessage="Required Field" ControlToValidate="txbEmailRe" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="regexpValEmailRe" runat="server" ErrorMessage="Enter a valid email <br />" ControlToValidate="txbEmailRe" Display="Dynamic" CssClass="text-danger" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <asp:CompareValidator ID="compValEmail" runat="server" ErrorMessage="Emails must match <br />" ControlToCompare="txbEmail" ControlToValidate="txbEmailRe" Display="Dynamic" Operator="Equal" CssClass="text-danger"></asp:CompareValidator>
                </div>
            </div>

            <div class="form-group row">
                <label for="txbFirstName" class="col-sm-2 col-form-label">First Name:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txbFirstName" runat="server" CssClass="form-control" Text=""></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqfieldFirstName" runat="server" ErrorMessage="Required Field" ControlToValidate="txbFirstName" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="form-group row">
                <label for="txbLastName" class="col-sm-2 col-form-label">Last Name:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txbLastName" runat="server" CssClass="form-control" Text=""></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqfieldLastName" runat="server" ErrorMessage="Required Field" ControlToValidate="txbLastName" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="form-group row">
                <label for="txbPhone" class="col-sm-2 col-form-label">Phone Number:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txbPhone" runat="server" CssClass="form-control" Text="555-555-5555"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqfieldPhone" runat="server" ErrorMessage="Required Field" ControlToValidate="txbPhone" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="regexpPhone" runat="server" ErrorMessage="format is 555-555-5555" ControlToValidate="txbPhone" Display="Dynamic" CssClass="text-danger" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>

                </div>
            </div>

            <!-- billing address section -->
            <h2>Billing Address</h2>

            <div class="form-group row">
                <label for="txbAddress" class="col-sm-2 col-form-label">Address:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txbAddress" runat="server" CssClass="form-control" Text="1234 Street"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqfieldAddress" runat="server" ErrorMessage="Required Field" ControlToValidate="txbAddress" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>

                </div>
            </div>

            <div class="form-group row">
                <label for="txbCity" class="col-sm-2 col-form-label">City:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txbCity" runat="server" CssClass="form-control" Text="City Name"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqfieldCity" runat="server" ErrorMessage="Required Field" ControlToValidate="txbCity" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>

                </div>
            </div>

            <div class="form-group row">
                <label for="ddlState" class="col-sm-2 col-form-label">State:</label>
                <div class="col-sm-10">
                    <asp:DropDownList ID="ddlState" runat="server" CssClass="form-control"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="reqfieldState" runat="server" ErrorMessage="Required Field" ControlToValidate="ddlState" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>

                </div>
            </div>

            <div class="form-group row">
                <label for="txbZip" class="col-sm-2 col-form-label">Zip code:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txbZip" runat="server" CssClass="form-control" Text="00000"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqfieldZip" runat="server" ErrorMessage="Required Field" ControlToValidate="txbZip" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="regexpZip" runat="server" ErrorMessage="enter a valid US Zip Code" ControlToValidate="txbZip" Display="Dynamic" CssClass="text-danger" ValidationExpression="\d{5}(-\d{4})?"></asp:RegularExpressionValidator>

                </div>
            </div>

            <!-- shipping address -->
            <h2>Shipping Address</h2>
            <div class="form-group row">
                <div class="col-sm-10">
                    <div class="form-check">                        
                        <asp:CheckBox ID="chkbSameAddress" runat="server" AutoPostBack="true" CssClass="form-check-input" OnCheckedChanged="chkbSameAddress_CheckedChanged"/>
                        <label class="form-check-label" for="chkbSameAddress">Same as billing address</label>
                    </div>                    
                </div>
            </div>
            
            <!-- form in case not same address -->
            <div class="form-group row">
                <label for="txbShipAddress" class="col-sm-2 col-form-label">Address:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txbShipAddress" runat="server" CssClass="form-control" Text=""></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqfieldShipAddress" runat="server" ErrorMessage="Required Field" ControlToValidate="txbShipAddress" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>

                </div>
            </div>

            <div class="form-group row">
                <label for="txbShipCity" class="col-sm-2 col-form-label">City:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txbShipCity" runat="server" CssClass="form-control" Text=""></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqfieldShipCity" runat="server" ErrorMessage="Required Field" ControlToValidate="txbShipCity" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>

                </div>
            </div>

            <div class="form-group row">
                <label for="ddlShipState" class="col-sm-2 col-form-label">State:</label>
                <div class="col-sm-10">                   
                    <asp:DropDownList ID="ddlShipState" runat="server" CssClass="form-control"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="reqfieldShipState" runat="server" ErrorMessage="Required Field" ControlToValidate="ddlShipState" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>

                </div>
            </div>

            <div class="form-group row">
                <label for="txbShipZip" class="col-sm-2 col-form-label">Zip code:</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txbShipZip" runat="server" CssClass="form-control" Text=""></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqfieldShipZip" runat="server" ErrorMessage="Required Field" ControlToValidate="txbShipZip" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="regexpShipZip" runat="server" ErrorMessage="enter a valid US Zip Code" ControlToValidate="txbShipZip" Display="Dynamic" CssClass="text-danger" ValidationExpression="\d{5}(-\d{4})?"></asp:RegularExpressionValidator>

                </div>
            </div>

            <div class="form-group row">
                <div class="col-sm-10">
                    <asp:Button ID="btnSubmit" runat="server" Text="Checkout" CssClass="btn btn-primary" OnClick="btnSubmit_Click"/>
                </div>
            </div>
            
        </form>
        
        <!-- label displayed when checkout is valid -->
        <div class="container-fluid checkoutDisplay" runat="server" id="checkoutDisplayDiv">

            <form>
                <h1 class="display-4 text-center mb-4">Checkout Summary</h1>
                <div class="form-group row">
                    <label for="lblEmail" class="col-sm-3 col-form-label lead">Email:</label>
                    <div class="col-sm-9">
                        <asp:Label runat="server" ID="lblEmail" CssClass="lead"></asp:Label>
                    </div>
                </div>

                <div class="form-group row">
                    <label for="lblFirstName" class="col-sm-3 col-form-label lead">First Name:</label>
                    <div class="col-sm-9">
                        <asp:Label runat="server" ID="lblFirstName" CssClass="lead"></asp:Label>
                    </div>
                </div>

                <div class="form-group row">
                    <label for="lblLastName" class="col-sm-3 col-form-label lead">Last Name:</label>
                    <div class="col-sm-9">
                        <asp:Label runat="server" ID="lblLastName" CssClass="lead"></asp:Label>
                    </div>
                </div>

                <div class="form-group row">
                    <label for="lblPhone" class="col-sm-3 col-form-label lead">Phone Number:</label>
                    <div class="col-sm-9">
                        <asp:Label runat="server" ID="lblPhone" CssClass="lead"></asp:Label>
                    </div>
                </div>

                <div class="form-group row">
                    <label for="lblShipAddress" class="col-sm-3 col-form-label lead">Shipping Address:</label>
                    <div class="col-sm-9">
                        <asp:Label runat="server" ID="lblShipAddress" CssClass="lead"></asp:Label>
                    </div>
                </div>

                <div class="form-group row">
                    <label for="lblShipCity" class="col-sm-3 col-form-label lead">Shipping City:</label>
                    <div class="col-sm-9">
                        <asp:Label runat="server" ID="lblShipCity" CssClass="lead"></asp:Label>
                    </div>
                </div>

                <div class="form-group row">
                    <label for="lblShipState" class="col-sm-3 col-form-label lead">Shipping State:</label>
                    <div class="col-sm-9">
                        <asp:Label runat="server" ID="lblShipState" CssClass="lead"></asp:Label>
                    </div>
                </div>

                <div class="form-group row">
                    <label for="lblShipZip" class="col-sm-3 col-form-label lead">Shipping Zip Code:</label>
                    <div class="col-sm-9">
                        <asp:Label runat="server" ID="lblShipZip" CssClass="lead"></asp:Label>
                    </div>
                </div>
            </form>

 
        </div>
        
    </div>
    






    
    
    






    
</body>
</html>
