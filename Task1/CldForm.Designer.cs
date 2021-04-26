
namespace sharp_1
{
    partial class CldForm
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
            this.OK = new System.Windows.Forms.Button();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // citizendList
            // 
            this.citizendList.BackColor = System.Drawing.Color.Honeydew;
            this.citizendList.ForeColor = System.Drawing.Color.Purple;
            this.citizendList.FormattingEnabled = true;
            this.citizendList.ItemHeight = 16;
            this.citizendList.Location = new System.Drawing.Point(12, 96);
            this.citizendList.Name = "citizendList";
            this.citizendList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.citizendList.Size = new System.Drawing.Size(592, 564);
            this.citizendList.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(529, 13);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 77);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // desc
            // 
            this.desc.BackColor = System.Drawing.Color.Honeydew;
            this.desc.Enabled = false;
            this.desc.ForeColor = System.Drawing.Color.Purple;
            this.desc.Location = new System.Drawing.Point(12, 13);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(510, 77);
            this.desc.TabIndex = 3;
            this.desc.Text = "Connect child of %s and press OK. If select citizen himself as a child, it will b" +
    "e ignored";
            // 
            // CldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(616, 673);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.citizendList);
            this.ForeColor = System.Drawing.Color.Purple;
            this.MaximumSize = new System.Drawing.Size(634, 720);
            this.MinimumSize = new System.Drawing.Size(634, 720);
            this.Name = "CldForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox citizendList;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.RichTextBox desc;
    }
}

