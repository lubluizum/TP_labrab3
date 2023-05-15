namespace TP_labrab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadFileButton = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tbInform6 = new MaterialSkin.Controls.MaterialTextBox();
            this.tbInform5 = new MaterialSkin.Controls.MaterialTextBox();
            this.tbInform4 = new MaterialSkin.Controls.MaterialTextBox();
            this.tbInform3 = new MaterialSkin.Controls.MaterialTextBox();
            this.tbInform2 = new MaterialSkin.Controls.MaterialTextBox();
            this.tbInform1s = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(17, 14);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart1.Size = new System.Drawing.Size(678, 250);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // loadFileButton
            // 
            this.loadFileButton.AutoSize = false;
            this.loadFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadFileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loadFileButton.Depth = 0;
            this.loadFileButton.HighEmphasis = true;
            this.loadFileButton.Icon = null;
            this.loadFileButton.Location = new System.Drawing.Point(18, 472);
            this.loadFileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loadFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loadFileButton.Padding = new System.Windows.Forms.Padding(10);
            this.loadFileButton.Size = new System.Drawing.Size(461, 36);
            this.loadFileButton.TabIndex = 0;
            this.loadFileButton.Text = "Загрузить файл с данными";
            this.loadFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loadFileButton.UseAccentColor = false;
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.tbInform6);
            this.materialCard1.Controls.Add(this.tbInform5);
            this.materialCard1.Controls.Add(this.tbInform4);
            this.materialCard1.Controls.Add(this.tbInform3);
            this.materialCard1.Controls.Add(this.tbInform2);
            this.materialCard1.Controls.Add(this.tbInform1s);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.loadFileButton);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(497, 528);
            this.materialCard1.TabIndex = 2;
            // 
            // tbInform6
            // 
            this.tbInform6.AnimateReadOnly = false;
            this.tbInform6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInform6.Depth = 0;
            this.tbInform6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbInform6.LeadingIcon = null;
            this.tbInform6.Location = new System.Drawing.Point(23, 326);
            this.tbInform6.MaxLength = 50;
            this.tbInform6.MouseState = MaterialSkin.MouseState.OUT;
            this.tbInform6.Multiline = false;
            this.tbInform6.Name = "tbInform6";
            this.tbInform6.Size = new System.Drawing.Size(457, 50);
            this.tbInform6.TabIndex = 7;
            this.tbInform6.Text = "";
            this.tbInform6.TrailingIcon = null;
            // 
            // tbInform5
            // 
            this.tbInform5.AnimateReadOnly = false;
            this.tbInform5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInform5.Depth = 0;
            this.tbInform5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbInform5.LeadingIcon = null;
            this.tbInform5.Location = new System.Drawing.Point(23, 270);
            this.tbInform5.MaxLength = 50;
            this.tbInform5.MouseState = MaterialSkin.MouseState.OUT;
            this.tbInform5.Multiline = false;
            this.tbInform5.Name = "tbInform5";
            this.tbInform5.Size = new System.Drawing.Size(457, 50);
            this.tbInform5.TabIndex = 6;
            this.tbInform5.Text = "";
            this.tbInform5.TrailingIcon = null;
            // 
            // tbInform4
            // 
            this.tbInform4.AnimateReadOnly = false;
            this.tbInform4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInform4.Depth = 0;
            this.tbInform4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbInform4.LeadingIcon = null;
            this.tbInform4.Location = new System.Drawing.Point(23, 214);
            this.tbInform4.MaxLength = 50;
            this.tbInform4.MouseState = MaterialSkin.MouseState.OUT;
            this.tbInform4.Multiline = false;
            this.tbInform4.Name = "tbInform4";
            this.tbInform4.Size = new System.Drawing.Size(457, 50);
            this.tbInform4.TabIndex = 5;
            this.tbInform4.Text = "";
            this.tbInform4.TrailingIcon = null;
            // 
            // tbInform3
            // 
            this.tbInform3.AnimateReadOnly = false;
            this.tbInform3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInform3.Depth = 0;
            this.tbInform3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbInform3.LeadingIcon = null;
            this.tbInform3.Location = new System.Drawing.Point(23, 158);
            this.tbInform3.MaxLength = 50;
            this.tbInform3.MouseState = MaterialSkin.MouseState.OUT;
            this.tbInform3.Multiline = false;
            this.tbInform3.Name = "tbInform3";
            this.tbInform3.Size = new System.Drawing.Size(457, 50);
            this.tbInform3.TabIndex = 4;
            this.tbInform3.Text = "";
            this.tbInform3.TrailingIcon = null;
            // 
            // tbInform2
            // 
            this.tbInform2.AnimateReadOnly = false;
            this.tbInform2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInform2.Depth = 0;
            this.tbInform2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbInform2.LeadingIcon = null;
            this.tbInform2.Location = new System.Drawing.Point(23, 102);
            this.tbInform2.MaxLength = 50;
            this.tbInform2.MouseState = MaterialSkin.MouseState.OUT;
            this.tbInform2.Multiline = false;
            this.tbInform2.Name = "tbInform2";
            this.tbInform2.Size = new System.Drawing.Size(457, 50);
            this.tbInform2.TabIndex = 3;
            this.tbInform2.Text = "";
            this.tbInform2.TrailingIcon = null;
            // 
            // tbInform1s
            // 
            this.tbInform1s.AnimateReadOnly = false;
            this.tbInform1s.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInform1s.Depth = 0;
            this.tbInform1s.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbInform1s.LeadingIcon = null;
            this.tbInform1s.Location = new System.Drawing.Point(22, 46);
            this.tbInform1s.MaxLength = 50;
            this.tbInform1s.MouseState = MaterialSkin.MouseState.OUT;
            this.tbInform1s.Multiline = false;
            this.tbInform1s.Name = "tbInform1s";
            this.tbInform1s.Size = new System.Drawing.Size(457, 50);
            this.tbInform1s.TabIndex = 2;
            this.tbInform1s.Text = "";
            this.tbInform1s.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(462, 29);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Статистические данные";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.chart2);
            this.materialCard2.Controls.Add(this.chart1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(524, 78);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(712, 528);
            this.materialCard2.TabIndex = 3;
            // 
            // chart2
            // 
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(17, 270);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart2.Size = new System.Drawing.Size(678, 238);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1250, 625);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 0, 0);
            this.Text = "Лабораторная работа 3";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialButton loadFileButton;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox tbInform6;
        private MaterialSkin.Controls.MaterialTextBox tbInform5;
        private MaterialSkin.Controls.MaterialTextBox tbInform4;
        private MaterialSkin.Controls.MaterialTextBox tbInform3;
        private MaterialSkin.Controls.MaterialTextBox tbInform2;
        private MaterialSkin.Controls.MaterialTextBox tbInform1s;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

