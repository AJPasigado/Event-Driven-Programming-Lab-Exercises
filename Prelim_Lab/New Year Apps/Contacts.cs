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
    public partial class Contacts : Form {
        public Contacts() {
            InitializeComponent();
        }

        private void AddBTN_Click(object sender, EventArgs e) {
            ContactsNew form = new ContactsNew();
            this.Hide();
            form.Reference = this;
            form.Show();
        }

        public void AddToList(String name, String num) {
            ListViewItem itm = new ListViewItem(name);
            itm.SubItems.Add(num);
            listView1.Items.Add(itm);
        }
    }
}
