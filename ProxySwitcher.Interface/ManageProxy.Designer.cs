namespace ProxySwitcher.Interface
{
    partial class ManageProxy
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
            this.ProxyList = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IpAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Script = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ProxyList
            // 
            this.ProxyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.IpAddress,
            this.Port,
            this.Script});
            this.ProxyList.FullRowSelect = true;
            this.ProxyList.GridLines = true;
            this.ProxyList.Location = new System.Drawing.Point(12, 12);
            this.ProxyList.Name = "ProxyList";
            this.ProxyList.Size = new System.Drawing.Size(616, 149);
            this.ProxyList.TabIndex = 0;
            this.ProxyList.UseCompatibleStateImageBehavior = false;
            this.ProxyList.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 134;
            // 
            // IpAddress
            // 
            this.IpAddress.Text = "IpAddress";
            this.IpAddress.Width = 139;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            this.Port.Width = 91;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 167);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(616, 37);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add Proxy";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(12, 210);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(616, 37);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit Proxy";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Script
            // 
            this.Script.Text = "Script";
            this.Script.Width = 246;
            // 
            // ManageProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 255);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ProxyList);
            //this.Name = "ManageProxy";
            this.Text = "ManageProxy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ProxyList;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader IpAddress;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ColumnHeader Script;
    }
}