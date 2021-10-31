
namespace Kstore.childForm
{
    partial class GioHang
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
            this.pnl_CartContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnl_CartContainer
            // 
            this.pnl_CartContainer.AutoScroll = true;
            this.pnl_CartContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_CartContainer.Location = new System.Drawing.Point(0, 0);
            this.pnl_CartContainer.Name = "pnl_CartContainer";
            this.pnl_CartContainer.Size = new System.Drawing.Size(800, 460);
            this.pnl_CartContainer.TabIndex = 0;
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.pnl_CartContainer);
            this.Name = "GioHang";
            this.Text = "GioHang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_CartContainer;
    }
}