namespace OptimizationMethods
{
    partial class OneDimensionalSearchMethodsForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneDimensionalSearchMethodsForm));
            this.GraphicChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BuildGraphicButton = new System.Windows.Forms.Button();
            this.TableListBox = new System.Windows.Forms.ListBox();
            this.ParametresListBox = new System.Windows.Forms.ListBox();
            this.hTextBox = new System.Windows.Forms.TextBox();
            this.X0TextBox = new System.Windows.Forms.TextBox();
            this.eTextBox = new System.Windows.Forms.TextBox();
            this.SwennMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.DichotomiesMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.QuadraticInterpolationMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.GoldenSectionMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.StepAdaptationMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.BisectionMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.ClearButton = new System.Windows.Forms.Button();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.QuadraticLabel2 = new System.Windows.Forms.Label();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.QuadraticLabel3 = new System.Windows.Forms.Label();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.QuadraticLabel1 = new System.Windows.Forms.Label();
            this.SelectGraphicDirectionGroupBox = new System.Windows.Forms.GroupBox();
            this.GraphicDirectionLeftRadioButton = new System.Windows.Forms.RadioButton();
            this.GraphicDirectionRightRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicChart)).BeginInit();
            this.SelectMethodGroupBox.SuspendLayout();
            this.SelectGraphicDirectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraphicChart
            // 
            chartArea1.Name = "ChartArea1";
            this.GraphicChart.ChartAreas.Add(chartArea1);
            this.GraphicChart.Location = new System.Drawing.Point(2, 65);
            this.GraphicChart.Name = "GraphicChart";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Name = "Series1";
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.BorderWidth = 100;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Red;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.MarkerSize = 8;
            series2.Name = "Series2";
            series2.YValuesPerPoint = 2;
            series3.BorderWidth = 10;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.MarkerSize = 10;
            series3.Name = "Series3";
            series3.YValuesPerPoint = 2;
            series4.BorderWidth = 10;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.Fuchsia;
            series4.MarkerSize = 12;
            series4.Name = "Series4";
            this.GraphicChart.Series.Add(series1);
            this.GraphicChart.Series.Add(series2);
            this.GraphicChart.Series.Add(series3);
            this.GraphicChart.Series.Add(series4);
            this.GraphicChart.Size = new System.Drawing.Size(600, 545);
            this.GraphicChart.TabIndex = 0;
            this.GraphicChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = " ";
            this.GraphicChart.Titles.Add(title1);
            // 
            // BuildGraphicButton
            // 
            this.BuildGraphicButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildGraphicButton.Location = new System.Drawing.Point(1040, 6);
            this.BuildGraphicButton.Name = "BuildGraphicButton";
            this.BuildGraphicButton.Size = new System.Drawing.Size(337, 52);
            this.BuildGraphicButton.TabIndex = 1;
            this.BuildGraphicButton.Text = "Построить график";
            this.BuildGraphicButton.UseVisualStyleBackColor = true;
            this.BuildGraphicButton.Click += new System.EventHandler(this.BuildGraphicButton_Click);
            // 
            // TableListBox
            // 
            this.TableListBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableListBox.FormattingEnabled = true;
            this.TableListBox.ItemHeight = 29;
            this.TableListBox.Location = new System.Drawing.Point(608, 6);
            this.TableListBox.Name = "TableListBox";
            this.TableListBox.Size = new System.Drawing.Size(426, 613);
            this.TableListBox.TabIndex = 2;
            // 
            // ParametresListBox
            // 
            this.ParametresListBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParametresListBox.FormattingEnabled = true;
            this.ParametresListBox.ItemHeight = 25;
            this.ParametresListBox.Items.AddRange(new object[] {
            "Шаг =",
            "Начальная точка =",
            "Погрешноть =",
            "Кол-во точек",
            "графика ="});
            this.ParametresListBox.Location = new System.Drawing.Point(1041, 65);
            this.ParametresListBox.Name = "ParametresListBox";
            this.ParametresListBox.Size = new System.Drawing.Size(204, 154);
            this.ParametresListBox.TabIndex = 3;
            // 
            // hTextBox
            // 
            this.hTextBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hTextBox.Location = new System.Drawing.Point(1243, 65);
            this.hTextBox.Name = "hTextBox";
            this.hTextBox.Size = new System.Drawing.Size(126, 28);
            this.hTextBox.TabIndex = 4;
            this.hTextBox.Text = "0,5";
            // 
            // X0TextBox
            // 
            this.X0TextBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X0TextBox.Location = new System.Drawing.Point(1243, 90);
            this.X0TextBox.Name = "X0TextBox";
            this.X0TextBox.Size = new System.Drawing.Size(126, 28);
            this.X0TextBox.TabIndex = 5;
            this.X0TextBox.Text = "-1";
            // 
            // eTextBox
            // 
            this.eTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.eTextBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eTextBox.Location = new System.Drawing.Point(1243, 115);
            this.eTextBox.Name = "eTextBox";
            this.eTextBox.Size = new System.Drawing.Size(126, 28);
            this.eTextBox.TabIndex = 6;
            this.eTextBox.Text = "0,01";
            // 
            // SwennMethodRadioButton
            // 
            this.SwennMethodRadioButton.AutoSize = true;
            this.SwennMethodRadioButton.Checked = true;
            this.SwennMethodRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SwennMethodRadioButton.Location = new System.Drawing.Point(6, 28);
            this.SwennMethodRadioButton.Name = "SwennMethodRadioButton";
            this.SwennMethodRadioButton.Size = new System.Drawing.Size(114, 34);
            this.SwennMethodRadioButton.TabIndex = 7;
            this.SwennMethodRadioButton.TabStop = true;
            this.SwennMethodRadioButton.Text = "Свенна";
            this.SwennMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // DichotomiesMethodRadioButton
            // 
            this.DichotomiesMethodRadioButton.AutoSize = true;
            this.DichotomiesMethodRadioButton.Location = new System.Drawing.Point(6, 68);
            this.DichotomiesMethodRadioButton.Name = "DichotomiesMethodRadioButton";
            this.DichotomiesMethodRadioButton.Size = new System.Drawing.Size(156, 34);
            this.DichotomiesMethodRadioButton.TabIndex = 8;
            this.DichotomiesMethodRadioButton.Text = "Дихотомии";
            this.DichotomiesMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // SelectMethodGroupBox
            // 
            this.SelectMethodGroupBox.Controls.Add(this.QuadraticInterpolationMethodRadioButton);
            this.SelectMethodGroupBox.Controls.Add(this.GoldenSectionMethodRadioButton);
            this.SelectMethodGroupBox.Controls.Add(this.StepAdaptationMethodRadioButton);
            this.SelectMethodGroupBox.Controls.Add(this.BisectionMethodRadioButton);
            this.SelectMethodGroupBox.Controls.Add(this.SwennMethodRadioButton);
            this.SelectMethodGroupBox.Controls.Add(this.DichotomiesMethodRadioButton);
            this.SelectMethodGroupBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectMethodGroupBox.Location = new System.Drawing.Point(1040, 290);
            this.SelectMethodGroupBox.Name = "SelectMethodGroupBox";
            this.SelectMethodGroupBox.Size = new System.Drawing.Size(337, 263);
            this.SelectMethodGroupBox.TabIndex = 9;
            this.SelectMethodGroupBox.TabStop = false;
            this.SelectMethodGroupBox.Text = "Выберите метод:";
            // 
            // QuadraticInterpolationMethodRadioButton
            // 
            this.QuadraticInterpolationMethodRadioButton.AutoSize = true;
            this.QuadraticInterpolationMethodRadioButton.Location = new System.Drawing.Point(6, 229);
            this.QuadraticInterpolationMethodRadioButton.Name = "QuadraticInterpolationMethodRadioButton";
            this.QuadraticInterpolationMethodRadioButton.Size = new System.Drawing.Size(314, 34);
            this.QuadraticInterpolationMethodRadioButton.TabIndex = 12;
            this.QuadraticInterpolationMethodRadioButton.TabStop = true;
            this.QuadraticInterpolationMethodRadioButton.Text = "Квадратич. интерполяции";
            this.QuadraticInterpolationMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // GoldenSectionMethodRadioButton
            // 
            this.GoldenSectionMethodRadioButton.AutoSize = true;
            this.GoldenSectionMethodRadioButton.Location = new System.Drawing.Point(6, 148);
            this.GoldenSectionMethodRadioButton.Name = "GoldenSectionMethodRadioButton";
            this.GoldenSectionMethodRadioButton.Size = new System.Drawing.Size(226, 34);
            this.GoldenSectionMethodRadioButton.TabIndex = 11;
            this.GoldenSectionMethodRadioButton.TabStop = true;
            this.GoldenSectionMethodRadioButton.Text = "Золотого сечения";
            this.GoldenSectionMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // StepAdaptationMethodRadioButton
            // 
            this.StepAdaptationMethodRadioButton.AutoSize = true;
            this.StepAdaptationMethodRadioButton.Location = new System.Drawing.Point(6, 188);
            this.StepAdaptationMethodRadioButton.Name = "StepAdaptationMethodRadioButton";
            this.StepAdaptationMethodRadioButton.Size = new System.Drawing.Size(211, 34);
            this.StepAdaptationMethodRadioButton.TabIndex = 10;
            this.StepAdaptationMethodRadioButton.TabStop = true;
            this.StepAdaptationMethodRadioButton.Text = "Адаптации шага";
            this.StepAdaptationMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // BisectionMethodRadioButton
            // 
            this.BisectionMethodRadioButton.AutoSize = true;
            this.BisectionMethodRadioButton.Location = new System.Drawing.Point(6, 108);
            this.BisectionMethodRadioButton.Name = "BisectionMethodRadioButton";
            this.BisectionMethodRadioButton.Size = new System.Drawing.Size(318, 34);
            this.BisectionMethodRadioButton.TabIndex = 9;
            this.BisectionMethodRadioButton.TabStop = true;
            this.BisectionMethodRadioButton.Text = "Деления отрезка пополам";
            this.BisectionMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(1041, 559);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(336, 51);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // pTextBox
            // 
            this.pTextBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pTextBox.Location = new System.Drawing.Point(1243, 171);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(126, 28);
            this.pTextBox.TabIndex = 11;
            this.pTextBox.Text = "16";
            // 
            // ATextBox
            // 
            this.ATextBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ATextBox.Location = new System.Drawing.Point(105, 12);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(92, 38);
            this.ATextBox.TabIndex = 12;
            this.ATextBox.Text = "1";
            this.ATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuadraticLabel2
            // 
            this.QuadraticLabel2.AutoSize = true;
            this.QuadraticLabel2.CausesValidation = false;
            this.QuadraticLabel2.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuadraticLabel2.Location = new System.Drawing.Point(203, 16);
            this.QuadraticLabel2.Name = "QuadraticLabel2";
            this.QuadraticLabel2.Size = new System.Drawing.Size(108, 36);
            this.QuadraticLabel2.TabIndex = 13;
            this.QuadraticLabel2.Text = "* X^2 +";
            // 
            // BTextBox
            // 
            this.BTextBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTextBox.Location = new System.Drawing.Point(317, 13);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(92, 38);
            this.BTextBox.TabIndex = 14;
            this.BTextBox.TabStop = false;
            this.BTextBox.Text = "-6";
            this.BTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuadraticLabel3
            // 
            this.QuadraticLabel3.AutoSize = true;
            this.QuadraticLabel3.CausesValidation = false;
            this.QuadraticLabel3.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuadraticLabel3.Location = new System.Drawing.Point(415, 16);
            this.QuadraticLabel3.Name = "QuadraticLabel3";
            this.QuadraticLabel3.Size = new System.Drawing.Size(78, 36);
            this.QuadraticLabel3.TabIndex = 15;
            this.QuadraticLabel3.Text = "* X +";
            // 
            // CTextBox
            // 
            this.CTextBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CTextBox.Location = new System.Drawing.Point(499, 13);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(92, 38);
            this.CTextBox.TabIndex = 16;
            this.CTextBox.TabStop = false;
            this.CTextBox.Text = "10";
            this.CTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuadraticLabel1
            // 
            this.QuadraticLabel1.AutoSize = true;
            this.QuadraticLabel1.CausesValidation = false;
            this.QuadraticLabel1.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuadraticLabel1.Location = new System.Drawing.Point(19, 14);
            this.QuadraticLabel1.Name = "QuadraticLabel1";
            this.QuadraticLabel1.Size = new System.Drawing.Size(80, 36);
            this.QuadraticLabel1.TabIndex = 17;
            this.QuadraticLabel1.Text = "f(X) =";
            // 
            // SelectGraphicDirectionGroupBox
            // 
            this.SelectGraphicDirectionGroupBox.Controls.Add(this.GraphicDirectionLeftRadioButton);
            this.SelectGraphicDirectionGroupBox.Controls.Add(this.GraphicDirectionRightRadioButton);
            this.SelectGraphicDirectionGroupBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectGraphicDirectionGroupBox.Location = new System.Drawing.Point(1041, 219);
            this.SelectGraphicDirectionGroupBox.Name = "SelectGraphicDirectionGroupBox";
            this.SelectGraphicDirectionGroupBox.Size = new System.Drawing.Size(254, 65);
            this.SelectGraphicDirectionGroupBox.TabIndex = 18;
            this.SelectGraphicDirectionGroupBox.TabStop = false;
            this.SelectGraphicDirectionGroupBox.Text = "График строить:";
            // 
            // GraphicDirectionLeftRadioButton
            // 
            this.GraphicDirectionLeftRadioButton.AutoSize = true;
            this.GraphicDirectionLeftRadioButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphicDirectionLeftRadioButton.Location = new System.Drawing.Point(6, 28);
            this.GraphicDirectionLeftRadioButton.Name = "GraphicDirectionLeftRadioButton";
            this.GraphicDirectionLeftRadioButton.Size = new System.Drawing.Size(100, 34);
            this.GraphicDirectionLeftRadioButton.TabIndex = 7;
            this.GraphicDirectionLeftRadioButton.Text = "Влево";
            this.GraphicDirectionLeftRadioButton.UseVisualStyleBackColor = true;
            // 
            // GraphicDirectionRightRadioButton
            // 
            this.GraphicDirectionRightRadioButton.AutoSize = true;
            this.GraphicDirectionRightRadioButton.Checked = true;
            this.GraphicDirectionRightRadioButton.Location = new System.Drawing.Point(131, 28);
            this.GraphicDirectionRightRadioButton.Name = "GraphicDirectionRightRadioButton";
            this.GraphicDirectionRightRadioButton.Size = new System.Drawing.Size(115, 34);
            this.GraphicDirectionRightRadioButton.TabIndex = 8;
            this.GraphicDirectionRightRadioButton.TabStop = true;
            this.GraphicDirectionRightRadioButton.Text = "Вправо";
            this.GraphicDirectionRightRadioButton.UseVisualStyleBackColor = true;
            // 
            // OneDimensionalSearchMethodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 613);
            this.Controls.Add(this.SelectGraphicDirectionGroupBox);
            this.Controls.Add(this.QuadraticLabel1);
            this.Controls.Add(this.CTextBox);
            this.Controls.Add(this.QuadraticLabel3);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.QuadraticLabel2);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SelectMethodGroupBox);
            this.Controls.Add(this.eTextBox);
            this.Controls.Add(this.X0TextBox);
            this.Controls.Add(this.hTextBox);
            this.Controls.Add(this.ParametresListBox);
            this.Controls.Add(this.TableListBox);
            this.Controls.Add(this.BuildGraphicButton);
            this.Controls.Add(this.GraphicChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "OneDimensionalSearchMethodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Методы оптимизаии";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OneDimensionalSearchMethodsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GraphicChart)).EndInit();
            this.SelectMethodGroupBox.ResumeLayout(false);
            this.SelectMethodGroupBox.PerformLayout();
            this.SelectGraphicDirectionGroupBox.ResumeLayout(false);
            this.SelectGraphicDirectionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GraphicChart;
        private System.Windows.Forms.Button BuildGraphicButton;
        private System.Windows.Forms.ListBox TableListBox;
        private System.Windows.Forms.ListBox ParametresListBox;
        private System.Windows.Forms.TextBox hTextBox;
        private System.Windows.Forms.TextBox X0TextBox;
        private System.Windows.Forms.TextBox eTextBox;
        private System.Windows.Forms.RadioButton SwennMethodRadioButton;
        private System.Windows.Forms.RadioButton DichotomiesMethodRadioButton;
        private System.Windows.Forms.GroupBox SelectMethodGroupBox;
        private System.Windows.Forms.RadioButton StepAdaptationMethodRadioButton;
        private System.Windows.Forms.RadioButton BisectionMethodRadioButton;
        private System.Windows.Forms.RadioButton GoldenSectionMethodRadioButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.RadioButton QuadraticInterpolationMethodRadioButton;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.Label QuadraticLabel2;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label QuadraticLabel3;
        private System.Windows.Forms.TextBox CTextBox;
        private System.Windows.Forms.Label QuadraticLabel1;
        private System.Windows.Forms.GroupBox SelectGraphicDirectionGroupBox;
        private System.Windows.Forms.RadioButton GraphicDirectionLeftRadioButton;
        private System.Windows.Forms.RadioButton GraphicDirectionRightRadioButton;
    }
}

