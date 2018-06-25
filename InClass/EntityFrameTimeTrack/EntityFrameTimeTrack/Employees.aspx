<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EntityFrameTimeTrack.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>List of Employees</h1>
            <!-- Add an Object Data Source which is your TimeTrackerRepository, point to the GetEmployees method -->
            <asp:GridView ID="grdvEmployees" runat="server" AutoGenerateColumns="False" DataSourceID="ODSEmployees" DataKeyNames="ID">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ODSEmployees" runat="server" SelectMethod="GetEmployees" TypeName="EntityFrameTimeTrack.Models.TimeTrackerRepository"></asp:ObjectDataSource>
            <asp:GridView ID="grdvTimeCards" runat="server" AutoGenerateColumns="False" DataSourceID="ODSTimeCardsFromEmployee">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="SubmissionDate" HeaderText="SubmissionDate" SortExpression="SubmissionDate" />
                    <asp:BoundField DataField="MondayHours" HeaderText="MondayHours" SortExpression="MondayHours" />
                    <asp:BoundField DataField="TuesdayHours" HeaderText="TuesdayHours" SortExpression="TuesdayHours" />
                    <asp:BoundField DataField="WednesdayHours" HeaderText="WednesdayHours" SortExpression="WednesdayHours" />
                    <asp:BoundField DataField="ThursdayHours" HeaderText="ThursdayHours" SortExpression="ThursdayHours" />
                    <asp:BoundField DataField="FridayHours" HeaderText="FridayHours" SortExpression="FridayHours" />
                    <asp:BoundField DataField="SaturdayHours" HeaderText="SaturdayHours" SortExpression="SaturdayHours" />
                    <asp:BoundField DataField="SundayHours" HeaderText="SundayHours" SortExpression="SundayHours" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ODSTimeCardsFromEmployee" runat="server" SelectMethod="GetEmployeeTimeCard" TypeName="EntityFrameTimeTrack.Models.TimeTrackerRepository">
                <SelectParameters>
                    <asp:ControlParameter ControlID="grdvEmployees" DefaultValue="0" Name="employeeId" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
