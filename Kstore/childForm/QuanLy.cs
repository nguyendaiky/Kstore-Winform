using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kstore.childForm
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
            LoadOrder();
        }

        public void LoadOrder()
        {
            DataRow[] drs = Form1.ordersData.Select();
            if (drs.Length > 0)
            {
                pnl_OrderContainer.Controls.Clear();
                for (int i = drs.Length - 1; i >= 0; i--)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.OrderItemId = drs[i]["id"].ToString();
                    orderItem.OrderItemStatus = drs[i]["status"].ToString();
                    orderItem.OrderItemTimeOrder = drs[i]["timeOrder"].ToString();
                    orderItem.OrderItemNote = drs[i]["note"].ToString();
                    orderItem.OrderItemName = drs[i]["name"].ToString();
                    orderItem.OrderItemPhone = drs[i]["phone"].ToString();
                    orderItem.OrderItemAddress = drs[i]["address"].ToString();
                    orderItem.OrderItemTimeShip = drs[i]["timeShip"].ToString();
                    orderItem.OrderItemProducts = drs[i]["products"].ToString();
                    orderItem.OrderItemCharge = Convert.ToDouble(drs[i]["money"]).ToString("#,##0") + "đ";
                    pnl_OrderContainer.Controls.Add(orderItem);
                }
            }
        }
    }
}
