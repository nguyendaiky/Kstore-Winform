
namespace Kstore.childForm
{
    partial class QuanLy
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
            this.pnl_OrderContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_OrderContainer
            // 
            this.pnl_OrderContainer.AutoScroll = true;
            this.pnl_OrderContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_OrderContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_OrderContainer.Location = new System.Drawing.Point(0, 0);
            this.pnl_OrderContainer.Name = "pnl_OrderContainer";
            this.pnl_OrderContainer.Size = new System.Drawing.Size(832, 467);
            this.pnl_OrderContainer.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(832, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 467);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(832, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 467);
            this.panel1.TabIndex = 3;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 467);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnl_OrderContainer);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLy";
            this.Text = "QuanLy";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnl_OrderContainer;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
    }
}