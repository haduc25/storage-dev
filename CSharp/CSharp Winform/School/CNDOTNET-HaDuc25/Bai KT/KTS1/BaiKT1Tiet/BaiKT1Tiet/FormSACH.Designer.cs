
namespace BaiKT1Tiet
{
    partial class FormSACH
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTenTG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaSach = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "SL:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(126, 261);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(328, 27);
            this.tbSL.TabIndex = 33;
            this.tbSL.TextChanged += new System.EventHandler(this.tbSL_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tên TG:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbTenTG
            // 
            this.tbTenTG.Location = new System.Drawing.Point(126, 211);
            this.tbTenTG.Name = "tbTenTG";
            this.tbTenTG.Size = new System.Drawing.Size(328, 27);
            this.tbTenTG.TabIndex = 31;
            this.tbTenTG.TextChanged += new System.EventHandler(this.tbTenTG_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Năm XB:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbNam
            // 
            this.tbNam.Location = new System.Drawing.Point(126, 165);
            this.tbNam.MaxLength = 4;
            this.tbNam.Name = "tbNam";
            this.tbNam.Size = new System.Drawing.Size(328, 27);
            this.tbNam.TabIndex = 29;
            this.tbNam.TextChanged += new System.EventHandler(this.tbNam_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "NXB:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbNXB
            // 
            this.tbNXB.Location = new System.Drawing.Point(126, 115);
            this.tbNXB.Name = "tbNXB";
            this.tbNXB.Size = new System.Drawing.Size(328, 27);
            this.tbNXB.TabIndex = 27;
            this.tbNXB.TextChanged += new System.EventHandler(this.tbNXB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 26;
            this.label2.Tag = "";
            this.label2.Text = "Tên sách:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbTenSach
            // 
            this.tbTenSach.Location = new System.Drawing.Point(126, 63);
            this.tbTenSach.Name = "tbTenSach";
            this.tbTenSach.Size = new System.Drawing.Size(328, 27);
            this.tbTenSach.TabIndex = 25;
            this.tbTenSach.TextChanged += new System.EventHandler(this.tbTenSach_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã sách:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbMaSach
            // 
            this.tbMaSach.Location = new System.Drawing.Point(126, 13);
            this.tbMaSach.Name = "tbMaSach";
            this.tbMaSach.Size = new System.Drawing.Size(328, 27);
            this.tbMaSach.TabIndex = 23;
            this.tbMaSach.TextChanged += new System.EventHandler(this.tbMaSach_TextChanged);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(25, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 51);
            this.button3.TabIndex = 22;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(858, 456);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1178, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 51);
            this.button2.TabIndex = 19;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btUpdate.Location = new System.Drawing.Point(289, 318);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(165, 51);
            this.btUpdate.TabIndex = 35;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(25, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 51);
            this.button4.TabIndex = 36;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(289, 418);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 51);
            this.button5.TabIndex = 37;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormSACH
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
            this.Controls.Add(this.tbTenTG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTenSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaSach);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "FormSACH";
            this.Text = "FormSACH";
            this.Load += new System.EventHandler(this.FormSACH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTenTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaSach;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}