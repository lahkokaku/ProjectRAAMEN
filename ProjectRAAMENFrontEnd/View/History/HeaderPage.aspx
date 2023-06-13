<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="HeaderPage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.History.HeaderPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%if (ListHeader.Count > 0)
        { %>
    <div id="ListHeaderDivCustomer" runat="server" visible="false" >
        <h3>Header List</h3>
        <table border="1"  cellpadding="4">
            <thead>
                <tr>
                    <th>Header Id</th>
                    <th>Date</th>
                    <th>Detail</th>
                </tr>
            </thead>
            <tbody>
                <% foreach (var header in ListHeader)
                    { %> 
                <tr>
                    <td><%= header.Id %></td>
                    <td><%= header.Date%></td>
                    <td>
                        <a href="./DetailPage.aspx?id=<%=header.Id %>"> Details  </a>
                    </td>
                    <%} %>
                </tr>
            </tbody>
        </table>
    </div>
    <div id="ListHeaderDivAdmin" runat="server" visible="false" >
        <h3>Header List</h3>
        <table border="1"  cellpadding="4">
            <thead>
                <tr>
                    <th>Header Id</th>
                    <th>Customer Name</th>
                    <th>Date</th>
                    <th>Detail</th>
                </tr>
            </thead>
            <tbody>
                <% foreach (var header in ListHeader)
                    { %> 
                <tr>
                    <td><%= header.Id %></td>
                    <td><%= header.User.Username%></td>
                    <td><%= header.Date%></td>
                    <td>
                        <a href="./DetailPage.aspx?id=<%=header.Id %>"> Details  </a>
                    </td>
                </tr>
                <%} %>
            </tbody>
        </table>
    </div>
    <%}
        else
        { %>
    <p>No transactions yet</p>
    <%} %>
</asp:Content>
