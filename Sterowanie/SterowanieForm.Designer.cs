namespace Sterowanie
{
    partial class SterowanieForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ZadanaPredkoscLabel = new System.Windows.Forms.Label();
            this.aktualnaPredkoscLabel = new System.Windows.Forms.Label();
            this.ZadanaPredkoscValue = new System.Windows.Forms.TextBox();
            this.AktualnaPredkoscValue = new System.Windows.Forms.TextBox();
            this.WyslijButton = new System.Windows.Forms.Button();
            this.Gauge = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            this.Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // ZadanaPredkoscLabel
            // 
            this.ZadanaPredkoscLabel.AutoSize = true;
            this.ZadanaPredkoscLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.ZadanaPredkoscLabel.Location = new System.Drawing.Point(18, 780);
            this.ZadanaPredkoscLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZadanaPredkoscLabel.Name = "ZadanaPredkoscLabel";
            this.ZadanaPredkoscLabel.Size = new System.Drawing.Size(423, 65);
            this.ZadanaPredkoscLabel.TabIndex = 0;
            this.ZadanaPredkoscLabel.Text = "Zadana Prędkość:";
            // 
            // aktualnaPredkoscLabel
            // 
            this.aktualnaPredkoscLabel.AutoSize = true;
            this.aktualnaPredkoscLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.aktualnaPredkoscLabel.Location = new System.Drawing.Point(776, 780);
            this.aktualnaPredkoscLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aktualnaPredkoscLabel.Name = "aktualnaPredkoscLabel";
            this.aktualnaPredkoscLabel.Size = new System.Drawing.Size(461, 65);
            this.aktualnaPredkoscLabel.TabIndex = 1;
            this.aktualnaPredkoscLabel.Text = "Aktualna Prędkość:";
            // 
            // ZadanaPredkoscValue
            // 
            this.ZadanaPredkoscValue.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZadanaPredkoscValue.Location = new System.Drawing.Point(453, 791);
            this.ZadanaPredkoscValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ZadanaPredkoscValue.Name = "ZadanaPredkoscValue";
            this.ZadanaPredkoscValue.Size = new System.Drawing.Size(208, 49);
            this.ZadanaPredkoscValue.TabIndex = 0;
            this.ZadanaPredkoscValue.Text = "0";
            this.ZadanaPredkoscValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ZadanaPredkoscValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZadanaPredkoscValue_KeyPress);
            // 
            // AktualnaPredkoscValue
            // 
            this.AktualnaPredkoscValue.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AktualnaPredkoscValue.Location = new System.Drawing.Point(1248, 791);
            this.AktualnaPredkoscValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AktualnaPredkoscValue.Name = "AktualnaPredkoscValue";
            this.AktualnaPredkoscValue.ReadOnly = true;
            this.AktualnaPredkoscValue.Size = new System.Drawing.Size(208, 49);
            this.AktualnaPredkoscValue.TabIndex = 4;
            this.AktualnaPredkoscValue.Text = "0";
            this.AktualnaPredkoscValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WyslijButton
            // 
            this.WyslijButton.BackColor = System.Drawing.Color.DarkGreen;
            this.WyslijButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WyslijButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WyslijButton.Location = new System.Drawing.Point(672, 791);
            this.WyslijButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WyslijButton.Name = "WyslijButton";
            this.WyslijButton.Size = new System.Drawing.Size(94, 54);
            this.WyslijButton.TabIndex = 5;
            this.WyslijButton.Text = "Wyślij";
            this.WyslijButton.UseVisualStyleBackColor = false;
            this.WyslijButton.Click += new System.EventHandler(this.WyslijButton_Click);
            // 
            // Gauge
            // 
            this.Gauge.ArcThickness = 2F;
            this.Gauge.BackgroundGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Gauge.BackgroundGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Gauge.EnableCustomNeedles = false;
            this.Gauge.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.Gauge.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gauge.ForeColor = System.Drawing.Color.Black;
            this.Gauge.FrameThickness = 12;
            this.Gauge.GaugeArcColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.Gauge.GaugeLabel = "Prędkość";
            this.Gauge.GaugeLableColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.Gauge.GaugeLableFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gauge.GaugeValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.Gauge.GaugeValueFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gauge.InnerFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Gauge.InnerFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Gauge.InterLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.Gauge.LabelPlacement = Syncfusion.Windows.Forms.Gauge.LabelPlacement.Outside;
            this.Gauge.Location = new System.Drawing.Point(920, 126);
            this.Gauge.MajorDifference = 50F;
            this.Gauge.MajorTickMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.Gauge.MaximumValue = 300F;
            this.Gauge.MinimumSize = new System.Drawing.Size(125, 125);
            this.Gauge.MinorDifference = 10F;
            this.Gauge.MinorTickMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.Gauge.Name = "Gauge";
            this.Gauge.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.Gauge.OuterFrameGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Gauge.OuterFrameGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Gauge.ScaleLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.Gauge.ShowTicks = true;
            this.Gauge.Size = new System.Drawing.Size(544, 544);
            this.Gauge.TabIndex = 7;
            this.Gauge.ThemeName = "Office2016White";
            this.Gauge.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Office2016White;
            // 
            // Wykres
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX2.IsMarginVisible = false;
            chartArea1.AxisX2.LabelStyle.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY2.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            this.Wykres.ChartAreas.Add(chartArea1);
            this.Wykres.Location = new System.Drawing.Point(12, 12);
            this.Wykres.Name = "Wykres";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.Legend = "Legend1";
            series1.Name = "ZadanaPredkoscSeries";
            series1.ShadowColor = System.Drawing.Color.Gray;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "AktualnaPredkoscSeries";
            this.Wykres.Series.Add(series1);
            this.Wykres.Series.Add(series2);
            this.Wykres.Size = new System.Drawing.Size(894, 765);
            this.Wykres.TabIndex = 8;
            this.Wykres.Text = "Wykres";
            // 
            // SterowanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 863);
            this.Controls.Add(this.Wykres);
            this.Controls.Add(this.Gauge);
            this.Controls.Add(this.WyslijButton);
            this.Controls.Add(this.AktualnaPredkoscValue);
            this.Controls.Add(this.ZadanaPredkoscValue);
            this.Controls.Add(this.aktualnaPredkoscLabel);
            this.Controls.Add(this.ZadanaPredkoscLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SterowanieForm";
            this.Text = "Panel Sterowania";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SterowanieForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ZadanaPredkoscLabel;
        private System.Windows.Forms.Label aktualnaPredkoscLabel;
        private System.Windows.Forms.TextBox ZadanaPredkoscValue;
        private System.Windows.Forms.TextBox AktualnaPredkoscValue;
        private System.Windows.Forms.Button WyslijButton;
        private Syncfusion.Windows.Forms.Gauge.RadialGauge Gauge;
        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres;
    }
}