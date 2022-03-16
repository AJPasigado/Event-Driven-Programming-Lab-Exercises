using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Login {
    public partial class Login : Form {
        public MySqlConnection conn;

        public Login() {
            InitializeComponent();
            this.Opacity = 0;
            AnimationTMR.Start();
            conn = new MySqlConnection("Server=localhost;Database=SAD_DB;Uid=root;Pwd=root;");
        }

        private void button2_Click(object sender, EventArgs e) {
            if (txtPass.Text.Equals("") || txtUser.Equals("")) {
                MessageBox.Show("The user must supply the necessary fields.");
            }
            else {
                try {
                    conn.Open();

                    MySqlCommand comm = new MySqlCommand("SELECT * FROM tbl_accounts WHERE username = '" + txtUser.Text + "' AND password = '" + txtPass.Text + "'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count == 1) {
                        if (int.Parse(dt.Rows[0]["account_status"].ToString()) == 1){
                            MessageBox.Show("User is currently inactive.");
                        }
                        else {
                            StartScreen mainF = new StartScreen();
                            mainF.Reference_main = this;
                            mainF.UserType = int.Parse(dt.Rows[0]["account_type"].ToString());
                            mainF.name = dt.Rows[0]["fn"].ToString();
                            mainF.Show();
                            this.Hide();
                        }
                    }
                    else {
                        MessageBox.Show("The user credentials are incorrect");
                    }



                    conn.Close();
                }
                catch (Exception ee) {
                    MessageBox.Show("Nah!");
                    conn.Close();
                }
            }
            
        }

        private void Login_Load(object sender, EventArgs e) {
            txtPass.Text = "";
            txtUser.Text = "";
        }

        private void CloseBTN_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void AnimationTMR_Tick(object sender, EventArgs e) {
            this.Opacity += 0.1;
        }

        Point lastLocation;
        bool mouseDown;

        private void label1_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
    }
}
