<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentMedia.aspx.cs" Inherits="VideoRental.RentMedia"
    MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Search Media by Title</h1>
    <asp:TextBox ID="txbSearch" runat="server"></asp:TextBox>
    <label for="txbSearch">(Ex. Monty)</label><br />
    <asp:Button ID="btnSearch" runat="server" Text="Search Titles" /><br /><br />

    <asp:CheckBoxList ID="cblResult" runat="server" DataSourceID="SqlDataSource1" DataTextField="Title" DataValueField="ID" OnSelectedIndexChanged="cblResult_SelectedIndexChanged" OnDataBound="cblResult_DataBound"></asp:CheckBoxList>
    
    <br /><br />
    <asp:Button ID="btnRent" runat="server" Text="Rent Now" OnClick="btnRent_Click" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ID], [Title], [ProductionYear], [RentalRecord_ID] FROM [Media] WHERE ([Title] LIKE '%' + @Title + '%')">
        <SelectParameters>
            <asp:ControlParameter ControlID="txbSearch" DefaultValue="null" Name="Title" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

