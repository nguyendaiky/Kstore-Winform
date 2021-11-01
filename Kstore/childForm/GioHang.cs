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

        public void ShowCart()
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
            CalTotalCharge();
        }

        public double CalTotalMoney()
        {
            double tongTien = 0;
            foreach (DataRow dr in Form1.cartItemsData.Rows)
            {
                tongTien += Convert.ToInt32(dr["price"]) * Convert.ToInt32(dr["number"]);
            }
            lb_TongTien.Text = tongTien.ToString("#,##0") + "đ";
            return tongTien;
        }

        public double CalTotalCharge()
        {
            double tienThanhToan = CalTotalMoney();
            if (txt_MaGiamGia.Text == "KHUYENMAI05")
            {
                tienThanhToan = tienThanhToan - tienThanhToan * 0.05;
            }
            else if (txt_MaGiamGia.Text == "KHUYENMAI10")
            {
                tienThanhToan = tienThanhToan - tienThanhToan * 0.1;
            }
            else if (txt_MaGiamGia.Text == "KHUYENMAI15")
            {
                tienThanhToan = tienThanhToan - tienThanhToan * 0.15;
            }
            else if (txt_MaGiamGia.Text == "KHUYENMAI20")
            {
                tienThanhToan = tienThanhToan - tienThanhToan * 0.2;
            }
            tienThanhToan += 20000;
            lb_ThanhToan.Text = tienThanhToan.ToString("#,##0") + "đ";
            return tienThanhToan;
        }

        private void txt_MaGiamGia_TextChanged(object sender, EventArgs e)
        {
            CalTotalCharge();
        }

        private void pnl_CartContainer_ControlRemoved(object sender, ControlEventArgs e)
        {
            CalTotalCharge();
        }

        private void pnl_CartContainer_Click(object sender, EventArgs e)
        {
            CalTotalCharge();
        }
    }
}
