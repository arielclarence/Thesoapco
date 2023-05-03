
namespace ProyekACS
{
    partial class MenuAdmin
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
            this.ButtonStatusKaryawan = new System.Windows.Forms.Button();
            this.ButtonMaster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuPenjualan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonStatusKaryawan
            // 
            this.ButtonStatusKaryawan.Location = new System.Drawing.Point(101, 170);
            this.ButtonStatusKaryawan.Name = "ButtonStatusKaryawan";
            this.ButtonStatusKaryawan.Size = new System.Drawing.Size(205, 86);
            this.ButtonStatusKaryawan.TabIndex = 5;
            this.ButtonStatusKaryawan.Text = "Status Karyawan";
            this.ButtonStatusKaryawan.UseVisualStyleBackColor = true;
            // 
            // ButtonMaster
            // 
            this.ButtonMaster.Location = new System.Drawing.Point(101, 81);
            this.ButtonMaster.Name = "ButtonMaster";
            this.ButtonMaster.Size = new System.Drawing.Size(205, 72);
            this.ButtonMaster.TabIndex = 4;
            this.ButtonMaster.Text = "Master";
            this.ButtonMaster.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome, ";
            // 
            // btnMenuPenjualan
            // 
            this.btnMenuPenjualan.Location = new System.Drawing.Point(101, 273);
            this.btnMenuPenjualan.Name = "btnMenuPenjualan";
            this.btnMenuPenjualan.Size = new System.Drawing.Size(205, 86);
            this.btnMenuPenjualan.TabIndex = 6;
            this.btnMenuPenjualan.Text = "Menu Penjualan";
            this.btnMenuPenjualan.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(303, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 37);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMenuPenjualan);
            this.Controls.Add(this.ButtonStatusKaryawan);
            this.Controls.Add(this.ButtonMaster);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStatusKaryawan;
        private System.Windows.Forms.Button ButtonMaster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuPenjualan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
    }
}