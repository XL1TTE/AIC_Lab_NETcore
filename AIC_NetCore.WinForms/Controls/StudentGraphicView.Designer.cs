namespace AIC_NetCore.WinForms.Controls
{
    partial class StudentGraphicView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            StudentHisto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            UpdateGraphButton = new Button();
            ToTableButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentHisto).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(StudentHisto);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 530);
            panel1.TabIndex = 0;
            // 
            // StudentHisto
            // 
            chartArea1.Name = "ChartArea1";
            StudentHisto.ChartAreas.Add(chartArea1);
            StudentHisto.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            StudentHisto.Legends.Add(legend1);
            StudentHisto.Location = new Point(0, 0);
            StudentHisto.Name = "StudentHisto";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            StudentHisto.Series.Add(series1);
            StudentHisto.Size = new Size(564, 530);
            StudentHisto.TabIndex = 0;
            StudentHisto.Text = "График";
            // 
            // panel2
            // 
            panel2.Controls.Add(UpdateGraphButton);
            panel2.Controls.Add(ToTableButton);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(573, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 530);
            panel2.TabIndex = 1;
            // 
            // UpdateGraphButton
            // 
            UpdateGraphButton.AutoSize = true;
            UpdateGraphButton.Location = new Point(17, 276);
            UpdateGraphButton.Name = "UpdateGraphButton";
            UpdateGraphButton.Size = new Size(141, 30);
            UpdateGraphButton.TabIndex = 1;
            UpdateGraphButton.Text = "Обновить график";
            UpdateGraphButton.UseVisualStyleBackColor = true;
            UpdateGraphButton.Click += UpdateGraphButton_Click;
            // 
            // ToTableButton
            // 
            ToTableButton.Location = new Point(36, 241);
            ToTableButton.Name = "ToTableButton";
            ToTableButton.Size = new Size(94, 29);
            ToTableButton.TabIndex = 0;
            ToTableButton.Text = "К таблице";
            ToTableButton.UseVisualStyleBackColor = true;
            ToTableButton.Click += ToStudentTableButton_Click;
            // 
            // StudentGraphicView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StudentGraphicView";
            Size = new Size(753, 530);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentHisto).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button UpdateGraphButton;
        private Button ToTableButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart StudentHisto;
    }
}
