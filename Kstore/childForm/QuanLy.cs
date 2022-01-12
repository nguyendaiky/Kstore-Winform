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
        int numberOfOrder;
        int numberOfOrderTC;
        int numberOfOrderBH;
        double totalMoney;

        public QuanLy()
        {
            InitializeComponent();
            LoadOrder();
        }

        public void LoadOrder()
        {
            numberOfOrder = 0;
            numberOfOrderTC = 0;
            numberOfOrderBH = 0;
            totalMoney = 0;
            DataRow[] drs = Form1.ordersData.Select();
            numberOfOrder = drs.Length;
            if (drs.Length > 0)
            {
                pnl_OrderContainer.Controls.Clear();
                for (int i = drs.Length - 1; i >= 0; i--)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.OrderItemId = drs[i]["id"].ToString();
                    orderItem.OrderItemStatus = drs[i]["status"].ToString();
                    orderItem.OrderItemTimeOrder = drs[i]["orderDate"].ToString() + "-" + drs[i]["orderMonth"].ToString() + "-" + drs[i]["orderYear"].ToString();
                    orderItem.OrderItemNote = drs[i]["note"].ToString();
                    orderItem.OrderItemName = drs[i]["name"].ToString();
                    orderItem.OrderItemPhone = drs[i]["phone"].ToString();
                    orderItem.OrderItemAddress = drs[i]["address"].ToString();
                    orderItem.OrderItemTimeShip = drs[i]["timeShip"].ToString();
                    orderItem.OrderItemProducts = drs[i]["products"].ToString();
                    orderItem.OrderItemCharge = Convert.ToDouble(drs[i]["money"]).ToString("#,##0") + "đ (gồm " + Convert.ToDouble(drs[i]["shipFee"]).ToString("#,##0") + "đ phí ship)";
                    orderItem.ParentForm = this;
                    pnl_OrderContainer.Controls.Add(orderItem);

                    if (drs[i]["status"].ToString() == "Đã giao hàng thành công")
                    {
                        numberOfOrderTC++;
                        totalMoney += Convert.ToDouble(drs[i]["money"]);
                    }
                    else if (drs[i]["status"].ToString() == "Đã hủy đơn hàng")
                    {
                        numberOfOrderBH++;
                    }
                }
            }
            else
            {
                pnl_OrderContainer.Controls.Clear();
            }
            UpdateResult();
        }

        public void LoadSpecificOrder()
        {
            numberOfOrder = 0;
            numberOfOrderTC = 0;
            numberOfOrderBH = 0;
            totalMoney = 0;
            string query = "";
            if (cb_Ngay.Text != "")
            {
                query += $"orderDate = '{cb_Ngay.Text}' AND ";
            }
            if (cb_Thang.Text != "")
            {
                query += $"orderMonth = '{cb_Thang.Text}' AND ";
            }
            if (cb_Nam.Text != "")
            {
                query += $"orderYear = '{cb_Nam.Text}' AND ";
            }
            if (cb_TinhTrang.Text != "Tất cả")
            {
                query += $"status = '{cb_TinhTrang.Text}' AND ";
            }
            if (cb_Tien.Text != "")
            {
                //< 500,000đ
                //500,000đ - 1,000,000đ
                //1,000,000đ - 1,500,000đ
                //1,500,000đ - 2,000,000đ
                //> 2,000,000đ
                if (cb_Tien.Text == "< 500,000đ")
                {
                    query += $"money <= 500000";
                }
                else if (cb_Tien.Text == "500,000đ - 1,000,000đ")
                {
                    query += $"money > 500000 AND money <= 1000000";
                }
                else if (cb_Tien.Text == "1,000,000đ - 1,500,000đ")
                {
                    query += $"money > 1000000 AND money <= 1500000";
                }
                else if (cb_Tien.Text == "1,500,000đ - 2,000,000đ")
                {
                    query += $"money > 1500000 AND money <= 2000000";
                }
                else if (cb_Tien.Text == "> 2,000,000đ")
                {
                    query += $"money > 2000000";
                }
            }
            if (query.EndsWith("AND "))
            {
                query = query.Substring(0, query.Length - 4);
            }
            DataRow[] drs = Form1.ordersData.Select(query);
            numberOfOrder = drs.Length;
            if (drs.Length > 0)
            {
                pnl_OrderContainer.Controls.Clear();
                for (int i = drs.Length - 1; i >= 0; i--)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.OrderItemId = drs[i]["id"].ToString();
                    orderItem.OrderItemStatus = drs[i]["status"].ToString();
                    orderItem.OrderItemTimeOrder = drs[i]["orderDate"].ToString() + "-" + drs[i]["orderMonth"].ToString() + "-" + drs[i]["orderYear"].ToString();
                    orderItem.OrderItemNote = drs[i]["note"].ToString();
                    orderItem.OrderItemName = drs[i]["name"].ToString();
                    orderItem.OrderItemPhone = drs[i]["phone"].ToString();
                    orderItem.OrderItemAddress = drs[i]["address"].ToString();
                    orderItem.OrderItemTimeShip = drs[i]["timeShip"].ToString();
                    orderItem.OrderItemProducts = drs[i]["products"].ToString();
                    orderItem.OrderItemCharge = Convert.ToDouble(drs[i]["money"]).ToString("#,##0") + "đ (gồm " + Convert.ToDouble(drs[i]["shipFee"]).ToString("#,##0") + "đ phí ship)";
                    orderItem.ParentForm = this;
                    pnl_OrderContainer.Controls.Add(orderItem);

                    if (drs[i]["status"].ToString() == "Đã giao hàng thành công")
                    {
                        numberOfOrderTC++;
                        totalMoney += Convert.ToDouble(drs[i]["money"]);
                    }
                    else if (drs[i]["status"].ToString() == "Đã hủy đơn hàng")
                    {
                        numberOfOrderBH++;
                    }
                }
            }
            else
            {
                pnl_OrderContainer.Controls.Clear();
            }
        }

        private void cb_Ngay_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSpecificOrder();
            UpdateResult();
        }

        private void cb_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSpecificOrder();
            UpdateResult();
        }

        public void UpdateResult()
        {
            lb_SoDon.Text = numberOfOrder.ToString();
            lb_SoDonTC.Text = numberOfOrderTC.ToString();
            lb_SoDonBH.Text = numberOfOrderBH.ToString();
            lb_TongTien.Text = totalMoney.ToString("#,##0") + "đ";
        }
    }
}
