namespace NewVer_Master
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCon = new System.Windows.Forms.GroupBox();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.btnDis = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dATATeble2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATA_TPCDataSet5 = new NewVer_Master.DATA_TPCDataSet5();
            this.tBDATATPCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATA_TPCDataSet4 = new NewVer_Master.DATA_TPCDataSet4();
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCoil1 = new System.Windows.Forms.TextBox();
            this.txtHol2 = new System.Windows.Forms.TextBox();
            this.txtHol1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chat001 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dATA_TPCDataSet = new NewVer_Master.DATA_TPCDataSet();
            this.tBTPCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBTPCTableAdapter = new NewVer_Master.DATA_TPCDataSetTableAdapters.TBTPCTableAdapter();
            this.dATA_TPCDataSet1 = new NewVer_Master.DATA_TPCDataSet1();
            this.tBTPC001BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_TPC001TableAdapter = new NewVer_Master.DATA_TPCDataSet1TableAdapters.TB_TPC001TableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer002 = new System.Windows.Forms.Timer(this.components);
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.tB_DATATPCTableAdapter = new NewVer_Master.DATA_TPCDataSet4TableAdapters.TB_DATATPCTableAdapter();
            this.dATATeble2TableAdapter = new NewVer_Master.DATA_TPCDataSet5TableAdapters.DATATeble2TableAdapter();
            this.gbCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATATeble2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATA_TPCDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBDATATPCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATA_TPCDataSet4)).BeginInit();
            this.GB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dATA_TPCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTPCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATA_TPCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTPC001BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCon
            // 
            this.gbCon.Controls.Add(this.lblStatus1);
            this.gbCon.Controls.Add(this.btnDis);
            this.gbCon.Controls.Add(this.btnCon);
            this.gbCon.Controls.Add(this.txtIP);
            this.gbCon.Controls.Add(this.txtPort);
            this.gbCon.Controls.Add(this.label1);
            this.gbCon.Controls.Add(this.lblIP);
            this.gbCon.Location = new System.Drawing.Point(10, 11);
            this.gbCon.Margin = new System.Windows.Forms.Padding(2);
            this.gbCon.Name = "gbCon";
            this.gbCon.Padding = new System.Windows.Forms.Padding(2);
            this.gbCon.Size = new System.Drawing.Size(323, 144);
            this.gbCon.TabIndex = 0;
            this.gbCon.TabStop = false;
            this.gbCon.Text = "Config IP";
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.Location = new System.Drawing.Point(8, 117);
            this.lblStatus1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(49, 13);
            this.lblStatus1.TabIndex = 5;
            this.lblStatus1.Text = "Status : -";
            // 
            // btnDis
            // 
            this.btnDis.Location = new System.Drawing.Point(188, 81);
            this.btnDis.Margin = new System.Windows.Forms.Padding(2);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(75, 34);
            this.btnDis.TabIndex = 4;
            this.btnDis.Text = "Disconnected";
            this.btnDis.UseVisualStyleBackColor = true;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(76, 81);
            this.btnCon.Margin = new System.Windows.Forms.Padding(2);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 34);
            this.btnCon.TabIndex = 3;
            this.btnCon.Text = "Connected.";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(76, 27);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(187, 20);
            this.txtIP.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(76, 50);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(187, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "502";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port : ";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(53, 27);
            this.lblIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(23, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP :";
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AutoGenerateColumns = false;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datetimeDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.pressureDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.DGV1.DataSource = this.dATATeble2BindingSource;
            this.DGV1.Location = new System.Drawing.Point(338, 11);
            this.DGV1.Margin = new System.Windows.Forms.Padding(2);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.Size = new System.Drawing.Size(551, 291);
            this.DGV1.TabIndex = 1;
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "Datetime";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.datetimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "Datetime";
            this.datetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.FillWeight = 60F;
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            // 
            // pressureDataGridViewTextBoxColumn
            // 
            this.pressureDataGridViewTextBoxColumn.DataPropertyName = "Pressure";
            this.pressureDataGridViewTextBoxColumn.FillWeight = 60F;
            this.pressureDataGridViewTextBoxColumn.HeaderText = "Pressure";
            this.pressureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pressureDataGridViewTextBoxColumn.Name = "pressureDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.FillWeight = 50F;
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // dATATeble2BindingSource
            // 
            this.dATATeble2BindingSource.DataMember = "DATATeble2";
            this.dATATeble2BindingSource.DataSource = this.dATA_TPCDataSet5;
            // 
            // dATA_TPCDataSet5
            // 
            this.dATA_TPCDataSet5.DataSetName = "DATA_TPCDataSet5";
            this.dATA_TPCDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBDATATPCBindingSource
            // 
            this.tBDATATPCBindingSource.DataMember = "TB_DATATPC";
            this.tBDATATPCBindingSource.DataSource = this.dATA_TPCDataSet4;
            // 
            // dATA_TPCDataSet4
            // 
            this.dATA_TPCDataSet4.DataSetName = "DATA_TPCDataSet4";
            this.dATA_TPCDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.label9);
            this.GB1.Controls.Add(this.label8);
            this.GB1.Controls.Add(this.label7);
            this.GB1.Controls.Add(this.txtCoil1);
            this.GB1.Controls.Add(this.txtHol2);
            this.GB1.Controls.Add(this.txtHol1);
            this.GB1.Controls.Add(this.label6);
            this.GB1.Controls.Add(this.label5);
            this.GB1.Controls.Add(this.label4);
            this.GB1.Controls.Add(this.label3);
            this.GB1.Controls.Add(this.label2);
            this.GB1.Location = new System.Drawing.Point(10, 160);
            this.GB1.Margin = new System.Windows.Forms.Padding(2);
            this.GB1.Name = "GB1";
            this.GB1.Padding = new System.Windows.Forms.Padding(2);
            this.GB1.Size = new System.Drawing.Size(323, 141);
            this.GB1.TabIndex = 2;
            this.GB1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Coil 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Holding Register 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Holding Register 1";
            // 
            // txtCoil1
            // 
            this.txtCoil1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dATATeble2BindingSource, "Status", true));
            this.txtCoil1.Location = new System.Drawing.Point(195, 100);
            this.txtCoil1.Margin = new System.Windows.Forms.Padding(2);
            this.txtCoil1.Name = "txtCoil1";
            this.txtCoil1.Size = new System.Drawing.Size(107, 20);
            this.txtCoil1.TabIndex = 2;
            // 
            // txtHol2
            // 
            this.txtHol2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dATATeble2BindingSource, "Pressure", true));
            this.txtHol2.Location = new System.Drawing.Point(195, 74);
            this.txtHol2.Margin = new System.Windows.Forms.Padding(2);
            this.txtHol2.Name = "txtHol2";
            this.txtHol2.Size = new System.Drawing.Size(107, 20);
            this.txtHol2.TabIndex = 2;
            // 
            // txtHol1
            // 
            this.txtHol1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dATATeble2BindingSource, "Temperature", true));
            this.txtHol1.Location = new System.Drawing.Point(195, 50);
            this.txtHol1.Margin = new System.Windows.Forms.Padding(2);
            this.txtHol1.Name = "txtHol1";
            this.txtHol1.Size = new System.Drawing.Size(107, 20);
            this.txtHol1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Current Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pressure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temperature";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(894, 11);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 45);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chat001
            // 
            this.chat001.Location = new System.Drawing.Point(10, 307);
            this.chat001.Margin = new System.Windows.Forms.Padding(2);
            this.chat001.Name = "chat001";
            this.chat001.Size = new System.Drawing.Size(879, 420);
            this.chat001.TabIndex = 4;
            this.chat001.Text = "elementHost1";
            this.chat001.Child = this.cartesianChart1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(894, 307);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(68, 41);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dATA_TPCDataSet
            // 
            this.dATA_TPCDataSet.DataSetName = "DATA_TPCDataSet";
            this.dATA_TPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBTPCBindingSource
            // 
            this.tBTPCBindingSource.DataMember = "TBTPC";
            this.tBTPCBindingSource.DataSource = this.dATA_TPCDataSet;
            // 
            // tBTPCTableAdapter
            // 
            this.tBTPCTableAdapter.ClearBeforeFill = true;
            // 
            // dATA_TPCDataSet1
            // 
            this.dATA_TPCDataSet1.DataSetName = "DATA_TPCDataSet1";
            this.dATA_TPCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBTPC001BindingSource
            // 
            this.tBTPC001BindingSource.DataMember = "TB_TPC001";
            this.tBTPC001BindingSource.DataSource = this.dATA_TPCDataSet1;
            // 
            // tB_TPC001TableAdapter
            // 
            this.tB_TPC001TableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(767, 743);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "DateTime : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dATATeble2BindingSource, "Datetime", true));
            this.lblDate.Location = new System.Drawing.Point(829, 743);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(10, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "-";
            // 
            // timer002
            // 
            this.timer002.Interval = 10000;
            this.timer002.Tick += new System.EventHandler(this.timer002_Tick);
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Location = new System.Drawing.Point(8, 743);
            this.lblStatus2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(49, 13);
            this.lblStatus2.TabIndex = 8;
            this.lblStatus2.Text = "Status : -";
            // 
            // tB_DATATPCTableAdapter
            // 
            this.tB_DATATPCTableAdapter.ClearBeforeFill = true;
            // 
            // dATATeble2TableAdapter
            // 
            this.dATATeble2TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 763);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.chat001);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.GB1);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.gbCon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCon.ResumeLayout(false);
            this.gbCon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATATeble2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATA_TPCDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBDATATPCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATA_TPCDataSet4)).EndInit();
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dATA_TPCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTPCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATA_TPCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTPC001BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCon;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button btnDis;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCoil1;
        private System.Windows.Forms.TextBox txtHol2;
        private System.Windows.Forms.TextBox txtHol1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Integration.ElementHost chat001;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Timer timer;
        private DATA_TPCDataSet dATA_TPCDataSet;
        private System.Windows.Forms.BindingSource tBTPCBindingSource;
        private DATA_TPCDataSetTableAdapters.TBTPCTableAdapter tBTPCTableAdapter;
        private DATA_TPCDataSet1 dATA_TPCDataSet1;
        private System.Windows.Forms.BindingSource tBTPC001BindingSource;
        private DATA_TPCDataSet1TableAdapters.TB_TPC001TableAdapter tB_TPC001TableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer002;
        private System.Windows.Forms.Label lblStatus2;
        private DATA_TPCDataSet4 dATA_TPCDataSet4;
        private System.Windows.Forms.BindingSource tBDATATPCBindingSource;
        private DATA_TPCDataSet4TableAdapters.TB_DATATPCTableAdapter tB_DATATPCTableAdapter;
        private DATA_TPCDataSet5 dATA_TPCDataSet5;
        private System.Windows.Forms.BindingSource dATATeble2BindingSource;
        private DATA_TPCDataSet5TableAdapters.DATATeble2TableAdapter dATATeble2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}

