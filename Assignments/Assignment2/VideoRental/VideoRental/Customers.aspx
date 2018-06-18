<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="VideoRental.Customers" 
    MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>View All Customers</h1>
            <asp:GridView ID="grdvAllCustomers" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="grdvAllCustomers_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                </Columns>
            </asp:GridView>

            <br />

            <asp:DetailsView ID="dtlvCustomer" runat="server" Height="50px" Width="483px" DataSourceID="SqlDataSource1" AutoGenerateEditButton="True" AutoGenerateRows="False" OnPageIndexChanging="dtlvCustomer_PageIndexChanging" DataKeyNames="ID" OnItemCreated="dtlvCustomer_ItemCreated">
                <Fields>
                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                </Fields>
            </asp:DetailsView>


            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Customers] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Customers] ([FirstName], [LastName], [Address], [Phone]) VALUES (@FirstName, @LastName, @Address, @Phone)" SelectCommand="SELECT [ID], [FirstName], [LastName], [Address], [Phone] FROM [Customers] WHERE ([ID] = @ID)" UpdateCommand="UPDATE [Customers] SET [FirstName] = @FirstName, [LastName] = @LastName, [Address] = @Address, [Phone] = @Phone WHERE [ID] = @ID">
                <DeleteParameters>
                    <asp:Parameter Name="ID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="Phone" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="grdvAllCustomers" DefaultValue="0" Name="ID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="Phone" Type="String" />
                    <asp:Parameter Name="ID" Type="Int32" />
                </UpdateParameters>
</asp:SqlDataSource>


            <asp:Button ID="btnRent" runat="server" Text="Rent Media" OnClick="btnRent_Click" />


            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetCustomerByID" TypeName="VideoRental.Models.DbContextVideoRentalRepository">
                <SelectParameters>
                    <asp:ControlParameter ControlID="grdvAllCustomers" DefaultValue="0" Name="customerID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>


            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCustomers" TypeName="VideoRental.Models.DbContextVideoRentalRepository"></asp:ObjectDataSource>
</asp:Content>

