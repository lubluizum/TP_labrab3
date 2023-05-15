using Aspose.Cells;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Workbook wb = new Workbook(openFileDialog1.FileName);
                Worksheet worksheet = wb.Worksheets[0];
                int rows = worksheet.Cells.MaxDataRow;
                int cols = worksheet.Cells.MaxDataColumn;
                FileJail file = new FileJail(worksheet);
                tbInform1s.Text = file.OpenCrimes(cols).ToString() + " Открытых преступлений";
                tbInform2.Text = file.CloseCrimes(cols).ToString() + " Закрытых преступлений";
                tbInform3.Text = file.Murder(cols).ToString() + " Убийств";
                tbInform4.Text = file.Rape(cols).ToString() + " Изнасилований";
                tbInform5.Text = file.Hard(cols).ToString() + " Тяжких преступлений";
                tbInform6.Text = file.Other(cols).ToString() + " Иных преступлений";
                file.GraphicOne(chart1, cols);
                file.GraphicTwo(chart2, cols);
            }
        }
    }
}
