
namespace Task2
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
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.WorkingPath = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Open = new System.Windows.Forms.Button();
            this.TextArea = new System.Windows.Forms.RichTextBox();
            this.Go = new System.Windows.Forms.Button();
            this.Stat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WorkingPath
            // 
            this.WorkingPath.Enabled = false;
            this.WorkingPath.Location = new System.Drawing.Point(89, 13);
            this.WorkingPath.Name = "WorkingPath";
            this.WorkingPath.Size = new System.Drawing.Size(699, 22);
            this.WorkingPath.TabIndex = 0;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(8, 12);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // TextArea
            // 
            this.TextArea.Location = new System.Drawing.Point(8, 70);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(780, 368);
            this.TextArea.TabIndex = 2;
            this.TextArea.Text = "";
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(610, 40);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(178, 25);
            this.Go.TabIndex = 7;
            this.Go.Text = "Solve Task";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Stat
            // 
            this.Stat.AutoSize = true;
            this.Stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stat.ForeColor = System.Drawing.Color.DarkViolet;
            this.Stat.Location = new System.Drawing.Point(12, 39);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(0, 24);
            this.Stat.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.TextArea);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.WorkingPath);
            this.ForeColor = System.Drawing.Color.Purple;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WorkingPath;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RichTextBox TextArea;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Label Stat;
    }
}

