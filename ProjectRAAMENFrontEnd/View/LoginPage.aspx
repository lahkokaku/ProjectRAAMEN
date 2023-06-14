<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <span>
                        <b>RAAMEN</b> |
                    </span>
                <a href="./LoginPage.aspx">Login</a> | <a href="./RegisterPage.aspx">Register</a>
            </div>
            <div>
                <h2>Login</h2>
            </div>
            <div>
                <asp:Label Text="Username" runat="server" />
                <asp:TextBox ID="txtUsername" runat="server" />
            </div>
            <div>
                <asp:Label Text="Password" runat="server" />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"/>
            </div>
            <div>
                <asp:CheckBox ID="chkRememberMe" Text="Remember Me" runat="server" />
            </div>
            <div>
                <asp:Label ID="lblMessage" Text="" runat="server" />
            </div>
            <div>
                <asp:Button Text="Login" runat="server" ID="btnLogin" OnClick="btnLogin_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
