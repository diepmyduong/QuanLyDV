namespace ProjectQuanLyDangVien.Forms
{
    partial class FrmStatisticalNation
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup2 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.fieldNgayVaoDang = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgayVaoDang1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgayVaoDang2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDanToc = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSoTheDangVien2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHoTen = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgayVaoDang3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.pageNation = new DevExpress.XtraTab.XtraTabPage();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fBCdantocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Project_QLDVDataSet = new ProjectQuanLyDangVien._Project_QLDVDataSet();
            this.fieldSoTheDangVien = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSoTheDangVien1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pageReligion = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoTheDangVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanToc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUuTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayVaoDang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.f_BC_dantocTableAdapter = new ProjectQuanLyDangVien._Project_QLDVDataSetTableAdapters.f_BC_dantocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.pageNation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBCdantocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_QLDVDataSet)).BeginInit();
            this.pageReligion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(684, 42);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(563, 23);
            this.lblFormTitle.Text = "Báo cáo đảng viên chia theo dân tộc và trong các tôn giáo";
            // 
            // fieldNgayVaoDang
            // 
            this.fieldNgayVaoDang.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldNgayVaoDang.AreaIndex = 0;
            this.fieldNgayVaoDang.Caption = "Năm";
            this.fieldNgayVaoDang.ExpandedInFieldsGroup = false;
            this.fieldNgayVaoDang.FieldName = "NgayVaoDang";
            this.fieldNgayVaoDang.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldNgayVaoDang.Name = "fieldNgayVaoDang";
            this.fieldNgayVaoDang.UnboundFieldName = "fieldNgayVaoDang";
            // 
            // fieldNgayVaoDang1
            // 
            this.fieldNgayVaoDang1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldNgayVaoDang1.AreaIndex = 1;
            this.fieldNgayVaoDang1.Caption = "Quý";
            this.fieldNgayVaoDang1.ExpandedInFieldsGroup = false;
            this.fieldNgayVaoDang1.FieldName = "NgayVaoDang";
            this.fieldNgayVaoDang1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldNgayVaoDang1.Name = "fieldNgayVaoDang1";
            this.fieldNgayVaoDang1.UnboundFieldName = "fieldNgayVaoDang1";
            this.fieldNgayVaoDang1.Visible = false;
            // 
            // fieldNgayVaoDang2
            // 
            this.fieldNgayVaoDang2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldNgayVaoDang2.AreaIndex = 2;
            this.fieldNgayVaoDang2.Caption = "Tháng";
            this.fieldNgayVaoDang2.FieldName = "NgayVaoDang";
            this.fieldNgayVaoDang2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldNgayVaoDang2.Name = "fieldNgayVaoDang2";
            this.fieldNgayVaoDang2.UnboundFieldName = "fieldNgayVaoDang2";
            this.fieldNgayVaoDang2.Visible = false;
            // 
            // fieldDanToc
            // 
            this.fieldDanToc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDanToc.AreaIndex = 0;
            this.fieldDanToc.Caption = "Dân tộc";
            this.fieldDanToc.ExpandedInFieldsGroup = false;
            this.fieldDanToc.FieldName = "DanToc";
            this.fieldDanToc.Name = "fieldDanToc";
            // 
            // fieldSoTheDangVien2
            // 
            this.fieldSoTheDangVien2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSoTheDangVien2.AreaIndex = 1;
            this.fieldSoTheDangVien2.Caption = "Số thẻ Đảng viên";
            this.fieldSoTheDangVien2.ExpandedInFieldsGroup = false;
            this.fieldSoTheDangVien2.FieldName = "SoTheDangVien";
            this.fieldSoTheDangVien2.Name = "fieldSoTheDangVien2";
            this.fieldSoTheDangVien2.Visible = false;
            // 
            // fieldHoTen
            // 
            this.fieldHoTen.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldHoTen.AreaIndex = 2;
            this.fieldHoTen.Caption = "Họ và tên";
            this.fieldHoTen.ExpandedInFieldsGroup = false;
            this.fieldHoTen.FieldName = "HoTen";
            this.fieldHoTen.Name = "fieldHoTen";
            this.fieldHoTen.Visible = false;
            // 
            // fieldNgayVaoDang3
            // 
            this.fieldNgayVaoDang3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldNgayVaoDang3.AreaIndex = 3;
            this.fieldNgayVaoDang3.Caption = "Ngày vào Đảng";
            this.fieldNgayVaoDang3.FieldName = "NgayVaoDang";
            this.fieldNgayVaoDang3.Name = "fieldNgayVaoDang3";
            this.fieldNgayVaoDang3.Visible = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dateTo);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.dateFrom);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 42);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(684, 37);
            this.panelControl2.TabIndex = 1;
            // 
            // dateTo
            // 
            this.dateTo.EditValue = null;
            this.dateTo.Location = new System.Drawing.Point(238, 7);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Size = new System.Drawing.Size(100, 20);
            this.dateTo.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(185, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Đến ngày";
            // 
            // dateFrom
            // 
            this.dateFrom.EditValue = null;
            this.dateFrom.Location = new System.Drawing.Point(79, 7);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Size = new System.Drawing.Size(100, 20);
            this.dateFrom.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(12, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Xem từ ngày";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 79);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.pageNation;
            this.xtraTabControl1.Size = new System.Drawing.Size(684, 326);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageNation,
            this.pageReligion});
            // 
            // pageNation
            // 
            this.pageNation.Controls.Add(this.pivotGridControl1);
            this.pageNation.Name = "pageNation";
            this.pageNation.Size = new System.Drawing.Size(678, 298);
            this.pageNation.Text = "Dân tộc";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.fBCdantocBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldSoTheDangVien,
            this.fieldSoTheDangVien1,
            this.fieldDanToc,
            this.fieldNgayVaoDang,
            this.fieldNgayVaoDang1,
            this.fieldNgayVaoDang2,
            this.fieldHoTen,
            this.fieldSoTheDangVien2,
            this.fieldNgayVaoDang3});
            pivotGridGroup1.Fields.Add(this.fieldNgayVaoDang);
            pivotGridGroup1.Fields.Add(this.fieldNgayVaoDang1);
            pivotGridGroup1.Fields.Add(this.fieldNgayVaoDang2);
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            pivotGridGroup2.Fields.Add(this.fieldDanToc);
            pivotGridGroup2.Fields.Add(this.fieldSoTheDangVien2);
            pivotGridGroup2.Fields.Add(this.fieldHoTen);
            pivotGridGroup2.Fields.Add(this.fieldNgayVaoDang3);
            pivotGridGroup2.Hierarchy = null;
            pivotGridGroup2.ShowNewValues = true;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1,
            pivotGridGroup2});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(678, 298);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fBCdantocBindingSource
            // 
            this.fBCdantocBindingSource.DataMember = "f_BC_dantoc";
            this.fBCdantocBindingSource.DataSource = this._Project_QLDVDataSet;
            // 
            // _Project_QLDVDataSet
            // 
            this._Project_QLDVDataSet.DataSetName = "_Project_QLDVDataSet";
            this._Project_QLDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldSoTheDangVien
            // 
            this.fieldSoTheDangVien.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSoTheDangVien.AreaIndex = 0;
            this.fieldSoTheDangVien.Caption = "Tổng số";
            this.fieldSoTheDangVien.FieldName = "SoTheDangVien";
            this.fieldSoTheDangVien.Name = "fieldSoTheDangVien";
            this.fieldSoTheDangVien.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // fieldSoTheDangVien1
            // 
            this.fieldSoTheDangVien1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSoTheDangVien1.AreaIndex = 1;
            this.fieldSoTheDangVien1.Caption = "Tỷ lệ";
            this.fieldSoTheDangVien1.FieldName = "SoTheDangVien";
            this.fieldSoTheDangVien1.Name = "fieldSoTheDangVien1";
            this.fieldSoTheDangVien1.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentVariation;
            this.fieldSoTheDangVien1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // pageReligion
            // 
            this.pageReligion.Controls.Add(this.gridControl1);
            this.pageReligion.Name = "pageReligion";
            this.pageReligion.Size = new System.Drawing.Size(678, 298);
            this.pageReligion.Text = "Tôn giáo";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.fBCdantocBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(678, 298);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoTheDangVien,
            this.colHoTen,
            this.colDanToc,
            this.colUuTien,
            this.colNgayVaoDang});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colSoTheDangVien
            // 
            this.colSoTheDangVien.FieldName = "SoTheDangVien";
            this.colSoTheDangVien.Name = "colSoTheDangVien";
            this.colSoTheDangVien.Visible = true;
            this.colSoTheDangVien.VisibleIndex = 0;
            // 
            // colHoTen
            // 
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            // 
            // colDanToc
            // 
            this.colDanToc.FieldName = "DanToc";
            this.colDanToc.Name = "colDanToc";
            this.colDanToc.Visible = true;
            this.colDanToc.VisibleIndex = 2;
            // 
            // colUuTien
            // 
            this.colUuTien.FieldName = "UuTien";
            this.colUuTien.Name = "colUuTien";
            this.colUuTien.Visible = true;
            this.colUuTien.VisibleIndex = 3;
            // 
            // colNgayVaoDang
            // 
            this.colNgayVaoDang.FieldName = "NgayVaoDang";
            this.colNgayVaoDang.Name = "colNgayVaoDang";
            this.colNgayVaoDang.Visible = true;
            this.colNgayVaoDang.VisibleIndex = 4;
            // 
            // f_BC_dantocTableAdapter
            // 
            this.f_BC_dantocTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStatisticalNation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 405);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl2);
            this.FormTitle = "Báo cáo đảng viên chia theo dân tộc và trong các tôn giáo";
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.Name = "FrmStatisticalNation";
            this.Text = "Thông kê theo dân tộc";
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.panelControl2, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.pageNation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBCdantocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_QLDVDataSet)).EndInit();
            this.pageReligion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage pageNation;
        private DevExpress.XtraTab.XtraTabPage pageReligion;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private _Project_QLDVDataSet _Project_QLDVDataSet;
        private System.Windows.Forms.BindingSource fBCdantocBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSoTheDangVien;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSoTheDangVien1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDanToc;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNgayVaoDang;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNgayVaoDang1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNgayVaoDang2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHoTen;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSoTheDangVien2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNgayVaoDang3;
        private _Project_QLDVDataSetTableAdapters.f_BC_dantocTableAdapter f_BC_dantocTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTheDangVien;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDanToc;
        private DevExpress.XtraGrid.Columns.GridColumn colUuTien;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayVaoDang;
    }
}