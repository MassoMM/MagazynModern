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
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace Modern_Magazyn.Forms
{
    public partial class FormDN : Form
    {
        public FormDN()
        {
            
            InitializeComponent();
            LoadTheme();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qrboxim.Visible = false;
            qrbox.Visible = false;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
            con.Open();
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'mydbDataSet1.dntbl' . Możesz go przenieść lub usunąć.
            this.dntblTableAdapter.Fill(this.mydbDataSet.dntbl);
            con.Close();
            LoadTheme();
            Edit(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtkolekcja.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                Edit(true);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                mydbDataSet.dntbl.AdddntblRow(mydbDataSet.dntbl.NewdntblRow());
                dntblBindingSource1.MoveLast();
                txtkolekcja.Focus();
                con.Close();
            }
            catch (Exception ex)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mydbDataSet.dntbl.RejectChanges();
                con.Close();
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
            label4.ForeColor = ThemeColor.SecondaryColor;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            dataGridView1.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            dataGridView1.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jesteś pewien ,że chcesz usunąć ten rekord?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dntblBindingSource1.RemoveCurrent();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                Edit(false);
                dntblBindingSource1.EndEdit();
                dntblTableAdapter.Update(mydbDataSet.dntbl);
                dataGridView1.Refresh();
                txtkolekcja.Focus();
                con.Close();
                MessageBox.Show("Your Data has been sucesfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            catch (Exception ex)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
                con.Open();
                MessageBox.Show(ex.Message, "Btn4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mydbDataSet.dntbl.RejectChanges();
                con.Close();
            }

        }
        private void Edit(bool value)
        {
            txtbelka.Enabled = value;
            txtkolekcja.Enabled = value;
            txtodpad.Enabled = value;
            txtrozmiar.Enabled = value;
            txtkanina.Enabled = value;
            txtuwagi.Enabled = value;

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//Enter
            {
                if (MessageBox.Show("Jesteś pewien ,że chcesz usunąć ten rekord?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dntblBindingSource1.RemoveCurrent();
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
            string sqlcmd = "SELECT * FROM dntbl WHERE tkanina LIKE '" + textBox2.Text + "%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
            string sqlcmd = "SELECT * FROM dntbl WHERE kolekcja LIKE '" + textBox1.Text + "%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "QR")
            {
                string str = "Kolekcja: " + txtkolekcja.Text + " Tkanina: " + txtkanina.Text + " Belka Rozmiar (cm): " + txtbelka.Text + " Odpad: " + txtodpad.Text + " Rozmiar: " + txtrozmiar.Text + " Uwagi: " + txtuwagi.Text;
                qrbox.Text = str;
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                barcodeWriter.Renderer = new BitmapRenderer();
                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                Bitmap bitmap = barcodeWriter.Write(qrbox.Text);
                Bitmap logo = new Bitmap($"{Application.StartupPath}/logo110.jpg");
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
                qrboxim.Image = bitmap;
                FormQRDN w1 = new FormQRDN(this);
                w1.ShowDialog();

            }
            else
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
                {
                    if (MessageBox.Show("Jesteś pewien ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dntblBindingSource1.RemoveCurrent();
                    }
                }
            }
        }
    }

}














