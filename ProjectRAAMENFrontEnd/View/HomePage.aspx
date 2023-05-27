<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Home</h2>
    </div>
    <div>
        Role: <h3 style="display: inline"><asp:Label Text="" runat="server" ID="lblRole" /></h3>
    </div>
</asp:Content>
