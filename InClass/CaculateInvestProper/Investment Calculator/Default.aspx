<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Investment_Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 250px;
        }
        .auto-style3 {
            font-size: xx-large;
        }
        .validateMessages {
            color: red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3" colspan="2">
                        <h1><strong>Investment Calculator</strong></h1>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><strong>Name</strong></td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Name Required" Text="*" CssClass="validateMessages"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><strong>Investment</strong></td>
                    <td>
                        <asp:DropDownList ID="ddlInvest" runat="server" Height="20px" Width="209px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlInvest" ErrorMessage="Select an investment" Text="*" CssClass="validateMessages"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><strong>Annual interest rate</strong></td>
                    <td>
                        <asp:TextBox ID="txtRate" runat="server" Width="200px"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Between 1 and 20" Text="*" ControlToValidate="txtRate" CssClass="validateMessages" MaximumValue="20" MinimumValue="1" Type="Double" Display="Dynamic"></asp:RangeValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRate" ErrorMessage="Required Field" Text="*" CssClass="validateMessages"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><strong>Number of years</strong></td>
                    <td>
                        <asp:TextBox ID="txtYears" runat="server" Width="200px"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Enter a valid number of years" Text="*" CssClass="validateMessages" ControlToValidate="txtYears" Type="Integer" Display="Dynamic" Operator="DataTypeCheck"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtYears" ErrorMessage="Required Field" Text="*" CssClass="validateMessages"></asp:RequiredFieldValidator>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate" Width="100px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnClear" runat="server" Text="Clear" Width="100px" />
                    </td>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="79px" CssClass="validateMessages"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblResult" runat="server" Font-Bold="True" Font-Names="Centaur" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
