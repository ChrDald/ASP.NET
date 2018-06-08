<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="First.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        .Menu {
            list-style-type: none;
        }
        .Menu li {
            display: inline-block;
            border: 1px solid black;
            color: white;
            background-color: black;
            padding: 10px;
            margin: 10px;
            width: 15%;
            text-align: center;
        }
        .Menu li a {
            text-decoration: none;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="blSearchEngines" runat="server" CssClass="Menu" DataTextField="Name" DataValueField="URL" DisplayMode="HyperLink" EnableTheming="True">
            </asp:BulletedList>
        </div>
        <asp:DropDownList ID="ddlAnswers" runat="server" OnSelectedIndexChanged="ddlAnswers_SelectedIndexChanged" AutoPostBack="true" OnDataBinding="ddlAnswers_DataBind">
        </asp:DropDownList>
        <p>
            <asp:Label ID="lblSelection" runat="server"></asp:Label>
        </p>
        <asp:Label ID="lblBindingEvent" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <h3>Part 2 - Listbox Binding</h3>
        <asp:ListBox ID="lstbTowns" runat="server" Height="154px" Width="301px" AutoPostBack="True" DataTextField="Name" DataValueField="ID" OnSelectedIndexChanged="lstbTowns_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Label ID="lblTownSelection" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
       
    </form>
</body>
</html>
