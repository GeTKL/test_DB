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
    public partial class Register : Form
    {

        DataBase dataBase = new DataBase();
        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Hide.Visible = false;
            textBox1.MaxLength = 20;
            textBox2_password.MaxLength = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            var login_User = textBox1.Text;
            var password = textBox2_password.Text;

            string querystring = $"insert into Beguns(login_user, password_user) values ('{login_User}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getSqlConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан");
                Login frm_login = new Login();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            dataBase.closeConnection();
        }
        private Boolean checkuser()
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select ID_Begun, Login_User, Password_User from Beguns where Login_User = '{loginUser}' and Password_User = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }

        }

        private void Visible_Click(object sender, EventArgs e)
        {
            textBox2_password.UseSystemPasswordChar = false;
            Hide.Visible = true;
            Visible.Visible = false;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            textBox2_password.UseSystemPasswordChar = true;
            Visible.Visible = true;
            Hide.Visible = false;
        }
    }
}
