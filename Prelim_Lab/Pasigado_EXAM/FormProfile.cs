using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasigado_EXAM
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        public ExamForm1 reference = new ExamForm1();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
        }
        String filename = String.Empty;
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult rs = PicDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pictureBox1.ImageLocation = PicDialog.FileName;
                filename = PicDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(String.Empty) || textBox2.Text.Equals(String.Empty))
            {
                MessageBox.Show("Firstname and/or lastname must not be empty", "Oppps!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (filename.Equals(String.Empty))
            {
                MessageBox.Show("Please select a profile image", "Oppps!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                reference.addData(textBox2.Text, textBox1.Text, dateTimePicker1.Value, filename);
                this.Close();
            }
        }
    }
}
