using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modern_Magazyn.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Modern_Magazyn
{
    public partial class FormHome : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnectionString"].ConnectionString);


        public FormHome()
        {
            
            InitializeComponent();
            random = new Random();
            btnclose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            customizedesign();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    DisableButton2();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnclose.Visible = true;
                }


            }


        }


        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls )
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                }
            }
        }
        private void DisableButton2()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            ActivateButton(btnsender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleBar.Text = childForm.Text;

        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFlat(), sender);
            hidesubmenu();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDN(), sender);
            hidesubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new Komponenty(), sender);
            if (panel1.Visible == false)
            { 
                showSubMenu(panel1);
            }
            else
            {
                hidesubmenu();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFlat(), sender);
            hidesubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFlat(), sender);
            hidesubmenu();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }

        }
        private void Reset()
        {
            DisableButton();
            labelTitleBar.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(127, 0, 0);
            panelLogo.BackColor = Color.FromArgb(102, 0, 0);
            currentButton = null;
            btnclose.Visible = false;

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
          
        }
        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormWZ(), sender);
            hidesubmenu();
        }
        private void customizedesign()
        {
            panel1.Visible = false;
        }
        private void hidesubmenu()
        {
            if(panel1.Visible == true)
            {
                panel1.Visible = false;
            }
        }
        private void showSubMenu(Panel submenu)
        {
            if (panel1.Visible == false)
            {
                if(submenu.Visible == false)
                {
                    hidesubmenu();
                    submenu.Visible = true;
                }
                else
                {
                    submenu.Visible = false;
                }
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormWW(), sender);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormSKA(), sender);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormDekolux(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMF(), sender);
           
        }
    }


}
