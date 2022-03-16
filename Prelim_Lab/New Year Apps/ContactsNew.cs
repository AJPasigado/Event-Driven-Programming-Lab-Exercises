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
    public partial class ContactsNew : Form {
        public ContactsNew() {
            InitializeComponent();
        }

        public Contacts Reference { get; set; }

        private void button2_Click(object sender, EventArgs e) {
            Reference.AddToList(textBox2.Text + ", " + textBox1.Text, textBox3.Text);
            Reference.Show();
            this.Close();
        }
    }
}
