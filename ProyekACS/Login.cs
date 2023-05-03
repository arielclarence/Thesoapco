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
    public partial class Login : Form
    {
        public Login()
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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            NewSalesOrderAdmin n = new NewSalesOrderAdmin();
            n.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfilKaryawan ProfilKaryawan = new ProfilKaryawan();
            ProfilKaryawan.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MasterBarang MasterBarang = new MasterBarang();
            MasterBarang.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MasterKaryawan MasterKaryawan = new MasterKaryawan();
            MasterKaryawan.Show();
            this.Hide();
        }
    }
}
