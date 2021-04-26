
namespace sharp_1
{
    partial class AddCitizenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameDesc = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.nameTextBox.ForeColor = System.Drawing.Color.Purple;
            this.nameTextBox.Location = new System.Drawing.Point(12, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(583, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameDesc
            // 
            this.nameDesc.AutoSize = true;
            this.nameDesc.Location = new System.Drawing.Point(275, 5);
            this.nameDesc.Name = "nameDesc";
            this.nameDesc.Size = new System.Drawing.Size(89, 17);
            this.nameDesc.TabIndex = 1;
            this.nameDesc.Text = "Citizen name";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(234, 53);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(175, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Add";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddCitizenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(607, 83);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.nameDesc);
            this.Controls.Add(this.nameTextBox);
            this.ForeColor = System.Drawing.Color.Purple;
            this.MaximumSize = new System.Drawing.Size(625, 130);
            this.MinimumSize = new System.Drawing.Size(625, 130);
            this.Name = "AddCitizenForm";
            this.Text = "AddCitizenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameDesc;
        private System.Windows.Forms.Button submit;
    }
}