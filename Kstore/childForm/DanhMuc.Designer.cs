
namespace Kstore.childForm
{
    partial class DanhMuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_ChatLieu = new System.Windows.Forms.ComboBox();
            this.cb_MucGia = new System.Windows.Forms.ComboBox();
            this.txt_SearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_Cap = new System.Windows.Forms.PictureBox();
            this.pic_Non = new System.Windows.Forms.PictureBox();
            this.pic_AoKhoac = new System.Windows.Forms.PictureBox();
            this.pic_Quan = new System.Windows.Forms.PictureBox();
            this.pic_Ao = new System.Windows.Forms.PictureBox();
            this.pic_TatCa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Non)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AoKhoac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Quan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TatCa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Container.AutoScroll = true;
            this.pnl_Container.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Container.Location = new System.Drawing.Point(0, 103);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(859, 378);
            this.pnl_Container.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pic_Cap);
            this.panel1.Controls.Add(this.pic_Non);
            this.panel1.Controls.Add(this.pic_AoKhoac);
            this.panel1.Controls.Add(this.pic_Quan);
            this.panel1.Controls.Add(this.pic_Ao);
            this.panel1.Controls.Add(this.pic_TatCa);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 104);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.Controls.Add(this.cb_ChatLieu);
            this.panel2.Controls.Add(this.cb_MucGia);
            this.panel2.Controls.Add(this.txt_SearchBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(638, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 88);
            this.panel2.TabIndex = 11;
            // 
            // cb_ChatLieu
            // 
            this.cb_ChatLieu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_ChatLieu.FormattingEnabled = true;
            this.cb_ChatLieu.Items.AddRange(new object[] {
            "Cotton",
            "Nỉ",
            "Nhung",
            "Dù",
            "Silk",
            "Poly silk",
            "Mohair",
            "Len",
            "Họa tiết thêu",
            "Vải da cá",
            "Corduroy",
            "Silimi"});
            this.cb_ChatLieu.Location = new System.Drawing.Point(72, 33);
            this.cb_ChatLieu.Name = "cb_ChatLieu";
            this.cb_ChatLieu.Size = new System.Drawing.Size(140, 23);
            this.cb_ChatLieu.TabIndex = 7;
            this.cb_ChatLieu.SelectedIndexChanged += new System.EventHandler(this.cb_ChatLieu_SelectedIndexChanged);
            // 
            // cb_MucGia
            // 
            this.cb_MucGia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_MucGia.FormattingEnabled = true;
            this.cb_MucGia.Items.AddRange(new object[] {
            "< 200,000đ",
            "200,000đ - 350,000đ",
            "350,000đ - 500,000đ",
            "> 500,000đ"});
            this.cb_MucGia.Location = new System.Drawing.Point(72, 62);
            this.cb_MucGia.Name = "cb_MucGia";
            this.cb_MucGia.Size = new System.Drawing.Size(140, 23);
            this.cb_MucGia.TabIndex = 10;
            this.cb_MucGia.SelectedIndexChanged += new System.EventHandler(this.cb_MucGia_SelectedIndexChanged);
            // 
            // txt_SearchBox
            // 
            this.txt_SearchBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_SearchBox.Location = new System.Drawing.Point(10, 4);
            this.txt_SearchBox.Name = "txt_SearchBox";
            this.txt_SearchBox.Size = new System.Drawing.Size(203, 23);
            this.txt_SearchBox.TabIndex = 6;
            this.txt_SearchBox.Text = "Tìm kiếm theo tên sản phẩm";
            this.txt_SearchBox.TextChanged += new System.EventHandler(this.txt_SearchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mức giá:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chất liệu:";
            // 
            // pic_Cap
            // 
            this.pic_Cap.BackgroundImage = global::Kstore.Properties.Resources.Kstore_bag;
            this.pic_Cap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Cap.Location = new System.Drawing.Point(541, 9);
            this.pic_Cap.Name = "pic_Cap";
            this.pic_Cap.Size = new System.Drawing.Size(88, 88);
            this.pic_Cap.TabIndex = 5;
            this.pic_Cap.TabStop = false;
            this.pic_Cap.Click += new System.EventHandler(this.pic_Cap_Click);
            // 
            // pic_Non
            // 
            this.pic_Non.BackgroundImage = global::Kstore.Properties.Resources.Kstore_cap;
            this.pic_Non.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Non.Location = new System.Drawing.Point(434, 9);
            this.pic_Non.Name = "pic_Non";
            this.pic_Non.Size = new System.Drawing.Size(88, 88);
            this.pic_Non.TabIndex = 4;
            this.pic_Non.TabStop = false;
            this.pic_Non.Click += new System.EventHandler(this.pic_Non_Click);
            // 
            // pic_AoKhoac
            // 
            this.pic_AoKhoac.BackgroundImage = global::Kstore.Properties.Resources.Kstore_outerwear;
            this.pic_AoKhoac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_AoKhoac.Location = new System.Drawing.Point(327, 9);
            this.pic_AoKhoac.Name = "pic_AoKhoac";
            this.pic_AoKhoac.Size = new System.Drawing.Size(88, 88);
            this.pic_AoKhoac.TabIndex = 3;
            this.pic_AoKhoac.TabStop = false;
            this.pic_AoKhoac.Click += new System.EventHandler(this.pic_AoKhoac_Click);
            // 
            // pic_Quan
            // 
            this.pic_Quan.BackgroundImage = global::Kstore.Properties.Resources.Kstore_short;
            this.pic_Quan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Quan.Location = new System.Drawing.Point(222, 9);
            this.pic_Quan.Name = "pic_Quan";
            this.pic_Quan.Size = new System.Drawing.Size(88, 88);
            this.pic_Quan.TabIndex = 2;
            this.pic_Quan.TabStop = false;
            this.pic_Quan.Click += new System.EventHandler(this.pic_Quan_Click);
            // 
            // pic_Ao
            // 
            this.pic_Ao.BackgroundImage = global::Kstore.Properties.Resources.Kstore_tee;
            this.pic_Ao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Ao.Location = new System.Drawing.Point(116, 9);
            this.pic_Ao.Name = "pic_Ao";
            this.pic_Ao.Size = new System.Drawing.Size(88, 88);
            this.pic_Ao.TabIndex = 1;
            this.pic_Ao.TabStop = false;
            this.pic_Ao.Click += new System.EventHandler(this.pic_Ao_Click);
            // 
            // pic_TatCa
            // 
            this.pic_TatCa.BackgroundImage = global::Kstore.Properties.Resources.Kstore_all;
            this.pic_TatCa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_TatCa.Location = new System.Drawing.Point(12, 9);
            this.pic_TatCa.Name = "pic_TatCa";
            this.pic_TatCa.Size = new System.Drawing.Size(88, 88);
            this.pic_TatCa.TabIndex = 0;
            this.pic_TatCa.TabStop = false;
            this.pic_TatCa.Click += new System.EventHandler(this.pic_TatCa_Click);
            // 
            // DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Container);
            this.MinimumSize = new System.Drawing.Size(596, 520);
            this.Name = "DanhMuc";
            this.Text = "DanhMuc";
            this.Load += new System.EventHandler(this.DanhMuc_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Non)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AoKhoac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Quan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TatCa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_Container;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_TatCa;
        private System.Windows.Forms.TextBox txt_SearchBox;
        private System.Windows.Forms.PictureBox pic_Cap;
        private System.Windows.Forms.PictureBox pic_Non;
        private System.Windows.Forms.PictureBox pic_AoKhoac;
        private System.Windows.Forms.PictureBox pic_Quan;
        private System.Windows.Forms.PictureBox pic_Ao;
        private System.Windows.Forms.ComboBox cb_MucGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ChatLieu;
        private System.Windows.Forms.Panel panel2;
    }
}