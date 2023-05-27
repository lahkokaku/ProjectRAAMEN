<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <a href="./LoginPage.aspx">Login</a> | <a href="./RegisterPage.aspx">Register</a>
            </div>
            <div>
                <h2>Register</h2>
            </div>
            <div>
                <asp:Label Text="Username" runat="server" />
                <asp:TextBox ID="txtUsername" runat="server" />
            </div>
            <div>
                <asp:Label Text="Email" runat="server" />
                <asp:TextBox ID="txtEmail" runat="server" />
            </div>
            <div>
                <asp:Label Text="Gender" runat="server" />
                <div>
                    <asp:RadioButton ID="rdbtnMale" runat="server" Text="Male" GroupName="Gender" /> 
                    <asp:RadioButton ID="rdbtnFemale" runat="server" Text="Female" GroupName="Gender" />
                </div>
            </div>
            <div>
                <asp:Label Text="Password" runat="server" />
                <asp:TextBox ID="txtPassword" runat="server"  TextMode="Password"/>
            </div>
            <div>
                <asp:Label Text="Confirm Password" runat="server" />
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" />
            </div>
            <div>
                <asp:Label Text="Role" runat="server" />
                <asp:DropDownList ID="listRole" runat="server">
                    <asp:ListItem Text="Customer (Buyer)" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Staff (Seller)" Value="2"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <asp:Label ID="lblMessage" Text="" runat="server" />
            </div>
            <div>
                <asp:Button Text="Register" runat="server" ID="btnRegister" OnClick="btnRegister_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
