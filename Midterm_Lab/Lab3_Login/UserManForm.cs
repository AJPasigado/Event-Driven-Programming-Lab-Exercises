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
    public partial class UserManForm : Form {
        public MySqlConnection conn;
        public Form Reference_start { get; set; }
        int account_type;
        int account_status = 100;
        int AccountID;
        public int UserID;

        public UserManForm() {
            InitializeComponent();
            this.Opacity = 0;
            AnimationTMR.Start();
            conn = new MySqlConnection("Server=localhost;Database=SAD_DB;Uid=root;Pwd=root;");
        }

        private void button2_Click(object sender, EventArgs e) {
            if (CreateBTN.Text.Equals("CREATE")) {
                if (FNBox.Text.Equals("") || MNBox.Text.Equals("") || LNBox.Text.Equals("") || UserBox.Text.Equals("") || PassBox.Text.Equals("") || TypeBox.SelectedIndex == 0 || account_status == 100) {
                    MessageBox.Show("Please supply all information.");
                }
                else {
                    try {
                        conn.Open();
                        try {
                            MySqlCommand comm = new MySqlCommand("INSERT INTO tbl_accounts(fn, mn, ln, username, password, account_type, account_status) VALUES('" + FNBox.Text + "','" + MNBox.Text + "','" + LNBox.Text + "','" + UserBox.Text + "','" + PassBox.Text + "','" + account_type + "','" + account_status + "')", conn);
                            comm.ExecuteNonQuery();
                            MessageBox.Show("Records inserted!");
                        }
                        catch (Exception ee) {
                            MessageBox.Show(ee.Message);
                        }
                        conn.Close();
                    }
                    catch (Exception ee) {
                        MessageBox.Show("Username and/or password already exists.");
                        conn.Close();
                    }
                    Rifrish();
                    ClearBoxes();
                }
            }
            else {
                if (FNBox.Text.Equals("") || MNBox.Text.Equals("") || LNBox.Text.Equals("") || UserBox.Text.Equals("") || PassBox.Text.Equals("") || TypeBox.SelectedIndex == 0 || account_status==100) {
                    MessageBox.Show("Please supply all information.");
                }
                else {
                    try {
                        conn.Open();
                        MySqlCommand comm = new MySqlCommand("UPDATE tbl_accounts SET fn = '" + FNBox.Text + "', mn='" + MNBox.Text + "', ln='" + LNBox.Text + "', username='" + UserBox.Text + "', password = '" + PassBox.Text + "', account_type = '" + account_type + "', account_status = '" + account_status + "' WHERE account_id= '" + AccountID + "'", conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Records updated!");
                    }
                    catch (Exception ee) {
                        MessageBox.Show("Username already exists!");
                        conn.Close();
                    }
                    Rifrish();
                    CreateBTN.Text = "CREATE";
                    ClearBoxes();
                }
            }
        }

        private void ActiveBTN_CheckedChanged(object sender, EventArgs e) {
            account_status = 0;
        }

        private void InactiveBTN_CheckedChanged(object sender, EventArgs e) {
            account_status = 1;
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e) {
            account_type = TypeBox.SelectedIndex - 1;
        }
        

        private void Rifrish() {
            try {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM tbl_accounts WHERE account_id != " + UserID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["account_id"].Visible = false;
                dataGridView1.Columns["fn"].HeaderText = "FIRSTNAME";
                dataGridView1.Columns["fn"].Width = 90;
                dataGridView1.Columns["mn"].HeaderText = "MIDDLENAME";
                dataGridView1.Columns["mn"].Width = 90;
                dataGridView1.Columns["ln"].HeaderText = "LASTNAME";
                dataGridView1.Columns["ln"].Width = 90;
                dataGridView1.Columns["account_type"].HeaderText = "TYPE";
                dataGridView1.Columns["account_type"].Width = 60;
                dataGridView1.Columns["username"].Visible = false;
                dataGridView1.Columns["password"].Visible = false;
                dataGridView1.Columns["account_type"].Visible = true;
                dataGridView1.Columns["account_status"].HeaderText = "STATUS";
                dataGridView1.Columns["account_status"].Width = 80;

                //     dataGridView1.Columns["account_status"].Visible = false;
                conn.Close();
            }
            catch (Exception ee) {
                MessageBox.Show(ee.Message);
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                FNBox.Text = dataGridView1.Rows[e.RowIndex].Cells["fn"].Value.ToString();
                MNBox.Text = dataGridView1.Rows[e.RowIndex].Cells["mn"].Value.ToString();
                LNBox.Text = dataGridView1.Rows[e.RowIndex].Cells["ln"].Value.ToString();
                UserBox.Text = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
                PassBox.Text = dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();
                AccountID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["account_id"].Value.ToString());
                if (dataGridView1.Rows[e.RowIndex].Cells["account_type"].Value.ToString().Equals("0")) {
                    TypeBox.SelectedIndex = 1;
                }
                else TypeBox.SelectedIndex = 2;
                if (dataGridView1.Rows[e.RowIndex].Cells["account_status"].Value.ToString().Equals("0")) {
                    ActiveBTN.Checked = true;
                    InactiveBTN.Checked = false;
                }
                else {
                    ActiveBTN.Checked = false;
                    InactiveBTN.Checked = true;
                }
                CreateBTN.Text = "UPDATE";
            } catch {
            }
            
        }

        private void UserManForm_FormClosed(object sender, FormClosedEventArgs e) {
            Reference_start.Show();
        }
        private void ClearBoxes() {
            FNBox.Text = String.Empty;
            MNBox.Text = String.Empty;
            LNBox.Text = String.Empty;
            TypeBox.SelectedIndex = 0;
            UserBox.Text = String.Empty;
            PassBox.Text = String.Empty;
            ActiveBTN.Checked = false;
            InactiveBTN.Checked = false;
        }

        private void AnimationTMR_Tick(object sender, EventArgs e) {
            this.Opacity += 0.1;
        }

        private void CloseBTN_Click(object sender, EventArgs e) {
            if (!(FNBox.Text.Equals("") && MNBox.Text.Equals("") && LNBox.Text.Equals("") && UserBox.Text.Equals("") && PassBox.Text.Equals(""))) {
                DialogResult rs = MessageBox.Show("Do you really want to go back? \nAny unsaved changes will be lost.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                    this.Close();
            } else this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 6) {
                if (e.Value is int) {
                    int value = (int)e.Value;
                    if (value == 0) {
                        e.Value = "Admin";
                    } else {
                        e.Value = "Staff";
                    }
                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == 7) {
                if (e.Value is int) {
                    int value = (int)e.Value;
                    if (value == 0) {
                        e.Value = "Active";
                    }
                    else {
                        e.Value = "Inactive";
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) {
            PassBox.PasswordChar = '\0';
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {
            ClearBoxes();
            CreateBTN.Text = "CREATE";
        }

        private void UserManForm_Load(object sender, EventArgs e) {
            Rifrish();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) {
            PassBox.PasswordChar = '●';
        }
    }
}
