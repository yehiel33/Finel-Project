﻿namespace Finel_Project
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.chartBus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSides = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAlcohol = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDishType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblBus = new System.Windows.Forms.Label();
            this.lblSides = new System.Windows.Forms.Label();
            this.lblAlcohol = new System.Windows.Forms.Label();
            this.lblDishType = new System.Windows.Forms.Label();
            this.finel_ProjectDataSet = new Finel_Project.Finel_ProjectDataSet();
            this.gUEST_LISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gUEST_LISTTableAdapter = new Finel_Project.Finel_ProjectDataSetTableAdapters.GUEST_LISTTableAdapter();
            this.tableAdapterManager = new Finel_Project.Finel_ProjectDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.chartBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAlcohol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDishType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finel_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUEST_LISTBindingSource)).BeginInit();
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
            this.btnBack.Location = new System.Drawing.Point(12, 682);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 57);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chartBus
            // 
            this.chartBus.BackColor = System.Drawing.SystemColors.Control;
            this.chartBus.BorderSkin.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chartBus.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea9.BackColor = System.Drawing.SystemColors.Control;
            chartArea9.Name = "ChartArea1";
            this.chartBus.ChartAreas.Add(chartArea9);
            legend9.BackColor = System.Drawing.SystemColors.Control;
            legend9.Enabled = false;
            legend9.Name = "Legend1";
            this.chartBus.Legends.Add(legend9);
            this.chartBus.Location = new System.Drawing.Point(311, 385);
            this.chartBus.Name = "chartBus";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Legend = "Legend1";
            series9.Name = "Bus";
            this.chartBus.Series.Add(series9);
            this.chartBus.Size = new System.Drawing.Size(291, 291);
            this.chartBus.TabIndex = 52;
            this.chartBus.Text = "chartBus";
            // 
            // chartSides
            // 
            this.chartSides.BackColor = System.Drawing.SystemColors.Control;
            this.chartSides.BorderSkin.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chartSides.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea10.BackColor = System.Drawing.SystemColors.Control;
            chartArea10.Name = "ChartArea1";
            this.chartSides.ChartAreas.Add(chartArea10);
            legend10.BackColor = System.Drawing.SystemColors.Control;
            legend10.Enabled = false;
            legend10.Name = "Legend1";
            this.chartSides.Legends.Add(legend10);
            this.chartSides.Location = new System.Drawing.Point(15, 61);
            this.chartSides.Name = "chartSides";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.Legend = "Legend1";
            series10.Name = "Side";
            series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartSides.Series.Add(series10);
            this.chartSides.Size = new System.Drawing.Size(291, 291);
            this.chartSides.TabIndex = 53;
            this.chartSides.Text = "chartSides";
            this.chartSides.Click += new System.EventHandler(this.chartSides_Click);
            // 
            // chartAlcohol
            // 
            this.chartAlcohol.BackColor = System.Drawing.SystemColors.Control;
            this.chartAlcohol.BorderSkin.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chartAlcohol.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea11.BackColor = System.Drawing.SystemColors.Control;
            chartArea11.Name = "ChartArea1";
            this.chartAlcohol.ChartAreas.Add(chartArea11);
            legend11.BackColor = System.Drawing.SystemColors.Control;
            legend11.Enabled = false;
            legend11.Name = "Legend1";
            this.chartAlcohol.Legends.Add(legend11);
            this.chartAlcohol.Location = new System.Drawing.Point(15, 385);
            this.chartAlcohol.Name = "chartAlcohol";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series11.Legend = "Legend1";
            series11.Name = "Alcohol";
            this.chartAlcohol.Series.Add(series11);
            this.chartAlcohol.Size = new System.Drawing.Size(291, 291);
            this.chartAlcohol.TabIndex = 54;
            this.chartAlcohol.Text = "chartAlcohol";
            // 
            // chartDishType
            // 
            this.chartDishType.BackColor = System.Drawing.SystemColors.Control;
            this.chartDishType.BorderSkin.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chartDishType.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea12.BackColor = System.Drawing.SystemColors.Control;
            chartArea12.Name = "ChartArea1";
            this.chartDishType.ChartAreas.Add(chartArea12);
            legend12.BackColor = System.Drawing.SystemColors.Control;
            legend12.Enabled = false;
            legend12.Name = "Legend1";
            this.chartDishType.Legends.Add(legend12);
            this.chartDishType.Location = new System.Drawing.Point(311, 61);
            this.chartDishType.Name = "chartDishType";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.LabelFormat = "#PERCENT";
            series12.Legend = "Legend1";
            series12.Name = "Dish";
            this.chartDishType.Series.Add(series12);
            this.chartDishType.Size = new System.Drawing.Size(291, 291);
            this.chartDishType.TabIndex = 55;
            this.chartDishType.Text = "chartDishType";
            // 
            // lblBus
            // 
            this.lblBus.BackColor = System.Drawing.Color.DarkCyan;
            this.lblBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBus.Location = new System.Drawing.Point(311, 355);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(291, 27);
            this.lblBus.TabIndex = 56;
            this.lblBus.Text = "Bus";
            this.lblBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSides
            // 
            this.lblSides.BackColor = System.Drawing.Color.DarkCyan;
            this.lblSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSides.Location = new System.Drawing.Point(15, 31);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(291, 27);
            this.lblSides.TabIndex = 57;
            this.lblSides.Text = "Sides";
            this.lblSides.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlcohol
            // 
            this.lblAlcohol.BackColor = System.Drawing.Color.DarkCyan;
            this.lblAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAlcohol.Location = new System.Drawing.Point(15, 355);
            this.lblAlcohol.Name = "lblAlcohol";
            this.lblAlcohol.Size = new System.Drawing.Size(291, 27);
            this.lblAlcohol.TabIndex = 58;
            this.lblAlcohol.Text = "Alcohol";
            this.lblAlcohol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDishType
            // 
            this.lblDishType.BackColor = System.Drawing.Color.DarkCyan;
            this.lblDishType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDishType.Location = new System.Drawing.Point(311, 31);
            this.lblDishType.Name = "lblDishType";
            this.lblDishType.Size = new System.Drawing.Size(291, 27);
            this.lblDishType.TabIndex = 59;
            this.lblDishType.Text = "Dish Type";
            this.lblDishType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finel_ProjectDataSet
            // 
            this.finel_ProjectDataSet.DataSetName = "Finel_ProjectDataSet";
            this.finel_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gUEST_LISTBindingSource
            // 
            this.gUEST_LISTBindingSource.DataMember = "GUEST_LIST";
            this.gUEST_LISTBindingSource.DataSource = this.finel_ProjectDataSet;
            // 
            // gUEST_LISTTableAdapter
            // 
            this.gUEST_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EVENT_OWNERSTableAdapter = null;
            this.tableAdapterManager.GUEST_LISTTableAdapter = this.gUEST_LISTTableAdapter;
            this.tableAdapterManager.SUPPLIERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Finel_Project.Finel_ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 750);
            this.Controls.Add(this.lblDishType);
            this.Controls.Add(this.lblAlcohol);
            this.Controls.Add(this.lblSides);
            this.Controls.Add(this.lblBus);
            this.Controls.Add(this.chartDishType);
            this.Controls.Add(this.chartAlcohol);
            this.Controls.Add(this.chartSides);
            this.Controls.Add(this.chartBus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAlcohol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDishType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finel_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUEST_LISTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSides;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAlcohol;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDishType;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.Label lblSides;
        private System.Windows.Forms.Label lblAlcohol;
        private System.Windows.Forms.Label lblDishType;
        private Finel_ProjectDataSet finel_ProjectDataSet;
        private System.Windows.Forms.BindingSource gUEST_LISTBindingSource;
        private Finel_ProjectDataSetTableAdapters.GUEST_LISTTableAdapter gUEST_LISTTableAdapter;
        private Finel_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}