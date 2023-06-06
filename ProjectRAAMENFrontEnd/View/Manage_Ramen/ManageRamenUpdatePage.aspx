<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="ManageRamenUpdatePage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.Manage_Ramen.ManageRamenEditPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div>
        <asp:Button Text="Back" runat="server" ID="btnBack" OnClick="btnBack_Click" />
    </div>
    <h2>Update Ramen</h2>
    <div>
        <asp:Label Text="Ramen Id: " runat="server" /><asp:Label Text="" runat="server" Id="lblRamenId" />
    </div>
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
        <asp:Button Text="Update Ramen" runat="server" ID="btnUpdateRamen" OnClick="btnUpdateRamen_Click" />
    </div>
    <div>
        <asp:Label Text="" runat="server" ID="lblMessage" />
    </div>
</asp:Content>
