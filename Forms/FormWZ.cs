using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Modern_Magazyn.Forms
{
    public partial class FormWZ : Form
    {
        public FormWZ()
        {
            InitializeComponent();
            LoadTheme();

        }

        private void FormUstawienia_Load(object sender, EventArgs e)
        {
            Edit(false);
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
            con.Open();
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'mydbDataSet.wztbl' . Możesz go przenieść lub usunąć.
            this.wztblTableAdapter.Fill(this.mydbDataSet.wztbl);
            LoadTheme();
            con.Close();
            

        }
        private void Edit(bool value)
        {
            txtzlecenie.Enabled = value;
            textBox4.Enabled = value;
            textBox5.Enabled = value;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit(false);
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                wztblBindingSource.EndEdit();
                wztblTableAdapter.Update(mydbDataSet.wztbl);
                dataGridView1.Refresh();
                txtzlecenie.Focus();
                con.Close();
                MessageBox.Show("Your Data has been sucesfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Btn4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mydbDataSet.wztbl.RejectChanges();
            }
            wydaniezew w1 = new wydaniezew(this);
            w1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit(true);
          try
            { 
                mydbDataSet.wztbl.AddwztblRow(mydbDataSet.wztbl.NewwztblRow());
                wztblBindingSource.MoveLast();
                txtzlecenie.Focus();
  
             }
            catch (Exception ex)
                {
                     MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     mydbDataSet.wztbl.RejectChanges();
                }
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
            label4.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            dataGridView1.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            dataGridView1.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jesteś pewien ,że chcesz usunąć ten rekord?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                wztblBindingSource.RemoveCurrent();
            }
        }
    }
}
