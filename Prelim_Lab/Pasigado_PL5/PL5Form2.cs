using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasigado_PL5
{
    public partial class PL5Form2 : Form
    {
        public PL5Form1 Reference_ListForm { get; set; }
        String[] female = {"Single", "Single Mom", "Married", "Widowed"};
        String[] male = { "Single", "Single Dad", "Married", "Widowed" };
        String gender;

        public PL5Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult pic = PictureDialog.ShowDialog();
            if (pic == DialogResult.OK)
            {
                textBox1.Text = PictureDialog.FileName.ToString();
                pictureBox1.ImageLocation = textBox1.Text;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            gender = "Male";
            for (int i=0; i<4; i++)
            {
                comboBox1.Items.Add(male[i]);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            gender = "Female";
            for (int i = 0; i < 4; i++)
            {
                comboBox1.Items.Add(female[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Equals("") || textBox2.Equals("") || comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Required Fields.", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                Reference_ListForm.addItem(textBox3.Text + ", " + textBox2.Text, gender, comboBox1.Text);
                this.Close();
            }
            
        }

        private void PL5Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
