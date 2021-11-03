using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kstore
{
    public partial class OrderItem : UserControl
    {
        public OrderItem()
        {
            InitializeComponent();
            lb_LyDo.Visible = false;
            DangGiaoHang(10);
        }

        Timer tm = new Timer();
        Timer tm1 = new Timer();

        private void DangGiaoHang(int seconds)
        {
            tm.Interval = seconds * 1000;
            tm.Enabled = true;
            tm.Tick += Tm_Tick;
        }

        private void DaGiaoHang(int seconds)
        {
            tm1.Interval = seconds * 1000;
            tm1.Enabled = true;
            tm1.Tick += Tm1_Tick;
        }

        private void Tm1_Tick(object sender, EventArgs e)
        {
            ChangeStatus();
            tm1.Enabled = false;
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            ChangeStatus();
            tm.Enabled = false;
            DaGiaoHang(7);
        }

        public Kstore.childForm.QuanLy ParentForm { get; set; }

        public void ChangeStatus()
        {
            foreach (DataRow dr in Form1.ordersData.Rows)
            {
                if (dr["id"].ToString() == this.OrderItemId && dr["status"].ToString() == "Đã đặt hàng")
                {
                    this.OrderItemStatus = "Đang giao hàng";
                    dr["status"] = "Đang giao hàng";
                }
                else if (dr["id"].ToString() == this.OrderItemId && dr["status"].ToString() == "Đang giao hàng")
                {
                    this.OrderItemStatus = "Đã giao hàng thành công";
                    dr["status"] = "Đã giao hàng thành công";
                    this.ParentForm.LoadOrder();
                }
            }
        }

        public string OrderItemId
        {
            get
            {
                return lb_MaDonHang.Text;
            }
            set
            {
                lb_MaDonHang.Text = value;
            }
        }

        public string OrderItemStatus
        {
            get
            {
                return lb_TinhTrang.Text;
            }
            set
            {
                lb_TinhTrang.Text = value;
                if (value == "Đã hủy đơn hàng")
                {
                    this.lb_TinhTrang.ForeColor = Color.Red;
                }
                else if (value == "Đang giao hàng")
                {
                    this.lb_TinhTrang.ForeColor = Color.Blue;
                }
                else if (value == "Đã giao hàng thành công")
                {
                    this.lb_TinhTrang.ForeColor = Color.SpringGreen;
                }
                else
                {
                    this.lb_TinhTrang.ForeColor = Color.Green;
                }
                if (value != "Đã đặt hàng")
                {
                    this.btn_HuyDonHang.Enabled = false;
                    this.btn_HuyDonHang.BackColor = Color.LightGray;
                }
            }
        }

        public string OrderItemTimeOrder
        {
            get
            {
                return lb_ThoiGianDat.Text;
            }
            set
            {
                lb_ThoiGianDat.Text = value;
            }
        }

        public string OrderItemNote
        {
            get
            {
                return lb_GhiChu.Text;
            }
            set
            {
                lb_GhiChu.Text = value;
            }
        }

        public string OrderItemName
        {
            get
            {
                return lb_HoTen.Text;
            }
            set
            {
                lb_HoTen.Text = value;
            }
        }

        public string OrderItemPhone
        {
            get
            {
                return lb_SoDienThoai.Text;
            }
            set
            {
                lb_SoDienThoai.Text = value;
            }
        }

        public string OrderItemAddress
        {
            get
            {
                return lb_DiaChi.Text;
            }
            set
            {
                lb_DiaChi.Text = value;
            }
        }

        public string OrderItemTimeShip
        {
            get
            {
                return lb_ThoiGianGiao.Text;
            }
            set
            {
                lb_ThoiGianGiao.Text = value;
            }
        }

        public string OrderItemProducts
        {
            get
            {
                return rtb_SanPham.Text;
            }
            set
            {
                rtb_SanPham.Text = value;
            }
        }

        public string OrderItemCharge
        {
            get
            {
                return lb_TienThanhToan.Text;
            }
            set
            {
                lb_TienThanhToan.Text = value;
            }
        }

        private void btn_HuyDonHang_Click(object sender, EventArgs e)
        {
            Prompt reasonInput = new Prompt();
            reasonInput.ShowDialog();
            string reason = Prompt.message;
            if(reason != "BUTTON CANCEL")
            {
                this.OrderItemStatus = "Đã hủy đơn hàng";
                this.lb_LyDo.Visible = true;
                this.lb_GhiChu.Text = reason;
                foreach (DataRow dr in Form1.ordersData.Rows)
                {
                    if (dr["id"].ToString() == this.OrderItemId)
                    {
                        dr["status"] = "Đã hủy đơn hàng";
                        this.ParentForm.LoadOrder();
                    }
                }
            }
        }
    }
}
