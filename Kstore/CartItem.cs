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
                return lb_CartItemSize.Text;
            }
            set
            {
                lb_CartItemSize.Text = value;
            }
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
    }
}
