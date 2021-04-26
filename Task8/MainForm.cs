using System;
using System.Windows.Forms;

namespace Task8
{
    public partial class MainForm : Form
    {
        private int bCounter = 0;
        private int lCounter = 0;

        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            AddActor(new InterfaceContainer(new Loader1(), $"Погрузчик#{lCounter++}"));
            AddActor(new InterfaceContainer(new Loader2(), $"Погрузчик#{lCounter++}"));
            for (int i = 0; i < 3; i++)
            {
                AddModel();
            }
        }

        private void AddActor(Subject subject)
        {
            Panel.VerticalScroll.Value = 0;
            var pan = CreatePanel();
            pan.Controls.Add(CreateLabel($"Объект: {subject.Type}"));
            pan.Controls.Add(CreateLabel($"Название: {subject.Name}"));
            pan.Controls.Add(CreateLabel("Состояние: отсутствует"));
            subject.SubjectEvent += state =>
            {
                try
                {
                    pan.Controls[2].Text = $"Состояние: {state}";
                    if (state == "Учавствует в гонке")
                    {
                        this.MovePan(pan);
                    }
                }
                catch
                {
                    
                }
            };
            subject.Start();
            this.Panel.Controls.Add(pan);
        }

        private void MovePan(Control control)
        {
            lock (this)
            {
                control.Location = new System.Drawing.Point(control.Location.X + 3, control.Location.Y);
            }
        }
        
        private Label CreateLabel(string text)
        {
            var label = new Label
            {
                AutoSize = true,
                Name = "DynamicLabel",
                Size = new System.Drawing.Size(100, 20),
                Text = text
            };
            return label;
        }
        private FlowLayoutPanel CreatePanel()
        {
            var group = new FlowLayoutPanel
            {
                Name = "DynamicPanel",
                Size = new System.Drawing.Size(340, 50),
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle
            };
            group.Location = new System.Drawing.Point(0, 55 * (bCounter + lCounter - 1) + 5);
            return group;
        }

        private void AddModel()
        {
            AddActor(new Bolide($"Болид#{bCounter++}"));
        }

        private void AddBolide_Click(object sender, EventArgs e)
        {
            AddModel();
        }

        private void Loader1_Click(object sender, EventArgs e)
        {
            AddActor(new InterfaceContainer(new Loader1(), $"Погрузчик#{lCounter++}"));
        }

        private void Loader2_Click(object sender, EventArgs e)
        {
            AddActor(new InterfaceContainer(new Loader2(), $"Погрузчик#{lCounter++}"));
        }

        private void Panel_Scroll(object sender, ScrollEventArgs e)
        {
            lock (this)
            {

            }
        }
    }
}
