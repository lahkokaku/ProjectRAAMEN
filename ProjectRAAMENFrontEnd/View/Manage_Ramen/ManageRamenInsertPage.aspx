<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="ManageRamenInsertPage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.Manage_Ramen.ManageRamenInsertPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div>
        <asp:Button Text="Back" runat="server" ID="btnBack"  OnClick="btnBack_Click"/>
    </div>
    <h2>Create New Ramen</h2>
    <div>
        <asp:Label Text="Ramen Name" runat="server" />
        <asp:TextBox runat="server" ID="txtRamenName" />
    </div>
    <div>
        <asp:Label Text="Meat" runat="server" />
        <asp:DropDownList runat="server" ID="ddlMeatList">
        </asp:DropDownList>
    </div>
    <div>
        <asp:Label Text="Broth" runat="server" />
        <asp:TextBox runat="server" ID="txtBroth" />
    </div>
    <div>
        <asp:Label Text="Price" runat="server" />
        <asp:TextBox runat="server" ID="txtPrice" Text="0" TextMode="Number" />
    </div>
    <div>
        <asp:Button Text="Create Ramen" runat="server" ID="btnCreateRamen" OnClick="btnCreateRamen_Click" />
    </div>
    <div>
        <asp:Label Text="" runat="server" ID="lblMessage" />
    </div>
</asp:Content>
