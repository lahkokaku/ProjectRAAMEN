<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Profile Page</h2>
    <div>
        <asp:Label Text="Username:" runat="server" /> <asp:Label ID="lblUsername" Text="" runat="server" />
    </div>
    <div>
        <asp:Label Text="Email:" runat="server" /> <asp:Label ID="lblEmail" Text="" runat="server" />
    </div>
    <div>
        <asp:Label Text="Gender:" runat="server" /> <asp:Label ID="lblGender" Text="" runat="server" />
    </div>
    <div>
        <asp:Label Text="Role:" runat="server" /> <asp:Label ID="lblRole" Text="" runat="server" />
    </div>
    <hr />
    <h2>Update Profile</h2>
    <div>
        <asp:Label Text="New Username" runat="server" />
        <asp:TextBox ID="txtNewUsername" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="New Email" runat="server" />
        <asp:TextBox ID="txtNewEmail" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label Text="New Gender" runat="server" />
        <div>
            <asp:RadioButton ID="rdbtnMale" runat="server" Text="Male" GroupName="Gender" /> 
            <asp:RadioButton ID="rdbtnFemale" runat="server" Text="Female" GroupName="Gender" /> 
        </div>
    </div>
    <div>
        <asp:Label Text="Password" runat="server" />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ></asp:TextBox>
    </div>
    <div>
        <asp:Button Text="Update Profile" runat="server" ID="btnUpdate" OnClick="btnUpdate_Click" />
    </div>
    <div>
        <asp:Label ID="lblUpdateMessage" Text="" runat="server" />
    </div>
</asp:Content>
