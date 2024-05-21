using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace smetana
{
    public partial class info : Form
    {
        string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\logs" + @"\logs.txt";
        string admin = "";
        private int userId;
        string type = "";
        int plosh;
        string mater = "";
        int etazh;
        string dopel = "";
        decimal stoim;
        static string serverName = @"DESKTOP-JLG9LLB";
        static string dbName = "smetana";

        SqlConnection con = new SqlConnection($@"Data Source={serverName}; Initial Catalog={dbName};Integrated Security = True");
        public info()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
        }
        //Задание как переменная для дальнейшего использования в коде
        public void UpdateControls(string labelText)
        {
            label1.Text = labelText;

        }
        //Задание как переменная для дальнейшего использования в коде
        public void Lak(string label1Text)
        {
            label2.Text = label1Text;

        }
        //Задание как переменная для дальнейшего использования в коде
        public void las(string textbox)
        {
            textBox1.Text = textbox;
        }
        //Задание как переменная для дальнейшего использования в коде
        public void jak(string label2Text)
        {
            label6.Text = label2Text;

        }
        //Задание как переменная для дальнейшего использования в коде
        public void For(string forms)
        {
            this.Text = forms;

        }
        //Задание как переменная для дальнейшего использования в коде
        public void LoadImage(Image image)
        {
            pictureBox1.Image = image;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "0";
            }
        }
        int n;
        public void rasch()
        {
            // Получить количество квадратных метров из текстового поля
            int площадь = int.Parse(textBox1.Text);

            // Проверить, находится ли площадь в допустимом диапазоне
            if (площадь < 160 || площадь > 540)
            {
                MessageBox.Show("Площадь должна быть в диапазоне от 160 до 540 квадратных метров.");
                return;
            }

            int этаж = int.Parse(textBox2.Text);

            // Проверить, находится ли площадь в допустимом диапазоне
            if (этаж < 1 || этаж > 3)
            {
                MessageBox.Show("Этажей может быть от 1 до 3");
                return;
            }
            int d;
            // Получить выбранный материал из выпадающего списка
            string материал = comboBox1.SelectedItem.ToString();
            if (label1 != null)
            {
                if (label1.Text == "Коттедж")
                {
                    n = 54000;
                }
                if (label1.Text == "Вилла")
                {
                    n = 40000;
                }
                if (label1.Text == "Особняк")
                {
                    n = 300000;
                }
                if (label1.Text == "Усадьба")
                {
                    n = 600000;
                }
                if (label1.Text == "Резиденция")
                {
                    n = 150000;
                }
                if (label1.Text == "Таунхаус")
                {
                    n = 65000;
                }
                if (label1.Text == "Лейнхаус")
                {
                    n = 60000;
                }
                if (label1.Text == "Дуплекс")
                {
                    n = 34000;
                }
                if (label1.Text == "Квадрохаус")
                {
                    n = 31000;
                }
                if (label1.Text == "Мезонет")
                {
                    n = 23000;
                }
            }

            double стоимость = площадь * n;
            double комиссия = 1.05;

            string этажи = textBox2.Text;
            switch (этажи)
            {
                case "1":
                    стоимость *= 1;
                    break;
                case "2":
                    стоимость *= 1.5;
                    break;
                case "3":
                    стоимость *= 2;
                    break;
            }

            switch (материал)
            {
                case "Дерево":
                    стоимость *= 1.2;
                    break;
                case "Металл":
                    стоимость *= 1.4;
                    break;
                case "Кирпич":
                    стоимость *= 1.3;
                    break;
                case "Керамические блоки":
                    стоимость *= 1.6;
                    break;
            }
            foreach (string допы in checkedListBox1.CheckedItems)
                switch (допы)
                {
                    case "Камин":
                        стоимость *= 1.05;
                        break;
                    case "Бассейн":
                        стоимость *= 1.2;
                        break;
                    case "Подвал":
                        стоимость *= 1.25;
                        break;
                    case "Беседка":
                        стоимость *= 1.1;
                        break;
                    case "Мангальная зона":
                        стоимость *= 1.2;
                        break;
                    case "Гараж":
                        стоимость *= 1.25;
                        break;
                }
            double коэф_комиссии = стоимость * комиссия;
            double стоимость_full = коэф_комиссии + стоимость;
            // Вывести рассчитанную стоимость
            label6.Text = $"{стоимость.ToString()} ";
            label8.Text = $"{стоимость_full.ToString()} ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rasch();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var selectedItems = checkedListBox1.CheckedItems.Cast<string>().ToArray();
            type = label1.Text;
            plosh = Convert.ToInt32(textBox1.Text);
            mater = comboBox1.Text;
            etazh = Convert.ToInt32(textBox2.Text);
            dopel = string.Join(", ", selectedItems);
            stoim = Convert.ToDecimal(label8.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();
            string quere = $"select * from Проект";
            SqlCommand cmd = new SqlCommand(quere, con);
            adapter.SelectCommand = cmd;
            adapter.Fill(Table);
            con.Open();
            SqlCommand insertCommand = new SqlCommand($"insert into Проект(Тип, Площадь, Материал, Этажи, Доп_элементы, общая_стоимость) values ('{type}','{plosh}','{mater}','{etazh}','{dopel}','{stoim}')", con);
            if (insertCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Проект успешно зарегистрирован!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Такой проект уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            con.Close();
            otchet otch = new otchet();
            otch.Show();
            otch.InputText1 =  $"Тип проект: {label1.Text} \r\n\r\nКоличество квадратных метров: {textBox1.Text} м2 \r\n\r\nВыбранный материал для постройки: {comboBox1.Text} \r\n\r\nКоличество этажей: {textBox2.Text} \r\n\r\nДополнительные элементы: {string.Join(", ", selectedItems)} \r\n\r\nСтоимость проекта без учёта комиссии: {label6.Text} рублей \r\n\r\nСтоимость проекта c учётом комиссии: {label8.Text} рублей";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "1";
            }
        }
    }
}
