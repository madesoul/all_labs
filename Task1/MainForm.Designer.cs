
namespace sharp_1
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
            this.citizendList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addCldBtn = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.addCitizenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // citizendList
            // 
            this.citizendList.BackColor = System.Drawing.Color.Honeydew;
            this.citizendList.ForeColor = System.Drawing.Color.Purple;
            this.citizendList.FormattingEnabled = true;
            this.citizendList.ItemHeight = 16;
            this.citizendList.Location = new System.Drawing.Point(12, 64);
            this.citizendList.Name = "citizendList";
            this.citizendList.Size = new System.Drawing.Size(526, 596);
            this.citizendList.TabIndex = 0;
            this.citizendList.SelectedIndexChanged += new System.EventHandler(this.citizendList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(376, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Citizens";
            // 
            // addCldBtn
            // 
            this.addCldBtn.Enabled = false;
            this.addCldBtn.Location = new System.Drawing.Point(118, 4);
            this.addCldBtn.Name = "addCldBtn";
            this.addCldBtn.Size = new System.Drawing.Size(146, 26);
            this.addCldBtn.TabIndex = 2;
            this.addCldBtn.Text = "Connect Child";
            this.addCldBtn.UseVisualStyleBackColor = true;
            this.addCldBtn.Click += new System.EventHandler(this.addCldBtn_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.PaleGreen;
            this.Submit.Location = new System.Drawing.Point(12, 32);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(252, 26);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Calculate Relatives!";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // addCitizenBtn
            // 
            this.addCitizenBtn.Location = new System.Drawing.Point(12, 4);
            this.addCitizenBtn.Name = "addCitizenBtn";
            this.addCitizenBtn.Size = new System.Drawing.Size(100, 26);
            this.addCitizenBtn.TabIndex = 4;
            this.addCitizenBtn.Text = "Add";
            this.addCitizenBtn.UseVisualStyleBackColor = true;
            this.addCitizenBtn.Click += new System.EventHandler(this.addCitizenBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(550, 673);
            this.Controls.Add(this.addCitizenBtn);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.addCldBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.citizendList);
            this.ForeColor = System.Drawing.Color.Purple;
            this.MaximumSize = new System.Drawing.Size(568, 720);
            this.MinimumSize = new System.Drawing.Size(568, 720);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox citizendList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCldBtn;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button addCitizenBtn;
    }
}

