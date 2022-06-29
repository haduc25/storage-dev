
namespace Lay1GiaTri
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
            this.btQue = new System.Windows.Forms.Button();
            this.btDis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btQue
            // 
            this.btQue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQue.Location = new System.Drawing.Point(12, 218);
            this.btQue.Name = "btQue";
            this.btQue.Size = new System.Drawing.Size(464, 53);
            this.btQue.TabIndex = 0;
            this.btQue.Text = "Truy Vấn (Query)";
            this.btQue.UseVisualStyleBackColor = true;
            this.btQue.Click += new System.EventHandler(this.btQue_Click);
            // 
            // btDis
            // 
            this.btDis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDis.Location = new System.Drawing.Point(12, 277);
            this.btDis.Name = "btDis";
            this.btDis.Size = new System.Drawing.Size(464, 53);
            this.btDis.TabIndex = 2;
            this.btDis.Text = "Disconnect";
            this.btDis.UseVisualStyleBackColor = true;
            this.btDis.Click += new System.EventHandler(this.btDis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(77, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Truy vấn trả về một giá trị";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDis);
            this.Controls.Add(this.btQue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQue;
        private System.Windows.Forms.Button btDis;
        private System.Windows.Forms.Label label1;
    }
}

