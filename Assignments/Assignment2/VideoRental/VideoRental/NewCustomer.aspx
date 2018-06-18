<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewCustomer.aspx.cs" Inherits="VideoRental.NewCustomer"
     MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add a new customer</h1>
            <label for="txbFirstName">First Name:</label>
            <asp:TextBox ID="txbFirstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required Field" Display="Dynamic" ControlToValidate="txbFirstName"></asp:RequiredFieldValidator><br /><br />
            
            <label for="txbLastName">Last Name:</label>
            <asp:TextBox ID="txbLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required Field" Display="Dynamic" ControlToValidate="txbLastName"></asp:RequiredFieldValidator><br /><br />
            
            <label for="txbPhone">Phone Number:</label>
            <asp:TextBox ID="txbPhone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required Field" Display="Dynamic" ControlToValidate="txbPhone"></asp:RequiredFieldValidator><br /><br />
            
            <label for="txbAddress">Address:</label>
            <asp:TextBox ID="txbAddress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Required Field" Display="Dynamic" ControlToValidate="txbAddress"></asp:RequiredFieldValidator><br /><br />

            <asp:Button ID="btnAddCustomer" runat="server" Text="Add Customer" OnClick="btnAddCustomer_Click" />
</asp:Content>

