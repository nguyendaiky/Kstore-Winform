
namespace Kstore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_ThongTin = new FontAwesome.Sharp.IconButton();
            this.btn_ThongKe = new FontAwesome.Sharp.IconButton();
            this.btn_QuanLy = new FontAwesome.Sharp.IconButton();
            this.btn_GioHang = new FontAwesome.Sharp.IconButton();
            this.btn_DanhMuc = new FontAwesome.Sharp.IconButton();
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.lb_Logo = new System.Windows.Forms.Label();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pnl_Desktop = new System.Windows.Forms.Panel();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Logo.SuspendLayout();
            this.pnl_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnl_Menu.Controls.Add(this.btn_ThongTin);
            this.pnl_Menu.Controls.Add(this.btn_ThongKe);
            this.pnl_Menu.Controls.Add(this.btn_QuanLy);
            this.pnl_Menu.Controls.Add(this.btn_GioHang);
            this.pnl_Menu.Controls.Add(this.btn_DanhMuc);
            this.pnl_Menu.Controls.Add(this.pnl_Logo);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(220, 454);
            this.pnl_Menu.TabIndex = 0;
            // 
            // btn_ThongTin
            // 
            this.btn_ThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ThongTin.FlatAppearance.BorderSize = 0;
            this.btn_ThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongTin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ThongTin.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ThongTin.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btn_ThongTin.IconColor = System.Drawing.Color.LightGray;
            this.btn_ThongTin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongTin.Location = new System.Drawing.Point(0, 340);
            this.btn_ThongTin.Name = "btn_ThongTin";
            this.btn_ThongTin.Size = new System.Drawing.Size(220, 60);
            this.btn_ThongTin.TabIndex = 5;
            this.btn_ThongTin.Text = "   Thông tin";
            this.btn_ThongTin.UseVisualStyleBackColor = true;
            this.btn_ThongTin.Click += new System.EventHandler(this.btn_ThongTin_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ThongKe.FlatAppearance.BorderSize = 0;
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ThongKe.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btn_ThongKe.IconColor = System.Drawing.Color.LightGray;
            this.btn_ThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKe.Location = new System.Drawing.Point(0, 280);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(220, 60);
            this.btn_ThongKe.TabIndex = 4;
            this.btn_ThongKe.Text = "   Thống kê đơn hàng";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_QuanLy
            // 
            this.btn_QuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLy.FlatAppearance.BorderSize = 0;
            this.btn_QuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_QuanLy.ForeColor = System.Drawing.Color.LightGray;
            this.btn_QuanLy.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btn_QuanLy.IconColor = System.Drawing.Color.LightGray;
            this.btn_QuanLy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLy.Location = new System.Drawing.Point(0, 220);
            this.btn_QuanLy.Name = "btn_QuanLy";
            this.btn_QuanLy.Size = new System.Drawing.Size(220, 60);
            this.btn_QuanLy.TabIndex = 3;
            this.btn_QuanLy.Text = "   Quản lý đơn hàng";
            this.btn_QuanLy.UseVisualStyleBackColor = true;
            this.btn_QuanLy.Click += new System.EventHandler(this.btn_QuanLy_Click);
            // 
            // btn_GioHang
            // 
            this.btn_GioHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GioHang.FlatAppearance.BorderSize = 0;
            this.btn_GioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GioHang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GioHang.ForeColor = System.Drawing.Color.LightGray;
            this.btn_GioHang.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_GioHang.IconColor = System.Drawing.Color.LightGray;
            this.btn_GioHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_GioHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GioHang.Location = new System.Drawing.Point(0, 160);
            this.btn_GioHang.Name = "btn_GioHang";
            this.btn_GioHang.Size = new System.Drawing.Size(220, 60);
            this.btn_GioHang.TabIndex = 2;
            this.btn_GioHang.Text = "   Giỏ hàng";
            this.btn_GioHang.UseVisualStyleBackColor = true;
            this.btn_GioHang.Click += new System.EventHandler(this.btn_GioHang_Click);
            // 
            // btn_DanhMuc
            // 
            this.btn_DanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DanhMuc.FlatAppearance.BorderSize = 0;
            this.btn_DanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DanhMuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DanhMuc.ForeColor = System.Drawing.Color.LightGray;
            this.btn_DanhMuc.IconChar = FontAwesome.Sharp.IconChar.Tshirt;
            this.btn_DanhMuc.IconColor = System.Drawing.Color.LightGray;
            this.btn_DanhMuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DanhMuc.Location = new System.Drawing.Point(0, 100);
            this.btn_DanhMuc.Name = "btn_DanhMuc";
            this.btn_DanhMuc.Size = new System.Drawing.Size(220, 60);
            this.btn_DanhMuc.TabIndex = 1;
            this.btn_DanhMuc.Text = "   Danh mục sản phẩm";
            this.btn_DanhMuc.UseVisualStyleBackColor = true;
            this.btn_DanhMuc.Click += new System.EventHandler(this.btn_DanhMuc_Click);
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.Controls.Add(this.lb_Logo);
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(220, 100);
            this.pnl_Logo.TabIndex = 0;
            // 
            // lb_Logo
            // 
            this.lb_Logo.AutoSize = true;
            this.lb_Logo.Font = new System.Drawing.Font("Pristina", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Logo.ForeColor = System.Drawing.Color.LightGray;
            this.lb_Logo.Location = new System.Drawing.Point(56, 26);
            this.lb_Logo.Name = "lb_Logo";
            this.lb_Logo.Size = new System.Drawing.Size(99, 49);
            this.lb_Logo.TabIndex = 0;
            this.lb_Logo.Text = "Kstore";
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnl_Title.Controls.Add(this.lb_Title);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(220, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(583, 38);
            this.pnl_Title.TabIndex = 1;
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Title.ForeColor = System.Drawing.Color.LightGray;
            this.lb_Title.Location = new System.Drawing.Point(10, 7);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(153, 21);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Danh mục sản phẩm";
            // 
            // pnl_Desktop
            // 
            this.pnl_Desktop.BackColor = System.Drawing.Color.Silver;
            this.pnl_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Desktop.Location = new System.Drawing.Point(220, 38);
            this.pnl_Desktop.Name = "pnl_Desktop";
            this.pnl_Desktop.Size = new System.Drawing.Size(583, 416);
            this.pnl_Desktop.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 454);
            this.Controls.Add(this.pnl_Desktop);
            this.Controls.Add(this.pnl_Title);
            this.Controls.Add(this.pnl_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kstore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Logo.ResumeLayout(false);
            this.pnl_Logo.PerformLayout();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private FontAwesome.Sharp.IconButton btn_ThongTin;
        private FontAwesome.Sharp.IconButton btn_ThongKe;
        private FontAwesome.Sharp.IconButton btn_QuanLy;
        private FontAwesome.Sharp.IconButton btn_GioHang;
        private FontAwesome.Sharp.IconButton btn_DanhMuc;
        private System.Windows.Forms.Panel pnl_Logo;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel pnl_Desktop;
        private System.Windows.Forms.Label lb_Logo;
    }
}

