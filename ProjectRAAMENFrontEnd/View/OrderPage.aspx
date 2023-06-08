<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="OrderPage.aspx.cs" Inherits="ProjectRAAMENFrontEnd.View.OrderPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Ramen List</h2>
    <div>
        <asp:GridView runat="server" ID="gvRamenList" AutoGenerateColumns="False" OnSelectedIndexChanged="gvRamenList_SelectedIndexChanged"  >
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Ramen Id" SortExpression="Id"/>
                <asp:BoundField DataField="Name" HeaderText="Ramen Name" SortExpression="Name"/>
                <asp:BoundField DataField="Meat.Name" HeaderText="Ramen Meat" SortExpression="Meat.Name"/>
                <asp:BoundField DataField="Broth" HeaderText="Broth" SortExpression="Broth"/>
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price"/>
                <asp:CommandField ButtonType="Button" HeaderText="Actions"  ShowSelectButton="True"  />
            </Columns>
            
        </asp:GridView>
       

        </div>
        
             
        <div>
            <h2>Cart</h2>
            <div>
                <asp:Button ID="btn_clear" Text="Clear All" runat="server"  OnClick="btn_clear_Click" />
                <asp:Button ID="btn_buy" Text="Buy" runat="server"  OnClick="btn_buy_Click"  />
            </div>
            <asp:GridView runat="server" ID="cartList" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Ramen Id" SortExpression="Id"/>
                    <asp:BoundField DataField="Name" HeaderText="Ramen Name" SortExpression="Name"/>
                    <asp:BoundField DataField="Meat.Name" HeaderText="Ramen Meat" SortExpression="Meat.Name"/>
                    <asp:BoundField DataField="Broth" HeaderText="Broth" SortExpression="Broth"/>
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price"/>
                    <asp:CommandField ButtonType="Button" HeaderText="Actions"    />
                </Columns>
            </asp:GridView>
    </div>
    <div>
         <asp:Label ID="labelMsg" runat="server" Text=""></asp:Label>
    </div>
       
   
</asp:Content>


