using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Form1 : Form
    {
        String[] Len = {"Meter", "Kilometer", "Foot", "Inch"};
        String[] Mass = { "Gram", "Kilogram", "Pound", "Ounce" };
        String[] Time = { "Second", "Minutes", "Hours", "Days" };
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Length"))
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                for (int i=0; i<Len.Length; i++)
                {
                    comboBox2.Items.Add(Len[i]);
                    comboBox3.Items.Add(Len[i]);
                    comboBox2.Text = Len[0];
                    comboBox3.Text = Len[1];
                }
                
            } else if (comboBox1.Text.Equals("Mass"))
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                for (int i = 0; i < Len.Length; i++)
                {
                    comboBox2.Items.Add(Mass[i]);
                    comboBox3.Items.Add(Mass[i]);
                    comboBox2.Text = Mass[0];
                    comboBox3.Text = Mass[1];
                }

            } else if (comboBox1.Text.Equals("Time"))
            {

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                for (int i = 0; i < Len.Length; i++)
                {
                    comboBox2.Items.Add(Time[i]);
                    comboBox3.Items.Add(Time[i]);
                    comboBox2.Text = Time[0];
                    comboBox3.Text = Time[1];
                }
            } else if (comboBox1.Text.Equals(String.Empty))
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox2.Text = "";
                comboBox3.Text = "";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox1.BackColor = Color.IndianRed;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox2.BackColor = Color.IndianRed;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == comboBox2.SelectedIndex && comboBox1.SelectedIndex != 0)
            {
                if (comboBox2.SelectedIndex == 3)
                {
                    comboBox2.SelectedIndex = 1;
                }
                else
                    comboBox3.SelectedIndex = comboBox3.SelectedIndex % 4 +1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!comboBox1.Text.Equals(String.Empty))
            {
                
                textBox2.Text = "convert.here";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!comboBox1.Text.Equals(String.Empty))
            {
                
                textBox1.Text = "convert.here";
            }
        }

        private void comboBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == comboBox2.SelectedIndex && comboBox1.SelectedIndex != 0)
            {
                if (comboBox2.SelectedIndex == 3)
                {
                    comboBox2.SelectedIndex = 1;
                } else 
                    comboBox2.SelectedIndex = comboBox2.SelectedIndex % 4 +1;
            }
        }

        private void comboBox3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   this.DialogResult = textBox1.Text; 
        }
    }
}
