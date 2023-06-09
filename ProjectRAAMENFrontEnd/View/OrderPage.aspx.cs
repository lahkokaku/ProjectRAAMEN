using ProjectRAAMENFrontEnd.Controller;
using ProjectRAAMENFrontEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectRAAMENFrontEnd.View
{
    public partial class OrderPage : System.Web.UI.Page
    {
        public static List<Raman> RamenList = new List<Raman>();
        public static List<Raman> cart = new List<Raman>();
        protected void Page_Load(object sender, EventArgs e)
        {
         
            RefreshRamenList();
        }
        protected void RefreshRamenList()
        {
            RamenList = RamenController.GetAllRamen();
            gvRamenList.DataSource = RamenList;
            gvRamenList.DataBind();

            cartList.DataSource = cart;
            cartList.DataBind();


        }

        protected void gvRamenList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvRamenList.SelectedRow;
            int id= Int32.Parse(row.Cells[0].Text);
            Raman ramen = RamenController.GetRamenById(id);
            cart.Add(ramen);
            RefreshRamenList();
            labelMsg.Text = ""; 
            return;
        }

        public void clearCart(){ 
            cart.Clear();
            RefreshRamenList();

        }
        protected void btn_clear_Click(object sender, EventArgs e)
        {
            clearCart();
        }
        public Dictionary<string,int> initializeQuantity(List<Raman> allRamen)
        {
            var quantity = new Dictionary<string, int>();
            foreach (Raman i in allRamen)
            {
                quantity.Add(i.Name, 0);
            }
            return quantity;
        }

        public int insertHeader() {
            int customerId = UserController.GetUserById((int)Session["user"]).Id;
            int staffId = 0;
            Header header = HeaderController.InsertHeader(customerId, staffId, DateTime.Now);
            return header.Id;
        }

        public void insertDetail (Dictionary<string,int>quantity,List<Raman> allRamen, int headerId)
        {
            foreach (Raman r in allRamen)
            {
                if (quantity[r.Name] != 0)
                {
                    int productQuantity = quantity[r.Name];
                    DetailController.InsertDetail(headerId, r.Id, productQuantity);
                }
            }
        }
        protected void btn_buy_Click(object sender, EventArgs e)
        {
            if(cart.Count == 0)
            {
                labelMsg.Text = "Cart is empty";
                return;
            }
            List<Raman> allRamen = new List<Raman>();
            allRamen = RamenController.GetAllRamen();
            var quantity = initializeQuantity(allRamen);
            foreach (Raman i in cart)
            {
                quantity[i.Name]++;
            }
            int headerId = insertHeader();
            insertDetail(quantity, allRamen, headerId);
            labelMsg.Text = "Cart Succesfully Added";
            clearCart();

        }

        protected void cartList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow Row = cartList.Rows[e.RowIndex];
            int Index = Int32.Parse(Row.RowIndex.ToString());
            cart.RemoveAt(Index);
            cartList.DataBind();
        }
    }
}