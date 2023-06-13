<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="TransactionsQueuePage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.TransactionsQueuePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Transactions Queue</h2>
    <%if (UnhandledHeaderList.Count > 0)
        { %>
    <div>
        <asp:GridView runat="server" ID="gvUnhandledHeaderList" AutoGenerateColumns="False" OnRowUpdating="gvHeaderList_RowUpdating" BorderWidth="1" CellPadding="4">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Header ID" SortExpression="Id" />
                <asp:BoundField DataField="CustomerId" HeaderText="Customer ID" ReadOnly="true" SortExpression="CustomerId" />
                <asp:BoundField DataField="Date" HeaderText="Transaction Date" ReadOnly="True" SortExpression="Date" />
                <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Action" ShowHeader="True" Text="Handle" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="lblMessage" Text="" runat="server" />
    </div>
    <%}
        else
        { %>
    <div>
        <p>All transactions handled!</p>
    </div>
    <%} %>
    <h2>Handled Transactions</h2>
    <%if (HandledHeaderList.Count > 0)
        { %>
    <div>
        <asp:GridView runat="server" ID="gvHandledHeaderList" AutoGenerateColumns="false" CellPadding="4" BorderWidth="1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Header ID" SortExpression="Id" />
                <asp:BoundField DataField="CustomerId" HeaderText="Customer ID" ReadOnly="true" SortExpression="CustomerId" />
                <asp:BoundField DataField="Date" HeaderText="Transaction Date" ReadOnly="True" SortExpression="Date" />
                <asp:BoundField DataField="StaffId" HeaderText="Handled By (Staff ID)" ReadOnly="True" SortExpression="StaffId" />
            </Columns>
        </asp:GridView>
    </div>
    <%}
        else
        { %>
    <div>
        <p>No handled transactions yet</p>
     </div>
    <%} %>
</asp:Content>
