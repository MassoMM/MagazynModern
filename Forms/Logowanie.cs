using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;


namespace Modern_Magazyn.Forms
{
    
    public partial class Logowanie : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthElipse,
            int nHeightElipse
           
           
        );
        public  Logowanie()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
          
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string tx1 = loginbox.Text.Trim();
            string tx2 = psbox.Text.Trim();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);
            con.Open();
            string query = "SELECT * FROM tbl where username='" + tx1 + "' and password ='" + tx2 + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            con.Close();
            if (dtbl.Rows.Count == 1)
            {
                ProgressBar1.Value = 0;
                timer2.Enabled = true;
                label1.Visible = true;
                ProgressBar1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                loginbox.Visible = false;
                psbox.Visible = false;
                panel1.Visible = false;
                panel2.Visible = false;
                button1.Visible = false;

            }
            else
            {
            MessageBox.Show("Error");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void psbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)//Enter
            {
                button1.Focus();
            }
        }
        private void loginbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//Enter
            {
                psbox.Focus();
            }
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {
            ProgressBar1.Visible = false;
            label1.Visible = false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            

                ProgressBar1.Value += 1;
                ProgressBar1.Text = ProgressBar1.Value.ToString() + "%";
                if (ProgressBar1.Value == 100)
                {
                    timer2.Enabled = false;
                    FormHome objdesktop = new FormHome();
                    this.Hide();
                    objdesktop.Show();
                }
            
        }
    }
}


