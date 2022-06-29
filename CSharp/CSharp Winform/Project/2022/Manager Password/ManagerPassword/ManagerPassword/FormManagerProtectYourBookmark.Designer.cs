namespace ManagerPassword
{
    partial class FormManagerProtectYourBookmark
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSM = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lbUrl = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCategories = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCategories = new System.Windows.Forms.ComboBox();
            this.cbbMXH = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbVsb = new System.Windows.Forms.ComboBox();
            this.lbVisible = new System.Windows.Forms.Label();
            this.cbbVisible = new System.Windows.Forms.ComboBox();
            this.lbUpdated = new System.Windows.Forms.Label();
            this.lbCreated = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.txtDePass = new System.Windows.Forms.TextBox();
            this.txtEnPass = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(9, 48);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(59, 27);
            this.txtID.TabIndex = 11;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNote.Location = new System.Drawing.Point(9, 442);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(470, 113);
            this.txtNote.TabIndex = 7;
            this.txtNote.Click += new System.EventHandler(this.txtNote_Click);
            this.txtNote.Leave += new System.EventHandler(this.txtNote_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Note";
            // 
            // txtSM
            // 
            this.txtSM.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSM.Location = new System.Drawing.Point(282, 100);
            this.txtSM.Multiline = true;
            this.txtSM.Name = "txtSM";
            this.txtSM.ReadOnly = true;
            this.txtSM.Size = new System.Drawing.Size(197, 30);
            this.txtSM.TabIndex = 1;
            this.txtSM.Click += new System.EventHandler(this.txtSM_Click);
            this.txtSM.TextChanged += new System.EventHandler(this.txtSM_TextChanged);
            this.txtSM.Leave += new System.EventHandler(this.txtSM_Leave);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Location = new System.Drawing.Point(6, 26);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(205, 35);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "The Loai";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUrl.Location = new System.Drawing.Point(13, 209);
            this.txtUrl.MaxLength = 5000;
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUrl.Size = new System.Drawing.Size(466, 163);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.Click += new System.EventHandler(this.txtPwd_Click);
            this.txtUrl.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUrl.Location = new System.Drawing.Point(9, 187);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(55, 19);
            this.lbUrl.TabIndex = 3;
            this.lbUrl.Text = "Url (0)";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(466, 30);
            this.button3.TabIndex = 16;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbStatus);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtCategories);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbCategories);
            this.groupBox1.Controls.Add(this.cbbMXH);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lbUrl);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtUrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 716);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Status";
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Chưa xem",
            "Đã xem",
            "Đang xem",
            "Đang xem dở",
            "Other..."});
            this.cbbStatus.Location = new System.Drawing.Point(13, 157);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(254, 27);
            this.cbbStatus.TabIndex = 27;
            this.cbbStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStatus.Location = new System.Drawing.Point(282, 154);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(197, 30);
            this.txtStatus.TabIndex = 26;
            this.txtStatus.Click += new System.EventHandler(this.txtStatus_Click);
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // txtCategories
            // 
            this.txtCategories.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategories.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCategories.Location = new System.Drawing.Point(282, 48);
            this.txtCategories.Multiline = true;
            this.txtCategories.Name = "txtCategories";
            this.txtCategories.ReadOnly = true;
            this.txtCategories.Size = new System.Drawing.Size(197, 30);
            this.txtCategories.TabIndex = 25;
            this.txtCategories.Click += new System.EventHandler(this.txtCategories_Click);
            this.txtCategories.TextChanged += new System.EventHandler(this.txtCategories_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "MXH";
            // 
            // cbbCategories
            // 
            this.cbbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategories.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategories.FormattingEnabled = true;
            this.cbbCategories.Items.AddRange(new object[] {
            "Android - Mod, Cracked",
            "Android - Xiaomi",
            "English",
            "Fake Cards",
            "Fun, Relax, Chill",
            "Games",
            "License Key",
            "Momo",
            "Movie",
            "Music",
            "Programing",
            "Sale & Products",
            "Tai lieu MH",
            "Technology",
            "Tips & Trick - Dev",
            "Tools - Dev",
            "Wallpapers",
            "Wiki",
            "XXX<== [Other] ===>XXX"});
            this.cbbCategories.Location = new System.Drawing.Point(77, 48);
            this.cbbCategories.Name = "cbbCategories";
            this.cbbCategories.Size = new System.Drawing.Size(190, 27);
            this.cbbCategories.Sorted = true;
            this.cbbCategories.TabIndex = 23;
            this.cbbCategories.SelectedIndexChanged += new System.EventHandler(this.cbbCategories_SelectedIndexChanged);
            // 
            // cbbMXH
            // 
            this.cbbMXH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMXH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMXH.FormattingEnabled = true;
            this.cbbMXH.Items.AddRange(new object[] {
            "247phim.com",
            "Aidn.jp",
            "Alternativeto.net",
            "Anhngumshoa.com",
            "Anonfiles.com",
            "Anotepad.com",
            "Any-api.com",
            "Apkcombo.com",
            "Apkdone.com",
            "Apkplay.io",
            "Apkpure.com",
            "Behance.net",
            "Benative.vn",
            "Bitly.com",
            "Blogger.com",
            "Blogspot.com",
            "Bootstrapcdn.com",
            "Brandcrowd.com",
            "C-Sharpcorner.com",
            "Cachhoc.net",
            "Calculator.net",
            "Capitalizemytitle.com",
            "Chamcode.net",
            "Checkip.dyndns.org",
            "Chrome://flags",
            "Cineb.net",
            "Cloudflare.com",
            "Cnttqn.com",
            "Code24h.com",
            "Codecademy.com",
            "Codeproject.com",
            "Coggle.it",
            "Colorme.vn",
            "Congnghe5s.com",
            "Creditcardvalidator.org",
            "Cuongblhs.blogspot.com",
            "Daynhauhoc.com",
            "Designbombs.com",
            "Desktophut.com",
            "Developers.google.com",
            "Developers.google.com",
            "Deviantart.com",
            "Dictionary.cambridge.org",
            "Digistar.vn",
            "Dnsdumpster.com",
            "Docs.google.com",
            "Dolenglish.vn",
            "Dotnetfunda.com",
            "Drive.google.com",
            "Dropbox.com",
            "Edugate.vn",
            "Englishclub.com",
            "Eslprintables.com",
            "Examenglish.com",
            "Facebook",
            "Fast.com",
            "Fastly.com",
            "Fatherly.com",
            "Flaticon.com",
            "Fontawesome.com",
            "Fontawesome.com",
            "Fonts.google.com",
            "Fptshop.com.vn",
            "Freecodecamp.org",
            "Freelogodesign.org",
            "Freenom.com",
            "Freepik.com",
            "Fshare.vn",
            "Fullstack.edu.vn",
            "Geeksforgeeks.org",
            "Getwallpapers.com",
            "Giasoc24h.com",
            "Giasutainha24h.com",
            "Github.com",
            "Glosbe.com",
            "Gocinfo.com",
            "Gocmod.com",
            "Goodfon.com",
            "Gtmetrix.com",
            "Guru99.com",
            "Gvn360.com",
            "Hatchful.shopify.com",
            "Hongkiat.com",
            "Howkteam.vn",
            "Icon-icons.com",
            "Idoceonline.com",
            "Iievietnam.org",
            "Inception.fandom.com",
            "IP-tracker.org",
            "Ipchicken.com",
            "Iplocation.com",
            "Iplocation.net",
            "Italki.com",
            "Itsourcecode.com",
            "Khoapham.vn",
            "Kienthuc24h.com",
            "Kimlongcenter.com",
            "Langmaster.edu.vn",
            "Laptopaz.vn",
            "Lenovo.com",
            "llv.edu.vn",
            "Logogenie.net",
            "Medal.tv",
            "Megacooltext.com",
            "Mephimmy.com",
            "Mifirm.net",
            "Minhng.info",
            "Motchill.net",
            "Motphimtv.com",
            "Mphimmoitv.net",
            "Muathe123.vn",
            "Myaccount.google.com",
            "Myenglishpages.com",
            "Napthengay.vn",
            "Nguyenvanhieu.vn",
            "Nhacdj.vn",
            "Nhanhoa.com",
            "Nhantien.momo.vn",
            "Ninite.com",
            "Notebookcheck.net",
            "Novocom.club",
            "Onlinegdb.com",
            "Ostonline.net",
            "Owasp.org",
            "Oxford.edu.vn",
            "Oxfordlearnersdictionaries.com",
            "Oxfordlearnersdictionaries.com",
            "Pagespeed.web.dev",
            "Pay.zing.vn",
            "Pdftoword.com",
            "Pexels.com",
            "Phimvietsub.tv",
            "Platinmods.com",
            "Playphrase.me",
            "Quantrimang.com",
            "Quizlet.com",
            "Raidforums.com",
            "Rapidtables.com",
            "Regex101.com",
            "Reqres.in",
            "Ryte.com",
            "Sachhoc.com",
            "Savefrom.net",
            "Share.zendvn.com",
            "Shopgiayreplica.com",
            "Similarweb.com",
            "Sinhvientot.net",
            "Sitepoint.com",
            "Sites.google.com",
            "Slidesgo.com",
            "Socialblade.com",
            "Socradar.io",
            "Softwaretestinghelp.com",
            "Sosanhgia.com",
            "Ssphim.net",
            "Stackoverflow.com",
            "Stdio.vn",
            "Stepup.edu.vn",
            "Stepup.edu.vn",
            "Studytienganh.vn",
            "Suntrustblog.com",
            "T.me",
            "Thachpham.com",
            "Theenglishspace.com",
            "Thehackernews.com",
            "Thenewsmexico.com",
            "Thuthuatphanmem.vn",
            "Tienminhvy.com",
            "Tinyzonetv.to",
            "Tools1s.com",
            "Topdev.vn",
            "Truongcb.hochiminhcity.gov.vn",
            "Tutsplus.com",
            "Unica.vn",
            "Unscreen.com",
            "Unsplash.com",
            "Users.soict.hust.edu.vn",
            "Viblo.asia",
            "Vieclam123.vn",
            "Vietjack.com",
            "Visme.co",
            "Vn-z.vn",
            "Voca.vn",
            "Vphimzz.net",
            "W3.org",
            "W3resource.com",
            "W3schools.com",
            "Wall.alphacoders.com",
            "Wallhaven.cc",
            "Wallpaperaccess.com",
            "Wallpaperflare.com",
            "Wallpapershome.com",
            "Wallpaperswide.com",
            "Wattpad.com",
            "Whatismyipaddress.com",
            "Whitehat.vn",
            "Wikipedia.org",
            "Xemphim.fun",
            "Xiconeditor.com",
            "Xuanthulab.net",
            "Y2mate.com",
            "Ymusic.io",
            "Youtube",
            "ZZZ<== [Other] ===>ZZZ"});
            this.cbbMXH.Location = new System.Drawing.Point(13, 103);
            this.cbbMXH.Name = "cbbMXH";
            this.cbbMXH.Size = new System.Drawing.Size(254, 27);
            this.cbbMXH.Sorted = true;
            this.cbbMXH.TabIndex = 22;
            this.cbbMXH.SelectedIndexChanged += new System.EventHandler(this.cbbMXH_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 562);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 151);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính năng";
            // 
            // button10
            // 
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(217, 108);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(205, 35);
            this.button10.TabIndex = 17;
            this.button10.Text = "Exit";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(217, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(205, 35);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Edit (Update)";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(217, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 35);
            this.button5.TabIndex = 14;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(6, 67);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(205, 35);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.Location = new System.Drawing.Point(367, 464);
            this.txtSearch.MaxLength = 10000;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(515, 27);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(300, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Search";
            // 
            // cbbSearch
            // 
            this.cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "ID",
            "Categories",
            "Social Media",
            "Url",
            "Note",
            "Status"});
            this.cbbSearch.Location = new System.Drawing.Point(6, 464);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(275, 27);
            this.cbbSearch.TabIndex = 17;
            this.cbbSearch.SelectedIndexChanged += new System.EventHandler(this.cbbSearch_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(10, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Advanced";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbVsb);
            this.groupBox3.Controls.Add(this.lbVisible);
            this.groupBox3.Controls.Add(this.cbbVisible);
            this.groupBox3.Controls.Add(this.lbUpdated);
            this.groupBox3.Controls.Add(this.lbCreated);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.cbbSearch);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(522, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(942, 716);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bookmark Protected";
            // 
            // cbbVsb
            // 
            this.cbbVsb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVsb.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbVsb.FormattingEnabled = true;
            this.cbbVsb.Items.AddRange(new object[] {
            "Public (0)",
            "Private (1)"});
            this.cbbVsb.Location = new System.Drawing.Point(367, 504);
            this.cbbVsb.Name = "cbbVsb";
            this.cbbVsb.Size = new System.Drawing.Size(145, 27);
            this.cbbVsb.TabIndex = 24;
            // 
            // lbVisible
            // 
            this.lbVisible.AutoSize = true;
            this.lbVisible.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVisible.Location = new System.Drawing.Point(300, 512);
            this.lbVisible.Name = "lbVisible";
            this.lbVisible.Size = new System.Drawing.Size(57, 19);
            this.lbVisible.TabIndex = 23;
            this.lbVisible.Text = "Visible";
            // 
            // cbbVisible
            // 
            this.cbbVisible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVisible.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbVisible.FormattingEnabled = true;
            this.cbbVisible.Items.AddRange(new object[] {
            "Public",
            "Private"});
            this.cbbVisible.Location = new System.Drawing.Point(607, 504);
            this.cbbVisible.Name = "cbbVisible";
            this.cbbVisible.Size = new System.Drawing.Size(275, 27);
            this.cbbVisible.TabIndex = 22;
            this.cbbVisible.SelectedIndexChanged += new System.EventHandler(this.cbbVisible_SelectedIndexChanged);
            // 
            // lbUpdated
            // 
            this.lbUpdated.AutoSize = true;
            this.lbUpdated.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdated.Location = new System.Drawing.Point(9, 527);
            this.lbUpdated.Name = "lbUpdated";
            this.lbUpdated.Size = new System.Drawing.Size(74, 19);
            this.lbUpdated.TabIndex = 21;
            this.lbUpdated.Text = "Updated:";
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreated.Location = new System.Drawing.Point(9, 504);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(77, 19);
            this.lbCreated.TabIndex = 20;
            this.lbCreated.Text = "Created: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.txtDePass);
            this.groupBox4.Controls.Add(this.txtEnPass);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 562);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(936, 151);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nâng cao";
            // 
            // button11
            // 
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(10, 102);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(285, 35);
            this.button11.TabIndex = 31;
            this.button11.Text = "Clear Log";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(404, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "Decrypt:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(404, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Encrypt:";
            // 
            // button9
            // 
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(780, 107);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 35);
            this.button9.TabIndex = 29;
            this.button9.Text = "Copy";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // txtDePass
            // 
            this.txtDePass.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDePass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDePass.Location = new System.Drawing.Point(487, 107);
            this.txtDePass.MaxLength = 1000;
            this.txtDePass.Multiline = true;
            this.txtDePass.Name = "txtDePass";
            this.txtDePass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDePass.Size = new System.Drawing.Size(285, 35);
            this.txtDePass.TabIndex = 10;
            this.txtDePass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDePass_KeyDown);
            // 
            // txtEnPass
            // 
            this.txtEnPass.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnPass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEnPass.Location = new System.Drawing.Point(487, 56);
            this.txtEnPass.MaxLength = 1000;
            this.txtEnPass.Multiline = true;
            this.txtEnPass.Name = "txtEnPass";
            this.txtEnPass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEnPass.Size = new System.Drawing.Size(285, 35);
            this.txtEnPass.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(780, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 35);
            this.button4.TabIndex = 20;
            this.button4.Text = "Copy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tự động hóa...";
            // 
            // FormManagerProtectYourBookmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 716);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormManagerProtectYourBookmark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager & Protect Your Bookmark - [Created by HaDuc25]";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbUpdated;
        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.TextBox txtEnPass;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtDePass;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCategories;
        private System.Windows.Forms.ComboBox cbbMXH;
        private System.Windows.Forms.TextBox txtCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ComboBox cbbVisible;
        private System.Windows.Forms.Label lbVisible;
        private System.Windows.Forms.ComboBox cbbVsb;
    }
}

