using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smetana
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            info form3 = new info();
            form3.For("Коттедж");
            form3.Lak("Коттедж — индивидуальный городской или загородный дом \r\nдля круглогодичного проживания, \r\nявляющийся частью городского района с частной \r\nзастройкой или коттеджного поселка.");
            form3.UpdateControls("Коттедж");
            form3.LoadImage(Properties.Resources.Коттедж);
            form3.ShowDialog();

        }
        private void label3_Click(object sender, EventArgs e)
        {
            info form3 = new info();
            form3.For("Вилла");
            form3.Lak("Вилла — это дом с элементами средиземноморской \r\nархитектуры. Но национальные и климатические особенности \r\nпородили и другие ответвления. Так, сегодня можно\r\nувидеть виллы в скандинавском, хай-тек, \r\nминимализм и других современных стилях.");
            form3.UpdateControls("Вилла");
            form3.LoadImage(Properties.Resources.Вилла);
            form3.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            info form3 = new info();
            form3.For("Особняк");
            form3.Lak("Частное домовладение со всеми удобствами на одну семью. \r\nРасполагается обособленно от других строений. \r\nЖилые помещения в особняке просторные и могут весьма \r\nзначительно превышать необходимые нормы. \r\nПеречень и разнообразие помещений зависит \r\nот интересов владельцев особняка, их фантазии \r\nи финансовых возможностей.");
            form3.UpdateControls("Особняк");
            form3.LoadImage(Properties.Resources.Особ);
            form3.ShowDialog();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            info form3 = new info();
            form3.For("Усадьба");
            form3.Lak("На сегодняшний день под усадьбой подразумевают достаточно \r\nбольшой земельный участок с «хозяйским» домом, \r\nгаражом, местом для отдыха и различными \r\nхозяйственными постройками.Если раньше усадьбы \r\nчаще имели «классический облик», то сегодня, \r\nфасад и внутреннее убранство «родового гнезда» \r\nмогут быть выполнены в практически \r\nлюбом архитектурном стиле.");
            form3.UpdateControls("Усадьба");
            form3.LoadImage(Properties.Resources.Уса);
            form3.ShowDialog();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            info form3 = new info();
            form3.For("Резиденция");
            form3.Lak("Если раньше резиденция была местом, где проживали \r\nвысокопоставленные лица, то сегодня этим термином \r\nобозначают эксклюзивную, статусную недвижимость с \r\nмногочисленными удобствами и выгодным расположением.");
            form3.UpdateControls("Резиденция");
            form3.LoadImage(Properties.Resources.Резидент);
            form3.ShowDialog();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            info form3 = new info();
            form3.For("Таунхаус");
            form3.Lak("Таунхаус представляет собой комплекс малоэтажных домов \r\n(в 2-3 этажа), совмещенные друг с другом посредством \r\nобщих стен. Он разделен на несколько секций, каждая из \r\nкоторых принадлежит одной семье, имеет отдельный \r\nвход и небольшой участок земли (до 7 соток).");
            form3.UpdateControls("Таунхаус");
            form3.LoadImage(Properties.Resources.Таун);
            form3.ShowDialog();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            info form3 = new info();
            form3.For("Лейнхаус");
            form3.Lak("Лейнхаус – формат сблокированных домов, отличаются от \r\nтаунхаусов более яркой архитектурой. И если секции \r\nу таунхаусов одинаковые, то в лейнхаусах каждая секция \r\nимеет индивидуальное архитектурное решение. Это \r\nсвоеобразный уход от монотонности многократно \r\nповторяющихся секций.");
            form3.UpdateControls("Лейнхаус");
            form3.LoadImage(Properties.Resources.Лейн);
            form3.ShowDialog();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            info form3 = new info();
            form3.For("Дуплекс");
            form3.Lak("Такой тип жилья к нам пришел из Англии. Дуплекс \r\nили, как его еще называют, твинхаус – это дом, \r\nразделенный на две равные части, имеющий отдельный \r\nвход и два участка земли, размером 6-10 соток.");
            form3.UpdateControls("Дуплекс");
            form3.LoadImage(Properties.Resources.Дуплек);
            form3.ShowDialog();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            info form3 = new info();
            form3.For("Квадрохаус");
            form3.Lak("Дома на четыре семьи. Каждый из них со своим входом, \r\nнаправленным на свою сторону света. Разумеется, \r\nк каждой секции прилагается участок.Преимущества \r\nквадрохауса перед «линейными» таунхаусами – в \r\nбольшей приватности. Строительство четырехсекционного \r\nдома не дороже строительства классического \r\nтаунхауса, но при этом уровень приватности \r\nв квадрохаусе выше.");
            form3.UpdateControls("Квадрохаус");
            form3.LoadImage(Properties.Resources.Квадро);
            form3.ShowDialog();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            info form3 = new info();
            form3.For("Мезонет");
            form3.Lak("Если вы откроете словарь архитектурных терминов, \r\nто прочтете следующее определение: «Мезонет – дом с \r\nквартирами, помещения которых расположены в двух или \r\nтрех уровнях». Проще говоря, мезонет – это двух- или \r\nтрехэтажный дом, рассчитанный на несколько семей, \r\nс квартирами разной площади обычно с небольшим \r\nучастком земли общего пользования.");
            form3.UpdateControls("Мезонет");
            form3.LoadImage(Properties.Resources.Мезонет);
            form3.ShowDialog();

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
