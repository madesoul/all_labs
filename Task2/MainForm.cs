using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Task2_ClassLibrary;

namespace Task2
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (this.OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.WorkingPath.Text = this.OpenFileDialog.FileName;
                TextArea.Text = File.ReadAllText(this.WorkingPath.Text);
            }
        }

        private void Go_Click(object sender, EventArgs e)
        {
            var counter = new NumericCounter()
            {
                Text = this.TextArea.Text
            };
            counter.Compute();
            this.Stat.Text = $"Count of numbers: {counter.Count}; Sum of numbers: {counter.Summa}";
        }
    }
}
