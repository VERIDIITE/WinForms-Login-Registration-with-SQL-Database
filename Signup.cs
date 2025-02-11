using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LoginAndRegistrationForm
{
    public partial class Signup : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=LoginData;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;");
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_loginhere_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string checkUsername = "SELECT * FROM admin WHERE username = '"
                    + Signup_username.Text.Trim() + "'";

                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(Signup_username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO admin (email, username, password, date_created) VALUES (@Email, @Username, @Password, @DateCreated)";
                            using (SqlCommand insertCommand = new SqlCommand(insertData, connect))
                            {
                                insertCommand.Parameters.AddWithValue("@Email", Signup_email.Text.Trim());
                                insertCommand.Parameters.AddWithValue("@Username", Signup_username.Text.Trim());
                                insertCommand.Parameters.AddWithValue("@Password", Signup_password.Text.Trim());
                                insertCommand.Parameters.AddWithValue("@DateCreated", DateTime.Now);

                                insertCommand.ExecuteNonQuery();
                                MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                Form1 f1 = new Form1();
                                f1.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connecting to Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void Signup_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (Signup_showpass.Checked)
            {
                Signup_password.UseSystemPasswordChar = false;
            }
            else
            {
                Signup_password.UseSystemPasswordChar = true;
            }
        }
    }
}
