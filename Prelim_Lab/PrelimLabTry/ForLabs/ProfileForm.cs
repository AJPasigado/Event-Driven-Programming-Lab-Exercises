using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLabs {
    public partial class ProfileForm : Form {
        public ProfileForm() {
            InitializeComponent();
        }
        public LabForm1 ReferenceToForm { get; set; }
        public String text = "Add";
        public int index = 0;

        private void ProfileForm_Load(object sender, EventArgs e) {
            button2.Text = text;
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        public void setValue(String name) {
            textBox1.Text = name;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
        }

        private void button2_Click(object sender, EventArgs e) {
            if (button2.Text.Equals("Update")) {
                ReferenceToForm.changeData(index ,textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Value, textBox5.Text);
            } else 
                ReferenceToForm.addDatas(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Value, textBox5.Text);
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult rs = PicDiag.ShowDialog();
            if (rs == DialogResult.OK) {
                pictureBox1.ImageLocation = PicDiag.FileName;
                textBox5.Text = PicDiag.FileName.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e) {
            textBox1.Text = e.KeyCode.ToString();
            if (!(e.KeyCode.ToString().Equals("D0") ||
                e.KeyCode.ToString().Equals("D1") ||
                e.KeyCode.ToString().Equals("D2") ||
                e.KeyCode.ToString().Equals("D3") ||
                e.KeyCode.ToString().Equals("D4") ||
                e.KeyCode.ToString().Equals("D5") ||
                e.KeyCode.ToString().Equals("D6") ||
                e.KeyCode.ToString().Equals("D7") ||
                e.KeyCode.ToString().Equals("D8") ||
                e.KeyCode.ToString().Equals("D9"))
                ) {
                e.SuppressKeyPress = true;
            }
        }
    }
}

