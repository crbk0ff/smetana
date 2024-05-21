using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace smetana
{
    public partial class Form1 : Form
    {
        public string admin = "";
        bool reg = false;
        private int userId;
        public string UserLogin = "";
        public string UserPass = "";
        static string serverName = @"DESKTOP-JLG9LLB";
        static string dbName = "smetana";

        SqlConnection con = new SqlConnection($@"Data Source={serverName}; Initial Catalog={dbName};Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(SqlConnection con, string userLogin, int userId, string admin)
        {
            this.con = con;
            UserLogin = userLogin;
            this.userId = userId;
            this.admin = admin;
        }

        private void login()
        {
            //подключение к бд
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();

            string quere = $"select Логин, Пароль from Пользователи where Логин='{UserLogin}' and Пароль='{UserPass}'";
            SqlCommand command = new SqlCommand(quere, con);
            adapter.SelectCommand = command;
            adapter.Fill(Table);
            //условие входа( если данные из бд совпадают с данным введенными в textbox, вход успешен)
            if (Table.Rows.Count == 1)
            {

                MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main r = new Main();
                r.Show();
                //если в поля авторизации были введены данные admin, происходит вход в аккаунт админа
                if (UserLogin == "admin")
                {
                    Admin admin = new Admin();
                    admin.Show();
                }
                else;

                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                int userId = -1;
                reader.Close();
                Form1 mf = new Form1(con, UserLogin, userId, admin);
                this.Hide();
                con.Close();

            }
            //если данные аккаунта не совпадают с существующими данными в бд,вход не будет совершен
            else
            {
                MessageBox.Show("Неверный логин/пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {
            reg reg = new reg();
            reg.Show();
            this.Hide();
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
            login();
        }

    }
}
