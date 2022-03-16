using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasigado_BonusLab {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public void encypt (String a, String lvl) {
            if (lvl.Equals("")) {
                comboBox1.SelectedIndex = 1;
                lvl = "0";
            }
            

            string[] ltrs = new string[] { "Q", "W", "E", "R", "T", "Y", "A", "S", "D", "F", "G", "H", "Z", "X", "C", "V", "B", "N" };
            textBox1.AppendText(ltrs[(Array.IndexOf(ltrs, a)+ int.Parse(lvl))% 18]);
        }

        private void button1_Click(object sender, EventArgs e) {
            encypt(button1.Text, comboBox1.Text);
        }
        private void button2_Click(object sender, EventArgs e) {
            encypt(button2.Text, comboBox1.Text);
        }
        private void button3_Click(object sender, EventArgs e) {
            encypt(button3.Text, comboBox1.Text);
        }
        private void button4_Click(object sender, EventArgs e) {
            encypt(button4.Text, comboBox1.Text);
        }
        private void button5_Click(object sender, EventArgs e) {
            encypt(button5.Text, comboBox1.Text);
        }
        private void button6_Click(object sender, EventArgs e) {
            encypt(button6.Text, comboBox1.Text);
        }
        private void button7_Click(object sender, EventArgs e) {
            encypt(button7.Text, comboBox1.Text);
        }
        private void button8_Click(object sender, EventArgs e) {
            encypt(button8.Text, comboBox1.Text);
        }
        private void button9_Click(object sender, EventArgs e) {
            encypt(button9.Text, comboBox1.Text);
        }
        private void button10_Click(object sender, EventArgs e) {
            encypt(button10.Text, comboBox1.Text);
        }
        private void button11_Click(object sender, EventArgs e) {
            encypt(button11.Text, comboBox1.Text);
        }
        private void button12_Click(object sender, EventArgs e) {
            encypt(button12.Text, comboBox1.Text);
        }
        private void button13_Click(object sender, EventArgs e) {
            encypt(button13.Text, comboBox1.Text);
        }
        private void button14_Click(object sender, EventArgs e) {
            encypt(button14.Text, comboBox1.Text);
        }
        private void button15_Click(object sender, EventArgs e) {
            encypt(button15.Text, comboBox1.Text);
        }
        private void button16_Click(object sender, EventArgs e) {
            encypt(button16.Text, comboBox1.Text);
        }
        private void button17_Click(object sender, EventArgs e) {
            encypt(button17.Text, comboBox1.Text);
        }
        private void button18_Click(object sender, EventArgs e) {
            encypt(button18.Text, comboBox1.Text);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void button19_Click(object sender, EventArgs e) {
            ListViewItem itm = new ListViewItem(textBox1.Text);
            itm.SubItems.Add(comboBox1.Text);
            listView1.Items.Add(itm);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == 0) {
                textBox1.Text = "";
            }
        }
    }
}
