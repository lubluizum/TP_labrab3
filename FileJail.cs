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
    public class FileJail
    {
        Worksheet Worksheet { get; set; }

        public FileJail(Worksheet ws) { Worksheet = ws; }

        public int OpenCrimes(int cols)
        {
            int row = 6;
            int summ = 0;
            for (int j = 1; j < cols; j++)
            {
                summ += Convert.ToInt32(Worksheet.Cells[row, j].Value);
            }
            return summ;
        }

        public int CloseCrimes(int cols)
        {
            int row = 7;
            int summ = 0;
            for (int j = 1; j < cols; j++)
            {
                summ += Convert.ToInt32(Worksheet.Cells[row, j].Value);
            }
            return summ;
        }
        public int Rape(int cols)
        {
            int row = 1;
            int summ = 0;
            for (int j = 1; j < cols; j++)
            {
                summ += Convert.ToInt32(Worksheet.Cells[row, j].Value);
            }
            return summ;
        }
        public int Murder(int cols)
        {
            int row = 2;
            int summ = 0;
            for (int j = 1; j < cols; j++)
            {
                summ += Convert.ToInt32(Worksheet.Cells[row, j].Value);
            }
            return summ;
        }
        public int Hard(int cols)
        {
            int row = 3;
            int summ = 0;
            for (int j = 1; j < cols; j++)
            {
                summ += Convert.ToInt32(Worksheet.Cells[row, j].Value);
            }
            return summ;
        }
        public int Other(int cols)
        {
            int row = 4;
            int summ = 0;
            for (int j = 1; j < cols; j++)
            {
                summ += Convert.ToInt32(Worksheet.Cells[row, j].Value);
            }
            return summ;
        }
        public void GraphicOne(Chart chart, int cols)
        {

            List<string> year = new List<string>(); 
            List<int> Rape = new List<int>();
            List<int> Murder = new List<int>();
            List<int> Hard = new List<int>();
            List<int> Other = new List<int>();
            for (int j = 1; j < cols; j++)
            {
                Rape.Add(Convert.ToInt32(Worksheet.Cells[1, j].Value));
                year.Add(Worksheet.Cells[0, j].Value.ToString());
                Murder.Add(Convert.ToInt32(Worksheet.Cells[2, j].Value));
                Hard.Add(Convert.ToInt32(Worksheet.Cells[3, j].Value));
                Other.Add(Convert.ToInt32(Worksheet.Cells[4, j].Value));
            }
            
            

            // Установим палитру
            chart.Palette = ChartColorPalette.SeaGreen;

            // Заголовок графика
            chart.Titles.Add("Преступления");

            // Добавляем последовательность
            Series series = chart.Series.Add("Изнасилование");
           
            for (int i = 0; i < year.Count; i++)
            {

                // Добавляем точку
                series.Points.Add(Rape[i]);
            }
            series = chart.Series.Add("Убийство");
            for (int i = 0; i < year.Count; i++)
            {

                series.Points.Add(Murder[i]);
            }
            series = chart.Series.Add("Тяжкие");
            for (int i = 0; i < year.Count; i++)
            {

                series.Points.Add(Hard[i]);
            }
            series = chart.Series.Add("Другое");
            for (int i = 0; i < year.Count; i++)
            {

                series.Points.Add(Other[i]);
            }
        }

        public void GraphicTwo(Chart chart, int cols)
        {

            List<string> year = new List<string>();
            List<int> Open = new List<int>();
            List<int> Close = new List<int>();
            for (int j = 1; j < cols; j++)
            {
                Open.Add(Convert.ToInt32(Worksheet.Cells[6, j].Value));
                year.Add(Worksheet.Cells[0, j].Value.ToString());
                Close.Add(Convert.ToInt32(Worksheet.Cells[7, j].Value));
            }



            // Установим палитру
            chart.Palette = ChartColorPalette.Berry;

            // Заголовок графика
            chart.Titles.Add("Преступления");

            // Добавляем последовательность
            Series series = chart.Series.Add("Открытые");

            for (int i = 0; i < year.Count; i++)
            {

                // Добавляем точку
                series.Points.Add(Open[i]);
            }
            series = chart.Series.Add("Закрытые");
            for (int i = 0; i < year.Count; i++)
            {

                series.Points.Add(Close[i]);
            }
        }
    }
}
