using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sharp_1
{
    public partial class CldForm : Form
    {
        private int currentIndex;

        public event Action<List<int>, int> SubmitEvent;

        public CldForm(List<string> citizens, int currentIndex, List<int> childIndices)
        {
            InitializeComponent();
            this.currentIndex = currentIndex;
            this.desc.Text = this.desc.Text.Replace("%s", citizens[currentIndex]);
            citizens.ForEach(x => this.citizendList.Items.Add(x));
            childIndices.ForEach(x => this.citizendList.SelectedItems.Add(citizens[x]));
        }

        private void OK_Click(object sender, EventArgs e)
        {
            SubmitEvent?.Invoke(this.citizendList.SelectedIndices.Cast<int>().Where(x => x != currentIndex).ToList(), currentIndex);
            Close();
        }
    }
}
