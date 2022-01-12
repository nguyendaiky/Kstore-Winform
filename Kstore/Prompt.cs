using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kstore
{
    public partial class Prompt : Form
    {
        public Prompt()
        {
            InitializeComponent();
        }

        public static string message = "";

        public void btn_Ok_Click(object sender, EventArgs e)
        {
            message = txt_LyDo.Text;
            this.Close();
        }

        public void btn_Cancel_Click(object sender, EventArgs e)
        {
            message = "BUTTON CANCEL";
            this.Close();
        }
    }
}
