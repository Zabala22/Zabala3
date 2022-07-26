using System.IO;

namespace contact_tracing_program
{
    public partial class CTF : Form
    {
        public CTF()
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

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}