<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" Title="User Info" ErrorPage="error.html" %>

<%@ Register src="UserControls/Footer.ascx" tagname="Footer" tagprefix="uc1" %>
<%@ Register src="UserControls/Header.ascx" tagname="Header" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .formTable {
            width: 100%;
            text-align: left;
        }

        .tableCells {
            text-align: left;
            width: 40%;
            margin: -20%;
        }
        .textBoxes {
            margin-left: 5%;
            width: 20%;
        }
        .dropLists {
            width: 20%;
        }
        .validateMessages {
            color: red;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btSubmit" defaultfocus="tbName">
        <div>

            
            <uc2:Header ID="Header1" runat="server" />

            
            <table class="formTable">
                <tr>
                    <td class="tableCells">Name: <asp:TextBox ID="tbName" runat="server" CssClass="auto-style1" Width="170px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="validateMessages" Display="Dynamic" ErrorMessage="Required Field" ControlToValidate="tbName">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="tableCells">Dob: <asp:TextBox ID="tbDob" runat="server" CssClass="auto-style3" Width="174px" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="validateMessages" Display="Dynamic" ErrorMessage="Required Field" ControlToValidate="tbDob">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">Email: <asp:TextBox ID="tbEmail" runat="server" CssClass="auto-style2" Width="174px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" CssClass="validateMessages" Display="Dynamic" ErrorMessage="Required Field" ControlToValidate="tbEmail">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Valid Email Required" ControlToValidate="tbEmail" CssClass="validateMessages" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="tableCells">Province: <asp:DropDownList ID="dlstProv" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dlstProv_SelectedIndexChanged" CssClass="auto-style4" Width="127px" >
                        <asp:ListItem>Select Province</asp:ListItem>
                        <asp:ListItem>QC</asp:ListItem>
                        <asp:ListItem>ON</asp:ListItem>
                        <asp:ListItem>AB</asp:ListItem>
                        <asp:ListItem>BC</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" CssClass="validateMessages" Display="Dynamic" ErrorMessage="Required Field" ControlToValidate="dlstProv" InitialValue="Select Province">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="tableCells">City: <asp:DropDownList ID="dlstCity" runat="server" CssClass="auto-style5">
                        <asp:ListItem>Select a city</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" CssClass="validateMessages" Display="Dynamic" ErrorMessage="Required Field" ControlToValidate="dlstCity" InitialValue="Select a city">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td> 
                </tr>
                <tr>
                    <td class="tableCells"><asp:button runat="server" text="Submit" ID="btSubmit" OnClick="btSubmit_Click"/>
                        <asp:button runat="server" text="Clear" ID="btClear" OnClick="btClear_Click"/>
                    </td>
                    <td>&nbsp;</td>
                </tr>
  
            </table>           

            <asp:ListBox ID="lstbUsers" runat="server" Height="130px" Width="774px"></asp:ListBox>

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="validateMessages"/>

        </div>
        <uc1:Footer ID="Footer1" runat="server" />
    </form>
</body>

</html>
