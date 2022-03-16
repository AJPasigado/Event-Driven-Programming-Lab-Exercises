using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQPI
{
    public partial class Form1 : Form
    {
        double grade;
        int total;
        bool equalspress = false;
        bool letterPressed = false;
        double prev; String letter;
        Point lastLocation;
        bool mouseDown;

        public Form1()
        {
            InitializeComponent();
        }

        private void AppendTheText (String a, double QPI, int b)
        {


            if (equalspress) {
                textBox1.Text = String.Empty;
                textBox2.Text = "0.0"; equalspress = false; grade = 0; total = 0; }
            if (textBox1.Text == "")
            {
                textBox1.Text = "("+a+":"+b+")";
            } else textBox1.AppendText(" + (" + a +":" + b + ")");

            total += b;
            grade += QPI * b;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void changeForm(bool a)
        {
            letterPressed = true;
            button4.Visible = !a;
            button7.Visible = !a;
            button8.Visible = !a;
            button9.Visible = !a;
            if (a)
            {
                button1.Text = "3";
                button2.Text = "5";
                button3.Text = "9";
                button6.Text = "1";
                button5.Text = "2";
                textBox4.Text = "Choose a unit.";
            } else
            {
                button1.Text = "A";
                button2.Text = "B+";
                button3.Text = "B";
                button6.Text = "C+";
                button5.Text = "C";
                textBox4.Text = "Choose a letter grade.";
                letterPressed = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!letterPressed)
            {
                prev = 3.5; letter = "B+";
                changeForm(true);
            }
            else { AppendTheText(letter, prev, 5); changeForm(false); prev = 0; letter = String.Empty; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!letterPressed)
            {
                prev = 4; letter = "A";
                changeForm(true);
            }
            else { AppendTheText(letter, prev, 3); changeForm(false); prev = 0; letter = String.Empty; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!letterPressed)
            {
                prev = 3; letter = "B";
                changeForm(true);
            }
            else { AppendTheText(letter, prev, 9); changeForm(false); prev = 0; letter = String.Empty; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!letterPressed)
            {
                prev = 2.5; letter = "C+";
                changeForm(true);
            }
            else { AppendTheText(letter, prev, 1); changeForm(false); prev = 0; letter = String.Empty; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!letterPressed)
            {
                prev = 2; letter = "C";
                changeForm(true);
            }
            else { AppendTheText(letter, prev, 2); changeForm(false); prev = 0; letter = String.Empty; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prev = 1; letter = "D";
            changeForm(true);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            prev = 0; letter = "F/FD";
            changeForm(true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = "0.0";
            grade = 0; total = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            equalspress = true;
            if ((grade / total).ToString("#.##").Equals(""))
            {
                textBox2.Text = grade.ToString() + "/" + total.ToString() + "=0";
            } else
                textBox2.Text = grade.ToString() + "/" + total.ToString() + "=" + (grade/total).ToString("#.##");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.Location.X, (this.Location.Y - lastLocation.Y) + e.Location.Y);
                this.Update();
            }
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            textBox4.Text = "Reset calculations.";
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            textBox4.Text = "Choose a letter grade.";
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            textBox4.Text = "Equate.";
        }
    }
}
