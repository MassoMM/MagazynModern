using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Modern_Magazyn.Forms
{
    public partial class FormQRFlat : Form
    {
        FormFlat FL;
        public FormQRFlat(FormFlat flat1)
        {
            InitializeComponent();
            this.FL = flat1;
        }

        private void FormQRFlat_Load(object sender, EventArgs e)
        {
            Qrbox1.Image = FL.qrboxim.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            //zamiast this.doc_PrintPage używam eventhandlera i widzę dużą poprawę jakości zapisanego pdfa
            doc.DefaultPageSettings.Margins = new Margins(75, 0, 50, 0);
            doc.DefaultPageSettings.PaperSize = new PaperSize("ICard", 595, 864);
            doc.PrintPage += new PrintPageEventHandler(doc_PrintPage);
            PrintDialog dlg = new PrintDialog();
            dlg.Document = doc;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(panel1.Width + 14032, panel1.Height + 19842);
            bmp = bmp.Clone(new Rectangle(0, 0, panel1.Width, panel1.Height), bmp.PixelFormat);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }
    }
}
