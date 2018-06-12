<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem>Student List</asp:ListItem>
                <asp:ListItem>Teacher List</asp:ListItem>
                <asp:ListItem>Course List</asp:ListItem>
            </asp:DropDownList>

            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Students who are under 18 years of age (in order of age)</asp:ListItem>
            <asp:ListItem>Students who are teenagers (in alphabetical order)</asp:ListItem>
            <asp:ListItem>Students who scored more than 80 in their last test</asp:ListItem>
            <asp:ListItem>Students with more than 320 marks</asp:ListItem>
            <asp:ListItem>Students with at least 60 in all tests</asp:ListItem>
            <asp:ListItem>Students grouped by first letter of their last name</asp:ListItem>
            <asp:ListItem>Students who are also teachers</asp:ListItem>
        </asp:ListBox>
    </form>
</body>
</html>
