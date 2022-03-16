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
    public partial class StartScreen : Form {
        public int UserType = 1;
        public String name;
        bool login = true;
        public MySqlConnection conn;
        int UserID = 0;

        public StartScreen() {
            InitializeComponent();
            this.Opacity = 0;
            DateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            conn = new MySqlConnection("Server=localhost;Database=SAD_DB;Uid=root;Pwd=root;");
            AnimationTMR.Start();
            txtUser.SelectAll();
        }

        public void StartLoad() {
            if (UserType == 0) {
                UserManBTN.Visible = true;
            } else UserManBTN.Visible = false;
            WelcomeLBL.Text = "Welcome, " + name + "!";
        }

        private void button2_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }

        private void LoginMain_FormClosed(object sender, FormClosedEventArgs e) {
        }

        private void UserManBTN_Click(object sender, EventArgs e) {
            UserManForm user = new UserManForm();
            user.Reference_start = this;
            user.Location = this.Location;
            user.UserID = this.UserID;
            user.Show();
            this.Hide();
        }

        private void StartScreen_Load(object sender, EventArgs e) {
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

        private void WelcomeLBL_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void FlowAnimation_Tick(object sender, EventArgs e) {
            StartLoad();
            if (login) {
                
                Point hide = new Point(-850, 0);
                Point start = new Point(0, 0);
                if (LoginPNL.Location != hide) LoginPNL.Location = new Point(LoginPNL.Location.X - 60, LoginPNL.Location.Y);
                if (StartPNL.Location != start) StartPNL.Location = new Point(StartPNL.Location.X - 60, StartPNL.Location.Y);
                else {
                    FlowAnimation.Stop();
                    login = false;
                    LoginPNL.Enabled = false;
                    StartPNL.Enabled = true;
                    LogoutBTN.Visible = true;
                }
            }
            else {
                LogoutBTN.Visible = false;
                Point hide = new Point(0, 0);
                Point start = new Point(850, 0);
                if (StartPNL.Location != start) StartPNL.Location = new Point(StartPNL.Location.X + 60, StartPNL.Location.Y);
                if (LoginPNL.Location != hide) LoginPNL.Location = new Point(LoginPNL.Location.X + 60, LoginPNL.Location.Y);
                else {
                    FlowAnimation.Stop();
                    login = true;
                    StartPNL.Enabled = false;
                    LoginPNL.Enabled = true;
                    txtUser.SelectAll();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            Login();
        }

        private void LogoutBTN_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you really want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                PassBox.Clear();
                FlowAnimation.Start();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) {
            PassBox.PasswordChar = '\0';
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e) {
            
        }

        public void Login() {
            if (PassBox.Text.Equals("")) {
                MessageBox.Show("Please enter your password");
            } else if (txtUser.Text.Equals("")) {
                MessageBox.Show("Please enter your username");
            }
            else {
                try {
                    conn.Open();

                    MySqlCommand comm = new MySqlCommand("SELECT * FROM tbl_accounts WHERE username = '" + txtUser.Text + "' AND password = '" + PassBox.Text + "'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    if (dt.Rows.Count == 1) {
                        if (int.Parse(dt.Rows[0]["account_status"].ToString()) == 1) {
                            MessageBox.Show("User is currently inactive.");
                        }
                        else {
                            UserType = int.Parse(dt.Rows[0]["account_type"].ToString());
                            StartLoad();
                            name = dt.Rows[0]["fn"].ToString();
                            UserID = int.Parse(dt.Rows[0]["account_id"].ToString());
                            FlowAnimation.Start();
                        }
                    }
                    else {
                        MessageBox.Show("The user credentials are incorrect");
                    }



                    conn.Close();
                }
                catch (Exception ee) {
                    MessageBox.Show("Please contact your administrator.");
                    conn.Close();
                }
            }

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode.ToString().Equals("Escape")){
                if (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.Close();
            }
            if (e.KeyValue.ToString().Equals("13")) {
                Login();
            }
        }

        private void txtPass_Enter(object sender, EventArgs e) {
            PassBox.SelectAll();
        }

        private void txtUser_Enter(object sender, EventArgs e) {
            txtUser.SelectAll();
        }

        private void StartScreen_KeyDown(object sender, KeyEventArgs e) {
        }

        private void StartScreen_KeyPress(object sender, KeyPressEventArgs e) {
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) {
            PassBox.PasswordChar = '●';
        }
    }
}
