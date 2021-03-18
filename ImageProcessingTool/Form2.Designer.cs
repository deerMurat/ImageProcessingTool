namespace ImageProcessingTool
{
    partial class Form2
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
            this.pbHistogram = new System.Windows.Forms.PictureBox();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBComp = new System.Windows.Forms.CheckBox();
            this.cbGComp = new System.Windows.Forms.CheckBox();
            this.cbRComp = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbColumn = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHistogram
            // 
            this.pbHistogram.Location = new System.Drawing.Point(12, 12);
            this.pbHistogram.Name = "pbHistogram";
            this.pbHistogram.Size = new System.Drawing.Size(500, 500);
            this.pbHistogram.TabIndex = 0;
            this.pbHistogram.TabStop = false;
            // 
            // chartHistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistogram.Legends.Add(legend1);
            this.chartHistogram.Location = new System.Drawing.Point(518, 12);
            this.chartHistogram.Name = "chartHistogram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHistogram.Series.Add(series1);
            this.chartHistogram.Size = new System.Drawing.Size(528, 404);
            this.chartHistogram.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBComp);
            this.groupBox1.Controls.Add(this.cbGComp);
            this.groupBox1.Controls.Add(this.cbRComp);
            this.groupBox1.Location = new System.Drawing.Point(529, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Components";
            // 
            // cbBComp
            // 
            this.cbBComp.AutoSize = true;
            this.cbBComp.Location = new System.Drawing.Point(6, 72);
            this.cbBComp.Name = "cbBComp";
            this.cbBComp.Size = new System.Drawing.Size(122, 21);
            this.cbBComp.TabIndex = 0;
            this.cbBComp.Text = "B Components";
            this.cbBComp.UseVisualStyleBackColor = true;
            // 
            // cbGComp
            // 
            this.cbGComp.AutoSize = true;
            this.cbGComp.Location = new System.Drawing.Point(6, 48);
            this.cbGComp.Name = "cbGComp";
            this.cbGComp.Size = new System.Drawing.Size(124, 21);
            this.cbGComp.TabIndex = 0;
            this.cbGComp.Text = "G Components";
            this.cbGComp.UseVisualStyleBackColor = true;
            // 
            // cbRComp
            // 
            this.cbRComp.AutoSize = true;
            this.cbRComp.Location = new System.Drawing.Point(6, 21);
            this.cbRComp.Name = "cbRComp";
            this.cbRComp.Size = new System.Drawing.Size(123, 21);
            this.cbRComp.TabIndex = 0;
            this.cbRComp.Text = "R Components";
            this.cbRComp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbLine);
            this.groupBox2.Controls.Add(this.rbColumn);
            this.groupBox2.Location = new System.Drawing.Point(754, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graph Type";
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(6, 49);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(56, 21);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbColumn
            // 
            this.rbColumn.AutoSize = true;
            this.rbColumn.Location = new System.Drawing.Point(7, 22);
            this.rbColumn.Name = "rbColumn";
            this.rbColumn.Size = new System.Drawing.Size(76, 21);
            this.rbColumn.TabIndex = 0;
            this.rbColumn.TabStop = true;
            this.rbColumn.Text = "Column";
            this.rbColumn.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(971, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(971, 476);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 42);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 534);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartHistogram);
            this.Controls.Add(this.pbHistogram);
            this.Name = "Form2";
            this.Text = "Histogram Graph";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbBComp;
        private System.Windows.Forms.CheckBox cbGComp;
        private System.Windows.Forms.CheckBox cbRComp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDraw;
    }
}