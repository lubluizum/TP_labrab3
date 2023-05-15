using Aspose.Cells;
using Aspose.Cells.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace TP_labrab3
{
    internal class RegistryOfficeFile
    {
        Worksheet Worksheet { get; set; }

        public RegistryOfficeFile(Worksheet ws) { Worksheet = ws; }

        public int Marriages(int cols)
        {
            int row = 6;
            int summ = 0;
            for (int j = 1; j <= cols; j++)
            {
                summ += Convert.ToInt32(Worksheet.Cells[row, j].Value);
            }
            return (summ / 15);
        }

        public int Divorces(int cols)
        {
            int row = 7;
            int summ = 0;
            for (int j = 1; j <= cols; j++)
            {
                summ += Convert.ToInt32(Worksheet.Cells[row, j].Value);
            }
            return (summ / 15);
        }
        public int MaleMarriages(int cols)
        {
            int row = 1;
            int summ = 0;
            for (int j = 1; j <= cols; j++)
            {
                summ += Convert.ToInt32(Worksheet.Cells[row, j].Value);
            }
            return (summ / 15);
        }
        public int FemaleMarriages(int cols)
        {
            int row = 2;
            int summ = 0;
            for (int j = 1; j <= cols; j++)
            {
                summ += Convert.ToInt32(Worksheet.Cells[row, j].Value);
            }
            return (summ / 15);
        }
        public int MaleDivorces(int cols)
        {
            int row = 3;
            int summ = 0;
            for (int j = 1; j <= cols; j++)
            {
                summ += Convert.ToInt32(Worksheet.Cells[row, j].Value);
            }
            return (summ / 15);
        }
        public int FemaleDivorces(int cols)
        {
            int row = 4;
            int summ = 0;
            for (int j = 1; j <= cols; j++)
            {
                summ += Convert.ToInt32(Worksheet.Cells[row, j].Value);
            }
            return (summ / 15);
        }
        public void GraphicOne(Chart chart, int cols)
        {

            List<string> year = new List<string>();
            List<int> MaleMarriages = new List<int>();
            List<int> FemaleMarriages = new List<int>();
            List<int> MaleDivorces = new List<int>();
            List<int> FemaleDivorces = new List<int>();
            for (int j = 1; j <= cols; j++)
            {
                MaleMarriages.Add(Convert.ToInt32(Worksheet.Cells[1, j].Value));
                year.Add(Worksheet.Cells[0, j].Value.ToString());
                FemaleMarriages.Add(Convert.ToInt32(Worksheet.Cells[2, j].Value));
                MaleDivorces.Add(Convert.ToInt32(Worksheet.Cells[3, j].Value));
                FemaleDivorces.Add(Convert.ToInt32(Worksheet.Cells[4, j].Value));
            }



            // Установим палитру
            chart.Palette = ChartColorPalette.Fire;

            // Заголовок графика
            chart.Titles.Add("Возраст людей заключающих и расторгающих брак");

            // Добавляем последовательность
            Series series = chart.Series.Add("Средний возраст мужчин заключающих брак");

            for (int i = 0; i < year.Count; i++)
            {
                series.Points.Add(MaleMarriages[i]);
            }
            series = chart.Series.Add("Средний возраст женщин заключающих брак");
            for (int i = 0; i < year.Count; i++)
            {
                series.Points.Add(FemaleMarriages[i]);
            }
            series = chart.Series.Add("Средний возраст мужчин расторгающих брак");
            for (int i = 0; i < year.Count; i++)
            {
                series.Points.Add(MaleDivorces[i]);
            }
            series = chart.Series.Add("Средний возраст женщин расторгающих брак");
            for (int i = 0; i < year.Count; i++)
            {
                series.Points.Add(FemaleDivorces[i]);
            }
        }

        public void GraphicTwo(Chart chart, int cols)
        {

            List<string> year = new List<string>();
            List<int> Marriages = new List<int>();
            List<int> Devorces = new List<int>();
            for (int j = 1; j <= cols; j++)
            {
                Marriages.Add(Convert.ToInt32(Worksheet.Cells[6, j].Value));
                year.Add(Worksheet.Cells[0, j].Value.ToString());
                Devorces.Add(Convert.ToInt32(Worksheet.Cells[7, j].Value));
            }



            // Установим палитру
            chart.Palette = ChartColorPalette.Fire;

            // Заголовок графика
            chart.Titles.Add("Всего браков и разводов");

            // Добавляем последовательность
            Series series = chart.Series.Add("Браки");

            for (int i = 0; i < year.Count; i++)
            {

                // Добавляем точку
                series.Points.Add(Marriages[i]);
            }
            series = chart.Series.Add("Разводы");
            for (int i = 0; i < year.Count; i++)
            {

                series.Points.Add(Devorces[i]);
            }
        }
    }
}
