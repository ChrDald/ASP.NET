<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalcInvest.aspx.cs" Inherits="CalculateInvest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 240px;
        }
        .auto-style4 {
            width: 240px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2">Investment Calculator</td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style3">Name</td>
                <td class="auto-style2">
                    <asp:TextBox ID="tbName" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Investment</td>
                <td>
                    <asp:TextBox ID="tbInvest" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Annual Interest Rate</td>
                <td>
                    <asp:DropDownList ID="dlstInterest" runat="server" Width="100px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Number of Years</td>
                <td class="auto-style2">
                    <asp:TextBox ID="tbYears" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <br />
                    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" />
&nbsp;<asp:Button ID="btnClear" runat="server" Text="Clear" />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style2"></td>
            </tr>
        </table>
    </form>
</body>
</html>
