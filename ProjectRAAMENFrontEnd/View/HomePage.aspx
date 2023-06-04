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
    <div id="ListCustomerDIv" runat="server" visible="false" >
        <h3>Customer List</h3>
        <table border="1"  cellpadding="4">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Gender</th>
                </tr>
            </thead>
            <tbody>
                <% if (ListCustomer.Count > 0)
                    { %>
                <% foreach (var customer in ListCustomer)
                    { %> 
                <tr>
                    <td><%= customer.Id %></td>
                    <td><%= customer.Username %></td>
                    <td><%= customer.Email %></td>
                    <td><%= customer.Gender %></td>
                </tr>
                <%}
                    } %>
            </tbody>
        </table>
    </div>
    <div id="ListStaffDiv" runat="server" visible="false">
        <h3>Staff List</h3>
        <table border="1"  cellpadding="4">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Gender</th>
                </tr>
            </thead>
            <tbody>
                <% if (ListStaff.Count > 0)
                    { %>
                <% foreach (var staff in ListStaff)
                    { %> 
                <tr>
                    <td><%= staff.Id %></td>
                    <td><%= staff.Username %></td>
                    <td><%= staff.Email %></td>
                    <td><%= staff.Gender %></td>
                </tr>
                <%}
                    } %>
            </tbody>
        </table>
    </div>
</asp:Content>
