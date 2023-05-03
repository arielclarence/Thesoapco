
namespace ProyekACS
{
    partial class MenuKaryawan
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
            this.ButtonProfile = new System.Windows.Forms.Button();
            this.ButtonSalesOrder = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, ";
            // 
            // ButtonProfile
            // 
            this.ButtonProfile.Location = new System.Drawing.Point(100, 77);
            this.ButtonProfile.Name = "ButtonProfile";
            this.ButtonProfile.Size = new System.Drawing.Size(205, 72);
            this.ButtonProfile.TabIndex = 1;
            this.ButtonProfile.Text = "Profile";
            this.ButtonProfile.UseVisualStyleBackColor = true;
            // 
            // ButtonSalesOrder
            // 
            this.ButtonSalesOrder.Location = new System.Drawing.Point(100, 166);
            this.ButtonSalesOrder.Name = "ButtonSalesOrder";
            this.ButtonSalesOrder.Size = new System.Drawing.Size(205, 86);
            this.ButtonSalesOrder.TabIndex = 2;
            this.ButtonSalesOrder.Text = "Sales Order";
            this.ButtonSalesOrder.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(310, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 37);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // MenuKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 308);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.ButtonSalesOrder);
            this.Controls.Add(this.ButtonProfile);
            this.Controls.Add(this.label1);
            this.Name = "MenuKaryawan";
            this.Text = "MenuKaryawan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonProfile;
        private System.Windows.Forms.Button ButtonSalesOrder;
        private System.Windows.Forms.Button btnLogout;
    }
}