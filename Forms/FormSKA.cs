using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Modern_Magazyn.Forms
{
    public partial class FormSKA : Form
    {
        public FormSKA()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void FormSKA_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
            con.Open();
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'mydbDataSet.skatbl' . Możesz go przenieść lub usunąć.
            this.skatblTableAdapter.Fill(this.mydbDataSet.skatbl);
            con.Close();
            LoadTheme();
            Edit(false);

        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            dataGridView1.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            dataGridView1.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                Edit(true);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                mydbDataSet.skatbl.AddskatblRow(mydbDataSet.skatbl.NewskatblRow());
                skatblBindingSource.MoveLast();
                txtkolekcja.Focus();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                mydbDataSet.skatbl.RejectChanges();
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtkolekcja.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jesteś pewien ,że chcesz usunąć ten rekord?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                skatblBindingSource.RemoveCurrent();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                skatblBindingSource.EndEdit();
                skatblTableAdapter.Update(mydbDataSet.skatbl);
                dataGridView1.Refresh();
                txtkolekcja.Focus();
                con.Close();
                MessageBox.Show("Your Data has been sucesfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Btn4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mydbDataSet.skatbl.RejectChanges();
            }
        }
        private void Edit(bool value)
        {
            txtbelka.Enabled = value;
            txtkolekcja.Enabled = value;
            txtodpad.Enabled = value;
            txtkanina.Enabled = value;
            txtuwagi.Enabled = value;

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//Enter
            {
                if (MessageBox.Show("Jesteś pewien ,że chcesz usunąć ten rekord?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    skatblBindingSource.RemoveCurrent();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
            string sqlcmd = "SELECT * FROM skatbl WHERE kod LIKE '" + textBox1.Text + "%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}

 
  






