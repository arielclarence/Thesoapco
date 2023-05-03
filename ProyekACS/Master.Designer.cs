
namespace ProyekACS
{
    partial class Master
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textStatusKaryawan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTargetKaryawan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textHargaBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDeskripsiBarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textStokBarang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBarang = new System.Windows.Forms.GroupBox();
            this.cmbWujudBarang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbJenisBarang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbStatusBarang = new System.Windows.Forms.ComboBox();
            this.textNamaBarang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radiobtnBarang = new System.Windows.Forms.RadioButton();
            this.radiobtnKaryawan = new System.Windows.Forms.RadioButton();
            this.radiobtnPelanggan = new System.Windows.Forms.RadioButton();
            this.groupKaryawan = new System.Windows.Forms.GroupBox();
            this.cmbJabatanKaryawan = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textNoTelpKaryawan = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textEmailKaryawan = new System.Windows.Forms.TextBox();
            this.textAlamatKaryawan = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.radiobtnPerempuanKaryawan = new System.Windows.Forms.RadioButton();
            this.radiobtnLakiKaryawan = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.textPasswordKaryawan = new System.Windows.Forms.TextBox();
            this.textUsernameKaryawan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupPelanggan = new System.Windows.Forms.GroupBox();
            this.cmbJenisPelanggan = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textNoTelpPelanggan = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textEmailPelanggan = new System.Windows.Forms.TextBox();
            this.textAlamatPelanggan = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textNamaPelanggan = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.radiobtnPerempuanPelanggan = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.radiobtnLakiPelanggan = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.labelidsabun = new System.Windows.Forms.Label();
            this.labelidpelanggan = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.labelidkaryawan = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBarang.SuspendLayout();
            this.groupKaryawan.SuspendLayout();
            this.groupPelanggan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Master";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(836, 330);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(17, 716);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 32);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(115, 716);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 32);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(212, 716);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // textStatusKaryawan
            // 
            this.textStatusKaryawan.Location = new System.Drawing.Point(127, 242);
            this.textStatusKaryawan.Name = "textStatusKaryawan";
            this.textStatusKaryawan.Size = new System.Drawing.Size(194, 22);
            this.textStatusKaryawan.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Target";
            // 
            // textTargetKaryawan
            // 
            this.textTargetKaryawan.Location = new System.Drawing.Point(127, 273);
            this.textTargetKaryawan.Name = "textTargetKaryawan";
            this.textTargetKaryawan.Size = new System.Drawing.Size(194, 22);
            this.textTargetKaryawan.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Harga";
            // 
            // textHargaBarang
            // 
            this.textHargaBarang.Location = new System.Drawing.Point(130, 100);
            this.textHargaBarang.Name = "textHargaBarang";
            this.textHargaBarang.Size = new System.Drawing.Size(205, 22);
            this.textHargaBarang.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Deskripsi";
            // 
            // textDeskripsiBarang
            // 
            this.textDeskripsiBarang.Location = new System.Drawing.Point(130, 131);
            this.textDeskripsiBarang.Name = "textDeskripsiBarang";
            this.textDeskripsiBarang.Size = new System.Drawing.Size(205, 22);
            this.textDeskripsiBarang.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stok";
            // 
            // textStokBarang
            // 
            this.textStokBarang.Location = new System.Drawing.Point(130, 161);
            this.textStokBarang.Name = "textStokBarang";
            this.textStokBarang.Size = new System.Drawing.Size(205, 22);
            this.textStokBarang.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Status";
            // 
            // groupBarang
            // 
            this.groupBarang.Controls.Add(this.labelidsabun);
            this.groupBarang.Controls.Add(this.label23);
            this.groupBarang.Controls.Add(this.cmbWujudBarang);
            this.groupBarang.Controls.Add(this.label10);
            this.groupBarang.Controls.Add(this.cmbJenisBarang);
            this.groupBarang.Controls.Add(this.label9);
            this.groupBarang.Controls.Add(this.cmbStatusBarang);
            this.groupBarang.Controls.Add(this.textNamaBarang);
            this.groupBarang.Controls.Add(this.label8);
            this.groupBarang.Controls.Add(this.label4);
            this.groupBarang.Controls.Add(this.textHargaBarang);
            this.groupBarang.Controls.Add(this.label5);
            this.groupBarang.Controls.Add(this.textDeskripsiBarang);
            this.groupBarang.Controls.Add(this.label6);
            this.groupBarang.Controls.Add(this.textStokBarang);
            this.groupBarang.Controls.Add(this.label7);
            this.groupBarang.Location = new System.Drawing.Point(17, 398);
            this.groupBarang.Name = "groupBarang";
            this.groupBarang.Size = new System.Drawing.Size(378, 308);
            this.groupBarang.TabIndex = 19;
            this.groupBarang.TabStop = false;
            this.groupBarang.Text = "Barang";
            // 
            // cmbWujudBarang
            // 
            this.cmbWujudBarang.FormattingEnabled = true;
            this.cmbWujudBarang.Location = new System.Drawing.Point(130, 253);
            this.cmbWujudBarang.Name = "cmbWujudBarang";
            this.cmbWujudBarang.Size = new System.Drawing.Size(205, 24);
            this.cmbWujudBarang.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Wujud";
            // 
            // cmbJenisBarang
            // 
            this.cmbJenisBarang.FormattingEnabled = true;
            this.cmbJenisBarang.Location = new System.Drawing.Point(130, 223);
            this.cmbJenisBarang.Name = "cmbJenisBarang";
            this.cmbJenisBarang.Size = new System.Drawing.Size(205, 24);
            this.cmbJenisBarang.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Jenis";
            // 
            // cmbStatusBarang
            // 
            this.cmbStatusBarang.FormattingEnabled = true;
            this.cmbStatusBarang.Location = new System.Drawing.Point(130, 193);
            this.cmbStatusBarang.Name = "cmbStatusBarang";
            this.cmbStatusBarang.Size = new System.Drawing.Size(205, 24);
            this.cmbStatusBarang.TabIndex = 25;
            // 
            // textNamaBarang
            // 
            this.textNamaBarang.Location = new System.Drawing.Point(130, 67);
            this.textNamaBarang.Name = "textNamaBarang";
            this.textNamaBarang.Size = new System.Drawing.Size(205, 22);
            this.textNamaBarang.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nama";
            // 
            // radiobtnBarang
            // 
            this.radiobtnBarang.AutoSize = true;
            this.radiobtnBarang.Location = new System.Drawing.Point(103, 26);
            this.radiobtnBarang.Name = "radiobtnBarang";
            this.radiobtnBarang.Size = new System.Drawing.Size(75, 21);
            this.radiobtnBarang.TabIndex = 20;
            this.radiobtnBarang.TabStop = true;
            this.radiobtnBarang.Text = "Barang";
            this.radiobtnBarang.UseVisualStyleBackColor = true;
            this.radiobtnBarang.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radiobtnKaryawan
            // 
            this.radiobtnKaryawan.AutoSize = true;
            this.radiobtnKaryawan.Location = new System.Drawing.Point(184, 26);
            this.radiobtnKaryawan.Name = "radiobtnKaryawan";
            this.radiobtnKaryawan.Size = new System.Drawing.Size(91, 21);
            this.radiobtnKaryawan.TabIndex = 21;
            this.radiobtnKaryawan.TabStop = true;
            this.radiobtnKaryawan.Text = "Karyawan";
            this.radiobtnKaryawan.UseVisualStyleBackColor = true;
            this.radiobtnKaryawan.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radiobtnPelanggan
            // 
            this.radiobtnPelanggan.AutoSize = true;
            this.radiobtnPelanggan.Location = new System.Drawing.Point(281, 26);
            this.radiobtnPelanggan.Name = "radiobtnPelanggan";
            this.radiobtnPelanggan.Size = new System.Drawing.Size(97, 21);
            this.radiobtnPelanggan.TabIndex = 22;
            this.radiobtnPelanggan.TabStop = true;
            this.radiobtnPelanggan.Text = "Pelanggan";
            this.radiobtnPelanggan.UseVisualStyleBackColor = true;
            this.radiobtnPelanggan.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupKaryawan
            // 
            this.groupKaryawan.Controls.Add(this.labelidkaryawan);
            this.groupKaryawan.Controls.Add(this.label29);
            this.groupKaryawan.Controls.Add(this.cmbJabatanKaryawan);
            this.groupKaryawan.Controls.Add(this.label17);
            this.groupKaryawan.Controls.Add(this.textNoTelpKaryawan);
            this.groupKaryawan.Controls.Add(this.label16);
            this.groupKaryawan.Controls.Add(this.textEmailKaryawan);
            this.groupKaryawan.Controls.Add(this.textAlamatKaryawan);
            this.groupKaryawan.Controls.Add(this.label15);
            this.groupKaryawan.Controls.Add(this.label14);
            this.groupKaryawan.Controls.Add(this.radiobtnPerempuanKaryawan);
            this.groupKaryawan.Controls.Add(this.radiobtnLakiKaryawan);
            this.groupKaryawan.Controls.Add(this.label13);
            this.groupKaryawan.Controls.Add(this.textPasswordKaryawan);
            this.groupKaryawan.Controls.Add(this.textUsernameKaryawan);
            this.groupKaryawan.Controls.Add(this.label11);
            this.groupKaryawan.Controls.Add(this.label12);
            this.groupKaryawan.Controls.Add(this.textStatusKaryawan);
            this.groupKaryawan.Controls.Add(this.label2);
            this.groupKaryawan.Controls.Add(this.label3);
            this.groupKaryawan.Controls.Add(this.textTargetKaryawan);
            this.groupKaryawan.Location = new System.Drawing.Point(812, 404);
            this.groupKaryawan.Name = "groupKaryawan";
            this.groupKaryawan.Size = new System.Drawing.Size(369, 327);
            this.groupKaryawan.TabIndex = 23;
            this.groupKaryawan.TabStop = false;
            this.groupKaryawan.Text = "Karyawan";
            // 
            // cmbJabatanKaryawan
            // 
            this.cmbJabatanKaryawan.FormattingEnabled = true;
            this.cmbJabatanKaryawan.Location = new System.Drawing.Point(127, 300);
            this.cmbJabatanKaryawan.Name = "cmbJabatanKaryawan";
            this.cmbJabatanKaryawan.Size = new System.Drawing.Size(195, 24);
            this.cmbJabatanKaryawan.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 17);
            this.label17.TabIndex = 33;
            this.label17.Text = "Jabatan";
            // 
            // textNoTelpKaryawan
            // 
            this.textNoTelpKaryawan.Location = new System.Drawing.Point(128, 208);
            this.textNoTelpKaryawan.Name = "textNoTelpKaryawan";
            this.textNoTelpKaryawan.Size = new System.Drawing.Size(194, 22);
            this.textNoTelpKaryawan.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "No Telp";
            // 
            // textEmailKaryawan
            // 
            this.textEmailKaryawan.Location = new System.Drawing.Point(127, 180);
            this.textEmailKaryawan.Name = "textEmailKaryawan";
            this.textEmailKaryawan.Size = new System.Drawing.Size(194, 22);
            this.textEmailKaryawan.TabIndex = 30;
            // 
            // textAlamatKaryawan
            // 
            this.textAlamatKaryawan.Location = new System.Drawing.Point(127, 152);
            this.textAlamatKaryawan.Name = "textAlamatKaryawan";
            this.textAlamatKaryawan.Size = new System.Drawing.Size(194, 22);
            this.textAlamatKaryawan.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Alamat";
            // 
            // radiobtnPerempuanKaryawan
            // 
            this.radiobtnPerempuanKaryawan.AutoSize = true;
            this.radiobtnPerempuanKaryawan.Location = new System.Drawing.Point(220, 125);
            this.radiobtnPerempuanKaryawan.Name = "radiobtnPerempuanKaryawan";
            this.radiobtnPerempuanKaryawan.Size = new System.Drawing.Size(102, 21);
            this.radiobtnPerempuanKaryawan.TabIndex = 26;
            this.radiobtnPerempuanKaryawan.TabStop = true;
            this.radiobtnPerempuanKaryawan.Text = "Perempuan";
            this.radiobtnPerempuanKaryawan.UseVisualStyleBackColor = true;
            // 
            // radiobtnLakiKaryawan
            // 
            this.radiobtnLakiKaryawan.AutoSize = true;
            this.radiobtnLakiKaryawan.Location = new System.Drawing.Point(128, 125);
            this.radiobtnLakiKaryawan.Name = "radiobtnLakiKaryawan";
            this.radiobtnLakiKaryawan.Size = new System.Drawing.Size(85, 21);
            this.radiobtnLakiKaryawan.TabIndex = 25;
            this.radiobtnLakiKaryawan.TabStop = true;
            this.radiobtnLakiKaryawan.Text = "Laki Laki";
            this.radiobtnLakiKaryawan.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Jenis Kelamin";
            // 
            // textPasswordKaryawan
            // 
            this.textPasswordKaryawan.Location = new System.Drawing.Point(127, 93);
            this.textPasswordKaryawan.Name = "textPasswordKaryawan";
            this.textPasswordKaryawan.Size = new System.Drawing.Size(194, 22);
            this.textPasswordKaryawan.TabIndex = 14;
            // 
            // textUsernameKaryawan
            // 
            this.textUsernameKaryawan.Location = new System.Drawing.Point(127, 62);
            this.textUsernameKaryawan.Name = "textUsernameKaryawan";
            this.textUsernameKaryawan.Size = new System.Drawing.Size(194, 22);
            this.textUsernameKaryawan.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Password ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Username ";
            // 
            // groupPelanggan
            // 
            this.groupPelanggan.Controls.Add(this.labelidpelanggan);
            this.groupPelanggan.Controls.Add(this.cmbJenisPelanggan);
            this.groupPelanggan.Controls.Add(this.label27);
            this.groupPelanggan.Controls.Add(this.label18);
            this.groupPelanggan.Controls.Add(this.label24);
            this.groupPelanggan.Controls.Add(this.textNoTelpPelanggan);
            this.groupPelanggan.Controls.Add(this.label19);
            this.groupPelanggan.Controls.Add(this.textEmailPelanggan);
            this.groupPelanggan.Controls.Add(this.textAlamatPelanggan);
            this.groupPelanggan.Controls.Add(this.label20);
            this.groupPelanggan.Controls.Add(this.textNamaPelanggan);
            this.groupPelanggan.Controls.Add(this.label21);
            this.groupPelanggan.Controls.Add(this.radiobtnPerempuanPelanggan);
            this.groupPelanggan.Controls.Add(this.label22);
            this.groupPelanggan.Controls.Add(this.radiobtnLakiPelanggan);
            this.groupPelanggan.Location = new System.Drawing.Point(419, 404);
            this.groupPelanggan.Name = "groupPelanggan";
            this.groupPelanggan.Size = new System.Drawing.Size(369, 302);
            this.groupPelanggan.TabIndex = 24;
            this.groupPelanggan.TabStop = false;
            this.groupPelanggan.Text = "Pelanggan";
            // 
            // cmbJenisPelanggan
            // 
            this.cmbJenisPelanggan.FormattingEnabled = true;
            this.cmbJenisPelanggan.Location = new System.Drawing.Point(147, 128);
            this.cmbJenisPelanggan.Name = "cmbJenisPelanggan";
            this.cmbJenisPelanggan.Size = new System.Drawing.Size(195, 24);
            this.cmbJenisPelanggan.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 17);
            this.label18.TabIndex = 52;
            this.label18.Text = "Jenis Pelanggan";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(27, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 17);
            this.label24.TabIndex = 38;
            this.label24.Text = "Nama";
            // 
            // textNoTelpPelanggan
            // 
            this.textNoTelpPelanggan.Location = new System.Drawing.Point(147, 214);
            this.textNoTelpPelanggan.Name = "textNoTelpPelanggan";
            this.textNoTelpPelanggan.Size = new System.Drawing.Size(194, 22);
            this.textNoTelpPelanggan.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 217);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 17);
            this.label19.TabIndex = 50;
            this.label19.Text = "No Telp";
            // 
            // textEmailPelanggan
            // 
            this.textEmailPelanggan.Location = new System.Drawing.Point(148, 186);
            this.textEmailPelanggan.Name = "textEmailPelanggan";
            this.textEmailPelanggan.Size = new System.Drawing.Size(194, 22);
            this.textEmailPelanggan.TabIndex = 48;
            // 
            // textAlamatPelanggan
            // 
            this.textAlamatPelanggan.Location = new System.Drawing.Point(148, 158);
            this.textAlamatPelanggan.Name = "textAlamatPelanggan";
            this.textAlamatPelanggan.Size = new System.Drawing.Size(194, 22);
            this.textAlamatPelanggan.TabIndex = 47;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 191);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 17);
            this.label20.TabIndex = 46;
            this.label20.Text = "Email";
            // 
            // textNamaPelanggan
            // 
            this.textNamaPelanggan.Location = new System.Drawing.Point(147, 74);
            this.textNamaPelanggan.Name = "textNamaPelanggan";
            this.textNamaPelanggan.Size = new System.Drawing.Size(194, 22);
            this.textNamaPelanggan.TabIndex = 40;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 159);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 17);
            this.label21.TabIndex = 45;
            this.label21.Text = "Alamat";
            // 
            // radiobtnPerempuanPelanggan
            // 
            this.radiobtnPerempuanPelanggan.AutoSize = true;
            this.radiobtnPerempuanPelanggan.Location = new System.Drawing.Point(239, 102);
            this.radiobtnPerempuanPelanggan.Name = "radiobtnPerempuanPelanggan";
            this.radiobtnPerempuanPelanggan.Size = new System.Drawing.Size(102, 21);
            this.radiobtnPerempuanPelanggan.TabIndex = 44;
            this.radiobtnPerempuanPelanggan.TabStop = true;
            this.radiobtnPerempuanPelanggan.Text = "Perempuan";
            this.radiobtnPerempuanPelanggan.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 17);
            this.label22.TabIndex = 42;
            this.label22.Text = "Jenis Kelamin";
            // 
            // radiobtnLakiPelanggan
            // 
            this.radiobtnLakiPelanggan.AutoSize = true;
            this.radiobtnLakiPelanggan.Location = new System.Drawing.Point(147, 102);
            this.radiobtnLakiPelanggan.Name = "radiobtnLakiPelanggan";
            this.radiobtnLakiPelanggan.Size = new System.Drawing.Size(85, 21);
            this.radiobtnLakiPelanggan.TabIndex = 43;
            this.radiobtnLakiPelanggan.TabStop = true;
            this.radiobtnLakiPelanggan.Text = "Laki Laki";
            this.radiobtnLakiPelanggan.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(774, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 32);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 17);
            this.label23.TabIndex = 30;
            this.label23.Text = "Id:";
            // 
            // labelidsabun
            // 
            this.labelidsabun.AutoSize = true;
            this.labelidsabun.Location = new System.Drawing.Point(127, 41);
            this.labelidsabun.Name = "labelidsabun";
            this.labelidsabun.Size = new System.Drawing.Size(19, 17);
            this.labelidsabun.TabIndex = 31;
            this.labelidsabun.Text = "Id";
            // 
            // labelidpelanggan
            // 
            this.labelidpelanggan.AutoSize = true;
            this.labelidpelanggan.Location = new System.Drawing.Point(144, 45);
            this.labelidpelanggan.Name = "labelidpelanggan";
            this.labelidpelanggan.Size = new System.Drawing.Size(19, 17);
            this.labelidpelanggan.TabIndex = 33;
            this.labelidpelanggan.Text = "Id";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(28, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 17);
            this.label27.TabIndex = 32;
            this.label27.Text = "Id:";
            // 
            // labelidkaryawan
            // 
            this.labelidkaryawan.AutoSize = true;
            this.labelidkaryawan.Location = new System.Drawing.Point(125, 35);
            this.labelidkaryawan.Name = "labelidkaryawan";
            this.labelidkaryawan.Size = new System.Drawing.Size(19, 17);
            this.labelidkaryawan.TabIndex = 54;
            this.labelidkaryawan.Text = "Id";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 35);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 17);
            this.label29.TabIndex = 53;
            this.label29.Text = "Id:";
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 760);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupPelanggan);
            this.Controls.Add(this.groupKaryawan);
            this.Controls.Add(this.radiobtnPelanggan);
            this.Controls.Add(this.radiobtnKaryawan);
            this.Controls.Add(this.radiobtnBarang);
            this.Controls.Add(this.groupBarang);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Master";
            this.Text = "Master";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBarang.ResumeLayout(false);
            this.groupBarang.PerformLayout();
            this.groupKaryawan.ResumeLayout(false);
            this.groupKaryawan.PerformLayout();
            this.groupPelanggan.ResumeLayout(false);
            this.groupPelanggan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textStatusKaryawan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTargetKaryawan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textHargaBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDeskripsiBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textStokBarang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBarang;
        private System.Windows.Forms.RadioButton radiobtnBarang;
        private System.Windows.Forms.RadioButton radiobtnKaryawan;
        private System.Windows.Forms.RadioButton radiobtnPelanggan;
        private System.Windows.Forms.TextBox textNamaBarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupKaryawan;
        private System.Windows.Forms.GroupBox groupPelanggan;
        private System.Windows.Forms.ComboBox cmbWujudBarang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbJenisBarang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbStatusBarang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textPasswordKaryawan;
        private System.Windows.Forms.TextBox textUsernameKaryawan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbJabatanKaryawan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textNoTelpKaryawan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textEmailKaryawan;
        private System.Windows.Forms.TextBox textAlamatKaryawan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radiobtnPerempuanKaryawan;
        private System.Windows.Forms.RadioButton radiobtnLakiKaryawan;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textNoTelpPelanggan;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textEmailPelanggan;
        private System.Windows.Forms.TextBox textAlamatPelanggan;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textNamaPelanggan;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RadioButton radiobtnPerempuanPelanggan;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton radiobtnLakiPelanggan;
        private System.Windows.Forms.ComboBox cmbJenisPelanggan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelidsabun;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelidkaryawan;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label labelidpelanggan;
        private System.Windows.Forms.Label label27;
    }
}