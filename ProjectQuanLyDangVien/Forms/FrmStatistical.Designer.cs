namespace ProjectQuanLyDangVien.Forms
{
    partial class FrmStatistical
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.pageProgress = new DevExpress.XtraTab.XtraTabPage();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.tbDangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Project_QLDVDataSet = new ProjectQuanLyDangVien._Project_QLDVDataSet();
            this.fieldChiBo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSoTheDangVien = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGioiTinh = new DevExpress.XtraPivotGrid.PivotGridField();
            this.cbGenger = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.tbDangVienTableAdapter = new ProjectQuanLyDangVien._Project_QLDVDataSetTableAdapters.tbDangVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.pageProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_QLDVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenger)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(921, 42);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(200, 23);
            this.lblFormTitle.Text = "Thống kê Đảng viên";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 42);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.pageProgress;
            this.xtraTabControl1.Size = new System.Drawing.Size(921, 489);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageProgress});
            // 
            // pageProgress
            // 
            this.pageProgress.Controls.Add(this.pivotGridControl1);
            this.pageProgress.Name = "pageProgress";
            this.pageProgress.Size = new System.Drawing.Size(915, 461);
            this.pageProgress.Text = "Tình hình phát triển Đảng";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.tbDangVienBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldSoTheDangVien,
            this.fieldChiBo,
            this.fieldGioiTinh});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbGenger});
            this.pivotGridControl1.Size = new System.Drawing.Size(915, 461);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // tbDangVienBindingSource
            // 
            this.tbDangVienBindingSource.DataMember = "tbDangVien";
            this.tbDangVienBindingSource.DataSource = this._Project_QLDVDataSet;
            // 
            // _Project_QLDVDataSet
            // 
            this._Project_QLDVDataSet.DataSetName = "_Project_QLDVDataSet";
            this._Project_QLDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldChiBo
            // 
            this.fieldChiBo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldChiBo.AreaIndex = 0;
            this.fieldChiBo.Caption = "Đơn vị";
            this.fieldChiBo.FieldName = "ChiBo";
            this.fieldChiBo.Name = "fieldChiBo";
            // 
            // fieldSoTheDangVien
            // 
            this.fieldSoTheDangVien.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSoTheDangVien.AreaIndex = 0;
            this.fieldSoTheDangVien.Caption = "Số Đảng viên";
            this.fieldSoTheDangVien.FieldName = "SoTheDangVien";
            this.fieldSoTheDangVien.Name = "fieldSoTheDangVien";
            this.fieldSoTheDangVien.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // fieldGioiTinh
            // 
            this.fieldGioiTinh.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldGioiTinh.AreaIndex = 0;
            this.fieldGioiTinh.Caption = "Giới tính";
            this.fieldGioiTinh.FieldEdit = this.cbGenger;
            this.fieldGioiTinh.FieldName = "GioiTinh";
            this.fieldGioiTinh.Name = "fieldGioiTinh";
            this.fieldGioiTinh.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // cbGenger
            // 
            this.cbGenger.AutoHeight = false;
            this.cbGenger.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGenger.Name = "cbGenger";
            // 
            // tbDangVienTableAdapter
            // 
            this.tbDangVienTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 531);
            this.Controls.Add(this.xtraTabControl1);
            this.FormTitle = "Thống kê Đảng viên";
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.Name = "FrmStatistical";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FrmStatistical_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.pageProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_QLDVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGenger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage pageProgress;
        private _Project_QLDVDataSet _Project_QLDVDataSet;
        private System.Windows.Forms.BindingSource tbDangVienBindingSource;
        private _Project_QLDVDataSetTableAdapters.tbDangVienTableAdapter tbDangVienTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldChiBo;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSoTheDangVien;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGioiTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cbGenger;
    }
}