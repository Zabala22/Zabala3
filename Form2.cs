using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_tracing_program
{
    public partial class Form2 : Form
    {
     
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            CTFinfobox.Text = CTF1.name;
        }

        private void CTgenerateqrcodebutton_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(CTFinfobox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            CTpicturebox.Image = code.GetGraphic(5);
        }

        private void CTsaveqrcodebutton_Click(object sender, EventArgs e)
        {
            string initialDIR = @"C:\Users\zabal\Documents\Contact Tracing Files";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialDIR;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CTpicturebox.Image.Save(dialog.FileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CTexitbutton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
