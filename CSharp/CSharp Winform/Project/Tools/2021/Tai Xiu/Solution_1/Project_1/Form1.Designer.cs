namespace Project_1
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
            this.cbb_Name = new System.Windows.Forms.ComboBox();
            this.lb_ShowName = new System.Windows.Forms.Label();
            this.pn_top = new System.Windows.Forms.Panel();
            this.cbb_language = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lb_netWork = new System.Windows.Forms.Label();
            this.lb_err1 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_err2 = new System.Windows.Forms.Label();
            this.tb_checking = new System.Windows.Forms.TextBox();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.lb_result = new System.Windows.Forms.Label();
            this.lb_more = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_load = new System.Windows.Forms.Timer(this.components);
            this.bt_spin = new System.Windows.Forms.Button();
            this.timer_wait = new System.Windows.Forms.Timer(this.components);
            this.lb_wait = new System.Windows.Forms.Label();
            this.timer_what = new System.Windows.Forms.Timer(this.components);
            this.lb_mkh = new System.Windows.Forms.Label();
            this.bt_activa = new System.Windows.Forms.Button();
            this.bt_webgame = new System.Windows.Forms.Button();
            this.bt_sub = new System.Windows.Forms.Button();
            this.bt_wov = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.notice = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pn_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_Name
            // 
            this.cbb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Name.ForeColor = System.Drawing.Color.Yellow;
            this.cbb_Name.FormattingEnabled = true;
            this.cbb_Name.Items.AddRange(new object[] {
            "\tGame List",
            "789clup_(789clubvip.com)",
            "B52club_(game.taib52.club)",
            "Bino79_(bino79.club)",
            "Chat79_(chat79.club)",
            "FA88club_(fa88.online)",
            "Gamvip_(gamvip.com)",
            "Go88_(tai.go88vn.vip)",
            "Hen88club_(doithuong.us/play/hen88)",
            "Kingfun_(dangkykingfun.info)",
            "MaCao.Club_(macauclub.fun)",
            "Nhat.Vip_(qc.nhat88.club)",
            "Nổ Hũ_(sieuno.win)",
            "Ric.Win_(dangky.gameric.win)",
            "Rikvip_(rik.vip)",
            "Roy.Vin_(roy.vin)",
            "Sunwin_(sunvn.vip)",
            "Taito_(taito.me)",
            "V8club_(taiv8.us)",
            "Vin.Win_(vin88.vip)",
            "X8club_(qc.x8vn.com)",
            "Yo88_(ad.yo88vn.vip)",
            "Zowin_(lp.zowinvn.vip)"});
            this.cbb_Name.Location = new System.Drawing.Point(0, 27);
            this.cbb_Name.Name = "cbb_Name";
            this.cbb_Name.Size = new System.Drawing.Size(300, 28);
            this.cbb_Name.Sorted = true;
            this.cbb_Name.TabIndex = 0;
            this.cbb_Name.SelectedIndexChanged += new System.EventHandler(this.cbb_Name_SelectedIndexChanged);
            // 
            // lb_ShowName
            // 
            this.lb_ShowName.AutoSize = true;
            this.lb_ShowName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShowName.ForeColor = System.Drawing.Color.White;
            this.lb_ShowName.Location = new System.Drawing.Point(0, 0);
            this.lb_ShowName.Name = "lb_ShowName";
            this.lb_ShowName.Size = new System.Drawing.Size(53, 19);
            this.lb_ShowName.TabIndex = 3;
            this.lb_ShowName.Text = "Name";
            // 
            // pn_top
            // 
            this.pn_top.BackColor = System.Drawing.Color.Gray;
            this.pn_top.Controls.Add(this.cbb_language);
            this.pn_top.Controls.Add(this.textBox4);
            this.pn_top.Controls.Add(this.lb_netWork);
            this.pn_top.Controls.Add(this.lb_err1);
            this.pn_top.Controls.Add(this.lb_status);
            this.pn_top.Controls.Add(this.lb_err2);
            this.pn_top.Controls.Add(this.cbb_Name);
            this.pn_top.Controls.Add(this.lb_ShowName);
            this.pn_top.Controls.Add(this.tb_checking);
            this.pn_top.Controls.Add(this.tb_value);
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top.Location = new System.Drawing.Point(0, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(632, 153);
            this.pn_top.TabIndex = 4;
            // 
            // cbb_language
            // 
            this.cbb_language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_language.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_language.ForeColor = System.Drawing.Color.Yellow;
            this.cbb_language.FormattingEnabled = true;
            this.cbb_language.Location = new System.Drawing.Point(0, 93);
            this.cbb_language.MaxLength = 10;
            this.cbb_language.Name = "cbb_language";
            this.cbb_language.Size = new System.Drawing.Size(300, 27);
            this.cbb_language.TabIndex = 14;
            this.cbb_language.TextChanged += new System.EventHandler(this.cbb_language_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(815, 27);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(61, 26);
            this.textBox4.TabIndex = 111;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lb_netWork
            // 
            this.lb_netWork.AutoSize = true;
            this.lb_netWork.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_netWork.ForeColor = System.Drawing.Color.White;
            this.lb_netWork.Location = new System.Drawing.Point(114, 128);
            this.lb_netWork.Name = "lb_netWork";
            this.lb_netWork.Size = new System.Drawing.Size(77, 16);
            this.lb_netWork.TabIndex = 11;
            this.lb_netWork.Text = "Connected";
            // 
            // lb_err1
            // 
            this.lb_err1.AutoSize = true;
            this.lb_err1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_err1.ForeColor = System.Drawing.Color.White;
            this.lb_err1.Location = new System.Drawing.Point(413, 57);
            this.lb_err1.Name = "lb_err1";
            this.lb_err1.Size = new System.Drawing.Size(72, 17);
            this.lb_err1.TabIndex = 17;
            this.lb_err1.Text = "True/false";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.White;
            this.lb_status.Location = new System.Drawing.Point(0, 128);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(106, 16);
            this.lb_status.TabIndex = 10;
            this.lb_status.Text = "Network Status:";
            // 
            // lb_err2
            // 
            this.lb_err2.AutoSize = true;
            this.lb_err2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_err2.ForeColor = System.Drawing.Color.White;
            this.lb_err2.Location = new System.Drawing.Point(413, 136);
            this.lb_err2.Name = "lb_err2";
            this.lb_err2.Size = new System.Drawing.Size(77, 17);
            this.lb_err2.TabIndex = 225;
            this.lb_err2.Text = "True/False";
            // 
            // tb_checking
            // 
            this.tb_checking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_checking.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_checking.ForeColor = System.Drawing.Color.White;
            this.tb_checking.Location = new System.Drawing.Point(413, 26);
            this.tb_checking.MaxLength = 10;
            this.tb_checking.Multiline = true;
            this.tb_checking.Name = "tb_checking";
            this.tb_checking.Size = new System.Drawing.Size(216, 28);
            this.tb_checking.TabIndex = 16;
            this.tb_checking.Text = "Activation Code";
            this.tb_checking.Enter += new System.EventHandler(this.tb_checking_Enter);
            this.tb_checking.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_checking_KeyDown);
            this.tb_checking.Leave += new System.EventHandler(this.tb_checking_Leave);
            // 
            // tb_value
            // 
            this.tb_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_value.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_value.ForeColor = System.Drawing.Color.White;
            this.tb_value.Location = new System.Drawing.Point(413, 93);
            this.tb_value.MaxLength = 8;
            this.tb_value.Multiline = true;
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(216, 28);
            this.tb_value.TabIndex = 16;
            this.tb_value.Text = "#123xxx";
            this.tb_value.Enter += new System.EventHandler(this.tb_value_Enter);
            this.tb_value.Leave += new System.EventHandler(this.tb_value_Leave);
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.ForeColor = System.Drawing.Color.Red;
            this.lb_result.Location = new System.Drawing.Point(285, 185);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(53, 59);
            this.lb_result.TabIndex = 21;
            this.lb_result.Text = "0";
            // 
            // lb_more
            // 
            this.lb_more.AutoSize = true;
            this.lb_more.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_more.ForeColor = System.Drawing.Color.White;
            this.lb_more.Location = new System.Drawing.Point(291, 244);
            this.lb_more.Name = "lb_more";
            this.lb_more.Size = new System.Drawing.Size(55, 22);
            this.lb_more.TabIndex = 25;
            this.lb_more.Text = "1-2-3";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_load
            // 
            this.timer_load.Interval = 10;
            this.timer_load.Tick += new System.EventHandler(this.timer_load_Tick);
            // 
            // bt_spin
            // 
            this.bt_spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_spin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.bt_spin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_spin.Location = new System.Drawing.Point(448, 244);
            this.bt_spin.Name = "bt_spin";
            this.bt_spin.Size = new System.Drawing.Size(184, 50);
            this.bt_spin.TabIndex = 222;
            this.bt_spin.Text = "Spin";
            this.bt_spin.UseVisualStyleBackColor = false;
            this.bt_spin.Click += new System.EventHandler(this.button9_Click);
            // 
            // timer_wait
            // 
            this.timer_wait.Interval = 1000;
            this.timer_wait.Tick += new System.EventHandler(this.timer_wait_Tick);
            // 
            // lb_wait
            // 
            this.lb_wait.AutoSize = true;
            this.lb_wait.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_wait.Location = new System.Drawing.Point(275, 339);
            this.lb_wait.Name = "lb_wait";
            this.lb_wait.Size = new System.Drawing.Size(145, 19);
            this.lb_wait.TabIndex = 28;
            this.lb_wait.Text = "Wait few second...";
            // 
            // timer_what
            // 
            this.timer_what.Interval = 1;
            this.timer_what.Tick += new System.EventHandler(this.timer_what_Tick);
            // 
            // lb_mkh
            // 
            this.lb_mkh.AutoSize = true;
            this.lb_mkh.BackColor = System.Drawing.Color.Gray;
            this.lb_mkh.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mkh.ForeColor = System.Drawing.Color.White;
            this.lb_mkh.Location = new System.Drawing.Point(413, 74);
            this.lb_mkh.Name = "lb_mkh";
            this.lb_mkh.Size = new System.Drawing.Size(185, 16);
            this.lb_mkh.TabIndex = 223;
            this.lb_mkh.Text = "Bạn chưa có mã kích hoạt ?";
            this.lb_mkh.Click += new System.EventHandler(this.lb_mkh_Click);
            this.lb_mkh.MouseEnter += new System.EventHandler(this.lb_mkh_MouseEnter);
            this.lb_mkh.MouseLeave += new System.EventHandler(this.lb_mkh_MouseLeave);
            // 
            // bt_activa
            // 
            this.bt_activa.Location = new System.Drawing.Point(0, 150);
            this.bt_activa.Name = "bt_activa";
            this.bt_activa.Size = new System.Drawing.Size(184, 34);
            this.bt_activa.TabIndex = 226;
            this.bt_activa.Text = "Activation Code";
            this.bt_activa.UseVisualStyleBackColor = true;
            this.bt_activa.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_webgame
            // 
            this.bt_webgame.Location = new System.Drawing.Point(0, 185);
            this.bt_webgame.Name = "bt_webgame";
            this.bt_webgame.Size = new System.Drawing.Size(184, 34);
            this.bt_webgame.TabIndex = 227;
            this.bt_webgame.Text = "Website Game";
            this.bt_webgame.UseVisualStyleBackColor = true;
            this.bt_webgame.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_sub
            // 
            this.bt_sub.BackColor = System.Drawing.Color.Red;
            this.bt_sub.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bt_sub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bt_sub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bt_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sub.ForeColor = System.Drawing.Color.Black;
            this.bt_sub.Location = new System.Drawing.Point(0, 255);
            this.bt_sub.Name = "bt_sub";
            this.bt_sub.Size = new System.Drawing.Size(184, 34);
            this.bt_sub.TabIndex = 229;
            this.bt_sub.Text = "SUBSCRIBE";
            this.bt_sub.UseVisualStyleBackColor = false;
            this.bt_sub.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_wov
            // 
            this.bt_wov.Location = new System.Drawing.Point(0, 220);
            this.bt_wov.Name = "bt_wov";
            this.bt_wov.Size = new System.Drawing.Size(184, 34);
            this.bt_wov.TabIndex = 228;
            this.bt_wov.Text = "List of Video";
            this.bt_wov.UseVisualStyleBackColor = true;
            this.bt_wov.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 10000;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(185, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(450, 32);
            this.button5.TabIndex = 230;
            this.button5.Text = "=================================================================";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // notice
            // 
            this.notice.Text = "notifyIcon1";
            this.notice.Visible = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(632, 313);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bt_sub);
            this.Controls.Add(this.bt_wov);
            this.Controls.Add(this.bt_webgame);
            this.Controls.Add(this.bt_activa);
            this.Controls.Add(this.lb_mkh);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.lb_more);
            this.Controls.Add(this.lb_wait);
            this.Controls.Add(this.bt_spin);
            this.Controls.Add(this.pn_top);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "T-Multi";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.pn_top.ResumeLayout(false);
            this.pn_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_Name;
        private System.Windows.Forms.Label lb_ShowName;
        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.Label lb_netWork;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tb_checking;
        private System.Windows.Forms.Timer timer_load;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Label lb_more;
        private System.Windows.Forms.Button bt_spin;
        private System.Windows.Forms.Timer timer_wait;
        private System.Windows.Forms.Label lb_wait;
        private Custom_ProGress custom_ProG;
        private System.Windows.Forms.Timer timer_what;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.Label lb_err1;
        private System.Windows.Forms.Label lb_mkh;
        private System.Windows.Forms.Label lb_err2;
        private System.Windows.Forms.Button bt_activa;
        private System.Windows.Forms.Button bt_webgame;
        private System.Windows.Forms.Button bt_sub;
        private System.Windows.Forms.Button bt_wov;
        private System.Windows.Forms.ComboBox cbb_language;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NotifyIcon notice;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

