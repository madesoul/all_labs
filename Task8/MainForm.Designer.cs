
namespace Task8
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            try
            {
                base.Dispose(disposing);
            } catch
            {

            }
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddFactory = new System.Windows.Forms.Button();
            this.Tech1 = new System.Windows.Forms.Button();
            this.Tech2 = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AddFactory
            // 
            this.AddFactory.BackColor = System.Drawing.Color.Honeydew;
            this.AddFactory.ForeColor = System.Drawing.Color.Purple;
            this.AddFactory.Location = new System.Drawing.Point(8, 12);
            this.AddFactory.Name = "AddFactory";
            this.AddFactory.Size = new System.Drawing.Size(153, 129);
            this.AddFactory.TabIndex = 1;
            this.AddFactory.Text = "Болид";
            this.AddFactory.UseVisualStyleBackColor = false;
            this.AddFactory.Click += new System.EventHandler(this.AddBolide_Click);
            // 
            // Tech1
            // 
            this.Tech1.BackColor = System.Drawing.Color.Honeydew;
            this.Tech1.ForeColor = System.Drawing.Color.Purple;
            this.Tech1.Location = new System.Drawing.Point(8, 284);
            this.Tech1.Name = "Tech1";
            this.Tech1.Size = new System.Drawing.Size(153, 129);
            this.Tech1.TabIndex = 2;
            this.Tech1.Text = "Погрузчик I";
            this.Tech1.UseVisualStyleBackColor = false;
            this.Tech1.Click += new System.EventHandler(this.Loader1_Click);
            // 
            // Tech2
            // 
            this.Tech2.BackColor = System.Drawing.Color.Honeydew;
            this.Tech2.ForeColor = System.Drawing.Color.Purple;
            this.Tech2.Location = new System.Drawing.Point(8, 419);
            this.Tech2.Name = "Tech2";
            this.Tech2.Size = new System.Drawing.Size(153, 129);
            this.Tech2.TabIndex = 3;
            this.Tech2.Text = "Погрузчик II";
            this.Tech2.UseVisualStyleBackColor = false;
            this.Tech2.Click += new System.EventHandler(this.Loader2_Click);
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.Location = new System.Drawing.Point(167, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1229, 797);
            this.Panel.TabIndex = 0;
            this.Panel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Panel_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1408, 821);
            this.Controls.Add(this.AddFactory);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Tech2);
            this.Controls.Add(this.Tech1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.MaximumSize = new System.Drawing.Size(1426, 868);
            this.MinimumSize = new System.Drawing.Size(1426, 868);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddFactory;
        private System.Windows.Forms.Button Tech1;
        private System.Windows.Forms.Button Tech2;
        private System.Windows.Forms.Panel Panel;
    }
}

