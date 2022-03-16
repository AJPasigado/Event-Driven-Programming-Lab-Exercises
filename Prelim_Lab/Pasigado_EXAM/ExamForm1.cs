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
    public partial class ExamForm1 : Form
    {
        public ExamForm1()
        {
            InitializeComponent();
        }
        Font defaultf;

        private void ExamForm1_Load(object sender, EventArgs e)
        {
            defaultf = label5.Font;
            label2.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProfile fp = new FormProfile();
            fp.reference = this;
            fp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Font = defaultf;
            label5.Font = defaultf;
            label6.Font = defaultf;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            panel1.BackColor = Color.Black;
            pictureBox1.Hide();
        }

        int index = 0;
        public void addData (String lastName, String firstName, DateTime birthmonth, String file)
        {
            index++;
            ListViewItem itm = new ListViewItem(index.ToString());
            itm.SubItems.Add(lastName);
            itm.SubItems.Add(firstName);
            itm.SubItems.Add(birthmonth.ToString("MMMM"));
            itm.SubItems.Add(birthmonth.ToString("dd"));
            itm.SubItems.Add(birthmonth.ToString("yyyy"));
            itm.SubItems.Add(((int)((DateTime.Now.Subtract(birthmonth).TotalDays)/365)).ToString());
            itm.SubItems.Add(file);
            listView1.Items.Add(itm);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Show();
            for (int i=0; i<listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    pictureBox1.ImageLocation = listView1.Items[i].SubItems[7].Text;
                    textBox1.Text = listView1.Items[i].SubItems[1].Text + ", " + listView1.Items[i].SubItems[2].Text;
                    textBox2.Text = listView1.Items[i].SubItems[3].Text + " " + listView1.Items[i].SubItems[4].Text + ", " + listView1.Items[i].SubItems[5].Text;
                    textBox3.Text = listView1.Items[i].SubItems[6].Text;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("You must select a profile", "Oppps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                DialogResult rs = fontDialog.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    label4.Font = fontDialog.Font;
                    label5.Font = fontDialog.Font;
                    label6.Font = fontDialog.Font;
                    textBox1.Font = fontDialog.Font;
                    textBox2.Font = fontDialog.Font;
                    textBox3.Font = fontDialog.Font;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("You must select a profile", "Oppps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = colorDialog.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    label4.ForeColor = colorDialog.Color;
                    label5.ForeColor = colorDialog.Color;
                    label6.ForeColor = colorDialog.Color;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("You must select a profile", "Oppps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = colorDialog.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    panel1.BackColor = colorDialog.Color;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkOliveGreen;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.IndianRed;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
