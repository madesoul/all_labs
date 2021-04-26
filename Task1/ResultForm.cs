using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharp_1
{
    public partial class ResultForm : Form
    {
        public ResultForm(string result)
        {
            InitializeComponent();
            this.richTextBox1.Text = result;
        }

        private void ResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
