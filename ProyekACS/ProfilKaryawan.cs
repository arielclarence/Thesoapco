using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyekACS
{
    public partial class ProfilKaryawan : Form
    {
        public ProfilKaryawan()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;


            var pos1 = this.PointToScreen(label1.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            label1.Parent = pictureBox1;
            label1.Location = pos1;
            label1.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(label2.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            label2.Parent = pictureBox1;
            label2.Location = pos2;
            label2.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(label3.Location);
            pos3 = pictureBox1.PointToClient(pos3);
            label3.Parent = pictureBox1;
            label3.Location = pos3;
            label3.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(label4.Location);
            pos4 = pictureBox1.PointToClient(pos4);
            label4.Parent = pictureBox1;
            label4.Location = pos4;
            label4.BackColor = Color.Transparent;

            var pos5 = this.PointToScreen(label5.Location);
            pos5 = pictureBox1.PointToClient(pos5);
            label5.Parent = pictureBox1;
            label5.Location = pos5;
            label5.BackColor = Color.Transparent;

            var pos6 = this.PointToScreen(label6.Location);
            pos6 = pictureBox1.PointToClient(pos6);
            label6.Parent = pictureBox1;
            label6.Location = pos6;
            label6.BackColor = Color.Transparent;

            var pos7 = this.PointToScreen(label7.Location);
            pos7 = pictureBox1.PointToClient(pos7);
            label7.Parent = pictureBox1;
            label7.Location = pos7;
            label7.BackColor = Color.Transparent;

            var pos8 = this.PointToScreen(label8.Location);
            pos8 = pictureBox1.PointToClient(pos8);
            label8.Parent = pictureBox1;
            label8.Location = pos8;
            label8.BackColor = Color.Transparent;

            var pos9 = this.PointToScreen(labelUsername.Location);
            pos9 = pictureBox1.PointToClient(pos9);
            labelUsername.Parent = pictureBox1;
            labelUsername.Location = pos9;
            labelUsername.BackColor = Color.Transparent;

            var pos10 = this.PointToScreen(labelPassword.Location);
            pos10 = pictureBox1.PointToClient(pos10);
            labelPassword.Parent = pictureBox1;
            labelPassword.Location = pos10;
            labelPassword.BackColor = Color.Transparent;

            var pos11 = this.PointToScreen(labelJenis.Location);
            pos11 = pictureBox1.PointToClient(pos11);
            labelJenis.Parent = pictureBox1;
            labelJenis.Location = pos11;
            labelJenis.BackColor = Color.Transparent;

            var pos12 = this.PointToScreen(labelAlamat.Location);
            pos12 = pictureBox1.PointToClient(pos12);
            labelAlamat.Parent = pictureBox1;
            labelAlamat.Location = pos12;
            labelAlamat.BackColor = Color.Transparent;

            var pos13 = this.PointToScreen(labelEmail.Location);
            pos13 = pictureBox1.PointToClient(pos13);
            labelEmail.Parent = pictureBox1;
            labelEmail.Location = pos13;
            labelEmail.BackColor = Color.Transparent;

            var pos14 = this.PointToScreen(labelTelp.Location);
            pos14 = pictureBox1.PointToClient(pos14);
            labelTelp.Parent = pictureBox1;
            labelTelp.Location = pos14;
            labelTelp.BackColor = Color.Transparent;

            var pos15 = this.PointToScreen(labelStatus.Location);
            pos15 = pictureBox1.PointToClient(pos15);
            labelStatus.Parent = pictureBox1;
            labelStatus.Location = pos15;
            labelStatus.BackColor = Color.Transparent;

            var pos16 = this.PointToScreen(labelTarget.Location);
            pos16 = pictureBox1.PointToClient(pos16);
            labelTarget.Parent = pictureBox1;
            labelTarget.Location = pos16;
            labelTarget.BackColor = Color.Transparent;

            var pos17 = this.PointToScreen(label9.Location);
            pos17 = pictureBox1.PointToClient(pos17);
            label9.Parent = pictureBox1;
            label9.Location = pos17;
            label9.BackColor = Color.Transparent;

            var pos18 = this.PointToScreen(label10.Location);
            pos18 = pictureBox1.PointToClient(pos18);
            label10.Parent = pictureBox1;
            label10.Location = pos18;
            label10.BackColor = Color.Transparent;

            var pos19 = this.PointToScreen(label11.Location);
            pos19 = pictureBox1.PointToClient(pos19);
            label11.Parent = pictureBox1;
            label11.Location = pos19;
            label11.BackColor = Color.Transparent;

            var pos20 = this.PointToScreen(label12.Location);
            pos20 = pictureBox1.PointToClient(pos20);
            label12.Parent = pictureBox1;
            label12.Location = pos20;
            label12.BackColor = Color.Transparent;

            var pos21 = this.PointToScreen(label13.Location);
            pos21 = pictureBox1.PointToClient(pos21);
            label13.Parent = pictureBox1;
            label13.Location = pos21;
            label13.BackColor = Color.Transparent;

            var pos22 = this.PointToScreen(label14.Location);
            pos22 = pictureBox1.PointToClient(pos22);
            label14.Parent = pictureBox1;
            label14.Location = pos22;
            label14.BackColor = Color.Transparent;

            var pos23 = this.PointToScreen(label15.Location);
            pos23 = pictureBox1.PointToClient(pos23);
            label15.Parent = pictureBox1;
            label15.Location = pos23;
            label15.BackColor = Color.Transparent;

            var pos24 = this.PointToScreen(label16.Location);
            pos24 = pictureBox1.PointToClient(pos24);
            label16.Parent = pictureBox1;
            label16.Location = pos24;
            label16.BackColor = Color.Transparent;

            var pos25 = this.PointToScreen(label17.Location);
            pos25 = pictureBox1.PointToClient(pos25);
            label17.Parent = pictureBox1;
            label17.Location = pos25;
            label17.BackColor = Color.Transparent;
        }

        private void ProfilKaryawan_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
