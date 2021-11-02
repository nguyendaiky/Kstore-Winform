using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kstore
{
    public partial class CartItem : UserControl
    {
        public Kstore.childForm.GioHang parentForm { get; set; }

        public CartItem()
        {
            InitializeComponent();
        }

        public string CartItemId { get; set; }

        public Image CartItemImage
        {
            get
            {
                return pic_CartItemImage.BackgroundImage;
            }
            set
            {
                pic_CartItemImage.BackgroundImage = value;
                pic_CartItemImage.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        public string CartItemName
        {
            get
            {
                return lb_CartItemName.Text;
            }
            set
            {
                lb_CartItemName.Text = value;
            }
        }

        public string CartItemPrice
        {
            get
            {
                return lb_CartItemPrice.Text;
            }
            set
            {
                lb_CartItemPrice.Text = value;
            }
        }

        public string CartItemSize
        {
            get
            {
                return cb_CartItemSize.Text;
            }
            set
            {
                cb_CartItemSize.Text = value;
            }
        }

        public void CartItemSizeInvisible()
        {
            this.lb_CartItemSize.Visible = false;
            this.cb_CartItemSize.Visible = false;
        }

        public decimal CartItemNumber
        {
            get
            {
                return num_CartItemNumber.Value;
            }
            set
            {
                num_CartItemNumber.Value = value;
            }
        }

        public string CartItemMoney
        {
            get
            {
                return lb_CartItemMoney.Text;
            }
            set
            {
                lb_CartItemMoney.Text = value;
            }
        }

        private void cb_CartItemSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            this.CartItemSize = cb.Text;
            foreach (DataRow dr in Form1.cartItemsData.Rows)
            {
                if (dr["id"].ToString() == this.CartItemId)
                {
                    dr["size"] = this.CartItemSize;
                }
            }
        }

        private void num_CartItemNumber_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            this.CartItemNumber = num.Value;
            foreach (DataRow dr in Form1.cartItemsData.Rows)
            {
                if (dr["id"].ToString() == this.CartItemId)
                {
                    dr["number"] = this.CartItemNumber;
                    this.CartItemMoney = (num.Value * Convert.ToInt32(dr["price"])).ToString("#,##0") + "đ";
                }
            }
            if (parentForm != null)
            {
                parentForm.CalTotalCharge();
            }
        }

        private void pic_CartItemDelete_Click(object sender, EventArgs e)
        {
            DataRow[] drr = Form1.cartItemsData.Select("id='" + this.CartItemId + "'");
            for (int i = 0; i < drr.Length; i++)
                drr[i].Delete();
            Form1.cartItemsData.AcceptChanges();
            this.Parent.Controls.Remove(this);
        }
    }
}
