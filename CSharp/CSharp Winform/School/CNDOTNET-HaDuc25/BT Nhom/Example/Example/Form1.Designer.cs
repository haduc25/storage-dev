
namespace Example
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_path = new System.Windows.Forms.Label();
            this.bt_filen = new System.Windows.Forms.Button();
            this.bt_filenwe = new System.Windows.Forms.Button();
            this.bt_ext = new System.Windows.Forms.Button();
            this.bt_direc = new System.Windows.Forms.Button();
            this.bt_fullp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_rs = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_path.Location = new System.Drawing.Point(12, 19);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(59, 28);
            this.lb_path.TabIndex = 1;
            this.lb_path.Text = "Path: ";
            // 
            // bt_filen
            // 
            this.bt_filen.Location = new System.Drawing.Point(0, 54);
            this.bt_filen.Name = "bt_filen";
            this.bt_filen.Size = new System.Drawing.Size(213, 48);
            this.bt_filen.TabIndex = 2;
            this.bt_filen.Text = "Get FileName";
            this.bt_filen.UseVisualStyleBackColor = true;
            this.bt_filen.Click += new System.EventHandler(this.bt_filen_Click);
            // 
            // bt_filenwe
            // 
            this.bt_filenwe.Location = new System.Drawing.Point(0, 108);
            this.bt_filenwe.Name = "bt_filenwe";
            this.bt_filenwe.Size = new System.Drawing.Size(515, 48);
            this.bt_filenwe.TabIndex = 3;
            this.bt_filenwe.Text = "Get File Name Without Extension";
            this.bt_filenwe.UseVisualStyleBackColor = true;
            this.bt_filenwe.Click += new System.EventHandler(this.bt_filenwe_Click);
            // 
            // bt_ext
            // 
            this.bt_ext.Location = new System.Drawing.Point(310, 54);
            this.bt_ext.Name = "bt_ext";
            this.bt_ext.Size = new System.Drawing.Size(205, 48);
            this.bt_ext.TabIndex = 4;
            this.bt_ext.Text = "Get Extension";
            this.bt_ext.UseVisualStyleBackColor = true;
            this.bt_ext.Click += new System.EventHandler(this.bt_ext_Click);
            // 
            // bt_direc
            // 
            this.bt_direc.Location = new System.Drawing.Point(310, 0);
            this.bt_direc.Name = "bt_direc";
            this.bt_direc.Size = new System.Drawing.Size(205, 48);
            this.bt_direc.TabIndex = 5;
            this.bt_direc.Text = "Get Directory Name";
            this.bt_direc.UseVisualStyleBackColor = true;
            this.bt_direc.Click += new System.EventHandler(this.bt_direc_Click);
            // 
            // bt_fullp
            // 
            this.bt_fullp.Location = new System.Drawing.Point(0, 0);
            this.bt_fullp.Name = "bt_fullp";
            this.bt_fullp.Size = new System.Drawing.Size(213, 48);
            this.bt_fullp.TabIndex = 6;
            this.bt_fullp.Text = "Get FullPath";
            this.bt_fullp.UseVisualStyleBackColor = true;
            this.bt_fullp.Click += new System.EventHandler(this.bt_fullp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fullp);
            this.panel1.Controls.Add(this.bt_direc);
            this.panel1.Controls.Add(this.bt_filenwe);
            this.panel1.Controls.Add(this.bt_ext);
            this.panel1.Controls.Add(this.bt_filen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 182);
            this.panel1.TabIndex = 8;
            // 
            // bt_rs
            // 
            this.bt_rs.AutoSize = true;
            this.bt_rs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_rs.Location = new System.Drawing.Point(12, 47);
            this.bt_rs.Name = "bt_rs";
            this.bt_rs.Size = new System.Drawing.Size(0, 28);
            this.bt_rs.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 304);
            this.Controls.Add(this.bt_rs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Example Path - Nhom 4";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.Button bt_filen;
        private System.Windows.Forms.Button bt_filenwe;
        private System.Windows.Forms.Button bt_ext;
        private System.Windows.Forms.Button bt_direc;
        private System.Windows.Forms.Button bt_fullp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bt_rs;
    }
}

