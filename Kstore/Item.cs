using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kstore
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        public string ItemId { get; set; }
        public string ItemType { get; set; }

        public Image ItemImage
        {
            get
            {
                return pic_ItemImage.BackgroundImage;
            }
            set
            {
                pic_ItemImage.BackgroundImage = value;
                pic_ItemImage.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        public string ItemName
        {
            get
            {
                return lb_ItemName.Text;
            }
            set
            {
                lb_ItemName.Text = value;
            }
        }

        public string ItemMaterial
        {
            get
            {
                return lb_ItemMaterial.Text;
            }
            set
            {
                lb_ItemMaterial.Text = value;
            }
        }

        public string ItemPrice
        {
            get
            {
                return lb_ItemPrice.Text;
            }
            set
            {
                lb_ItemPrice.Text = value;
            }
        }

        private void btn_ThemVaoGio_Click(object sender, EventArgs e)
        {
            bool newItem = true;
            foreach (DataRow dr in Form1.cartItemsData.Rows)
            {
                if (dr["id"].ToString() == ItemId)
                {
                    newItem = false;
                    dr["number"] = Convert.ToInt32(dr["number"]) + 1;
                }
            }
            if (newItem)
            {
                string strPrice = lb_ItemPrice.Text.Replace(",", "");
                strPrice = strPrice.Replace("đ", "");
                int intPrice = Convert.ToInt32(strPrice);
                string size = "L";
                if (this.ItemType == "Nón" || this.ItemType == "Túi")
                {
                    size = "None";
                }
                Form1.cartItemsData.Rows.Add(ItemId, lb_ItemName.Text, size, intPrice, 1);
            }
            MessageBox.Show("Đã thêm sản phẩm " + lb_ItemName.Text + " vào giỏ!");
        }
    }
}
