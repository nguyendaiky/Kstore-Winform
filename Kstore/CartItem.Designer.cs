
namespace Kstore
{
    partial class CartItem
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
            this.pic_CartItemImage = new System.Windows.Forms.PictureBox();
            this.lb_CartItemName = new System.Windows.Forms.Label();
            this.lb_CartItemSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_CartItemNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_CartItemPrice = new System.Windows.Forms.Label();
            this.lb_CartItemMoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_CartItemDelete = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CartItemNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartItemDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_CartItemImage
            // 
            this.pic_CartItemImage.Location = new System.Drawing.Point(3, 3);
            this.pic_CartItemImage.Name = "pic_CartItemImage";
            this.pic_CartItemImage.Size = new System.Drawing.Size(114, 114);
            this.pic_CartItemImage.TabIndex = 0;
            this.pic_CartItemImage.TabStop = false;
            // 
            // lb_CartItemName
            // 
            this.lb_CartItemName.AutoSize = true;
            this.lb_CartItemName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_CartItemName.Location = new System.Drawing.Point(135, 26);
            this.lb_CartItemName.Name = "lb_CartItemName";
            this.lb_CartItemName.Size = new System.Drawing.Size(128, 25);
            this.lb_CartItemName.TabIndex = 1;
            this.lb_CartItemName.Text = "Tên sản phẩm";
            // 
            // lb_CartItemSize
            // 
            this.lb_CartItemSize.AutoSize = true;
            this.lb_CartItemSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_CartItemSize.Location = new System.Drawing.Point(135, 61);
            this.lb_CartItemSize.Name = "lb_CartItemSize";
            this.lb_CartItemSize.Size = new System.Drawing.Size(38, 21);
            this.lb_CartItemSize.TabIndex = 2;
            this.lb_CartItemSize.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(358, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số lượng:";
            // 
            // num_CartItemNumber
            // 
            this.num_CartItemNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_CartItemNumber.Location = new System.Drawing.Point(440, 59);
            this.num_CartItemNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_CartItemNumber.Name = "num_CartItemNumber";
            this.num_CartItemNumber.Size = new System.Drawing.Size(65, 29);
            this.num_CartItemNumber.TabIndex = 4;
            this.num_CartItemNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(624, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá:";
            // 
            // lb_CartItemPrice
            // 
            this.lb_CartItemPrice.AutoSize = true;
            this.lb_CartItemPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_CartItemPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_CartItemPrice.Location = new System.Drawing.Point(666, 61);
            this.lb_CartItemPrice.Name = "lb_CartItemPrice";
            this.lb_CartItemPrice.Size = new System.Drawing.Size(76, 21);
            this.lb_CartItemPrice.TabIndex = 6;
            this.lb_CartItemPrice.Text = "400,000đ";
            // 
            // lb_CartItemMoney
            // 
            this.lb_CartItemMoney.AutoSize = true;
            this.lb_CartItemMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_CartItemMoney.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_CartItemMoney.Location = new System.Drawing.Point(936, 61);
            this.lb_CartItemMoney.Name = "lb_CartItemMoney";
            this.lb_CartItemMoney.Size = new System.Drawing.Size(76, 21);
            this.lb_CartItemMoney.TabIndex = 8;
            this.lb_CartItemMoney.Text = "400,000đ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(844, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thành tiền:";
            // 
            // pic_CartItemDelete
            // 
            this.pic_CartItemDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pic_CartItemDelete.ForeColor = System.Drawing.Color.Silver;
            this.pic_CartItemDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.pic_CartItemDelete.IconColor = System.Drawing.Color.Silver;
            this.pic_CartItemDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pic_CartItemDelete.IconSize = 52;
            this.pic_CartItemDelete.Location = new System.Drawing.Point(1043, 42);
            this.pic_CartItemDelete.Name = "pic_CartItemDelete";
            this.pic_CartItemDelete.Size = new System.Drawing.Size(52, 57);
            this.pic_CartItemDelete.TabIndex = 9;
            this.pic_CartItemDelete.TabStop = false;
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pic_CartItemDelete);
            this.Controls.Add(this.lb_CartItemMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_CartItemPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_CartItemNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_CartItemSize);
            this.Controls.Add(this.lb_CartItemName);
            this.Controls.Add(this.pic_CartItemImage);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(1115, 121);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CartItemNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartItemDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_CartItemImage;
        private System.Windows.Forms.Label lb_CartItemName;
        private System.Windows.Forms.Label lb_CartItemSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_CartItemNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_CartItemPrice;
        private System.Windows.Forms.Label lb_CartItemMoney;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox pic_CartItemDelete;
    }
}
