using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kstore.childForm
{
    public partial class GioHang : Form
    {
        public GioHang()
        {
            InitializeComponent();
            ShowCart();
        }

        private void ShowCart()
        {
            pnl_CartContainer.Controls.Clear();
            foreach (DataRow dr in Form1.cartItemsData.Rows)
            {
                CartItem cartItem = new CartItem();
                cartItem.CartItemId = dr["id"].ToString();
                cartItem.CartItemImage = Image.FromFile(@"ItemImage\" + cartItem.CartItemId + ".jpg");
                cartItem.CartItemName = dr["name"].ToString();
                cartItem.CartItemSize = dr["size"].ToString();
                cartItem.CartItemNumber = Convert.ToDecimal(dr["number"]);
                cartItem.CartItemPrice = Convert.ToInt32(dr["price"]).ToString("#,##0") + "đ";
                long money = Convert.ToInt32(dr["price"]) * Convert.ToInt32(dr["number"]);
                cartItem.CartItemMoney = money.ToString("#,##0") + "đ";
                pnl_CartContainer.Controls.Add(cartItem);
            }
        }
    }
}
