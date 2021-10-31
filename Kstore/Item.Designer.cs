
namespace Kstore
{
    partial class Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_ItemImage = new System.Windows.Forms.PictureBox();
            this.lb_ItemName = new System.Windows.Forms.Label();
            this.lb_ItemPrice = new System.Windows.Forms.Label();
            this.lb_ItemMaterial = new System.Windows.Forms.Label();
            this.btn_ThemVaoGio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_ItemImage
            // 
            this.pic_ItemImage.BackColor = System.Drawing.Color.Transparent;
            this.pic_ItemImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_ItemImage.Location = new System.Drawing.Point(16, 0);
            this.pic_ItemImage.Name = "pic_ItemImage";
            this.pic_ItemImage.Size = new System.Drawing.Size(243, 258);
            this.pic_ItemImage.TabIndex = 0;
            this.pic_ItemImage.TabStop = false;
            // 
            // lb_ItemName
            // 
            this.lb_ItemName.AutoSize = true;
            this.lb_ItemName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ItemName.Location = new System.Drawing.Point(14, 225);
            this.lb_ItemName.Name = "lb_ItemName";
            this.lb_ItemName.Size = new System.Drawing.Size(32, 20);
            this.lb_ItemName.TabIndex = 1;
            this.lb_ItemName.Text = "Tên";
            // 
            // lb_ItemPrice
            // 
            this.lb_ItemPrice.AutoSize = true;
            this.lb_ItemPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ItemPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_ItemPrice.Location = new System.Drawing.Point(16, 268);
            this.lb_ItemPrice.Name = "lb_ItemPrice";
            this.lb_ItemPrice.Size = new System.Drawing.Size(33, 21);
            this.lb_ItemPrice.TabIndex = 2;
            this.lb_ItemPrice.Text = "Giá";
            // 
            // lb_ItemMaterial
            // 
            this.lb_ItemMaterial.AutoSize = true;
            this.lb_ItemMaterial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ItemMaterial.Location = new System.Drawing.Point(16, 246);
            this.lb_ItemMaterial.Name = "lb_ItemMaterial";
            this.lb_ItemMaterial.Size = new System.Drawing.Size(58, 17);
            this.lb_ItemMaterial.TabIndex = 4;
            this.lb_ItemMaterial.Text = "Chất liệu";
            // 
            // btn_ThemVaoGio
            // 
            this.btn_ThemVaoGio.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_ThemVaoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemVaoGio.Location = new System.Drawing.Point(155, 265);
            this.btn_ThemVaoGio.Name = "btn_ThemVaoGio";
            this.btn_ThemVaoGio.Size = new System.Drawing.Size(104, 26);
            this.btn_ThemVaoGio.TabIndex = 5;
            this.btn_ThemVaoGio.Text = "Thêm vào giỏ";
            this.btn_ThemVaoGio.UseVisualStyleBackColor = false;
            this.btn_ThemVaoGio.Click += new System.EventHandler(this.btn_ThemVaoGio_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_ThemVaoGio);
            this.Controls.Add(this.lb_ItemMaterial);
            this.Controls.Add(this.lb_ItemPrice);
            this.Controls.Add(this.lb_ItemName);
            this.Controls.Add(this.pic_ItemImage);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(274, 294);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_ItemImage;
        private System.Windows.Forms.Label lb_ItemName;
        private System.Windows.Forms.Label lb_ItemPrice;
        private System.Windows.Forms.Label lb_ItemType;
        private System.Windows.Forms.Label lb_ItemMaterial;
        private System.Windows.Forms.Button btn_ThemVaoGio;
    }
}
