
namespace BaiKT1Tiet
{
    partial class FormMuon_Tra
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNHT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaDG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaSach = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(296, 424);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 51);
            this.button5.TabIndex = 55;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(18, 424);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 51);
            this.button4.TabIndex = 54;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btUpdate.Location = new System.Drawing.Point(296, 328);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(165, 51);
            this.btUpdate.TabIndex = 53;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "SL:";
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(133, 271);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(328, 27);
            this.tbSL.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày Hẹn Trả:";
            // 
            // tbNHT
            // 
            this.tbNHT.Location = new System.Drawing.Point(133, 175);
            this.tbNHT.MaxLength = 4;
            this.tbNHT.Name = "tbNHT";
            this.tbNHT.Size = new System.Drawing.Size(328, 27);
            this.tbNHT.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ngày Mượn:";
            // 
            // tbNM
            // 
            this.tbNM.Location = new System.Drawing.Point(133, 125);
            this.tbNM.Name = "tbNM";
            this.tbNM.Size = new System.Drawing.Size(328, 27);
            this.tbNM.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 44;
            this.label2.Tag = "";
            this.label2.Text = "Mã DG:";
            // 
            // tbMaDG
            // 
            this.tbMaDG.Location = new System.Drawing.Point(133, 73);
            this.tbMaDG.Name = "tbMaDG";
            this.tbMaDG.Size = new System.Drawing.Size(328, 27);
            this.tbMaDG.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã sách:";
            // 
            // tbMaSach
            // 
            this.tbMaSach.Location = new System.Drawing.Point(133, 23);
            this.tbMaSach.Name = "tbMaSach";
            this.tbMaSach.Size = new System.Drawing.Size(328, 27);
            this.tbMaSach.TabIndex = 41;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(18, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 51);
            this.button3.TabIndex = 40;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(478, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(858, 456);
            this.dataGridView1.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1171, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 51);
            this.button2.TabIndex = 38;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ngày Trả:";
            // 
            // tbNT
            // 
            this.tbNT.Location = new System.Drawing.Point(133, 221);
            this.tbNT.Name = "tbNT";
            this.tbNT.Size = new System.Drawing.Size(328, 27);
            this.tbNT.TabIndex = 49;
            // 
            // FormMuon_Tra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 568);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNHT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaDG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaSach);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "FormMuon_Tra";
            this.Text = "FormMuon_Tra";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNHT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaSach;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTenTG;
        private System.Windows.Forms.TextBox tbNT;
    }
}