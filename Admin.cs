using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace smetana
{
    public partial class Admin : Form
    {
        static string serverName = @"DESKTOP-JLG9LLB";
        static string dbName = "smetana";
        SqlConnection con = new SqlConnection($@"Data Source={serverName}; Initial Catalog={dbName};Integrated Security = True");
        public Admin()
        {
            InitializeComponent();
            c();
            d();
            b();
            a();
            t(dataGridView1);
            o(dataGridView4);
            h(dataGridView3);
            j(dataGridView2);
        }
        private void c()
        {
            dataGridView1.Columns.Add("id_проекта", "ID");
            dataGridView1.Columns.Add("Тип", "Тип");
            dataGridView1.Columns.Add("Площадь", "Площадь");
            dataGridView1.Columns.Add("Материал", "Материал");
            dataGridView1.Columns.Add("Этажи", "Этажи");
            dataGridView1.Columns.Add("Доп_элементы", "Доп элементы");
            dataGridView1.Columns.Add("общая_стоимость", "Oбщая стоимость");
        }
        private void d()
        {
            dataGridView2.Columns.Add("id", "ID");
            dataGridView2.Columns.Add("id_проекта", "id проекта");
            dataGridView2.Columns.Add("ФИО", "ФИО");
            dataGridView2.Columns.Add("зарплата", "Зарплата");
        }
        private void b()
        {
            dataGridView4.Columns.Add("id_проекта", "ID");
            dataGridView4.Columns.Add("id_пользователя", "id пользователя");
            dataGridView4.Columns.Add("id_застройщика", "id застройщика");
        }
        private void a()
        {
            dataGridView3.Columns.Add("Логин", "Логин");
            dataGridView3.Columns.Add("Пароль", "Пароль");
        }
        private void p(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4), record.GetString(5), record.GetDecimal(6));
        }
        private void t(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Проект";
            SqlCommand cmd = new SqlCommand(queryString, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                p(dgw, reader);
            }
            reader.Close();
            con.Close();
        }
        private void k(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetDecimal(3));
        }
        private void j(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Застройщики";
            SqlCommand cmd = new SqlCommand(queryString, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                k(dgw, reader);
            }
            reader.Close();
            con.Close();
        }
        private void i(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2));
        }
        private void o(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Отчет_по_проекту";
            SqlCommand cmd = new SqlCommand(queryString, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i(dgw, reader);
            }
            reader.Close();
            con.Close();
        }
        private void g(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1));
        }
        private void h(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Пользователи";
            SqlCommand cmd = new SqlCommand(queryString, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                g(dgw, reader);
            }
            reader.Close();
            con.Close();
        }
    }
}
