namespace ProxySwitcher.Interface
{
    partial class ScriptEditor
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
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.ScriptTxt = new System.Windows.Forms.RichTextBox();
            this.ScriptLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(13, 28);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(538, 20);
            this.NameTxt.TabIndex = 0;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(13, 9);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // ScriptTxt
            // 
            this.ScriptTxt.Location = new System.Drawing.Point(12, 86);
            this.ScriptTxt.Name = "ScriptTxt";
            this.ScriptTxt.Size = new System.Drawing.Size(539, 139);
            this.ScriptTxt.TabIndex = 2;
            this.ScriptTxt.Text = "";
            // 
            // ScriptLbl
            // 
            this.ScriptLbl.AutoSize = true;
            this.ScriptLbl.Location = new System.Drawing.Point(12, 70);
            this.ScriptLbl.Name = "ScriptLbl";
            this.ScriptLbl.Size = new System.Drawing.Size(34, 13);
            this.ScriptLbl.TabIndex = 3;
            this.ScriptLbl.Text = "Script";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(12, 240);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(539, 59);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ScriptEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 317);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ScriptLbl);
            this.Controls.Add(this.ScriptTxt);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.NameTxt);
            this.Name = "ScriptEditor";
            this.Text = "ScriptEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.RichTextBox ScriptTxt;
        private System.Windows.Forms.Label ScriptLbl;
        private System.Windows.Forms.Button SaveBtn;
    }
}