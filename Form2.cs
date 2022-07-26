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
            string namelist = @"C:\Users\zabal\Documents\Contact Tracing Files\FILE RECORDS.txt";

            //string[] lines = File.ReadAllLines(filepath);

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(namelist).ToList();

            foreach (String line in lines)
            {
                Console.WriteLine(line);
            }
                Console.ReadLine();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
