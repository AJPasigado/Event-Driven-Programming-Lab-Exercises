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
    public partial class LabForm1 : Form {
        public LabForm1() {
            InitializeComponent();
        }

        int index = 0;

        private void button1_Click(object sender, EventArgs e) {
            ProfileForm prof = new ProfileForm();
            prof.ReferenceToForm = this;
            prof.Show();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }


        public void addDatas(String name, String addr, String gender, String mar, DateTime dt, String file) {
            index++;
            ListViewItem itm = new ListViewItem(index.ToString());
            itm.SubItems.Add("Basta");
            itm.SubItems.Add(addr);
            itm.SubItems.Add(gender);
            itm.SubItems.Add(mar);

            itm.SubItems.Add(((DateTime.Now.Subtract(dt).TotalDays)/365).ToString());
          //  itm.SubItems.Add(dt.ToString("MMMM/dd/yyyy"));
            itm.SubItems.Add(file);
            listView1.Items.Add(itm);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
            for (int i=0; i<listView1.Items.Count; i++) {
                if (listView1.Items[i].Selected) {
                    textBox1.Text = listView1.Items[i].Index.ToString();
                    textBox2.Text = listView1.Items[i].SubItems[1].Text;
                    listView1.Items[i].SubItems[1].Text = "Yeah";
                    pictureBox1.ImageLocation = listView1.Items[i].SubItems[6].Text;
                    textBox3.Text = listView1.Items[i].SubItems[6].Text;

                    listView1.Items[i].BackColor = Color.Aqua;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            for (int i = 0; i < listView1.Items.Count; i++) {
                if (listView1.Items[i].Selected) {
                    listView1.Items[i].Remove();
                    i--;
                }
            }
            updateIndex();
            index--;
        }

        private void updateIndex() {
            for (int i = 0; i < listView1.Items.Count; i++) {
                listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e) {
            

            ProfileForm prof = new ProfileForm();
            prof.ReferenceToForm = this;

            for (int i = 0; i < listView1.Items.Count; i++) {
                if (listView1.Items[i].Selected) {
                    prof.setValue(listView1.Items[i].SubItems[2].Text);
                    prof.index = i;
                }
            }
            
            prof.text = "Update";
            prof.Show();
        }

        public void changeData (int index, String name, String addr, String gender, String mar, DateTime dt, String file) {
            listView1.Items[index].SubItems[1].Text = name;
            listView1.Items[index].SubItems[2].Text = addr;
            listView1.Items[index].SubItems[3].Text = gender;
            listView1.Items[index].SubItems[4].Text = mar;
            listView1.Items[index].SubItems[6].Text = file;
        }

        private void button4_Click(object sender, EventArgs e) {

        }

        private void LabForm1_Load(object sender, EventArgs e) {

        }
    }
}
