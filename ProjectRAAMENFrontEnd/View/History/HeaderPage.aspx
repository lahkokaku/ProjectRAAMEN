<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="HeaderPage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.History.HeaderPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="ListHeaderDiv" runat="server" visible="true" >
        <h3>Header List</h3>
        <table border="1"  cellpadding="4">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Date</th>
                    <th>Detail</th>
                </tr>
            </thead>
            <tbody>
                <% if (ListHeader.Count > 0)
                    { %>
                <% foreach (var header in ListHeader)
                    { %> 
                <tr>
                    <td><%= header.Id %></td>
                    <td><%= header.User.Username %></td>
                    <td><%= header.Date%></td>
                    <td>
                        <a href="./DetailPage.aspx?id=<%=header.Id %>"> Details  </a>
                    </td>

                </tr>
                <%}
                    } %>
            </tbody>
        </table>
    </div>
</asp:Content>
