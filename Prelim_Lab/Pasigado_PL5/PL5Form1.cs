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
    public partial class PL5Form1 : Form
    {
        int num = 0;
        double male;
        double female;

        public PL5Form1()
        {
            InitializeComponent();
        }

        private void PL5Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                DialogResult mb = MessageBox.Show("Are you sure you want to exit?", "Are you?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mb == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL5Form2 AddForm = new PL5Form2();
            AddForm.Reference_ListForm = this;
            AddForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            num = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        public void addItem (String Fullname, String Gender, String CivilStatus)
        {
            num++;
            ListViewItem item = new ListViewItem(num.ToString());
            item.SubItems.Add(Fullname);
            item.SubItems.Add(Gender);
            item.SubItems.Add(CivilStatus);
            listView1.Items.Add(item);

            if (Gender.Equals("Male"))
            {
                male++;
                textBox1.Text = male.ToString();
                textBox4.Text = female.ToString();
                textBox2.Text = (male / num * 100).ToString("#.##") + "%";
                textBox3.Text = (female / num * 100).ToString("#.##") + "%";
                if (textBox3.Text.Equals("%"))
                {
                    textBox3.Text = "0%";
                }
                if (textBox2.Text.Equals("%"))
                {
                    textBox2.Text = "0%";
                }
            } else if (Gender.Equals("Female"))
            {
                female++;
                textBox1.Text = male.ToString();
                textBox4.Text = female.ToString();
                textBox2.Text = (male / num * 100).ToString("#.##") + "%";
                textBox3.Text = (female / num * 100).ToString("#.##") + "%";
                if (textBox3.Text.Equals("%"))
                {
                    textBox3.Text = "0%";
                }
                if (textBox2.Text.Equals("%"))
                {
                    textBox2.Text = "0%";
                }
            }
        }
    }
}
