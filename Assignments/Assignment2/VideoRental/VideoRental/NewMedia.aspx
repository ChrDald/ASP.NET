<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewMedia.aspx.cs" Inherits="VideoRental.NewMedia" 
    MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add new media</h1>
    <label for="txbTitle">Title:</label>
    <asp:TextBox ID="txbTitle" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required Field" Display="Dynamic" ControlToValidate="txbTitle"></asp:RequiredFieldValidator><br /><br />
            
    <label for="ddlType">Type:</label>
    <asp:DropDownList ID="ddlType" runat="server"></asp:DropDownList><br /><br />

    <label for="calProdYear">Production Year:</label>
    <asp:Calendar ID="calProdYear" runat="server" SelectedDate="2000-01-01 12:00:00 AM"></asp:Calendar>

    <asp:Button ID="btnAddMedia" runat="server" Text="Add Media" OnClick="btnAddMedia_Click"/>
</asp:Content>
