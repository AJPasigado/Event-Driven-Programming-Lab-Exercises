using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0_TryCodes {
    public partial class TryForm : Form {

        public MySqlConnection conn;

        public TryForm() {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=midterm_trytabl1;Uid=root; Pwd=root;");
        }

        private void TryForm_Load(object sender, EventArgs e) {
            try {
                conn.Open();
                MessageBox.Show("Connection Successful!");
                conn.Close();
            } catch {
                MessageBox.Show("No Connection Found");
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e) {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                MySqlCommand com = new MySqlCommand("SELECT * FROM Employees WHERE Username = '" + UBox.Text + "' and Passwors = '" + PassBox.Text + "'");
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);

            } catch (Exception ee){
                MessageBox.Show(ee.Message);
                conn.Close();
            }
        }
    }
}
