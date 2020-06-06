namespace Finel_Project
{
    partial class Statistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDishType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMorF = new System.Windows.Forms.Label();
            this.lblSide = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDishType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "סטטיסטיקה";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(38, 463);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 57);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderSkin.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(273, 263);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(252, 169);
            this.chart1.TabIndex = 52;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.Control;
            this.chart2.BorderSkin.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chart2.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.SystemColors.Control;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(15, 61);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(252, 169);
            this.chart2.TabIndex = 53;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.SystemColors.Control;
            this.chart3.BorderSkin.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chart3.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea3.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.SystemColors.Control;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(15, 263);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(252, 169);
            this.chart3.TabIndex = 54;
            this.chart3.Text = "chart3";
            // 
            // lblDishType
            // 
            this.lblDishType.BackColor = System.Drawing.SystemColors.Control;
            this.lblDishType.BorderSkin.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.lblDishType.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea4.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            this.lblDishType.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.SystemColors.Control;
            legend4.Name = "Legend1";
            this.lblDishType.Legends.Add(legend4);
            this.lblDishType.Location = new System.Drawing.Point(273, 61);
            this.lblDishType.Name = "lblDishType";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.lblDishType.Series.Add(series4);
            this.lblDishType.Size = new System.Drawing.Size(252, 169);
            this.lblDishType.TabIndex = 55;
            this.lblDishType.Text = "chart4";
            // 
            // lblMorF
            // 
            this.lblMorF.BackColor = System.Drawing.Color.DarkCyan;
            this.lblMorF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMorF.Location = new System.Drawing.Point(273, 233);
            this.lblMorF.Name = "lblMorF";
            this.lblMorF.Size = new System.Drawing.Size(252, 27);
            this.lblMorF.TabIndex = 56;
            this.lblMorF.Text = "Male / Female";
            this.lblMorF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSide
            // 
            this.lblSide.BackColor = System.Drawing.Color.DarkCyan;
            this.lblSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSide.Location = new System.Drawing.Point(15, 31);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(252, 27);
            this.lblSide.TabIndex = 57;
            this.lblSide.Text = "Sides";
            this.lblSide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.DarkCyan;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAge.Location = new System.Drawing.Point(15, 233);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(252, 27);
            this.lblAge.TabIndex = 58;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(273, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 27);
            this.label4.TabIndex = 59;
            this.label4.Text = "Dish Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 534);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.lblMorF);
            this.Controls.Add(this.lblDishType);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDishType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart lblDishType;
        private System.Windows.Forms.Label lblMorF;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label4;
    }
}