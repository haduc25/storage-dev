
namespace BaiKT1Tiet
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
            this.btSach = new System.Windows.Forms.Button();
            this.btMT = new System.Windows.Forms.Button();
            this.btDG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSach
            // 
            this.btSach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSach.Location = new System.Drawing.Point(12, 25);
            this.btSach.Name = "btSach";
            this.btSach.Size = new System.Drawing.Size(445, 51);
            this.btSach.TabIndex = 18;
            this.btSach.Text = "Form Sach";
            this.btSach.UseVisualStyleBackColor = true;
            this.btSach.Click += new System.EventHandler(this.btSach_Click);
            // 
            // btMT
            // 
            this.btMT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMT.Location = new System.Drawing.Point(12, 110);
            this.btMT.Name = "btMT";
            this.btMT.Size = new System.Drawing.Size(445, 51);
            this.btMT.TabIndex = 19;
            this.btMT.Text = "Form Muon Tra";
            this.btMT.UseVisualStyleBackColor = true;
            this.btMT.Click += new System.EventHandler(this.btMT_Click);
            // 
            // btDG
            // 
            this.btDG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDG.Location = new System.Drawing.Point(12, 188);
            this.btDG.Name = "btDG";
            this.btDG.Size = new System.Drawing.Size(445, 51);
            this.btDG.TabIndex = 20;
            this.btDG.Text = "Form Doc Gia";
            this.btDG.UseVisualStyleBackColor = true;
            this.btDG.Click += new System.EventHandler(this.btDG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 281);
            this.Controls.Add(this.btDG);
            this.Controls.Add(this.btMT);
            this.Controls.Add(this.btSach);
            this.Name = "Form1";
            this.Text = "Form QLTV";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSach;
        private System.Windows.Forms.Button btMT;
        private System.Windows.Forms.Button btDG;
    }
}

