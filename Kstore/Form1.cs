﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Kstore
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Color myBlue = Color.FromArgb(31, 30, 68);
        public Color myYellow = Color.FromArgb(242, 177, 56);
        public Color mySilver = Color.FromArgb(211, 211, 211);
        public Color myWhite = Color.FromArgb(227, 227, 227);

        public static DataTable cartItemsData = new DataTable();

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 60);
            pnl_Menu.Controls.Add(leftBorderBtn);
            currentBtn = btn_DanhMuc;
            ActivateButton(currentBtn);
            OpenChildForm(new childForm.DanhMuc());
            cartItemsData.Columns.Add("id", typeof(string));
            cartItemsData.Columns.Add("name", typeof(string));
            cartItemsData.Columns.Add("size", typeof(string));
            cartItemsData.Columns.Add("price", typeof(int));
            cartItemsData.Columns.Add("number", typeof(int));
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DeActivateButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = myYellow;
                currentBtn.IconColor = myYellow;

                leftBorderBtn.BackColor = myYellow;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                lb_Title.Text = currentBtn.Text;
            }
        }

        private void DeActivateButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = myBlue;
                currentBtn.ForeColor = mySilver;
                currentBtn.IconColor = mySilver;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Size = pnl_Desktop.Size;
            pnl_Desktop.Controls.Add(childForm);
            pnl_Desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_DanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm.DanhMuc());
            ActivateButton(sender);
        }

        private void btn_GioHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm.GioHang());
            ActivateButton(sender);
        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm.QuanLy());
            ActivateButton(sender);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForm.ThongKe());
            ActivateButton(sender);
        }

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}