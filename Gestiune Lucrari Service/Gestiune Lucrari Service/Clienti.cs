using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Gestiune_Lucrari_Service
{
    public partial class Clienti : Form
    {
        string path = "Data Source=DESKTOP-HUEGF7L;Initial Catalog=Lucrari_Service_Auto;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;

        int ID;

        public Clienti()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void Clienti_Load(object sender, EventArgs e)
        {

        }

        public void display()
        {

            try
            {

                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Clienti", con);

                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Clienti (Nume, Prenume, Telefon, Istoric_lucrari) values ('" + textNume.Text + "', '" + textPrenume.Text + "', '" + textTelefon.Text + "', '" + textIstoric.Text + "') ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Refresh();
                MessageBox.Show("Un nou client a fost adaugat!");
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Clienti set Nume='" + textNume.Text + "', Prenume='" + textPrenume.Text + "', Telefon='" + textTelefon.Text + "', Istoric_lucrari='" + textIstoric.Text + "' where ClientID='" + ID + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Refresh();
                MessageBox.Show("Datele au fost schimbate!");
                display();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from Clienti where ClientID='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Clientul a fost sters!");

                con.Close();
                Refresh();
                display();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textNume.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textPrenume.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textIstoric.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Complex3 c3 = new Complex3();
            c3.Show();
        }
    }
}
