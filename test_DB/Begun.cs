using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test_DB
{
    public partial class Begun : Form
    {
        SqlDataAdapter Data = new SqlDataAdapter();
        DataTable Data_table = new DataTable();
        DataBase dataBase = new DataBase();
        string loginUser2 = LoginUser.Log_Us;
        string id_B = Console.ReadLine();
        string id_In = Console.ReadLine();
        string Id_Beg = Console.ReadLine();
        DateTime Timer = new DateTime(2022, 09, 10, 0, 0, 0);
        public Begun()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            Timer Timer1 = new Timer();

            string QS = $"SELECT FSP, Inventar, name_sp, name_bo, vid_zch, prodol, D_nachalo " +
                $"FROM Beguns AS B, Inventars AS I, Sponsors AS S, Blag_Orgs AS B2, Zachets AS Z, Marafons AS M, Post_Inv AS P " +
                $"WHERE B.ID_Begun = M.ID_Begun and M.ID_Zch = Z.ID_Zch and M.ID_Sponsors = S.ID_Sponsors " +
                $"and S.ID_BO = B2.ID_BO AND M.ID_Post = P.ID_Post AND P.ID_Inv = I.ID_Inv and login_User = '{loginUser2}'";


            SqlCommand QSC = new SqlCommand(QS, dataBase.getSqlConnection());
            dataBase.openConnection();
            Data.SelectCommand = QSC;
            Data.Fill(Data_table);

            SqlDataReader Reader = QSC.ExecuteReader();
            while (Reader.Read())
            {
                FSP.Text = Reader["FSP"].ToString();
                Inventar.Text = Reader["Inventar"].ToString();
                Sponsor.Text = Reader["name_sp"].ToString();
                Blag_Org.Text = Reader["name_bo"].ToString();
                Vid_Zch.Text = Reader["vid_zch"].ToString();
                Prod.Text = Reader["prodol"].ToString();
                D_Nach.Text = Reader["D_nachalo"].ToString();
            }
            dataBase.closeConnection();
            string Vid_zch = $"select vid_Zch from Zachets";
            SqlCommand CVZ = new SqlCommand(Vid_zch, dataBase.getSqlConnection());
            SqlDataAdapter Adapter = new SqlDataAdapter(CVZ);
            DataTable table = new DataTable();
            Adapter.Fill(table);
            this.Vid_Zch.DataSource = table;
            this.Vid_Zch.DisplayMember = "Vid_Zch";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fio = FSP.Text;
            var invent = Inventar.Text;
            var BO = Blag_Org.Text;
            var spons = Sponsor.Text;
            var prodol = Prod.Text;
            string Vid = Vid_Zch.Text;
            if (Data_table.Rows.Count == 1)
            {
                String Update = $"BEGIN TRAN UPDATE Beguns SET FSP = '{fio}' where login_user = '{loginUser2}' UPDATE Inventars SET Inventar('{invent}') from Beguns as B, Marafons as M, Post_Inv as P, Inventars as I where I.ID_Inv =  COMMIT TRAN";
                SqlCommand com = new SqlCommand(Update, dataBase.getSqlConnection());
                Data.SelectCommand = com;
                Data.Fill(Data_table);
                MessageBox.Show("Данные изменены!");
            }
            else 
            {
                string INSERT = 
                    $"BEGIN TRANSACTION UPDATE Beguns SET FSP = '{fio}' where login_user = '{loginUser2}' INSERT INTO Inventars (inventar) values ('{invent}') INSERT INTO Blag_Orgs (Name_Bo) values ('{BO}') COMMIT TRANSACTION";
                SqlCommand INSERT2 = new SqlCommand(INSERT, dataBase.getSqlConnection());
                dataBase.openConnection();
                Data.SelectCommand = INSERT2;
                Data.Fill(Data_table);

                string sel = $"select ID_BO from Blag_Orgs WHERE NAME_BO = '{BO}'";
                SqlCommand sel2 = new SqlCommand(sel, dataBase.getSqlConnection());
                int Id_B = ((int)sel2.ExecuteScalar()); // наизусть выучить 2 запроса этот и ниже.
                
                string INS =
                    $"INSERT Sponsors(Name_SP, ID_BO) values ('{spons}', '{Id_B}') ";
                SqlCommand command = new SqlCommand(INS, dataBase.getSqlConnection());
                Data.SelectCommand = command;
                Data.Fill(Data_table);
               

                string sel3 = $"select ID_Inv from Inventars WHERE inventar = '{invent}'";
                SqlCommand sel4 = new SqlCommand(sel3, dataBase.getSqlConnection());
                int ID_I = ((int)sel4.ExecuteScalar());

                string INS2 = $"INSERT Post_Inv(ID_Inv, D_Post) values ('{ID_I}', '17-12-2022')";
                SqlCommand comm = new SqlCommand(INS2, dataBase.getSqlConnection());
                Data.SelectCommand = comm;
                Data.Fill(Data_table);


                string sel12 = $"select ID_Zch from Zachets where Vid_zch = '{Vid}'";
                string sel5 = $"select ID_Post from Post_Inv, Inventars where Inventars.ID_Inv = Post_Inv.ID_Inv and inventar = '{invent}'";
                string sel6 = $"select ID_Sponsors from sponsors, blag_orgs where sponsors.id_bo = blag_orgs.id_bo and name_bo = '{BO}'";
                string sel7 = $"select id_begun from beguns where fsp = '{fio}'";
                SqlCommand sel8 = new SqlCommand(sel5, dataBase.getSqlConnection());
                SqlCommand sel9 = new SqlCommand(sel6, dataBase.getSqlConnection());
                SqlCommand sel10 = new SqlCommand(sel7, dataBase.getSqlConnection());
                SqlCommand sel13 = new SqlCommand(sel12, dataBase.getSqlConnection());
                int ID_Z = ((int)sel13.ExecuteScalar());
                int ID_P = ((int)sel8.ExecuteScalar());
                int ID_S = ((int)sel9.ExecuteScalar());
                int ID_B = ((int)sel10.ExecuteScalar());
                
                

                string sel11 = $"INSERT Marafons (ID_Begun, ID_Post, ID_Sponsors, ID_Sotr, ID_Zch, D_Nachalo, Prodol) values ('{ID_B}', '{ID_P}', '{ID_S}', '0', '{ID_Z}', '17-12-2022', '{prodol}')";
                SqlCommand comm3 = new SqlCommand(sel11, dataBase.getSqlConnection());
                Data.SelectCommand = comm3;
                Data.Fill(Data_table);
                MessageBox.Show("Данные добавлены!");
            }
        }

        private void Begun_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Vid_Zch_TextUpdate(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemain = Timer - DateTime.Now;
            LTime.Text = TimeRemain.Days + " : " + TimeRemain.Hours + " : " + TimeRemain.Minutes + " : " + TimeRemain.Seconds;
        }
    }
}
