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
    public partial class Form3 : Form
    {

        public Form Reference_Form2 { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button2.Text = this.Text;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reference_Form2.Size = this.Size;
            Reference_Form2.Location = this.Location;
            Reference_Form2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
