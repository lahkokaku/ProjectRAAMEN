<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="ManageRamenPage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.Manage_Ramen.ManageRamenPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Manage Ramen</h2>
    <div>
        <asp:GridView runat="server" ID="gvRamenList" AutoGenerateColumns="False" OnRowDeleting="gvRamenList_RowDeleting" OnRowEditing="gvRamenList_RowEditing" >
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Ramen Id" SortExpression="Id"/>
                <asp:BoundField DataField="Name" HeaderText="Ramen Name" SortExpression="Name"/>
                <asp:BoundField DataField="Meat.Name" HeaderText="Ramen Meat" SortExpression="Meat.Name"/>
                <asp:BoundField DataField="Broth" HeaderText="Broth" SortExpression="Broth"/>
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price"/>
                <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Label Text="" runat="server" ID="lblRamenMessage" />
    </div>
    <br />
    <div>
        <asp:Button Text="Create New Ramen" runat="server" ID="btnCreateNewRamen" OnClick="btnCreateNewRamen_Click" />
    </div>
</asp:Content>
