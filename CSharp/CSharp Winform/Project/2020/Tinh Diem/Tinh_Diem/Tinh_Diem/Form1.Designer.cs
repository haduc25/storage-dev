namespace Tinh_Diem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_result = new System.Windows.Forms.Label();
            this.tb_diem_lop = new System.Windows.Forms.TextBox();
            this.tb_diem_thi = new System.Windows.Forms.TextBox();
            this.tb_checking = new System.Windows.Forms.TextBox();
            this.only_checking = new System.Windows.Forms.Timer(this.components);
            this.lb_tong_ket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.ForeColor = System.Drawing.Color.White;
            this.lb_result.Location = new System.Drawing.Point(12, 82);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(16, 23);
            this.lb_result.TabIndex = 1;
            this.lb_result.Text = " ";
            // 
            // tb_diem_lop
            // 
            this.tb_diem_lop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_diem_lop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diem_lop.ForeColor = System.Drawing.Color.Yellow;
            this.tb_diem_lop.Location = new System.Drawing.Point(11, 34);
            this.tb_diem_lop.MaxLength = 3;
            this.tb_diem_lop.Name = "tb_diem_lop";
            this.tb_diem_lop.Size = new System.Drawing.Size(96, 25);
            this.tb_diem_lop.TabIndex = 2;
            // 
            // tb_diem_thi
            // 
            this.tb_diem_thi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_diem_thi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diem_thi.ForeColor = System.Drawing.Color.Yellow;
            this.tb_diem_thi.Location = new System.Drawing.Point(162, 34);
            this.tb_diem_thi.MaxLength = 3;
            this.tb_diem_thi.Name = "tb_diem_thi";
            this.tb_diem_thi.Size = new System.Drawing.Size(96, 25);
            this.tb_diem_thi.TabIndex = 5;
            // 
            // tb_checking
            // 
            this.tb_checking.Location = new System.Drawing.Point(598, 34);
            this.tb_checking.MaxLength = 3;
            this.tb_checking.Name = "tb_checking";
            this.tb_checking.Size = new System.Drawing.Size(58, 22);
            this.tb_checking.TabIndex = 6;
            this.tb_checking.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // only_checking
            // 
            this.only_checking.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_tong_ket
            // 
            this.lb_tong_ket.AutoSize = true;
            this.lb_tong_ket.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tong_ket.ForeColor = System.Drawing.Color.White;
            this.lb_tong_ket.Location = new System.Drawing.Point(12, 114);
            this.lb_tong_ket.Name = "lb_tong_ket";
            this.lb_tong_ket.Size = new System.Drawing.Size(16, 23);
            this.lb_tong_ket.TabIndex = 7;
            this.lb_tong_ket.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Điểm Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(159, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Điểm Thi";
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_1.ForeColor = System.Drawing.Color.Yellow;
            this.rd_1.Location = new System.Drawing.Point(25, 38);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(100, 21);
            this.rd_1.TabIndex = 15;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "30% - 70%";
            this.rd_1.UseVisualStyleBackColor = true;
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_2.ForeColor = System.Drawing.Color.Yellow;
            this.rd_2.Location = new System.Drawing.Point(25, 85);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(100, 21);
            this.rd_2.TabIndex = 16;
            this.rd_2.TabStop = true;
            this.rd_2.Text = "40% - 60%";
            this.rd_2.UseVisualStyleBackColor = true;
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_3.ForeColor = System.Drawing.Color.Yellow;
            this.rd_3.Location = new System.Drawing.Point(25, 132);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(100, 21);
            this.rd_3.TabIndex = 17;
            this.rd_3.TabStop = true;
            this.rd_3.Text = "50% - 50%";
            this.rd_3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rd_1);
            this.panel1.Controls.Add(this.rd_3);
            this.panel1.Controls.Add(this.rd_2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(264, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 203);
            this.panel1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(414, 203);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_tong_ket);
            this.Controls.Add(this.tb_checking);
            this.Controls.Add(this.tb_diem_thi);
            this.Controls.Add(this.tb_diem_lop);
            this.Controls.Add(this.lb_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Point - Haduc25";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox tb_diem_lop;
        private System.Windows.Forms.TextBox tb_diem_thi;
        private System.Windows.Forms.TextBox tb_checking;
        private System.Windows.Forms.Timer only_checking;
        private System.Windows.Forms.Label lb_tong_ket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rd_1;
        private System.Windows.Forms.RadioButton rd_2;
        private System.Windows.Forms.RadioButton rd_3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}

