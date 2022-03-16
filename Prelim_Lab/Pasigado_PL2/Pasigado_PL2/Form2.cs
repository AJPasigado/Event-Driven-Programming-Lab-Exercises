using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasigado_PL2
{
    public partial class Form2 : Form
    {
        public Form Reference_Form1 { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 thirdform = new Form3();
            thirdform.Reference_Form2 = this;
            thirdform.Text = this.Text;
            thirdform.Location = this.Location;
            thirdform.Size = this.Size;
            thirdform.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reference_Form1.Size = Size;
            Reference_Form1.Location = Location;
            Reference_Form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
