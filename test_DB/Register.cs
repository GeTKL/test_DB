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
        int v = Convert.ToInt32(Console.ReadLine());
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
           
            var log = textBox1.Text;
            var pas = textBox2_password.Text;

            string QS = $"INSERT Beguns(Login_User, Password_User, ID_Role) VALUES ('{log}', '{pas}', 2)";

            SqlCommand command = new SqlCommand(QS, dataBase.getSqlConnection());
 
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
            var log = textBox1.Text;
            var pas = textBox2_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"Select id_Begun, login_user, password_user where login_user = '{log}' and password_user = '{pas}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getSqlConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else return false;
        }
    }
       

      
    
}
