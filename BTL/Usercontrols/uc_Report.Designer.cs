namespace DONGHO.Usercontrols
{
    partial class uc_Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            cbbNam = new ComboBox();
            panel1 = new Panel();
            btnEmail = new Button();
            button1 = new Button();
            panelCheckBox = new Panel();
            groupBox = new GroupBox();
            checkBoxOrient = new CheckBox();
            checkBoxTissot = new CheckBox();
            checkBoxSeiko = new CheckBox();
            checkBoxCitizen = new CheckBox();
            checkBoxOlymPianus = new CheckBox();
            checkBoxBentley = new CheckBox();
            checkBoxGShock = new CheckBox();
            checkBoxCasio = new CheckBox();
            chartBrandAll = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartBrand = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            label4 = new Label();
            PDFMinProduct = new Button();
            dtgvMinProduct = new DataGridView();
            panelTopProduct = new Panel();
            label3 = new Label();
            PDFTopProduct = new Button();
            dtgvTopProduct = new DataGridView();
            label2 = new Label();
            cbbTrungBinhHoaDon = new ComboBox();
            chartTrungBinhHoaDon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panelCheckBox.SuspendLayout();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartBrandAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartBrand).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMinProduct).BeginInit();
            panelTopProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTopProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTrungBinhHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 17);
            label1.Name = "label1";
            label1.Size = new Size(332, 64);
            label1.TabIndex = 1;
            label1.Text = "Doanh thu trung bình";
            // 
            // cbbNam
            // 
            cbbNam.FormattingEnabled = true;
            cbbNam.Items.AddRange(new object[] { "Năm 2023", "Năm 2024" });
            cbbNam.Location = new Point(338, 17);
            cbbNam.Name = "cbbNam";
            cbbNam.Size = new Size(242, 40);
            cbbNam.TabIndex = 2;
            cbbNam.SelectedIndexChanged += cbbNam_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnEmail);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panelCheckBox);
            panel1.Controls.Add(chartBrandAll);
            panel1.Controls.Add(chartBrand);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelTopProduct);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbbTrungBinhHoaDon);
            panel1.Controls.Add(chartTrungBinhHoaDon);
            panel1.Controls.Add(chartDoanhThu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbbNam);
            panel1.Location = new Point(24, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(2286, 1184);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(2104, 3);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(150, 46);
            btnEmail.TabIndex = 18;
            btnEmail.Text = "Xuất báo cáo";
            btnEmail.UseVisualStyleBackColor = true;
            btnEmail.Click += btnEmail_Click;
            // 
            // button1
            // 
            button1.Location = new Point(504, 1603);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 17;
            button1.Text = "So sánh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelCheckBox
            // 
            panelCheckBox.Controls.Add(groupBox);
            panelCheckBox.Location = new Point(54, 1587);
            panelCheckBox.Name = "panelCheckBox";
            panelCheckBox.Size = new Size(444, 259);
            panelCheckBox.TabIndex = 16;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(checkBoxOrient);
            groupBox.Controls.Add(checkBoxTissot);
            groupBox.Controls.Add(checkBoxSeiko);
            groupBox.Controls.Add(checkBoxCitizen);
            groupBox.Controls.Add(checkBoxOlymPianus);
            groupBox.Controls.Add(checkBoxBentley);
            groupBox.Controls.Add(checkBoxGShock);
            groupBox.Controls.Add(checkBoxCasio);
            groupBox.Location = new Point(16, 3);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(408, 248);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "BrandName";
            groupBox.Enter += groupBox_Enter;
            // 
            // checkBoxOrient
            // 
            checkBoxOrient.AutoSize = true;
            checkBoxOrient.Location = new Point(168, 138);
            checkBoxOrient.Name = "checkBoxOrient";
            checkBoxOrient.Size = new Size(113, 36);
            checkBoxOrient.TabIndex = 18;
            checkBoxOrient.Text = "Orient";
            checkBoxOrient.UseVisualStyleBackColor = true;
            checkBoxOrient.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // checkBoxTissot
            // 
            checkBoxTissot.AutoSize = true;
            checkBoxTissot.Location = new Point(168, 180);
            checkBoxTissot.Name = "checkBoxTissot";
            checkBoxTissot.Size = new Size(107, 36);
            checkBoxTissot.TabIndex = 4;
            checkBoxTissot.Text = "Tissot";
            checkBoxTissot.UseVisualStyleBackColor = true;
            // 
            // checkBoxSeiko
            // 
            checkBoxSeiko.AutoSize = true;
            checkBoxSeiko.Location = new Point(37, 178);
            checkBoxSeiko.Name = "checkBoxSeiko";
            checkBoxSeiko.Size = new Size(104, 36);
            checkBoxSeiko.TabIndex = 3;
            checkBoxSeiko.Text = "Seiko";
            checkBoxSeiko.UseVisualStyleBackColor = true;
            // 
            // checkBoxCitizen
            // 
            checkBoxCitizen.AutoSize = true;
            checkBoxCitizen.Location = new Point(37, 136);
            checkBoxCitizen.Name = "checkBoxCitizen";
            checkBoxCitizen.Size = new Size(119, 36);
            checkBoxCitizen.TabIndex = 2;
            checkBoxCitizen.Text = "Citizen";
            checkBoxCitizen.UseVisualStyleBackColor = true;
            // 
            // checkBoxOlymPianus
            // 
            checkBoxOlymPianus.AutoSize = true;
            checkBoxOlymPianus.Location = new Point(169, 96);
            checkBoxOlymPianus.Name = "checkBoxOlymPianus";
            checkBoxOlymPianus.Size = new Size(179, 36);
            checkBoxOlymPianus.TabIndex = 17;
            checkBoxOlymPianus.Text = "Olym Pianus";
            checkBoxOlymPianus.UseVisualStyleBackColor = true;
            // 
            // checkBoxBentley
            // 
            checkBoxBentley.AutoSize = true;
            checkBoxBentley.Location = new Point(37, 96);
            checkBoxBentley.Name = "checkBoxBentley";
            checkBoxBentley.Size = new Size(126, 36);
            checkBoxBentley.TabIndex = 1;
            checkBoxBentley.Text = "Bentley";
            checkBoxBentley.UseVisualStyleBackColor = true;
            // 
            // checkBoxGShock
            // 
            checkBoxGShock.AutoSize = true;
            checkBoxGShock.Location = new Point(168, 52);
            checkBoxGShock.Name = "checkBoxGShock";
            checkBoxGShock.Size = new Size(136, 36);
            checkBoxGShock.TabIndex = 5;
            checkBoxGShock.Text = "G-Shock";
            checkBoxGShock.UseVisualStyleBackColor = true;
            checkBoxGShock.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBoxCasio
            // 
            checkBoxCasio.AutoSize = true;
            checkBoxCasio.Location = new Point(37, 52);
            checkBoxCasio.Name = "checkBoxCasio";
            checkBoxCasio.Size = new Size(103, 36);
            checkBoxCasio.TabIndex = 0;
            checkBoxCasio.Text = "Casio";
            checkBoxCasio.UseVisualStyleBackColor = true;
            // 
            // chartBrandAll
            // 
            chartArea1.Name = "ChartArea1";
            chartBrandAll.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartBrandAll.Legends.Add(legend1);
            chartBrandAll.Location = new Point(1149, 1847);
            chartBrandAll.Name = "chartBrandAll";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartBrandAll.Series.Add(series1);
            chartBrandAll.Size = new Size(1108, 607);
            chartBrandAll.TabIndex = 15;
            chartBrandAll.Text = "chart1";
            // 
            // chartBrand
            // 
            chartArea2.Name = "ChartArea1";
            chartBrand.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartBrand.Legends.Add(legend2);
            chartBrand.Location = new Point(54, 1852);
            chartBrand.Name = "chartBrand";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartBrand.Series.Add(series2);
            chartBrand.Size = new Size(1089, 600);
            chartBrand.TabIndex = 9;
            chartBrand.Text = "chart2";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(PDFMinProduct);
            panel2.Controls.Add(dtgvMinProduct);
            panel2.Location = new Point(1502, 885);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 764);
            panel2.TabIndex = 7;
            // 
            // label4
            // 
            label4.Location = new Point(33, 0);
            label4.Name = "label4";
            label4.Size = new Size(526, 64);
            label4.TabIndex = 8;
            label4.Text = "Sản phẩm có doanh thu ít nhất";
            // 
            // PDFMinProduct
            // 
            PDFMinProduct.Location = new Point(578, 3);
            PDFMinProduct.Name = "PDFMinProduct";
            PDFMinProduct.Size = new Size(150, 46);
            PDFMinProduct.TabIndex = 7;
            PDFMinProduct.Text = "In PDF";
            PDFMinProduct.UseVisualStyleBackColor = true;
            PDFMinProduct.Click += PDFMinProduct_Click;
            // 
            // dtgvMinProduct
            // 
            dtgvMinProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvMinProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMinProduct.Location = new Point(3, 67);
            dtgvMinProduct.Name = "dtgvMinProduct";
            dtgvMinProduct.RowHeadersWidth = 82;
            dtgvMinProduct.Size = new Size(725, 694);
            dtgvMinProduct.TabIndex = 0;
            // 
            // panelTopProduct
            // 
            panelTopProduct.Controls.Add(label3);
            panelTopProduct.Controls.Add(PDFTopProduct);
            panelTopProduct.Controls.Add(dtgvTopProduct);
            panelTopProduct.Location = new Point(1499, 133);
            panelTopProduct.Name = "panelTopProduct";
            panelTopProduct.Size = new Size(728, 690);
            panelTopProduct.TabIndex = 6;
            // 
            // label3
            // 
            label3.Location = new Point(36, 0);
            label3.Name = "label3";
            label3.Size = new Size(481, 64);
            label3.TabIndex = 8;
            label3.Text = "Sản phẩm bán ra nhiều nhất";
            label3.Click += label3_Click;
            // 
            // PDFTopProduct
            // 
            PDFTopProduct.Location = new Point(578, 3);
            PDFTopProduct.Name = "PDFTopProduct";
            PDFTopProduct.Size = new Size(150, 46);
            PDFTopProduct.TabIndex = 7;
            PDFTopProduct.Text = "In PDF";
            PDFTopProduct.UseVisualStyleBackColor = true;
            PDFTopProduct.Click += PDFTopProduct_Click;
            // 
            // dtgvTopProduct
            // 
            dtgvTopProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvTopProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTopProduct.Location = new Point(3, 67);
            dtgvTopProduct.Name = "dtgvTopProduct";
            dtgvTopProduct.RowHeadersWidth = 82;
            dtgvTopProduct.Size = new Size(728, 620);
            dtgvTopProduct.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(9, 818);
            label2.Name = "label2";
            label2.Size = new Size(323, 64);
            label2.TabIndex = 4;
            label2.Text = "Thống kê doanh thu";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbbTrungBinhHoaDon
            // 
            cbbTrungBinhHoaDon.FormattingEnabled = true;
            cbbTrungBinhHoaDon.Items.AddRange(new object[] { "Năm 2023", "Năm 2024" });
            cbbTrungBinhHoaDon.Location = new Point(379, 815);
            cbbTrungBinhHoaDon.Name = "cbbTrungBinhHoaDon";
            cbbTrungBinhHoaDon.Size = new Size(242, 40);
            cbbTrungBinhHoaDon.TabIndex = 5;
            cbbTrungBinhHoaDon.SelectedIndexChanged += cbbTrungBinhHoaDon_SelectedIndexChanged;
            // 
            // chartTrungBinhHoaDon
            // 
            chartArea3.Name = "ChartArea1";
            chartTrungBinhHoaDon.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartTrungBinhHoaDon.Legends.Add(legend3);
            chartTrungBinhHoaDon.Location = new Point(24, 885);
            chartTrungBinhHoaDon.Name = "chartTrungBinhHoaDon";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartTrungBinhHoaDon.Series.Add(series3);
            chartTrungBinhHoaDon.Size = new Size(1443, 688);
            chartTrungBinhHoaDon.TabIndex = 3;
            chartTrungBinhHoaDon.Text = "chart1";
            // 
            // chartDoanhThu
            // 
            chartArea4.Name = "ChartArea1";
            chartDoanhThu.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartDoanhThu.Legends.Add(legend4);
            chartDoanhThu.Location = new Point(24, 133);
            chartDoanhThu.Name = "chartDoanhThu";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartDoanhThu.Series.Add(series4);
            chartDoanhThu.Size = new Size(1443, 621);
            chartDoanhThu.TabIndex = 1;
            chartDoanhThu.Text = "chart1";
            // 
            // uc_Report
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "uc_Report";
            Size = new Size(2313, 2620);
            Load += uc_Report_Load;
            panel1.ResumeLayout(false);
            panelCheckBox.ResumeLayout(false);
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartBrandAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartBrand).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvMinProduct).EndInit();
            panelTopProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTopProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTrungBinhHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ComboBox cbbNam;
        private Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrungBinhHoaDon;
        private Label label2;
        private ComboBox cbbTrungBinhHoaDon;
        private Panel panelTopProduct;
        private DataGridView dtgvTopProduct;
        private Button PDFTopProduct;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Button PDFMinProduct;
        private DataGridView dtgvMinProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBrandAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBrand;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelCheckBox;
        private GroupBox groupBox;
        private CheckBox checkBoxCitizen;
        private CheckBox checkBoxBentley;
        private CheckBox checkBoxCasio;
        private CheckBox checkBoxGShock;
        private CheckBox checkBoxSeiko;
        private CheckBox checkBoxTissot;
        private CheckBox checkBoxOrient;
        private CheckBox checkBoxOlymPianus;
        private Button button1;
        private Button btnEmail;
    }
}
