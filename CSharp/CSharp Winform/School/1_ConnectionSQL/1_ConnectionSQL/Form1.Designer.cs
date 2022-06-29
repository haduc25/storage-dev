
namespace _1_ConnectionSQL
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
            this.btConn = new System.Windows.Forms.Button();
            this.btDis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConn
            // 
            this.btConn.Location = new System.Drawing.Point(65, 160);
            this.btConn.Name = "btConn";
            this.btConn.Size = new System.Drawing.Size(171, 65);
            this.btConn.TabIndex = 0;
            this.btConn.Text = "Connect";
            this.btConn.UseVisualStyleBackColor = true;
            this.btConn.Click += new System.EventHandler(this.btConn_Click);
            // 
            // btDis
            // 
            this.btDis.Location = new System.Drawing.Point(311, 160);
            this.btDis.Name = "btDis";
            this.btDis.Size = new System.Drawing.Size(171, 65);
            this.btDis.TabIndex = 1;
            this.btDis.Text = "Disconnect";
            this.btDis.UseVisualStyleBackColor = true;
            this.btDis.Click += new System.EventHandler(this.btDis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDis);
            this.Controls.Add(this.btConn);
            this.Name = "Form1";
            this.Text = "ConnectToSQL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConn;
        private System.Windows.Forms.Button btDis;
    }
}

