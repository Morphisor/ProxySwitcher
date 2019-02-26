namespace ProxySwitcher.Interface
{
    partial class ManageScript
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
            this.ScriptList = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RunBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScriptList
            // 
            this.ScriptList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name});
            this.ScriptList.Location = new System.Drawing.Point(12, 12);
            this.ScriptList.Name = "ScriptList";
            this.ScriptList.Size = new System.Drawing.Size(297, 97);
            this.ScriptList.TabIndex = 0;
            this.ScriptList.UseCompatibleStateImageBehavior = false;
            this.ScriptList.View = System.Windows.Forms.View.List;
            // 
            // Name
            // 
            this.Name.Width = 290;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 137);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(297, 42);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 185);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(297, 42);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(12, 233);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(297, 42);
            this.RunBtn.TabIndex = 3;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // ManageScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 291);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ScriptList);
            //this.Name = "ManageScript";
            this.Text = "ManageScript";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ScriptList;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RunBtn;
    }
}