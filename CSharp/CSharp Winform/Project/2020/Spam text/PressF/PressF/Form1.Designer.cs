namespace PressF
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
            this.bt_on = new System.Windows.Forms.Button();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.bt_off = new System.Windows.Forms.Button();
            this.timer_auto = new System.Windows.Forms.Timer(this.components);
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_text = new System.Windows.Forms.Label();
            this.lb_controls = new System.Windows.Forms.Label();
            this.lb_interval = new System.Windows.Forms.Label();
            this.tb_interval = new System.Windows.Forms.TextBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.tb_checking = new System.Windows.Forms.TextBox();
            this.timer_check = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_mode = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_temp = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_on
            // 
            this.bt_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_on.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_on.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_on.ForeColor = System.Drawing.Color.Black;
            this.bt_on.Location = new System.Drawing.Point(480, 22);
            this.bt_on.Name = "bt_on";
            this.bt_on.Size = new System.Drawing.Size(87, 34);
            this.bt_on.TabIndex = 0;
            this.bt_on.Text = "On";
            this.bt_on.UseVisualStyleBackColor = false;
            this.bt_on.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_text
            // 
            this.tb_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_text.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_text.ForeColor = System.Drawing.Color.Yellow;
            this.tb_text.Location = new System.Drawing.Point(0, 22);
            this.tb_text.Multiline = true;
            this.tb_text.Name = "tb_text";
            this.tb_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_text.Size = new System.Drawing.Size(475, 230);
            this.tb_text.TabIndex = 1;
            // 
            // bt_off
            // 
            this.bt_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_off.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_off.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_off.Location = new System.Drawing.Point(480, 62);
            this.bt_off.Name = "bt_off";
            this.bt_off.Size = new System.Drawing.Size(87, 34);
            this.bt_off.TabIndex = 2;
            this.bt_off.Text = "Off";
            this.bt_off.UseVisualStyleBackColor = false;
            this.bt_off.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer_auto
            // 
            this.timer_auto.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.Color.Red;
            this.lb_time.Location = new System.Drawing.Point(480, 108);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(106, 17);
            this.lb_time.TabIndex = 4;
            this.lb_time.Text = "Time: Seconds";
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_text.ForeColor = System.Drawing.Color.Red;
            this.lb_text.Location = new System.Drawing.Point(0, 0);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(123, 19);
            this.lb_text.TabIndex = 6;
            this.lb_text.Text = "Text and Mode";
            // 
            // lb_controls
            // 
            this.lb_controls.AutoSize = true;
            this.lb_controls.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_controls.ForeColor = System.Drawing.Color.Red;
            this.lb_controls.Location = new System.Drawing.Point(480, 3);
            this.lb_controls.Name = "lb_controls";
            this.lb_controls.Size = new System.Drawing.Size(77, 19);
            this.lb_controls.TabIndex = 6;
            this.lb_controls.Text = "Controls";
            // 
            // lb_interval
            // 
            this.lb_interval.AutoSize = true;
            this.lb_interval.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_interval.ForeColor = System.Drawing.Color.Red;
            this.lb_interval.Location = new System.Drawing.Point(481, 173);
            this.lb_interval.Name = "lb_interval";
            this.lb_interval.Size = new System.Drawing.Size(54, 17);
            this.lb_interval.TabIndex = 8;
            this.lb_interval.Text = "Interval";
            // 
            // tb_interval
            // 
            this.tb_interval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_interval.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_interval.ForeColor = System.Drawing.Color.Yellow;
            this.tb_interval.Location = new System.Drawing.Point(481, 193);
            this.tb_interval.MaxLength = 10;
            this.tb_interval.Multiline = true;
            this.tb_interval.Name = "tb_interval";
            this.tb_interval.Size = new System.Drawing.Size(99, 30);
            this.tb_interval.TabIndex = 7;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.Red;
            this.lb_status.Location = new System.Drawing.Point(480, 226);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(0, 19);
            this.lb_status.TabIndex = 9;
            // 
            // tb_checking
            // 
            this.tb_checking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_checking.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_checking.ForeColor = System.Drawing.Color.Yellow;
            this.tb_checking.Location = new System.Drawing.Point(747, 22);
            this.tb_checking.MaxLength = 10;
            this.tb_checking.Multiline = true;
            this.tb_checking.Name = "tb_checking";
            this.tb_checking.Size = new System.Drawing.Size(69, 34);
            this.tb_checking.TabIndex = 10;
            this.tb_checking.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer_check
            // 
            this.timer_check.Interval = 1000;
            this.timer_check.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.cb_mode);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tb_temp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 48);
            this.panel2.TabIndex = 12;
            // 
            // cb_mode
            // 
            this.cb_mode.AutoSize = true;
            this.cb_mode.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cb_mode.Location = new System.Drawing.Point(212, 22);
            this.cb_mode.Name = "cb_mode";
            this.cb_mode.Size = new System.Drawing.Size(18, 17);
            this.cb_mode.TabIndex = 7;
            this.cb_mode.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(239, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_temp
            // 
            this.tb_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_temp.Font = new System.Drawing.Font("Arial", 10.2F);
            this.tb_temp.ForeColor = System.Drawing.Color.Yellow;
            this.tb_temp.Location = new System.Drawing.Point(-1, 14);
            this.tb_temp.Multiline = true;
            this.tb_temp.Name = "tb_temp";
            this.tb_temp.Size = new System.Drawing.Size(207, 30);
            this.tb_temp.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.tb_text);
            this.panel1.Controls.Add(this.lb_text);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 252);
            this.panel1.TabIndex = 0;
            // 
            // tb_time
            // 
            this.tb_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_time.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_time.ForeColor = System.Drawing.Color.Yellow;
            this.tb_time.Location = new System.Drawing.Point(481, 128);
            this.tb_time.MaxLength = 10;
            this.tb_time.Multiline = true;
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(99, 30);
            this.tb_time.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(860, 300);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tb_checking);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_interval);
            this.Controls.Add(this.tb_interval);
            this.Controls.Add(this.lb_controls);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.bt_off);
            this.Controls.Add(this.bt_on);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_on;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.Button bt_off;
        private System.Windows.Forms.Timer timer_auto;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.Label lb_controls;
        private System.Windows.Forms.Label lb_interval;
        private System.Windows.Forms.TextBox tb_interval;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.TextBox tb_checking;
        private System.Windows.Forms.Timer timer_check;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_temp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.CheckBox cb_mode;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Timer timer1;
    }
}

