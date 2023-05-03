
namespace ProyekACS
{
    partial class StatusKaryawan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textNamaSales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textStatusKaryawan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.cmbTipeLaporan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(605, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(303, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textNamaSales
            // 
            this.textNamaSales.Location = new System.Drawing.Point(119, 48);
            this.textNamaSales.Name = "textNamaSales";
            this.textNamaSales.Size = new System.Drawing.Size(178, 22);
            this.textNamaSales.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Sales :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(323, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // textStatusKaryawan
            // 
            this.textStatusKaryawan.Location = new System.Drawing.Point(137, 406);
            this.textStatusKaryawan.Name = "textStatusKaryawan";
            this.textStatusKaryawan.Size = new System.Drawing.Size(171, 22);
            this.textStatusKaryawan.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status Karyawan :";
            // 
            // btnLaporan
            // 
            this.btnLaporan.Location = new System.Drawing.Point(413, 397);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(75, 34);
            this.btnLaporan.TabIndex = 7;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            // 
            // cmbTipeLaporan
            // 
            this.cmbTipeLaporan.FormattingEnabled = true;
            this.cmbTipeLaporan.Location = new System.Drawing.Point(119, 15);
            this.cmbTipeLaporan.Name = "cmbTipeLaporan";
            this.cmbTipeLaporan.Size = new System.Drawing.Size(178, 24);
            this.cmbTipeLaporan.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipe Laporan :";
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(305, 13);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(108, 26);
            this.btnShowReport.TabIndex = 10;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            // 
            // StatusKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 464);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipeLaporan);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textStatusKaryawan);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNamaSales);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StatusKaryawan";
            this.Text = "StatusKaryawan";
            this.Load += new System.EventHandler(this.StatusKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textNamaSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textStatusKaryawan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.ComboBox cmbTipeLaporan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowReport;
    }
}