<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="DetailPage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.History.DetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table border="1"  cellpadding="4">
            <thead>
                <tr>
                    <th>Header Id</th>
                    <th>Ramen Name </th>
                    <th>Ramen Broth</th>
                    <th>Ramen Meat</th>
                    <th>Quantity </th>
                    <th>Total</th>


                </tr>
            </thead>
            <tbody>
                <% if (details.Count > 0)
                    { %>
                <% foreach (var detail in details)
                    { %> 
                <tr>
                    <td><%= detail.HeaderId %></td>
                    <td><%= detail.Raman.Name%></td>
                    <td><%= detail.Raman.Broth%></td>
                    <td><%= detail.Raman.Meat.Name%></td>
                    <td><%= detail.Quantity%></td>
                    <td><%= detail.Quantity * Int32.Parse(detail.Raman.Price)%></td>
                </tr>
                <%}
                    } %>
            </tbody>
        </table>
    </div>
</asp:Content>
