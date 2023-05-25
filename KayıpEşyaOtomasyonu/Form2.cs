using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KayıpEşyaOtomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Kayıp Eşya Otomasyonu";

        }

        private void esyaismi_TextChanged(object sender, EventArgs e)
        {

        }

        private void bulundugutarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void bulundugukonum_TextChanged(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=kayipesya;uid=root;password='';";
            string insertSql = "INSERT INTO veri (esyaadi, bulundugutarih , bulundugukonum ) VALUES (@value1, @value2 , @value3);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@value1", esyaismi.Text);
                    command.Parameters.AddWithValue("@value2", bulundugutarih.Text);
                    command.Parameters.AddWithValue("@value3", bulundugukonum.Text);

                    command.ExecuteNonQuery();
                    MySqlDataAdapter sqDa = new MySqlDataAdapter("Select * from veri", connection);
                    DataTable dtbl = new DataTable();
                    sqDa.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
                string connectionString = "server=localhost;database=kayipesya;uid=root;password='';";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        string query = $"DELETE FROM veri WHERE id = {id}";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Silme işlemi başarılı!");
                        MySqlDataAdapter sqDa = new MySqlDataAdapter("Select * from veri", connection);
                        DataTable dtbl = new DataTable();
                        sqDa.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Silme işlemi başarısız!" + ex.Message);
            }
           



        }

        private void düzenle_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;



            string connectionString = "server=localhost;database=kayipesya;uid=root;password='';";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string textBox1Value = esyaismi.Text;
                string textBox2Value = bulundugutarih.Text;
                string textBox3Value = bulundugukonum.Text;


                foreach (DataGridViewRow row in selectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["id"].Value);
                    string query = $"UPDATE veri SET esyaadi = @esyaadi, bulundugutarih = @bulundugutarih , bulundugukonum = @bulundugukonum WHERE id = {id}";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@esyaadi", textBox1Value);
                    command.Parameters.AddWithValue("@bulundugutarih", textBox2Value);
                    command.Parameters.AddWithValue("@bulundugukonum", textBox3Value);

                    int rowsUpdated = command.ExecuteNonQuery();

                    MessageBox.Show("Güncelleme Başarılı!");

                    if (rowsUpdated > 0)
                    {

                        MySqlDataAdapter sqDa = new MySqlDataAdapter("Select * from veri", connection);
                        DataTable dtbl = new DataTable();
                        sqDa.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                    }
                }





            }
        }

        private void esyaarama_TextChanged(object sender, EventArgs e)
        {

        }

        private void ara_Click(object sender, EventArgs e)
        {
            string searchText = esyaarama.Text; 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                    {
                        cell.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index; 
                        return; 
                    }
                }
            }
            MessageBox.Show("Arama sonucu bulunamadı.");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void yenile_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=kayipesya;uid=root;password='';";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlDataAdapter sqDa = new MySqlDataAdapter("Select * from veri", connection);
                DataTable dtbl = new DataTable();
                sqDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                string value1 = selectedRow.Cells["esyaadi"].Value.ToString();
                string value2 = selectedRow.Cells["bulundugutarih"].Value.ToString();
                string value3 = selectedRow.Cells["bulundugukonum"].Value.ToString();
                

                esyaismi.Text = value1;
                bulundugutarih.Text = value2;
                bulundugukonum.Text = value3;
               

            }
        }
    }
}