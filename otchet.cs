using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace smetana
{
    public partial class otchet : Form
    {
        PrintDocument printDocument;
        public otchet()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }
        public void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Определение размера страницы A4
            float pageWidth = e.PageSettings.PrintableArea.Width;
            float pageHeight = e.PageSettings.PrintableArea.Height;
            // Установка шрифта для печати

            Font font = new Font("Sans", 12);
            // Печать всех Label и TextBox
            foreach (Control control in Controls)
            {
                // Проверка типа элемента управления
                if (control is System.Windows.Forms.Label || control is System.Windows.Forms.TextBox)
                // Определение координат элемента на форме
                {
                    float x = control.Left * pageWidth / Width; float y = control.Top * pageHeight / Height;
                    // Определение текста для печати
                    string text = control is System.Windows.Forms.Label ? ((System.Windows.Forms.Label)control).Text : ((System.Windows.Forms.TextBox)control).Text;
                    // Печать элемента управления
                    e.Graphics.DrawString(text, font, Brushes.Black, x, y);
                }
            }
        }
        public string InputText1
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // Размер страницы A4
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
