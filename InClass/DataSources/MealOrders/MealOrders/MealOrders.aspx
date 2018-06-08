<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MealOrders.aspx.cs" Inherits="MealOrders.MealOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 460px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <label>Order Number</label>
                </td>
                <td>
                    <asp:Label ID="lblOrderNo" runat="server" Text=""></asp:Label>
                </td>
            </tr>

            <tr>
                <td class="auto-style2"><label>City</label></td>
                <td><asp:DropDownList ID="ddlCity" runat="server"></asp:DropDownList></td>
            </tr>
            <tr>
                <td class="auto-style2"><label>Gender</label></td>
                <td><asp:DropDownList ID="ddlGender" runat="server"></asp:DropDownList></td>
            </tr>
            <tr>
                <td class="auto-style2"><label>Meal Options</label></td>
                <td><asp:CheckBoxList ID="cblMeals" runat="server" DataTextField="Name" DataValueField="ID"></asp:CheckBoxList></td>
            </tr>
            <tr>
                <td class="auto-style2"><label>Payment Method</label></td>
                <td><asp:RadioButtonList ID="rblPayment" runat="server" DataTextField="Name" DataValueField="ID"></asp:RadioButtonList></td>
                
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
           
        </table>
        <asp:ListBox ID="lstbOrders" runat="server" Height="104px" Width="748px"></asp:ListBox>
    </form>
</body>
</html>
