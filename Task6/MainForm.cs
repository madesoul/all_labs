using System;
using System.ComponentModel;
using System.Windows.Forms;
using Task6_ClassLibrary;

namespace Task6
{
    public partial class MainForm : Form
    {
        readonly IBindingList bricks = new BindingList<Model>();

        public MainForm()
        {
            InitializeComponent();
            Bricks.AutoGenerateColumns = true;
            Bricks.DataSource = bricks;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var brick = new Model
            {
                ModelSpec = BrickColour.Text,
                Storage = BrickLength.Text,
                Name = NameField.Text,
                CPU = SizeField.Text,
                RAM = TypeField.Text,
            };

            bricks.Add(brick);

            BrickColour.Text = BrickLength.Text = NameField.Text = SizeField.Text = TypeField.Text = "";
        }
    }
}
