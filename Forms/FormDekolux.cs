﻿using System;
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
    public partial class FormDekolux : Form
    {
        public FormDekolux()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void FormDekolux_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
            con.Open();
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'mydbDataSet.dktbl' . Możesz go przenieść lub usunąć.
            this.dktblTableAdapter.Fill(this.mydbDataSet.dktbl);
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

        private void button5_Click(object sender, EventArgs e)
        {

            Edit(false);
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                dktblBindingSource.Filter = string.Format("kolor = '{0}' OR kod LIKE '*{1}*' OR ilosc = '{2}' OR uwagi LIKE '*{3}*' OR dluzyca = '{4}'  ", txtkolekcja.Text, txtkanina.Text, txtbelka.Text,  txtuwagi.Text, txtodpad.Text);
                con.Close();
            }
            else
            {
                dktblBindingSource.Filter = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                Edit(true);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                mydbDataSet.dktbl.AdddktblRow(mydbDataSet.dktbl.NewdktblRow());
                dktblBindingSource.MoveLast();
                txtkolekcja.Focus();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                mydbDataSet.dktbl.RejectChanges();
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
                dktblBindingSource.RemoveCurrent();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                dktblBindingSource.EndEdit();
                dktblTableAdapter.Update(mydbDataSet.dktbl);
                dataGridView1.Refresh();
                txtkolekcja.Focus();
                con.Close();
                MessageBox.Show("Your Data has been sucesfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Btn4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                mydbDataSet.dktbl.RejectChanges();
                con.Close();
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
                    dktblBindingSource.RemoveCurrent();
                }
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
            string sqlcmd = "SELECT * FROM dktbl WHERE kolor LIKE '" + txtSearch.Text + "%'";
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








