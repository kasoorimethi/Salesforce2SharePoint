namespace Salesforce2SharePoint
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.dgvSource = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesforceDataSet = new Salesforce2SharePoint.SalesforceDataSet();
            this.scRight = new System.Windows.Forms.SplitContainer();
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.btImport = new System.Windows.Forms.Button();
            this.dgvDestination = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sharePointDataSet = new Salesforce2SharePoint.SharePointDataSet();
            this.eventTableAdapter = new Salesforce2SharePoint.SalesforceDataSetTableAdapters.EventTableAdapter();
            this.salesforce予定表TableAdapter = new Salesforce2SharePoint.SharePointDataSetTableAdapters.Salesforce予定表TableAdapter();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAllDayEventDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.タイトルDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.場所DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.終日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.開始時刻DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.終了時刻DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.説明DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesforceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).BeginInit();
            this.scRight.Panel1.SuspendLayout();
            this.scRight.Panel2.SuspendLayout();
            this.scRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharePointDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMain.Location = new System.Drawing.Point(20, 49);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.dgvSource);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scRight);
            this.scMain.Size = new System.Drawing.Size(1097, 428);
            this.scMain.SplitterDistance = 481;
            this.scMain.TabIndex = 6;
            // 
            // dgvSource
            // 
            this.dgvSource.AllowUserToAddRows = false;
            this.dgvSource.AllowUserToDeleteRows = false;
            this.dgvSource.AllowUserToResizeRows = false;
            this.dgvSource.AutoGenerateColumns = false;
            this.dgvSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.isAllDayEventDataGridViewCheckBoxColumn,
            this.startDateTimeDataGridViewTextBoxColumn,
            this.endDateTimeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvSource.DataSource = this.bindingSource1;
            this.dgvSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSource.Location = new System.Drawing.Point(0, 0);
            this.dgvSource.Name = "dgvSource";
            this.dgvSource.ReadOnly = true;
            this.dgvSource.RowTemplate.Height = 21;
            this.dgvSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSource.Size = new System.Drawing.Size(481, 428);
            this.dgvSource.TabIndex = 1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Event";
            this.bindingSource1.DataSource = this.salesforceDataSet;
            // 
            // salesforceDataSet
            // 
            this.salesforceDataSet.DataSetName = "SalesforceDataSet";
            this.salesforceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scRight
            // 
            this.scRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scRight.Location = new System.Drawing.Point(0, 0);
            this.scRight.Name = "scRight";
            // 
            // scRight.Panel1
            // 
            this.scRight.Panel1.Controls.Add(this.pbArrow);
            this.scRight.Panel1.Controls.Add(this.btImport);
            // 
            // scRight.Panel2
            // 
            this.scRight.Panel2.Controls.Add(this.dgvDestination);
            this.scRight.Size = new System.Drawing.Size(612, 428);
            this.scRight.SplitterDistance = 87;
            this.scRight.TabIndex = 0;
            // 
            // pbArrow
            // 
            this.pbArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbArrow.Image")));
            this.pbArrow.Location = new System.Drawing.Point(16, 171);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(54, 33);
            this.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrow.TabIndex = 4;
            this.pbArrow.TabStop = false;
            // 
            // btImport
            // 
            this.btImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImport.Location = new System.Drawing.Point(7, 220);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(73, 27);
            this.btImport.TabIndex = 3;
            this.btImport.Text = "インポート";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // dgvDestination
            // 
            this.dgvDestination.AllowUserToAddRows = false;
            this.dgvDestination.AllowUserToDeleteRows = false;
            this.dgvDestination.AllowUserToResizeRows = false;
            this.dgvDestination.AutoGenerateColumns = false;
            this.dgvDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.タイトルDataGridViewTextBoxColumn,
            this.場所DataGridViewTextBoxColumn,
            this.終日DataGridViewTextBoxColumn,
            this.開始時刻DataGridViewTextBoxColumn,
            this.終了時刻DataGridViewTextBoxColumn,
            this.説明DataGridViewTextBoxColumn});
            this.dgvDestination.DataSource = this.bindingSource2;
            this.dgvDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDestination.Location = new System.Drawing.Point(0, 0);
            this.dgvDestination.Name = "dgvDestination";
            this.dgvDestination.ReadOnly = true;
            this.dgvDestination.RowTemplate.Height = 21;
            this.dgvDestination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestination.Size = new System.Drawing.Size(521, 428);
            this.dgvDestination.TabIndex = 2;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Salesforce予定表";
            this.bindingSource2.DataSource = this.sharePointDataSet;
            // 
            // sharePointDataSet
            // 
            this.sharePointDataSet.DataSetName = "SharePointDataSet";
            this.sharePointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // salesforce予定表TableAdapter
            // 
            this.salesforce予定表TableAdapter.ClearBeforeFill = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isAllDayEventDataGridViewCheckBoxColumn
            // 
            this.isAllDayEventDataGridViewCheckBoxColumn.DataPropertyName = "IsAllDayEvent";
            this.isAllDayEventDataGridViewCheckBoxColumn.HeaderText = "IsAllDayEvent";
            this.isAllDayEventDataGridViewCheckBoxColumn.Name = "isAllDayEventDataGridViewCheckBoxColumn";
            this.isAllDayEventDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // startDateTimeDataGridViewTextBoxColumn
            // 
            this.startDateTimeDataGridViewTextBoxColumn.DataPropertyName = "StartDateTime";
            this.startDateTimeDataGridViewTextBoxColumn.HeaderText = "StartDateTime";
            this.startDateTimeDataGridViewTextBoxColumn.Name = "startDateTimeDataGridViewTextBoxColumn";
            this.startDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateTimeDataGridViewTextBoxColumn
            // 
            this.endDateTimeDataGridViewTextBoxColumn.DataPropertyName = "EndDateTime";
            this.endDateTimeDataGridViewTextBoxColumn.HeaderText = "EndDateTime";
            this.endDateTimeDataGridViewTextBoxColumn.Name = "endDateTimeDataGridViewTextBoxColumn";
            this.endDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // タイトルDataGridViewTextBoxColumn
            // 
            this.タイトルDataGridViewTextBoxColumn.DataPropertyName = "タイトル";
            this.タイトルDataGridViewTextBoxColumn.HeaderText = "タイトル";
            this.タイトルDataGridViewTextBoxColumn.Name = "タイトルDataGridViewTextBoxColumn";
            this.タイトルDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 場所DataGridViewTextBoxColumn
            // 
            this.場所DataGridViewTextBoxColumn.DataPropertyName = "場所";
            this.場所DataGridViewTextBoxColumn.HeaderText = "場所";
            this.場所DataGridViewTextBoxColumn.Name = "場所DataGridViewTextBoxColumn";
            this.場所DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 終日DataGridViewTextBoxColumn
            // 
            this.終日DataGridViewTextBoxColumn.DataPropertyName = "終日";
            this.終日DataGridViewTextBoxColumn.HeaderText = "終日";
            this.終日DataGridViewTextBoxColumn.Name = "終日DataGridViewTextBoxColumn";
            this.終日DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 開始時刻DataGridViewTextBoxColumn
            // 
            this.開始時刻DataGridViewTextBoxColumn.DataPropertyName = "開始時刻";
            this.開始時刻DataGridViewTextBoxColumn.HeaderText = "開始時刻";
            this.開始時刻DataGridViewTextBoxColumn.Name = "開始時刻DataGridViewTextBoxColumn";
            this.開始時刻DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 終了時刻DataGridViewTextBoxColumn
            // 
            this.終了時刻DataGridViewTextBoxColumn.DataPropertyName = "終了時刻";
            this.終了時刻DataGridViewTextBoxColumn.HeaderText = "終了時刻";
            this.終了時刻DataGridViewTextBoxColumn.Name = "終了時刻DataGridViewTextBoxColumn";
            this.終了時刻DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 説明DataGridViewTextBoxColumn
            // 
            this.説明DataGridViewTextBoxColumn.DataPropertyName = "説明";
            this.説明DataGridViewTextBoxColumn.HeaderText = "説明";
            this.説明DataGridViewTextBoxColumn.Name = "説明DataGridViewTextBoxColumn";
            this.説明DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 526);
            this.Controls.Add(this.scMain);
            this.Name = "MainForm";
            this.Text = "Salesforce -> SharePoint";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesforceDataSet)).EndInit();
            this.scRight.Panel1.ResumeLayout(false);
            this.scRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).EndInit();
            this.scRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharePointDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource salesforce予定表BindingSource;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.DataGridView dgvSource;
        private System.Windows.Forms.SplitContainer scRight;
        private System.Windows.Forms.PictureBox pbArrow;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.DataGridView dgvDestination;
        private SalesforceDataSet salesforceDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SalesforceDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private SharePointDataSet sharePointDataSet;
        private System.Windows.Forms.BindingSource bindingSource2;
        private SharePointDataSetTableAdapters.Salesforce予定表TableAdapter salesforce予定表TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAllDayEventDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn タイトルDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 場所DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 終日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 開始時刻DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 終了時刻DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 説明DataGridViewTextBoxColumn;
    }
}

