using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test_DB
{
    
    public partial class Login : Form
    {
        DataBase database = new DataBase();
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_Login.Text;
            var passUser = textBox_Password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select ID_Begun, Login_User, Password_User from Beguns where Login_User = '{loginUser}' and Password_User = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {

                MessageBox.Show("Вы успешно вошли!");
                database.openConnection();
                string QS = $"select ID_Role from Beguns where Login_User = '{loginUser}'";
                SqlCommand com = new SqlCommand(QS, database.getSqlConnection());
                int Role = ((int)com.ExecuteScalar());
                switch (Role)
                {
                    case 2:
                        LoginUser.Log_Us = textBox_Login.Text;
                        Begun frm_Begun = new Begun();
                        this.Hide();
                        frm_Begun.ShowDialog();
                        this.Show();
                        break;
                    case 1:
                        LoginUser.Log_Us = textBox_Login.Text;
                        Director frm_director = new Director();
                        this.Hide();
                        frm_director.ShowDialog();
                        this.Show();
                        break;
                    case 3:
                        LoginUser.Log_Us = textBox_Login.Text;
                        Manager frm_manager = new Manager();
                        this.Hide();
                        frm_manager.ShowDialog();
                        this.Show();
                        break;
                    case 4:
                        LoginUser.Log_Us = textBox_Login.Text;
                        Klad frm_klad = new Klad();
                        this.Hide();
                        frm_klad.ShowDialog();
                        this.Show();
                        break;
                    default: break;
                }
            }
            else
                MessageBox.Show("Введен неверный логин или пароль!");
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            textBox_Login.MaxLength = 20;
            textBox_Password.MaxLength = 20;
            textBox_Password.PasswordChar = '●';
        }

        private void Visible_Click(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = true;
            Hide.Visible = true;
            Visible.Visible = false;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = false;
            Visible.Visible = true;
            Hide.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register frm_sign = new Register();
            frm_sign.Show();
            this.Hide();
        }
    }
}
