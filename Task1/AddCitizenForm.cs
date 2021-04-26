using System;
using System.Windows.Forms;

namespace sharp_1
{
    public partial class AddCitizenForm : Form
    {
        public event Action<string> SubmitEvent;

        public AddCitizenForm()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SubmitEvent?.Invoke(this.nameTextBox.Text);
            Close();
        }
    }
}
