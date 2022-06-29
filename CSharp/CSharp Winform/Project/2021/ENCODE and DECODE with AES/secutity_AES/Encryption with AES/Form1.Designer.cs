
namespace Encryption_with_AES
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
            this.bt_en = new System.Windows.Forms.Button();
            this.bt_de = new System.Windows.Forms.Button();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_en = new System.Windows.Forms.TextBox();
            this.tb_de = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_en
            // 
            this.bt_en.Location = new System.Drawing.Point(615, 114);
            this.bt_en.Name = "bt_en";
            this.bt_en.Size = new System.Drawing.Size(173, 54);
            this.bt_en.TabIndex = 0;
            this.bt_en.Text = "encode";
            this.bt_en.UseVisualStyleBackColor = true;
            this.bt_en.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_de
            // 
            this.bt_de.Location = new System.Drawing.Point(413, 114);
            this.bt_de.Name = "bt_de";
            this.bt_de.Size = new System.Drawing.Size(173, 54);
            this.bt_de.TabIndex = 1;
            this.bt_de.Text = "decode";
            this.bt_de.UseVisualStyleBackColor = true;
            this.bt_de.Click += new System.EventHandler(this.bt_de_Click);
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(0, 114);
            this.tb_text.Multiline = true;
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(391, 89);
            this.tb_text.TabIndex = 2;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(0, 28);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(391, 22);
            this.tb_pass.TabIndex = 3;
            // 
            // tb_en
            // 
            this.tb_en.Location = new System.Drawing.Point(0, 222);
            this.tb_en.Multiline = true;
            this.tb_en.Name = "tb_en";
            this.tb_en.Size = new System.Drawing.Size(391, 89);
            this.tb_en.TabIndex = 4;
            // 
            // tb_de
            // 
            this.tb_de.Location = new System.Drawing.Point(0, 340);
            this.tb_de.Multiline = true;
            this.tb_de.Name = "tb_de";
            this.tb_de.Size = new System.Drawing.Size(391, 89);
            this.tb_de.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_de);
            this.Controls.Add(this.tb_en);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.bt_de);
            this.Controls.Add(this.bt_en);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_en;
        private System.Windows.Forms.Button bt_de;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_en;
        private System.Windows.Forms.TextBox tb_de;
    }
}

