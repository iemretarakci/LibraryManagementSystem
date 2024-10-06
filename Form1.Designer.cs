namespace LibrarySystemFrontend
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Membership = new System.Windows.Forms.TabControl();
            this.BookQuery = new System.Windows.Forms.TabPage();
            this.KitapSorgulamaGosterge = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.KitapSorgulamaISBN = new System.Windows.Forms.TextBox();
            this.KitapSorgulamaKitapismi = new System.Windows.Forms.TextBox();
            this.KitapSorgulamaYazar = new System.Windows.Forms.TextBox();
            this.KitapSorgulamaYayinevi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonKitapSorgulama = new System.Windows.Forms.Button();
            this.Loans = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.KitapAlimUyeSoyad = new System.Windows.Forms.TextBox();
            this.OduncKitapGosterge = new System.Windows.Forms.DataGridView();
            this.KitapAlimUyeAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KitapAlimKitapSorgu = new System.Windows.Forms.TextBox();
            this.buttonKitapAlimSorgu = new System.Windows.Forms.Button();
            this.MembershipLog = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UyeSorgulamaID = new System.Windows.Forms.TextBox();
            this.UyeSorgulamaisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UyeSorgulamaSoyisim = new System.Windows.Forms.TextBox();
            this.buttonUyeSorgulama = new System.Windows.Forms.Button();
            this.UyelikGosterge = new System.Windows.Forms.DataGridView();
            this.buttonUyeKaydiSilme = new System.Windows.Forms.Button();
            this.buttonUyeKaydi = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.UyeEklemeSoyisim = new System.Windows.Forms.TextBox();
            this.UyeEklemeTarih = new System.Windows.Forms.TextBox();
            this.UyeEklemeMail = new System.Windows.Forms.TextBox();
            this.UyeEklemeTelefon = new System.Windows.Forms.TextBox();
            this.UyeEklemeisim = new System.Windows.Forms.TextBox();
            this.BookLog = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.KitapKayitSayfa = new System.Windows.Forms.TextBox();
            this.buttonKitapKayit = new System.Windows.Forms.Button();
            this.KitapKayitYayinci = new System.Windows.Forms.ComboBox();
            this.KitapKayitYazar = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.KitapKayitBasimYili = new System.Windows.Forms.TextBox();
            this.KitapKayitKopya = new System.Windows.Forms.TextBox();
            this.KitapKayitISBN = new System.Windows.Forms.TextBox();
            this.KitapKayitGenre = new System.Windows.Forms.TextBox();
            this.KitapKayitisim = new System.Windows.Forms.TextBox();
            this.Reservation = new System.Windows.Forms.TabPage();
            this.buttonRezervasyonveOdunc = new System.Windows.Forms.Button();
            this.RezervasyonUyeSoyad = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.RezervasyonUyeAdi = new System.Windows.Forms.TextBox();
            this.RezervasyonKitapAdi = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Membership.SuspendLayout();
            this.BookQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitapSorgulamaGosterge)).BeginInit();
            this.Loans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OduncKitapGosterge)).BeginInit();
            this.MembershipLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UyelikGosterge)).BeginInit();
            this.BookLog.SuspendLayout();
            this.Reservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Membership
            // 
            this.Membership.Controls.Add(this.BookQuery);
            this.Membership.Controls.Add(this.Loans);
            this.Membership.Controls.Add(this.MembershipLog);
            this.Membership.Controls.Add(this.BookLog);
            this.Membership.Controls.Add(this.Reservation);
            this.Membership.Location = new System.Drawing.Point(0, 0);
            this.Membership.Name = "Membership";
            this.Membership.SelectedIndex = 0;
            this.Membership.Size = new System.Drawing.Size(875, 509);
            this.Membership.TabIndex = 0;
            // 
            // BookQuery
            // 
            this.BookQuery.Controls.Add(this.KitapSorgulamaGosterge);
            this.BookQuery.Controls.Add(this.label9);
            this.BookQuery.Controls.Add(this.KitapSorgulamaISBN);
            this.BookQuery.Controls.Add(this.KitapSorgulamaKitapismi);
            this.BookQuery.Controls.Add(this.KitapSorgulamaYazar);
            this.BookQuery.Controls.Add(this.KitapSorgulamaYayinevi);
            this.BookQuery.Controls.Add(this.label6);
            this.BookQuery.Controls.Add(this.label5);
            this.BookQuery.Controls.Add(this.label4);
            this.BookQuery.Controls.Add(this.buttonKitapSorgulama);
            this.BookQuery.Location = new System.Drawing.Point(4, 25);
            this.BookQuery.Name = "BookQuery";
            this.BookQuery.Padding = new System.Windows.Forms.Padding(3);
            this.BookQuery.Size = new System.Drawing.Size(867, 480);
            this.BookQuery.TabIndex = 1;
            this.BookQuery.Text = "Kitap Sorgulama";
            this.BookQuery.UseVisualStyleBackColor = true;
            // 
            // KitapSorgulamaGosterge
            // 
            this.KitapSorgulamaGosterge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapSorgulamaGosterge.Location = new System.Drawing.Point(321, 54);
            this.KitapSorgulamaGosterge.Name = "KitapSorgulamaGosterge";
            this.KitapSorgulamaGosterge.RowHeadersWidth = 51;
            this.KitapSorgulamaGosterge.RowTemplate.Height = 24;
            this.KitapSorgulamaGosterge.Size = new System.Drawing.Size(540, 340);
            this.KitapSorgulamaGosterge.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "ISBN";
            // 
            // KitapSorgulamaISBN
            // 
            this.KitapSorgulamaISBN.Location = new System.Drawing.Point(27, 54);
            this.KitapSorgulamaISBN.Name = "KitapSorgulamaISBN";
            this.KitapSorgulamaISBN.Size = new System.Drawing.Size(174, 22);
            this.KitapSorgulamaISBN.TabIndex = 8;
            // 
            // KitapSorgulamaKitapismi
            // 
            this.KitapSorgulamaKitapismi.Location = new System.Drawing.Point(27, 125);
            this.KitapSorgulamaKitapismi.Name = "KitapSorgulamaKitapismi";
            this.KitapSorgulamaKitapismi.Size = new System.Drawing.Size(201, 22);
            this.KitapSorgulamaKitapismi.TabIndex = 4;
            // 
            // KitapSorgulamaYazar
            // 
            this.KitapSorgulamaYazar.Location = new System.Drawing.Point(27, 209);
            this.KitapSorgulamaYazar.Name = "KitapSorgulamaYazar";
            this.KitapSorgulamaYazar.Size = new System.Drawing.Size(201, 22);
            this.KitapSorgulamaYazar.TabIndex = 3;
            // 
            // KitapSorgulamaYayinevi
            // 
            this.KitapSorgulamaYayinevi.Location = new System.Drawing.Point(27, 295);
            this.KitapSorgulamaYayinevi.Name = "KitapSorgulamaYayinevi";
            this.KitapSorgulamaYayinevi.Size = new System.Drawing.Size(201, 22);
            this.KitapSorgulamaYayinevi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Yayıncı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yazar Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kitap Adı";
            // 
            // buttonKitapSorgulama
            // 
            this.buttonKitapSorgulama.Location = new System.Drawing.Point(27, 354);
            this.buttonKitapSorgulama.Name = "buttonKitapSorgulama";
            this.buttonKitapSorgulama.Size = new System.Drawing.Size(138, 40);
            this.buttonKitapSorgulama.TabIndex = 2;
            this.buttonKitapSorgulama.Text = "Kitap Sorgula";
            this.buttonKitapSorgulama.UseVisualStyleBackColor = true;
            this.buttonKitapSorgulama.Click += new System.EventHandler(this.buttonKitapSorgulama_Click);
            // 
            // Loans
            // 
            this.Loans.Controls.Add(this.label24);
            this.Loans.Controls.Add(this.KitapAlimUyeSoyad);
            this.Loans.Controls.Add(this.OduncKitapGosterge);
            this.Loans.Controls.Add(this.KitapAlimUyeAd);
            this.Loans.Controls.Add(this.label3);
            this.Loans.Controls.Add(this.label2);
            this.Loans.Controls.Add(this.KitapAlimKitapSorgu);
            this.Loans.Controls.Add(this.buttonKitapAlimSorgu);
            this.Loans.Location = new System.Drawing.Point(4, 25);
            this.Loans.Name = "Loans";
            this.Loans.Padding = new System.Windows.Forms.Padding(3);
            this.Loans.Size = new System.Drawing.Size(867, 480);
            this.Loans.TabIndex = 2;
            this.Loans.Text = "Ödünç Kitaplar";
            this.Loans.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(22, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 16);
            this.label24.TabIndex = 8;
            this.label24.Text = "Üye Soyadı:";
            // 
            // KitapAlimUyeSoyad
            // 
            this.KitapAlimUyeSoyad.Location = new System.Drawing.Point(25, 179);
            this.KitapAlimUyeSoyad.Name = "KitapAlimUyeSoyad";
            this.KitapAlimUyeSoyad.Size = new System.Drawing.Size(176, 22);
            this.KitapAlimUyeSoyad.TabIndex = 7;
            // 
            // OduncKitapGosterge
            // 
            this.OduncKitapGosterge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OduncKitapGosterge.Location = new System.Drawing.Point(294, 18);
            this.OduncKitapGosterge.Name = "OduncKitapGosterge";
            this.OduncKitapGosterge.RowHeadersWidth = 51;
            this.OduncKitapGosterge.RowTemplate.Height = 24;
            this.OduncKitapGosterge.Size = new System.Drawing.Size(540, 340);
            this.OduncKitapGosterge.TabIndex = 6;
            // 
            // KitapAlimUyeAd
            // 
            this.KitapAlimUyeAd.Location = new System.Drawing.Point(25, 71);
            this.KitapAlimUyeAd.Name = "KitapAlimUyeAd";
            this.KitapAlimUyeAd.Size = new System.Drawing.Size(176, 22);
            this.KitapAlimUyeAd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kitap Adı:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Üye Adı:";
            // 
            // KitapAlimKitapSorgu
            // 
            this.KitapAlimKitapSorgu.Location = new System.Drawing.Point(25, 285);
            this.KitapAlimKitapSorgu.Name = "KitapAlimKitapSorgu";
            this.KitapAlimKitapSorgu.Size = new System.Drawing.Size(176, 22);
            this.KitapAlimKitapSorgu.TabIndex = 1;
            // 
            // buttonKitapAlimSorgu
            // 
            this.buttonKitapAlimSorgu.Location = new System.Drawing.Point(25, 343);
            this.buttonKitapAlimSorgu.Name = "buttonKitapAlimSorgu";
            this.buttonKitapAlimSorgu.Size = new System.Drawing.Size(176, 57);
            this.buttonKitapAlimSorgu.TabIndex = 0;
            this.buttonKitapAlimSorgu.Text = "Ödünç Alım Sorgula";
            this.buttonKitapAlimSorgu.UseVisualStyleBackColor = true;
            this.buttonKitapAlimSorgu.Click += new System.EventHandler(this.buttonKitapAlimSorgu_Click);
            // 
            // MembershipLog
            // 
            this.MembershipLog.Controls.Add(this.label8);
            this.MembershipLog.Controls.Add(this.label7);
            this.MembershipLog.Controls.Add(this.UyeSorgulamaID);
            this.MembershipLog.Controls.Add(this.UyeSorgulamaisim);
            this.MembershipLog.Controls.Add(this.label1);
            this.MembershipLog.Controls.Add(this.UyeSorgulamaSoyisim);
            this.MembershipLog.Controls.Add(this.buttonUyeSorgulama);
            this.MembershipLog.Controls.Add(this.UyelikGosterge);
            this.MembershipLog.Controls.Add(this.buttonUyeKaydiSilme);
            this.MembershipLog.Controls.Add(this.buttonUyeKaydi);
            this.MembershipLog.Controls.Add(this.label14);
            this.MembershipLog.Controls.Add(this.label13);
            this.MembershipLog.Controls.Add(this.label12);
            this.MembershipLog.Controls.Add(this.label11);
            this.MembershipLog.Controls.Add(this.label10);
            this.MembershipLog.Controls.Add(this.UyeEklemeSoyisim);
            this.MembershipLog.Controls.Add(this.UyeEklemeTarih);
            this.MembershipLog.Controls.Add(this.UyeEklemeMail);
            this.MembershipLog.Controls.Add(this.UyeEklemeTelefon);
            this.MembershipLog.Controls.Add(this.UyeEklemeisim);
            this.MembershipLog.Location = new System.Drawing.Point(4, 25);
            this.MembershipLog.Name = "MembershipLog";
            this.MembershipLog.Size = new System.Drawing.Size(867, 480);
            this.MembershipLog.TabIndex = 3;
            this.MembershipLog.Text = "Üye Ekleme";
            this.MembershipLog.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Üye Soyadı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Üye ID";
            // 
            // UyeSorgulamaID
            // 
            this.UyeSorgulamaID.Location = new System.Drawing.Point(284, 70);
            this.UyeSorgulamaID.Name = "UyeSorgulamaID";
            this.UyeSorgulamaID.Size = new System.Drawing.Size(174, 22);
            this.UyeSorgulamaID.TabIndex = 24;
            // 
            // UyeSorgulamaisim
            // 
            this.UyeSorgulamaisim.Location = new System.Drawing.Point(284, 144);
            this.UyeSorgulamaisim.Name = "UyeSorgulamaisim";
            this.UyeSorgulamaisim.Size = new System.Drawing.Size(174, 22);
            this.UyeSorgulamaisim.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Üye Adı";
            // 
            // UyeSorgulamaSoyisim
            // 
            this.UyeSorgulamaSoyisim.Location = new System.Drawing.Point(284, 229);
            this.UyeSorgulamaSoyisim.Name = "UyeSorgulamaSoyisim";
            this.UyeSorgulamaSoyisim.Size = new System.Drawing.Size(174, 22);
            this.UyeSorgulamaSoyisim.TabIndex = 21;
            // 
            // buttonUyeSorgulama
            // 
            this.buttonUyeSorgulama.Location = new System.Drawing.Point(284, 274);
            this.buttonUyeSorgulama.Name = "buttonUyeSorgulama";
            this.buttonUyeSorgulama.Size = new System.Drawing.Size(130, 37);
            this.buttonUyeSorgulama.TabIndex = 20;
            this.buttonUyeSorgulama.Text = "Üye Sorgula";
            this.buttonUyeSorgulama.UseVisualStyleBackColor = true;
            this.buttonUyeSorgulama.Click += new System.EventHandler(this.buttonUyeSorgulama_Click_1);
            // 
            // UyelikGosterge
            // 
            this.UyelikGosterge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UyelikGosterge.Location = new System.Drawing.Point(516, 67);
            this.UyelikGosterge.Name = "UyelikGosterge";
            this.UyelikGosterge.RowHeadersWidth = 51;
            this.UyelikGosterge.RowTemplate.Height = 24;
            this.UyelikGosterge.Size = new System.Drawing.Size(348, 305);
            this.UyelikGosterge.TabIndex = 19;
            // 
            // buttonUyeKaydiSilme
            // 
            this.buttonUyeKaydiSilme.Location = new System.Drawing.Point(284, 332);
            this.buttonUyeKaydiSilme.Name = "buttonUyeKaydiSilme";
            this.buttonUyeKaydiSilme.Size = new System.Drawing.Size(136, 40);
            this.buttonUyeKaydiSilme.TabIndex = 11;
            this.buttonUyeKaydiSilme.Text = "Üye Kaydı Sil";
            this.buttonUyeKaydiSilme.UseVisualStyleBackColor = true;
            this.buttonUyeKaydiSilme.Click += new System.EventHandler(this.buttonUyeKaydiSilme_Click);
            // 
            // buttonUyeKaydi
            // 
            this.buttonUyeKaydi.Location = new System.Drawing.Point(114, 372);
            this.buttonUyeKaydi.Name = "buttonUyeKaydi";
            this.buttonUyeKaydi.Size = new System.Drawing.Size(136, 40);
            this.buttonUyeKaydi.TabIndex = 10;
            this.buttonUyeKaydi.Text = "Üye Kaydı Oluştur";
            this.buttonUyeKaydi.UseVisualStyleBackColor = true;
            this.buttonUyeKaydi.Click += new System.EventHandler(this.buttonUyeKaydi_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Telefon:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Üyelik Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Soyisim:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "İsim:";
            // 
            // UyeEklemeSoyisim
            // 
            this.UyeEklemeSoyisim.Location = new System.Drawing.Point(114, 128);
            this.UyeEklemeSoyisim.Name = "UyeEklemeSoyisim";
            this.UyeEklemeSoyisim.Size = new System.Drawing.Size(136, 22);
            this.UyeEklemeSoyisim.TabIndex = 4;
            // 
            // UyeEklemeTarih
            // 
            this.UyeEklemeTarih.Location = new System.Drawing.Point(114, 185);
            this.UyeEklemeTarih.Name = "UyeEklemeTarih";
            this.UyeEklemeTarih.Size = new System.Drawing.Size(136, 22);
            this.UyeEklemeTarih.TabIndex = 3;
            // 
            // UyeEklemeMail
            // 
            this.UyeEklemeMail.Location = new System.Drawing.Point(114, 311);
            this.UyeEklemeMail.Name = "UyeEklemeMail";
            this.UyeEklemeMail.Size = new System.Drawing.Size(136, 22);
            this.UyeEklemeMail.TabIndex = 2;
            // 
            // UyeEklemeTelefon
            // 
            this.UyeEklemeTelefon.Location = new System.Drawing.Point(114, 248);
            this.UyeEklemeTelefon.Name = "UyeEklemeTelefon";
            this.UyeEklemeTelefon.Size = new System.Drawing.Size(136, 22);
            this.UyeEklemeTelefon.TabIndex = 1;
            // 
            // UyeEklemeisim
            // 
            this.UyeEklemeisim.Location = new System.Drawing.Point(114, 70);
            this.UyeEklemeisim.Name = "UyeEklemeisim";
            this.UyeEklemeisim.Size = new System.Drawing.Size(136, 22);
            this.UyeEklemeisim.TabIndex = 0;
            // 
            // BookLog
            // 
            this.BookLog.Controls.Add(this.label25);
            this.BookLog.Controls.Add(this.KitapKayitSayfa);
            this.BookLog.Controls.Add(this.buttonKitapKayit);
            this.BookLog.Controls.Add(this.KitapKayitYayinci);
            this.BookLog.Controls.Add(this.KitapKayitYazar);
            this.BookLog.Controls.Add(this.label21);
            this.BookLog.Controls.Add(this.label20);
            this.BookLog.Controls.Add(this.label19);
            this.BookLog.Controls.Add(this.label18);
            this.BookLog.Controls.Add(this.label17);
            this.BookLog.Controls.Add(this.label16);
            this.BookLog.Controls.Add(this.label15);
            this.BookLog.Controls.Add(this.KitapKayitBasimYili);
            this.BookLog.Controls.Add(this.KitapKayitKopya);
            this.BookLog.Controls.Add(this.KitapKayitISBN);
            this.BookLog.Controls.Add(this.KitapKayitGenre);
            this.BookLog.Controls.Add(this.KitapKayitisim);
            this.BookLog.Location = new System.Drawing.Point(4, 25);
            this.BookLog.Name = "BookLog";
            this.BookLog.Size = new System.Drawing.Size(867, 480);
            this.BookLog.TabIndex = 4;
            this.BookLog.Text = "Kitap Kayıt";
            this.BookLog.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(44, 331);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 16);
            this.label25.TabIndex = 18;
            this.label25.Text = "Sayfa Sayısı:";
            // 
            // KitapKayitSayfa
            // 
            this.KitapKayitSayfa.Location = new System.Drawing.Point(147, 328);
            this.KitapKayitSayfa.Name = "KitapKayitSayfa";
            this.KitapKayitSayfa.Size = new System.Drawing.Size(218, 22);
            this.KitapKayitSayfa.TabIndex = 17;
            // 
            // buttonKitapKayit
            // 
            this.buttonKitapKayit.Location = new System.Drawing.Point(501, 187);
            this.buttonKitapKayit.Name = "buttonKitapKayit";
            this.buttonKitapKayit.Size = new System.Drawing.Size(150, 46);
            this.buttonKitapKayit.TabIndex = 16;
            this.buttonKitapKayit.Text = "Kitap Kaydı Oluştur";
            this.buttonKitapKayit.UseVisualStyleBackColor = true;
            this.buttonKitapKayit.Click += new System.EventHandler(this.buttonKitapKayit_Click);
            // 
            // KitapKayitYayinci
            // 
            this.KitapKayitYayinci.FormattingEnabled = true;
            this.KitapKayitYayinci.Location = new System.Drawing.Point(147, 152);
            this.KitapKayitYayinci.Name = "KitapKayitYayinci";
            this.KitapKayitYayinci.Size = new System.Drawing.Size(218, 24);
            this.KitapKayitYayinci.TabIndex = 15;
            // 
            // KitapKayitYazar
            // 
            this.KitapKayitYazar.FormattingEnabled = true;
            this.KitapKayitYazar.Location = new System.Drawing.Point(147, 90);
            this.KitapKayitYazar.Name = "KitapKayitYazar";
            this.KitapKayitYazar.Size = new System.Drawing.Size(218, 24);
            this.KitapKayitYazar.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(46, 440);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 16);
            this.label21.TabIndex = 13;
            this.label21.Text = "Kopya Adeti:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(46, 385);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 16);
            this.label20.TabIndex = 12;
            this.label20.Text = "Çıkış Yılı:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(46, 275);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 16);
            this.label19.TabIndex = 11;
            this.label19.Text = "Tür:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(46, 214);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "ISBN:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(46, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "Yayıncı Adı:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Yazar Adı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "Kitap Adı:";
            // 
            // KitapKayitBasimYili
            // 
            this.KitapKayitBasimYili.Location = new System.Drawing.Point(147, 379);
            this.KitapKayitBasimYili.Name = "KitapKayitBasimYili";
            this.KitapKayitBasimYili.Size = new System.Drawing.Size(218, 22);
            this.KitapKayitBasimYili.TabIndex = 6;
            // 
            // KitapKayitKopya
            // 
            this.KitapKayitKopya.Location = new System.Drawing.Point(147, 434);
            this.KitapKayitKopya.Name = "KitapKayitKopya";
            this.KitapKayitKopya.Size = new System.Drawing.Size(218, 22);
            this.KitapKayitKopya.TabIndex = 5;
            // 
            // KitapKayitISBN
            // 
            this.KitapKayitISBN.Location = new System.Drawing.Point(147, 211);
            this.KitapKayitISBN.Name = "KitapKayitISBN";
            this.KitapKayitISBN.Size = new System.Drawing.Size(218, 22);
            this.KitapKayitISBN.TabIndex = 2;
            // 
            // KitapKayitGenre
            // 
            this.KitapKayitGenre.Location = new System.Drawing.Point(147, 269);
            this.KitapKayitGenre.Name = "KitapKayitGenre";
            this.KitapKayitGenre.Size = new System.Drawing.Size(218, 22);
            this.KitapKayitGenre.TabIndex = 1;
            // 
            // KitapKayitisim
            // 
            this.KitapKayitisim.Location = new System.Drawing.Point(147, 34);
            this.KitapKayitisim.Name = "KitapKayitisim";
            this.KitapKayitisim.Size = new System.Drawing.Size(218, 22);
            this.KitapKayitisim.TabIndex = 0;
            // 
            // Reservation
            // 
            this.Reservation.Controls.Add(this.buttonRezervasyonveOdunc);
            this.Reservation.Controls.Add(this.RezervasyonUyeSoyad);
            this.Reservation.Controls.Add(this.label26);
            this.Reservation.Controls.Add(this.RezervasyonUyeAdi);
            this.Reservation.Controls.Add(this.RezervasyonKitapAdi);
            this.Reservation.Controls.Add(this.label23);
            this.Reservation.Controls.Add(this.label22);
            this.Reservation.Location = new System.Drawing.Point(4, 25);
            this.Reservation.Name = "Reservation";
            this.Reservation.Padding = new System.Windows.Forms.Padding(3);
            this.Reservation.Size = new System.Drawing.Size(867, 480);
            this.Reservation.TabIndex = 5;
            this.Reservation.Text = "Rezervasyon ve Ödünç Alım";
            this.Reservation.UseVisualStyleBackColor = true;
            this.Reservation.Click += new System.EventHandler(this.Reservation_Click);
            // 
            // buttonRezervasyonveOdunc
            // 
            this.buttonRezervasyonveOdunc.Location = new System.Drawing.Point(172, 249);
            this.buttonRezervasyonveOdunc.Name = "buttonRezervasyonveOdunc";
            this.buttonRezervasyonveOdunc.Size = new System.Drawing.Size(121, 37);
            this.buttonRezervasyonveOdunc.TabIndex = 18;
            this.buttonRezervasyonveOdunc.Text = "İşlemi Tamamla";
            this.buttonRezervasyonveOdunc.UseVisualStyleBackColor = true;
            this.buttonRezervasyonveOdunc.Click += new System.EventHandler(this.buttonRezervasyonveOdunc_Click);
            // 
            // RezervasyonUyeSoyad
            // 
            this.RezervasyonUyeSoyad.Location = new System.Drawing.Point(172, 168);
            this.RezervasyonUyeSoyad.Name = "RezervasyonUyeSoyad";
            this.RezervasyonUyeSoyad.Size = new System.Drawing.Size(121, 22);
            this.RezervasyonUyeSoyad.TabIndex = 17;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(21, 174);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(78, 16);
            this.label26.TabIndex = 16;
            this.label26.Text = "ÜyeSoyadı:";
            // 
            // RezervasyonUyeAdi
            // 
            this.RezervasyonUyeAdi.Location = new System.Drawing.Point(172, 104);
            this.RezervasyonUyeAdi.Name = "RezervasyonUyeAdi";
            this.RezervasyonUyeAdi.Size = new System.Drawing.Size(121, 22);
            this.RezervasyonUyeAdi.TabIndex = 15;
            // 
            // RezervasyonKitapAdi
            // 
            this.RezervasyonKitapAdi.Location = new System.Drawing.Point(172, 44);
            this.RezervasyonKitapAdi.Name = "RezervasyonKitapAdi";
            this.RezervasyonKitapAdi.Size = new System.Drawing.Size(121, 22);
            this.RezervasyonKitapAdi.TabIndex = 14;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 110);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 16);
            this.label23.TabIndex = 4;
            this.label23.Text = "ÜyeAdı:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 47);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 16);
            this.label22.TabIndex = 3;
            this.label22.Text = "KitapAdı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 513);
            this.Controls.Add(this.Membership);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Membership.ResumeLayout(false);
            this.BookQuery.ResumeLayout(false);
            this.BookQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitapSorgulamaGosterge)).EndInit();
            this.Loans.ResumeLayout(false);
            this.Loans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OduncKitapGosterge)).EndInit();
            this.MembershipLog.ResumeLayout(false);
            this.MembershipLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UyelikGosterge)).EndInit();
            this.BookLog.ResumeLayout(false);
            this.BookLog.PerformLayout();
            this.Reservation.ResumeLayout(false);
            this.Reservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Membership;
        private System.Windows.Forms.TabPage BookQuery;
        private System.Windows.Forms.TabPage Loans;
        private System.Windows.Forms.TextBox KitapAlimUyeAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KitapAlimKitapSorgu;
        private System.Windows.Forms.Button buttonKitapAlimSorgu;
        private System.Windows.Forms.TabPage MembershipLog;
        private System.Windows.Forms.TabPage BookLog;
        private System.Windows.Forms.TabPage Reservation;
        private System.Windows.Forms.TextBox UyeEklemeSoyisim;
        private System.Windows.Forms.TextBox UyeEklemeTarih;
        private System.Windows.Forms.TextBox UyeEklemeMail;
        private System.Windows.Forms.TextBox UyeEklemeTelefon;
        private System.Windows.Forms.TextBox UyeEklemeisim;
        private System.Windows.Forms.Button buttonUyeKaydi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox KitapKayitBasimYili;
        private System.Windows.Forms.TextBox KitapKayitKopya;
        private System.Windows.Forms.TextBox KitapKayitISBN;
        private System.Windows.Forms.TextBox KitapKayitGenre;
        private System.Windows.Forms.TextBox KitapKayitisim;
        private System.Windows.Forms.Button buttonKitapKayit;
        private System.Windows.Forms.ComboBox KitapKayitYayinci;
        private System.Windows.Forms.ComboBox KitapKayitYazar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonUyeKaydiSilme;
        private System.Windows.Forms.DataGridView UyelikGosterge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UyeSorgulamaID;
        private System.Windows.Forms.TextBox UyeSorgulamaisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UyeSorgulamaSoyisim;
        private System.Windows.Forms.Button buttonUyeSorgulama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox KitapSorgulamaISBN;
        private System.Windows.Forms.TextBox KitapSorgulamaKitapismi;
        private System.Windows.Forms.TextBox KitapSorgulamaYazar;
        private System.Windows.Forms.TextBox KitapSorgulamaYayinevi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonKitapSorgulama;
        private System.Windows.Forms.DataGridView KitapSorgulamaGosterge;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox KitapKayitSayfa;
        private System.Windows.Forms.TextBox RezervasyonUyeSoyad;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox RezervasyonUyeAdi;
        private System.Windows.Forms.TextBox RezervasyonKitapAdi;
        private System.Windows.Forms.DataGridView OduncKitapGosterge;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox KitapAlimUyeSoyad;
        private System.Windows.Forms.Button buttonRezervasyonveOdunc;
    }
}

