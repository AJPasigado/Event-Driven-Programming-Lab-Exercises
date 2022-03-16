using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Year_Apps {
    public partial class Notes : Form {
        public Notes() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            DialogResult rs = fontDialog.ShowDialog();
            if (rs == DialogResult.OK) {
                textBox1.Font = fontDialog.Font;
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            DialogResult rs = colorDialog.ShowDialog();
            if (rs == DialogResult.OK) {
                textBox1.ForeColor = colorDialog.Color;
            }
        }
    }
}
