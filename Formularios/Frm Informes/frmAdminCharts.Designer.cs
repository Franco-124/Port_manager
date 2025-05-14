namespace Port_manager.Formularios.Frm_Informes
{
    partial class frmAdminCharts
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGrafico = new System.Windows.Forms.Label();
            this.chartTipoIncidencia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartUsuariosPorRol = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLineaTendencia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTipoIncidencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuariosPorRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLineaTendencia)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.chartTipoIncidencia);
            this.flowLayoutPanel1.Controls.Add(this.chartUsuariosPorRol);
            this.flowLayoutPanel1.Controls.Add(this.chartLineaTendencia);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1467, 888);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGrafico);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 79);
            this.panel1.TabIndex = 3;
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafico.ForeColor = System.Drawing.Color.White;
            this.lblGrafico.Location = new System.Drawing.Point(479, 20);
            this.lblGrafico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(351, 42);
            this.lblGrafico.TabIndex = 4;
            this.lblGrafico.Text = "Informacion Grafica ";
            // 
            // chartTipoIncidencia
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTipoIncidencia.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTipoIncidencia.Legends.Add(legend1);
            this.chartTipoIncidencia.Location = new System.Drawing.Point(13, 99);
            this.chartTipoIncidencia.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chartTipoIncidencia.Name = "chartTipoIncidencia";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTipoIncidencia.Series.Add(series1);
            this.chartTipoIncidencia.Size = new System.Drawing.Size(519, 377);
            this.chartTipoIncidencia.TabIndex = 0;
            this.chartTipoIncidencia.Text = "chart1";
            this.chartTipoIncidencia.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chartUsuariosPorRol
            // 
            chartArea2.Name = "ChartArea1";
            this.chartUsuariosPorRol.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartUsuariosPorRol.Legends.Add(legend2);
            this.chartUsuariosPorRol.Location = new System.Drawing.Point(558, 99);
            this.chartUsuariosPorRol.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chartUsuariosPorRol.Name = "chartUsuariosPorRol";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartUsuariosPorRol.Series.Add(series2);
            this.chartUsuariosPorRol.Size = new System.Drawing.Size(686, 377);
            this.chartUsuariosPorRol.TabIndex = 1;
            this.chartUsuariosPorRol.Text = "chart2";
            this.chartUsuariosPorRol.Click += new System.EventHandler(this.chartUsuariosPorRol_Click);
            // 
            // chartLineaTendencia
            // 
            chartArea3.Name = "ChartArea1";
            this.chartLineaTendencia.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartLineaTendencia.Legends.Add(legend3);
            this.chartLineaTendencia.Location = new System.Drawing.Point(13, 500);
            this.chartLineaTendencia.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chartLineaTendencia.Name = "chartLineaTendencia";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartLineaTendencia.Series.Add(series3);
            this.chartLineaTendencia.Size = new System.Drawing.Size(625, 352);
            this.chartLineaTendencia.TabIndex = 2;
            this.chartLineaTendencia.Text = "chart1";
            // 
            // frmAdminCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1467, 888);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminCharts";
            this.Text = "Graficos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdminCharts_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTipoIncidencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuariosPorRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLineaTendencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTipoIncidencia;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsuariosPorRol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLineaTendencia;
        private System.Windows.Forms.Label lblGrafico;
    }
}