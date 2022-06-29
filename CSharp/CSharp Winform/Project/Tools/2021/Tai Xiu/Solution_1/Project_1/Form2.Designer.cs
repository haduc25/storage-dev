
namespace Project_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tm_count = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_name = new System.Windows.Forms.ComboBox();
            this.cbb_sl = new System.Windows.Forms.ComboBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.lb_pay = new System.Windows.Forms.Label();
            this.bt_play = new System.Windows.Forms.Button();
            this.bt_uht = new System.Windows.Forms.Button();
            this.bt_pay = new System.Windows.Forms.Button();
            this.bt_momo = new System.Windows.Forms.Button();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.tb_magiaodich = new System.Windows.Forms.TextBox();
            this.lb_mgg = new System.Windows.Forms.Label();
            this.lb_attention = new System.Windows.Forms.Label();
            this.bt_cp = new System.Windows.Forms.Button();
            this.tb_node = new System.Windows.Forms.TextBox();
            this.cbb_nhacungcap = new System.Windows.Forms.ComboBox();
            this.tb_seri = new System.Windows.Forms.TextBox();
            this.tb_mathe = new System.Windows.Forms.TextBox();
            this.cbb_menhgia = new System.Windows.Forms.ComboBox();
            this.pn_card = new System.Windows.Forms.Panel();
            this.bt_card = new System.Windows.Forms.Button();
            this.bt_tuto = new System.Windows.Forms.Button();
            this.bt_atten = new System.Windows.Forms.Button();
            this.bt_more = new System.Windows.Forms.Button();
            this.bt_video = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_lang = new System.Windows.Forms.Button();
            this.pn_card.SuspendLayout();
            this.SuspendLayout();
            // 
            // tm_count
            // 
            this.tm_count.Interval = 500;
            this.tm_count.Tick += new System.EventHandler(this.tm_count_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 23;
            // 
            // cbb_name
            // 
            this.cbb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbb_name.ForeColor = System.Drawing.Color.Yellow;
            this.cbb_name.FormattingEnabled = true;
            this.cbb_name.Items.AddRange(new object[] {
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
            this.cbb_name.Location = new System.Drawing.Point(12, 12);
            this.cbb_name.Name = "cbb_name";
            this.cbb_name.Size = new System.Drawing.Size(258, 28);
            this.cbb_name.Sorted = true;
            this.cbb_name.TabIndex = 0;
            this.cbb_name.SelectedIndexChanged += new System.EventHandler(this.cbb_name_SelectedIndexChanged);
            // 
            // cbb_sl
            // 
            this.cbb_sl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sl.FormattingEnabled = true;
            this.cbb_sl.Items.AddRange(new object[] {
            "1. 20 Lượt Quay",
            "2. 50 Lượt Quay (+10 Lượt Quay)",
            "3. Không Giới Hạn Số Lượt Quay"});
            this.cbb_sl.Location = new System.Drawing.Point(12, 53);
            this.cbb_sl.Name = "cbb_sl";
            this.cbb_sl.Size = new System.Drawing.Size(258, 24);
            this.cbb_sl.TabIndex = 1;
            this.cbb_sl.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(300, 12);
            this.tb_price.Name = "tb_price";
            this.tb_price.ReadOnly = true;
            this.tb_price.ShortcutsEnabled = false;
            this.tb_price.Size = new System.Drawing.Size(161, 22);
            this.tb_price.TabIndex = 2;
            // 
            // lb_pay
            // 
            this.lb_pay.AutoSize = true;
            this.lb_pay.Location = new System.Drawing.Point(12, 117);
            this.lb_pay.Name = "lb_pay";
            this.lb_pay.Size = new System.Drawing.Size(160, 17);
            this.lb_pay.TabIndex = 3;
            this.lb_pay.Text = "Phương thức thanh toán";
            // 
            // bt_play
            // 
            this.bt_play.Location = new System.Drawing.Point(12, 220);
            this.bt_play.Name = "bt_play";
            this.bt_play.Size = new System.Drawing.Size(203, 33);
            this.bt_play.TabIndex = 4;
            this.bt_play.Text = "PlayerDuo";
            this.bt_play.UseVisualStyleBackColor = true;
            this.bt_play.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_uht
            // 
            this.bt_uht.Location = new System.Drawing.Point(12, 260);
            this.bt_uht.Name = "bt_uht";
            this.bt_uht.Size = new System.Drawing.Size(203, 33);
            this.bt_uht.TabIndex = 5;
            this.bt_uht.Text = "Ung Ho Toi";
            this.bt_uht.UseVisualStyleBackColor = true;
            this.bt_uht.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_pay
            // 
            this.bt_pay.Location = new System.Drawing.Point(66, 177);
            this.bt_pay.Name = "bt_pay";
            this.bt_pay.Size = new System.Drawing.Size(161, 33);
            this.bt_pay.TabIndex = 13;
            this.bt_pay.Text = "Pay";
            this.bt_pay.UseVisualStyleBackColor = true;
            this.bt_pay.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_momo
            // 
            this.bt_momo.Location = new System.Drawing.Point(12, 180);
            this.bt_momo.Name = "bt_momo";
            this.bt_momo.Size = new System.Drawing.Size(203, 33);
            this.bt_momo.TabIndex = 15;
            this.bt_momo.Text = "Momo";
            this.bt_momo.UseVisualStyleBackColor = true;
            this.bt_momo.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_count
            // 
            this.tb_count.Location = new System.Drawing.Point(893, 15);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(46, 22);
            this.tb_count.TabIndex = 18;
            this.tb_count.Text = "count";
            // 
            // tb_magiaodich
            // 
            this.tb_magiaodich.Location = new System.Drawing.Point(300, 55);
            this.tb_magiaodich.MaxLength = 15;
            this.tb_magiaodich.Multiline = true;
            this.tb_magiaodich.Name = "tb_magiaodich";
            this.tb_magiaodich.Size = new System.Drawing.Size(161, 22);
            this.tb_magiaodich.TabIndex = 16;
            this.tb_magiaodich.TextChanged += new System.EventHandler(this.tb_note_TextChanged);
            // 
            // lb_mgg
            // 
            this.lb_mgg.AutoSize = true;
            this.lb_mgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lb_mgg.Location = new System.Drawing.Point(297, 37);
            this.lb_mgg.Name = "lb_mgg";
            this.lb_mgg.Size = new System.Drawing.Size(93, 17);
            this.lb_mgg.TabIndex = 22;
            this.lb_mgg.Text = "Mã Giao Dịch";
            // 
            // lb_attention
            // 
            this.lb_attention.AutoSize = true;
            this.lb_attention.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_attention.ForeColor = System.Drawing.Color.Red;
            this.lb_attention.Location = new System.Drawing.Point(246, 307);
            this.lb_attention.Name = "lb_attention";
            this.lb_attention.Size = new System.Drawing.Size(12, 15);
            this.lb_attention.TabIndex = 24;
            this.lb_attention.Text = "*";
            // 
            // bt_cp
            // 
            this.bt_cp.Location = new System.Drawing.Point(467, 55);
            this.bt_cp.Name = "bt_cp";
            this.bt_cp.Size = new System.Drawing.Size(164, 33);
            this.bt_cp.TabIndex = 26;
            this.bt_cp.Text = "Sao Chép";
            this.bt_cp.UseVisualStyleBackColor = true;
            this.bt_cp.Click += new System.EventHandler(this.button6_Click);
            // 
            // tb_node
            // 
            this.tb_node.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_node.ForeColor = System.Drawing.Color.Silver;
            this.tb_node.Location = new System.Drawing.Point(66, 128);
            this.tb_node.Multiline = true;
            this.tb_node.Name = "tb_node";
            this.tb_node.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_node.Size = new System.Drawing.Size(161, 42);
            this.tb_node.TabIndex = 17;
            this.tb_node.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_node_MouseClick);
            this.tb_node.Enter += new System.EventHandler(this.tb_node_Enter);
            this.tb_node.Leave += new System.EventHandler(this.tb_node_Leave);
            // 
            // cbb_nhacungcap
            // 
            this.cbb_nhacungcap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nhacungcap.FormattingEnabled = true;
            this.cbb_nhacungcap.Items.AddRange(new object[] {
            "Chọn Nhà Cung Cấp",
            "Viettel",
            "Vinaphone",
            "Mobifone"});
            this.cbb_nhacungcap.Location = new System.Drawing.Point(66, 10);
            this.cbb_nhacungcap.Name = "cbb_nhacungcap";
            this.cbb_nhacungcap.Size = new System.Drawing.Size(161, 24);
            this.cbb_nhacungcap.TabIndex = 11;
            this.cbb_nhacungcap.SelectedIndexChanged += new System.EventHandler(this.cbb_nhacungcap_SelectedIndexChanged);
            // 
            // tb_seri
            // 
            this.tb_seri.ForeColor = System.Drawing.Color.Silver;
            this.tb_seri.Location = new System.Drawing.Point(66, 72);
            this.tb_seri.MaxLength = 12;
            this.tb_seri.Name = "tb_seri";
            this.tb_seri.Size = new System.Drawing.Size(161, 22);
            this.tb_seri.TabIndex = 9;
            this.tb_seri.Text = "Nhập Số Seri";
            this.tb_seri.Enter += new System.EventHandler(this.tb_seri_Enter);
            this.tb_seri.Leave += new System.EventHandler(this.tb_seri_Leave);
            // 
            // tb_mathe
            // 
            this.tb_mathe.ForeColor = System.Drawing.Color.Silver;
            this.tb_mathe.Location = new System.Drawing.Point(66, 100);
            this.tb_mathe.MaxLength = 12;
            this.tb_mathe.Name = "tb_mathe";
            this.tb_mathe.Size = new System.Drawing.Size(161, 22);
            this.tb_mathe.TabIndex = 10;
            this.tb_mathe.Text = "Nhập Mã Thẻ";
            this.tb_mathe.Enter += new System.EventHandler(this.tb_mathe_Enter);
            this.tb_mathe.Leave += new System.EventHandler(this.tb_mathe_Leave);
            // 
            // cbb_menhgia
            // 
            this.cbb_menhgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_menhgia.FormattingEnabled = true;
            this.cbb_menhgia.Items.AddRange(new object[] {
            "Mệnh Giá Thẻ Nạp",
            "10.000đ",
            "20.000đ",
            "30.000đ",
            "50.000đ",
            "100.000đ",
            "200.000đ",
            "300.000đ",
            "500.000đ"});
            this.cbb_menhgia.Location = new System.Drawing.Point(66, 42);
            this.cbb_menhgia.Name = "cbb_menhgia";
            this.cbb_menhgia.Size = new System.Drawing.Size(161, 24);
            this.cbb_menhgia.TabIndex = 12;
            this.cbb_menhgia.SelectedIndexChanged += new System.EventHandler(this.cbb_menhgia_SelectedIndexChanged);
            // 
            // pn_card
            // 
            this.pn_card.Controls.Add(this.cbb_menhgia);
            this.pn_card.Controls.Add(this.tb_mathe);
            this.pn_card.Controls.Add(this.tb_seri);
            this.pn_card.Controls.Add(this.cbb_nhacungcap);
            this.pn_card.Controls.Add(this.tb_node);
            this.pn_card.Controls.Add(this.bt_pay);
            this.pn_card.Location = new System.Drawing.Point(233, 83);
            this.pn_card.Name = "pn_card";
            this.pn_card.Size = new System.Drawing.Size(233, 218);
            this.pn_card.TabIndex = 27;
            this.pn_card.Visible = false;
            // 
            // bt_card
            // 
            this.bt_card.Location = new System.Drawing.Point(12, 140);
            this.bt_card.Name = "bt_card";
            this.bt_card.Size = new System.Drawing.Size(203, 33);
            this.bt_card.TabIndex = 28;
            this.bt_card.Text = "Thẻ Cào";
            this.bt_card.UseVisualStyleBackColor = true;
            this.bt_card.Click += new System.EventHandler(this.bt_card_Click);
            // 
            // bt_tuto
            // 
            this.bt_tuto.Location = new System.Drawing.Point(467, 98);
            this.bt_tuto.Name = "bt_tuto";
            this.bt_tuto.Size = new System.Drawing.Size(164, 33);
            this.bt_tuto.TabIndex = 32;
            this.bt_tuto.Text = "Hướng Dẫn";
            this.bt_tuto.UseVisualStyleBackColor = true;
            this.bt_tuto.Click += new System.EventHandler(this.bt_tuto_Click);
            // 
            // bt_atten
            // 
            this.bt_atten.Location = new System.Drawing.Point(467, 141);
            this.bt_atten.Name = "bt_atten";
            this.bt_atten.Size = new System.Drawing.Size(164, 33);
            this.bt_atten.TabIndex = 33;
            this.bt_atten.Text = "Chú Ý";
            this.bt_atten.UseVisualStyleBackColor = true;
            this.bt_atten.Click += new System.EventHandler(this.bt_atten_Click);
            // 
            // bt_more
            // 
            this.bt_more.Location = new System.Drawing.Point(467, 184);
            this.bt_more.Name = "bt_more";
            this.bt_more.Size = new System.Drawing.Size(164, 33);
            this.bt_more.TabIndex = 34;
            this.bt_more.Text = "Thêm";
            this.bt_more.UseVisualStyleBackColor = true;
            this.bt_more.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // bt_video
            // 
            this.bt_video.Location = new System.Drawing.Point(467, 227);
            this.bt_video.Name = "bt_video";
            this.bt_video.Size = new System.Drawing.Size(164, 33);
            this.bt_video.TabIndex = 35;
            this.bt_video.Text = "Video";
            this.bt_video.UseVisualStyleBackColor = true;
            this.bt_video.Visible = false;
            this.bt_video.Click += new System.EventHandler(this.bt_video_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(467, 270);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(164, 33);
            this.bt_exit.TabIndex = 36;
            this.bt_exit.Text = "Thoát";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Visible = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_lang
            // 
            this.bt_lang.Location = new System.Drawing.Point(467, 12);
            this.bt_lang.Name = "bt_lang";
            this.bt_lang.Size = new System.Drawing.Size(164, 33);
            this.bt_lang.TabIndex = 37;
            this.bt_lang.Text = "Vietnamese";
            this.bt_lang.UseVisualStyleBackColor = true;
            this.bt_lang.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 303);
            this.Controls.Add(this.bt_lang);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_video);
            this.Controls.Add(this.bt_more);
            this.Controls.Add(this.bt_atten);
            this.Controls.Add(this.bt_tuto);
            this.Controls.Add(this.bt_card);
            this.Controls.Add(this.pn_card);
            this.Controls.Add(this.bt_cp);
            this.Controls.Add(this.lb_attention);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_mgg);
            this.Controls.Add(this.tb_magiaodich);
            this.Controls.Add(this.tb_count);
            this.Controls.Add(this.bt_momo);
            this.Controls.Add(this.bt_uht);
            this.Controls.Add(this.bt_play);
            this.Controls.Add(this.lb_pay);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.cbb_sl);
            this.Controls.Add(this.cbb_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pn_card.ResumeLayout(false);
            this.pn_card.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tm_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_name;
        private System.Windows.Forms.ComboBox cbb_sl;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label lb_pay;
        private System.Windows.Forms.Button bt_play;
        private System.Windows.Forms.Button bt_uht;
        private System.Windows.Forms.Button bt_pay;
        private System.Windows.Forms.Button bt_momo;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.TextBox tb_magiaodich;
        private System.Windows.Forms.Label lb_mgg;
        private System.Windows.Forms.Label lb_attention;
        private System.Windows.Forms.Button bt_cp;
        private System.Windows.Forms.TextBox tb_node;
        private System.Windows.Forms.ComboBox cbb_nhacungcap;
        private System.Windows.Forms.TextBox tb_seri;
        private System.Windows.Forms.TextBox tb_mathe;
        private System.Windows.Forms.ComboBox cbb_menhgia;
        private System.Windows.Forms.Panel pn_card;
        private System.Windows.Forms.Button bt_card;
        private System.Windows.Forms.Button bt_tuto;
        private System.Windows.Forms.Button bt_atten;
        private System.Windows.Forms.Button bt_more;
        private System.Windows.Forms.Button bt_video;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_lang;
    }
}