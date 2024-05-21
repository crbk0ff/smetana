using smetana;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace smetana
{
    public partial class reg : Form
    {
        Main e = new Main();
        string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\logs" + @"\logs.txt";
        string admin = "";
        private int userId;
        string UserLogin = "";
        string UserPass = "";
        static string serverName = @"DESKTOP-JLG9LLB";
        static string dbName = "smetana";

        SqlConnection con = new SqlConnection($@"Data Source={serverName}; Initial Catalog={dbName};Integrated Security = True");
        public reg()
        {
            InitializeComponent();
        }
        public reg(SqlConnection con, string userLogin, int userId, string admin)
        {
            this.con = con;
            UserLogin = userLogin;
            this.userId = userId;
            this.admin = admin;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 auth = new Form1();
            auth.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin = textBox1.Text;
            UserPass = textBox2.Text;

            if (UserLogin == "" || UserPass == "")
            {
                MessageBox.Show("Пожалуйста, введите логин/пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            registration();
        }

        public void registration()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();
            string quere = $"select Логин,Пароль from Пользователи where Логин='{UserLogin}'";
            SqlCommand cmd = new SqlCommand(quere, con);
            adapter.SelectCommand = cmd;
            adapter.Fill(Table);
            con.Open();
            //если введены новые данные которые не существуют в бд, регистрация прошла успешно
            if (Table.Rows.Count == 0)
            {
                SqlCommand insertCommand = new SqlCommand($"insert into Пользователи(Логин,Пароль) values ('{UserLogin}','{UserPass}')", con);
                if (insertCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Регистрация прошла успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Main r = new Main();
                    r.Show();
                }
                //если введены существующие данные(которые есть в бд) будет ошибка
                else
                {
                    MessageBox.Show("Такой логин уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            con.Close();
        }
    }
}
