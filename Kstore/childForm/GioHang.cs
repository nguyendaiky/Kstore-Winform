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
                if (dr["size"].ToString() != "None")
                {
                    cartItem.CartItemSize = dr["size"].ToString();
                }
                else
                {
                    cartItem.CartItemSizeInvisible();
                }
                cartItem.CartItemNumber = Convert.ToDecimal(dr["number"]);
                cartItem.CartItemPrice = Convert.ToInt32(dr["price"]).ToString("#,##0") + "đ";
                long money = Convert.ToInt32(dr["price"]) * Convert.ToInt32(dr["number"]);
                cartItem.CartItemMoney = money.ToString("#,##0") + "đ";
                cartItem.parentForm = this;
                pnl_CartContainer.Controls.Add(cartItem);
            }
            CalTotalCharge();
        }

        public void ChangeTotalMoney(double value)
        {
            lb_TongTien.Text = value.ToString();
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
            double tienShip = 20000;
            if (tienThanhToan == 0)
            {
                tienShip = 0;
                lb_PhiShip.Text = "0đ";
            }
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
            tienThanhToan += tienShip;
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

        private void btn_DatHang_Click(object sender, EventArgs e)
        {
            if (lb_ThanhToan.Text == "0đ")
            {
                MessageBox.Show("Chưa có sản phẩm trong giỏ!");
                return;
            }
            else if (txt_HoVaTen.Text == "")
            {
                MessageBox.Show("Chưa điền họ và tên!");
                return;
            }
            else if (txt_SoDienThoai.Text == "")
            {
                MessageBox.Show("Chưa điền số điện thoại!");
                return;
            }
            else if (txt_DiaChi.Text == "")
            {
                MessageBox.Show("Chưa điền địa chỉ giao hàng!");
                return;
            }
            else
            {
                MessageBox.Show("ĐẶT HÀNG THÀNH CÔNG!");
                string products = "";
                foreach (DataRow dr in Form1.cartItemsData.Rows)
                {
                    string size = "";
                    if (dr["size"].ToString() != "None")
                    {
                        size = " size: " + dr["size"].ToString();
                    }
                    products += dr["name"].ToString() + size + " sl: " + dr["number"].ToString() + "\n";
                }
                string strThanhToan = lb_ThanhToan.Text;
                strThanhToan = strThanhToan.Replace("đ", "");
                strThanhToan = strThanhToan.Replace(",", "");
                double douThanhToan = Convert.ToDouble(strThanhToan);

                Form1.ordersData.Rows.Add("order" + Form1.orderId.ToString(), "Đã đặt hàng", 
                    DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"), "", txt_HoVaTen.Text, txt_SoDienThoai.Text,
                    txt_DiaChi.Text, txt_ThoiGian.Text, products, douThanhToan);
                Form1.orderId += 1;

                pnl_CartContainer.Controls.Clear();
                Form1.cartItemsData.Rows.Clear();
                lb_TongTien.Text = "0đ";
                lb_PhiShip.Text = "0đ";
                lb_ThanhToan.Text = "0đ";
            }
        }
    }
}
