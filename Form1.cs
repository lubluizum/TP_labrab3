using Aspose.Cells;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_labrab3
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Orange200, TextShade.WHITE);
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
        ReturnThere:
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = openFileDialog1.FileName;
            FileInfo fileInfo = new FileInfo(filename);
            if (fileInfo.Name == "Crimes.xlsx")
            {
                materialTextBox1.Hint = "Изнасилований и покушений на изнасилования за 15 лет (в тыс.)";
                materialTextBox2.Hint = "Убийств и покушений на убийства за 15 лет (в тыс.)";
                materialTextBox3.Hint = "Случаев причинения тяжкого вреда здоровью за 15 лет (в тыс.)";
                materialTextBox4.Hint = "Других преступлений за 15 лет (в тыс.)";
                materialTextBox5.Hint = "Всего открытых дел за 15 лет (в тыс.)";
                materialTextBox6.Hint = "Всего закрытых дел за 15 лет (в тыс.)";

                Workbook wb = new Workbook(openFileDialog1.FileName);
                Worksheet worksheet = wb.Worksheets[0];
                int rows = worksheet.Cells.MaxDataRow;
                int cols = worksheet.Cells.MaxDataColumn;
                FileJail file = new FileJail(worksheet);
                materialTextBox5.Text = file.OpenCrimes(cols).ToString() + " тыс.";
                materialTextBox6.Text = file.CloseCrimes(cols).ToString() + " тыс.";
                materialTextBox1.Text = file.Murder(cols).ToString() + " тыс.";
                materialTextBox2.Text = file.Rape(cols).ToString() + " тыс.";
                materialTextBox3.Text = file.Hard(cols).ToString() + " тыс.";
                materialTextBox4.Text = file.Other(cols).ToString() + " тыс.";
                file.GraphicOne(chart1, cols);
                file.GraphicTwo(chart2, cols);
            }
            else if (fileInfo.Name == "RegistryOffice.xlsx")
            {
                materialTextBox1.Hint = "Средний возраст мужчин заключающих брак";
                materialTextBox2.Hint = "Средний возраст женщин заключающих брак";
                materialTextBox3.Hint = "Средний возраст мужчин расторгающих брак";
                materialTextBox4.Hint = "Средний возраст женщин расторгающих брак";
                materialTextBox5.Hint = "Количество заключенных браков (в тыс.)";
                materialTextBox6.Hint = "Количество разводов (в тыс.)";

            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Выбранный файл не подходит! Попробуйте заново",
                    "Ошибка",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Retry)
                    goto ReturnThere;

                if (result == DialogResult.Cancel)
                    this.Close();
            }
        }
    }
}
