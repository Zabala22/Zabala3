using System.IO;

namespace contact_tracing_program
{
    public partial class CTF1 : Form
    {
        

        public CTF1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nametextbox.Text = "";
            agetextbox.Text = "";
            emailtextbox.Text = "";
            numbertextbox.Text = "";
            datetextbox.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CTsavebutton_Click(object sender, EventArgs e)
        {
            // create textfile for data

            StreamWriter outputFile;
            outputFile = File.AppendText(@"C:\Users\zabal\Documents\Contact Tracing Files\FILE RECORDS.txt");

            outputFile.WriteLine(CTlabelname.Text + " " + nametextbox.Text);
            outputFile.WriteLine(CTlabelage.Text + " " + agetextbox.Text);
            outputFile.WriteLine(CTlabelemail.Text + " " + emailtextbox.Text);
            outputFile.WriteLine(CTlabelnumber.Text + " " + numbertextbox.Text);
            outputFile.WriteLine(CTlabeldate.Text + " " + datetextbox.Text);

            // radiobutton sex category

            if (radioButton1.Checked)
                outputFile.WriteLine(radioButton1.Text);

            else if (radioButton2.Checked)
                outputFile.WriteLine(radioButton2.Text);

            // line space for new data

            outputFile.WriteLine();
            outputFile.Close();

            if (string.IsNullOrEmpty(nametextbox.Text))
                return;
            CTlistbox.Items.Add(nametextbox.Text);
            nametextbox.Focus();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CTexitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CTF_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 CTF2 = new Form2();
            CTF2.Show();
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CTlabel1.Text = CTlistbox.Text;
        }
    }
    }
