using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace ProyekACS
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }
        String connStr;
        OracleConnection conn;

        String queryStr;
        OracleCommand query;
        OracleDataAdapter adapter;


        DataSet datasetmutasi;
        DataSet datasetsabun;
        DataSet datasetkaryawan;
        DataSet datasetpelanggan;
        
        DataTable dtPembelian;
        String cmdStr;
        OracleCommand cmd;

        OracleCommand storedProcedure;

        OracleCommandBuilder builder;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnBarang.Checked)
            {
                groupBarang.Visible = true;
                groupKaryawan.Visible = false;
                groupPelanggan.Visible = false;
                loadDGVsabun();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnKaryawan.Checked)
            {
                groupKaryawan.Visible = true;
                groupBarang.Visible = false;
                groupPelanggan.Visible = false;
                loadDGVkaryawan();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnPelanggan.Checked)
            {
                groupPelanggan.Visible = true;
                groupBarang.Visible = false;
                groupKaryawan.Visible = false;
                loadDGVpelanggan();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radiobtnBarang.Checked = true;
            groupBarang.Visible = true;
            groupKaryawan.Visible = false;
            groupPelanggan.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            String connStr = "USER ID = ARIEL; DATA SOURCE = localhost:1521 / XEPDB1; PERSIST SECURITY INFO = True; PASSWORD = ariel";
            conn = new OracleConnection(connStr);
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void loadDGVsabun()
        {

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = $"select ID,NAMA,DESKRIPSI,HARGA,STOK,STATUS,JENIS_SABUN,WUJUD from SABUN";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                datasetsabun = new DataSet();

                adapter.Fill(datasetsabun, "sabun");

                dataGridView1.DataSource = datasetsabun;
                dataGridView1.DataMember = "sabun";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                queryStr = $"SELECT max(ID)+1 from SABUN";
                query = new OracleCommand(queryStr, conn);
                string idsabunbaru = query.ExecuteScalar().ToString();
                labelidsabun.Text = idsabunbaru;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }
        void loadDGVkaryawan()
        {

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = $"select ID,USERNAME,PASSWORD,NAMA,JENIS_KELAMIN,ALAMAT,EMAIL,NO_TELP,STATUS,FK_JABATAN,TARGET from KARYAWAN";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                datasetkaryawan = new DataSet();

                adapter.Fill(datasetkaryawan, "karyawan");

                dataGridView1.DataSource = datasetkaryawan;
                dataGridView1.DataMember = "karyawan";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                queryStr = $"SELECT max(ID)+1 from KARYAWAN";
                query = new OracleCommand(queryStr, conn);
                string idakryawanbaru = query.ExecuteScalar().ToString();
                labelidkaryawan.Text = idakryawanbaru;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }
        void loadDGVpelanggan()
        {

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                conn.Open();

                queryStr = $"select ID,NAMA,JENIS_KELAMIN,ALAMAT,JENIS_PELANGGAN,EMAIL,NO_TELP from PELANGGAN";
                query = new OracleCommand(queryStr, conn);
                adapter = new OracleDataAdapter(query);
                datasetpelanggan = new DataSet();

                adapter.Fill(datasetpelanggan, "pelanggan");

                dataGridView1.DataSource = datasetpelanggan;
                dataGridView1.DataMember = "pelanggan";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                queryStr = $"SELECT max(ID)+1 from PELANGGAN";
                query = new OracleCommand(queryStr, conn);
                string idpelangganbaru = query.ExecuteScalar().ToString();
                labelidpelanggan.Text = idpelangganbaru;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }
        

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int cekinsert = -1;
            if (radiobtnBarang.Checked)
            {
                cekinsert = 0;
            }
            else if (radiobtnKaryawan.Checked)
            {
                cekinsert = 1;
            }
            else if (radiobtnPelanggan.Checked)
            {
                cekinsert = 2;
            }
            if (cekinsert==0)
            {
                

            }
            
            
        }

        
    }
}
