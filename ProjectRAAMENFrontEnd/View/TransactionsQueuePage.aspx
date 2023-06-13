<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="TransactionsQueuePage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.TransactionsQueuePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Transactions Queue</h2>
    <%if (UnhandledHeaderList.Count > 0)
        { %>
    <div>
        <asp:GridView runat="server" ID="gvHeaderList" AutoGenerateColumns="False" OnRowUpdating="gvHeaderList_RowUpdating" border="1" CellPadding="4">
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
</asp:Content>
