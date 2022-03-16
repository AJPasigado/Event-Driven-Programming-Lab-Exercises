using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec_FORMS
{
    public partial class FormSec : Form
    {

        public Form Reference_main { get; set; }
        public FormSec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reference_main.Text = textBox2.Text;
            this.Close();
        }

        private void FormSec_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reference_main.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
