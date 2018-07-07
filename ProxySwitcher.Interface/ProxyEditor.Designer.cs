namespace ProxySwitcher.Interface
{
    partial class ProxyEditor
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
            this.ProxyNameTxt = new System.Windows.Forms.TextBox();
            this.ProxyNameLbl = new System.Windows.Forms.Label();
            this.IpAddressTxt = new System.Windows.Forms.TextBox();
            this.IpAddressLbl = new System.Windows.Forms.Label();
            this.PortTxt = new System.Windows.Forms.TextBox();
            this.PortLbl = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProxyNameTxt
            // 
            this.ProxyNameTxt.Location = new System.Drawing.Point(12, 26);
            this.ProxyNameTxt.Name = "ProxyNameTxt";
            this.ProxyNameTxt.Size = new System.Drawing.Size(203, 20);
            this.ProxyNameTxt.TabIndex = 0;
            // 
            // ProxyNameLbl
            // 
            this.ProxyNameLbl.AutoSize = true;
            this.ProxyNameLbl.Location = new System.Drawing.Point(13, 7);
            this.ProxyNameLbl.Name = "ProxyNameLbl";
            this.ProxyNameLbl.Size = new System.Drawing.Size(35, 13);
            this.ProxyNameLbl.TabIndex = 1;
            this.ProxyNameLbl.Text = "Name";
            // 
            // IpAddressTxt
            // 
            this.IpAddressTxt.Location = new System.Drawing.Point(12, 78);
            this.IpAddressTxt.Name = "IpAddressTxt";
            this.IpAddressTxt.Size = new System.Drawing.Size(203, 20);
            this.IpAddressTxt.TabIndex = 2;
            // 
            // IpAddressLbl
            // 
            this.IpAddressLbl.AutoSize = true;
            this.IpAddressLbl.Location = new System.Drawing.Point(13, 62);
            this.IpAddressLbl.Name = "IpAddressLbl";
            this.IpAddressLbl.Size = new System.Drawing.Size(58, 13);
            this.IpAddressLbl.TabIndex = 3;
            this.IpAddressLbl.Text = "IP Address";
            // 
            // PortTxt
            // 
            this.PortTxt.Location = new System.Drawing.Point(12, 132);
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(203, 20);
            this.PortTxt.TabIndex = 4;
            // 
            // PortLbl
            // 
            this.PortLbl.AutoSize = true;
            this.PortLbl.Location = new System.Drawing.Point(16, 113);
            this.PortLbl.Name = "PortLbl";
            this.PortLbl.Size = new System.Drawing.Size(26, 13);
            this.PortLbl.TabIndex = 5;
            this.PortLbl.Text = "Port";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 168);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(203, 34);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ProxyEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 214);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.PortLbl);
            this.Controls.Add(this.PortTxt);
            this.Controls.Add(this.IpAddressLbl);
            this.Controls.Add(this.IpAddressTxt);
            this.Controls.Add(this.ProxyNameLbl);
            this.Controls.Add(this.ProxyNameTxt);
            this.Name = "ProxyEditor";
            this.Text = "ProxyEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProxyNameTxt;
        private System.Windows.Forms.Label ProxyNameLbl;
        private System.Windows.Forms.TextBox IpAddressTxt;
        private System.Windows.Forms.Label IpAddressLbl;
        private System.Windows.Forms.TextBox PortTxt;
        private System.Windows.Forms.Label PortLbl;
        private System.Windows.Forms.Button Save;
    }
}