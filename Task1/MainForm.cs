using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sharp_1
{
    public partial class MainForm : Form
    {
        private ListBox.ObjectCollection citizens;
        private Dictionary<int, List<int>> citizen2child = new Dictionary<int, List<int>>();

        bool IsChildOf(int Child, int Parent) => citizen2child.ContainsKey(Parent) ? citizen2child[Parent].Contains(Child) : false;

        bool isExplicitRelatives(int A, int B) => IsChildOf(A, B) || IsChildOf(B, A);
        bool isImplicitRelatives(int A, int V, int B) => A != B && isExplicitRelatives(A, V) && isExplicitRelatives(V, B);

        public MainForm()
        {
            InitializeComponent();
            citizens = this.citizendList.Items;
            fillTestData();
        }

        private void fillTestData()
        {
            citizens.Add("Ivan");
            citizens.Add("Maria");
            citizens.Add("Brother");
            citizens.Add("Sister");
            citizens.Add("Stranger");
            citizen2child[0] = new List<int>(new []{ 2, 3 });
            citizen2child[1] = new List<int>(new[] { 2, 3 });
        }

        private void addCitizenBtn_Click(object sender, EventArgs e)
        {
            var form = new AddCitizenForm();
            form.Owner = this;
            form.SubmitEvent += OnAddedCitezen;
            form.ShowDialog();
        }

        private void OnAddedCitezen(string name)
        {
            citizens.Add(name);
        }

        private void citizendList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.addCldBtn.Enabled = this.citizendList.SelectedIndex != -1;
        }

        private void addCldBtn_Click(object sender, EventArgs e)
        {
            var ind = this.citizendList.SelectedIndex;
            var form = new CldForm(citizens.Cast<string>().ToList(),
                ind,
                citizen2child.ContainsKey(ind) ? citizen2child[ind] : new List<int>());
            form.Owner = this;
            form.SubmitEvent += OnSelectedChild;
            form.ShowDialog();
        }

        private void OnSelectedChild(List<int> child, int citizen)
        {
            citizen2child[citizen] = child;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            var citizensSafe = citizens.Cast<string>().Select((x, y) => new { obj = x, index = y }).ToList();
            var result = citizensSafe.
              Select(x => new
              {
                  relatives = string.Join(",", citizensSafe.
                      Where(y => y.index != x.index).
                      Where(y => isExplicitRelatives(x.index, y.index) ||
                        citizensSafe.
                            Select(z => z).
                            Where(z => z.index != x.index && z.index != y.index).
                            Where(z => isImplicitRelatives(x.index, z.index, y.index)).
                            Any()
                        ).
                      Select(y => y.obj).
                      ToList()
                  ),
                  citizen = x.obj
              }).Select(x => x.ToString());
            var form = new ResultForm(string.Join("\n", result));
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
