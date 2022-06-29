namespace RWtxt
{
    partial class Form1
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
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btWrite = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.Color.Black;
            this.tbResult.ForeColor = System.Drawing.Color.Yellow;
            this.tbResult.Location = new System.Drawing.Point(12, 50);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(482, 186);
            this.tbResult.TabIndex = 0;
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(400, 242);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(94, 35);
            this.btWrite.TabIndex = 2;
            this.btWrite.Text = "Write File";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.button2_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(281, 242);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(103, 35);
            this.btRead.TabIndex = 1;
            this.btRead.Text = "Read File";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Here\'s Read or Write File (.txt)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWrite);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.tbResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "WRFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label label1;
    }
}

