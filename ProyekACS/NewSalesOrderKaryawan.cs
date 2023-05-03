using System;
using System.Collections;
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
    public partial class NewSalesOrderKaryawan : Form
    {
        public NewSalesOrderKaryawan()
        {
            InitializeComponent();
        }
        int IDKaryawan = 3;
        ArrayList listHarga = new ArrayList();
        ArrayList listStok = new ArrayList();

        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter adapter;
        int kali = 1;
        private void NewSalesOrderKaryawan_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection();
            adapter = new OracleDataAdapter();
            cmd = new OracleCommand();

            cmd.Connection = conn;
            conn.ConnectionString = "USER ID = ARIEL; DATA SOURCE = localhost:1521 / XEPDB1; PERSIST SECURITY INFO = True; PASSWORD = ariel";
            newNota();
            conn.Open();

            string queryString = "select id, nama from pelanggan";
            OracleCommand command = new OracleCommand(queryString, conn);
            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbCust.Items.Add(reader.GetString(1));
                }

            }
            cmbCust.SelectedIndex = 0;
            
            queryString = "select id, nama, harga, stok from sabun";
            command = new OracleCommand(queryString, conn);
            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbItem.Items.Add(reader.GetString(1));
                    listHarga.Add(reader.GetInt32(2));
                    listStok.Add(reader.GetInt32(3));
                    MessageBox.Show(Convert.ToString(reader.GetInt32(3)));
                }

            }
            
            cmbItem.SelectedIndex = 0;

            conn.Close();
        }
        void newNota()
        {
            String  notaL="";
            conn.Open();

            string queryString = "select * from (select substr(nomor_nota,5) from h_trans order by 1 desc) where rownum = 1";
            OracleCommand command = new OracleCommand(queryString, conn);
            using (OracleDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    notaL = reader.GetString(0).ToString();
                }
            }
            //MessageBox.Show(DateTime.Now.ToString("yyyyMMdd"));
            conn.Close();
            if (notaL.Substring(0,8).Equals(DateTime.Now.ToString("yyyyMMdd").ToString()))
            {
                int ctr = Convert.ToInt32(notaL.Substring(9)) + 1;
                textNomorSO.Text = "NOTA" + DateTime.Now.ToString("yyyyMMdd").ToString()+ctr.ToString("00#");
            }
            else
            {
                textNomorSO.Text = "NOTA" + DateTime.Now.ToString("yyyyMMdd").ToString() + "001";
            }

            //textNomorSO.Text = "NOTA20220105005";


        }

        private void cmbItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCode.Text = (cmbItem.SelectedIndex + 1) +"";
            updateHarga();
        }

        private void Qty_ValueChanged(object sender, EventArgs e)
        {
            updateHarga();
        }

        void updateHarga()
        {
            textAmount.Text = Convert.ToInt32(listHarga[cmbItem.SelectedIndex]) * kali * Qty.Value + "";
        }

        private void cmbSatuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSatuan.SelectedIndex)
            {
                case 0:
                    kali = 1;
                    break;
                case 1:
                    kali = 6;
                    break;
                case 2:
                    kali = 12;
                    break;
                case 3:
                    kali = 24;
                    break;
            }
            updateHarga();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(listStok[cmbSatuan.SelectedIndex]) < kali * Qty.Value)
            {
                MessageBox.Show("Stok tidak mencukupi");
            }
            else
            {
                listStok[cmbSatuan.SelectedIndex] = Convert.ToInt32(listStok[cmbSatuan.SelectedIndex]) - kali * Qty.Value;
                dataGridView1.Rows.Add(tbCode.Text, cmbItem.SelectedItem, Qty.Value, cmbSatuan.SelectedItem, textAmount.Text, cmbSatuan.SelectedIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idx = -1;
            cmbSatuan.SelectedIndex = 0;
            cmbItem.SelectedIndex = 0;
            Qty.Value = 1;
        }
        int idx = -1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            cmbItem.SelectedIndex = Convert.ToInt32(dataGridView1.Rows[idx].Cells[0].Value)-1;
            Qty.Value = Convert.ToInt32(dataGridView1.Rows[idx].Cells[2].Value);
            switch (dataGridView1.Rows[idx].Cells[3].Value.ToString())
            {
                case "biji":
                    cmbSatuan.SelectedIndex = 0;
                    break;
                case "dus kecil":
                    cmbSatuan.SelectedIndex = 1;
                    break;
                case "dus sedang":
                    cmbSatuan.SelectedIndex = 2;
                    break;
                case "dus besar":
                    cmbSatuan.SelectedIndex = 3;
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (idx>-1)
            {

                if (Convert.ToInt32(listStok[cmbSatuan.SelectedIndex]) < kali * Qty.Value)
                {
                    MessageBox.Show("Stok tidak mencukupi");
                }
                else
                {
                    dataGridView1.Rows[idx].Cells[0].Value = tbCode.Text;
                    dataGridView1.Rows[idx].Cells[1].Value = cmbItem.SelectedItem;
                    dataGridView1.Rows[idx].Cells[2].Value = Qty.Value;
                    dataGridView1.Rows[idx].Cells[3].Value = cmbSatuan.SelectedItem;
                    dataGridView1.Rows[idx].Cells[4].Value = textAmount.Text;
                }

            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.Value.ToString("dd-MM-yyyy"));
            idx = e.RowIndex;
            cmbItem.SelectedIndex = Convert.ToInt32(dataGridView1.Rows[idx].Cells[0].Value) - 1;
            Qty.Value = Convert.ToInt32(dataGridView1.Rows[idx].Cells[2].Value);
            switch (dataGridView1.Rows[idx].Cells[3].Value.ToString())
            {
                case "biji":
                    cmbSatuan.SelectedIndex = 0;
                    break;
                case "dus kecil":
                    cmbSatuan.SelectedIndex = 1;
                    break;
                case "dus sedang":
                    cmbSatuan.SelectedIndex = 2;
                    break;
                case "dus besar":
                    cmbSatuan.SelectedIndex = 3;
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (idx > -1)
            {
                listStok[cmbSatuan.SelectedIndex] = Convert.ToInt32(listStok[cmbSatuan.SelectedIndex]) + kali * Qty.Value;
                dataGridView1.Rows.RemoveAt(idx);

                idx = -1;
                cmbSatuan.SelectedIndex = 0;
                cmbItem.SelectedIndex = 0;
                Qty.Value = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int total = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    total += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                }
                conn.Open();

                cmd = new OracleCommand($"insert into h_trans values('{textNomorSO.Text}'," +
                    $"TO_DATE('{dateTimePicker1.Value.ToString("dd-MM-yyyy")}', 'DD-MM-YYYY')," +
                    $" {total}, " +
                    $"{IDKaryawan}, " +
                    $"{cmbCust.SelectedIndex + 1}, " +
                    $"'{comboBox1.SelectedItem}',0,0)", conn);
                cmd.ExecuteNonQuery();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    cmd = new OracleCommand($"insert into d_trans values('{textNomorSO.Text}'," +
                        $"{dataGridView1.Rows[i].Cells[0].Value}," +
                        $"{dataGridView1.Rows[i].Cells[2].Value}," +
                        $"{dataGridView1.Rows[i].Cells[5].Value}," +
                        $"{dataGridView1.Rows[i].Cells[4].Value})", conn);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Berhasil Buat Sales Order");
                conn.Close();

                dataGridView1.Rows.Clear();
                idx = -1;
                cmbSatuan.SelectedIndex = 0;
                cmbItem.SelectedIndex = 0;
                Qty.Value = 1;

                newNota();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
        }
    }
}
