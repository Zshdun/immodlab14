namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.peopleCount = new System.Windows.Forms.Label();
            this.queueCount = new System.Windows.Forms.Label();
            this.opercnt = new System.Windows.Forms.NumericUpDown();
            this.stop = new System.Windows.Forms.Button();
            this.cl2 = new System.Windows.Forms.Label();
            this.cl3 = new System.Windows.Forms.Label();
            this.cl1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.opersCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.opercnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleCount
            // 
            this.peopleCount.AutoSize = true;
            this.peopleCount.Location = new System.Drawing.Point(765, 96);
            this.peopleCount.Name = "peopleCount";
            this.peopleCount.Size = new System.Drawing.Size(13, 13);
            this.peopleCount.TabIndex = 20;
            this.peopleCount.Text = "0";
            // 
            // queueCount
            // 
            this.queueCount.AutoSize = true;
            this.queueCount.Location = new System.Drawing.Point(815, 42);
            this.queueCount.Name = "queueCount";
            this.queueCount.Size = new System.Drawing.Size(13, 13);
            this.queueCount.TabIndex = 19;
            this.queueCount.Text = "0";
            // 
            // opercnt
            // 
            this.opercnt.Location = new System.Drawing.Point(456, 49);
            this.opercnt.Name = "opercnt";
            this.opercnt.Size = new System.Drawing.Size(120, 20);
            this.opercnt.TabIndex = 18;
            this.opercnt.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(96, 114);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(74, 35);
            this.stop.TabIndex = 17;
            this.stop.Text = "Стоп";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // cl2
            // 
            this.cl2.AutoSize = true;
            this.cl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cl2.Location = new System.Drawing.Point(614, 39);
            this.cl2.Name = "cl2";
            this.cl2.Size = new System.Drawing.Size(203, 17);
            this.cl2.TabIndex = 16;
            this.cl2.Text = "Количество людей в очереди";
            // 
            // cl3
            // 
            this.cl3.AutoSize = true;
            this.cl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cl3.Location = new System.Drawing.Point(614, 92);
            this.cl3.Name = "cl3";
            this.cl3.Size = new System.Drawing.Size(145, 17);
            this.cl3.TabIndex = 15;
            this.cl3.Text = "Всего людей за день";
            // 
            // cl1
            // 
            this.cl1.AutoSize = true;
            this.cl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cl1.Location = new System.Drawing.Point(204, 49);
            this.cl1.Name = "cl1";
            this.cl1.Size = new System.Drawing.Size(249, 17);
            this.cl1.TabIndex = 14;
            this.cl1.Text = "Количество касс самообслуживания";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(67, 33);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(131, 49);
            this.start.TabIndex = 13;
            this.start.Text = "Открыть магазин";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(14, 170);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Maroon;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 11;
            series2.Name = "Касс занято";
            series2.ShadowColor = System.Drawing.Color.Black;
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1402, 605);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(285, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Свободных касс";
            // 
            // opersCount
            // 
            this.opersCount.AutoSize = true;
            this.opersCount.Location = new System.Drawing.Point(453, 99);
            this.opersCount.Name = "opersCount";
            this.opersCount.Size = new System.Drawing.Size(13, 13);
            this.opersCount.TabIndex = 23;
            this.opersCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 830);
            this.Controls.Add(this.opersCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.peopleCount);
            this.Controls.Add(this.queueCount);
            this.Controls.Add(this.opercnt);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.cl2);
            this.Controls.Add(this.cl3);
            this.Controls.Add(this.cl1);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.opercnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label peopleCount;
        private System.Windows.Forms.Label queueCount;
        private System.Windows.Forms.NumericUpDown opercnt;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label cl2;
        private System.Windows.Forms.Label cl3;
        private System.Windows.Forms.Label cl1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label opersCount;
    }
}

