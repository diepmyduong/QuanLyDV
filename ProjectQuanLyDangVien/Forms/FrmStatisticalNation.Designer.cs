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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup3 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup4 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.fieldNgayVaoDang = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgayVaoDang1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgayVaoDang2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDanToc = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSoTheDangVien2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHoTen = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgayVaoDang3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTonGiao = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSoTheDangVien5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHoTen1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgayVaoDang4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgayVaoDang5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgayVaoDang6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNgayVaoDang7 = new DevExpress.XtraPivotGrid.PivotGridField();
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
            this.pivotGridControl2 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fBCtongiaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldSoTheDangVien3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSoTheDangVien4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.f_BC_dantocTableAdapter = new ProjectQuanLyDangVien._Project_QLDVDataSetTableAdapters.f_BC_dantocTableAdapter();
            this.f_BC_tongiaoTableAdapter = new ProjectQuanLyDangVien._Project_QLDVDataSetTableAdapters.f_BC_tongiaoTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBCtongiaoBindingSource)).BeginInit();
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
            // fieldTonGiao
            // 
            this.fieldTonGiao.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldTonGiao.AreaIndex = 0;
            this.fieldTonGiao.Caption = "Tôn giáo";
            this.fieldTonGiao.ExpandedInFieldsGroup = false;
            this.fieldTonGiao.FieldName = "TonGiao";
            this.fieldTonGiao.Name = "fieldTonGiao";
            // 
            // fieldSoTheDangVien5
            // 
            this.fieldSoTheDangVien5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSoTheDangVien5.AreaIndex = 1;
            this.fieldSoTheDangVien5.Caption = "Số thẻ Đảng Viên";
            this.fieldSoTheDangVien5.FieldName = "SoTheDangVien";
            this.fieldSoTheDangVien5.Name = "fieldSoTheDangVien5";
            this.fieldSoTheDangVien5.Visible = false;
            // 
            // fieldHoTen1
            // 
            this.fieldHoTen1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldHoTen1.AreaIndex = 2;
            this.fieldHoTen1.Caption = "Họ và tên";
            this.fieldHoTen1.FieldName = "HoTen";
            this.fieldHoTen1.Name = "fieldHoTen1";
            this.fieldHoTen1.Visible = false;
            // 
            // fieldNgayVaoDang4
            // 
            this.fieldNgayVaoDang4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldNgayVaoDang4.AreaIndex = 3;
            this.fieldNgayVaoDang4.Caption = "Ngày vào Đảng";
            this.fieldNgayVaoDang4.FieldName = "NgayVaoDang";
            this.fieldNgayVaoDang4.Name = "fieldNgayVaoDang4";
            this.fieldNgayVaoDang4.Visible = false;
            // 
            // fieldNgayVaoDang5
            // 
            this.fieldNgayVaoDang5.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldNgayVaoDang5.AreaIndex = 0;
            this.fieldNgayVaoDang5.Caption = "Năm";
            this.fieldNgayVaoDang5.ExpandedInFieldsGroup = false;
            this.fieldNgayVaoDang5.FieldName = "NgayVaoDang";
            this.fieldNgayVaoDang5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldNgayVaoDang5.Name = "fieldNgayVaoDang5";
            this.fieldNgayVaoDang5.UnboundFieldName = "fieldNgayVaoDang5";
            // 
            // fieldNgayVaoDang6
            // 
            this.fieldNgayVaoDang6.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldNgayVaoDang6.AreaIndex = 1;
            this.fieldNgayVaoDang6.Caption = "Quý";
            this.fieldNgayVaoDang6.FieldName = "NgayVaoDang";
            this.fieldNgayVaoDang6.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldNgayVaoDang6.Name = "fieldNgayVaoDang6";
            this.fieldNgayVaoDang6.UnboundFieldName = "fieldNgayVaoDang6";
            this.fieldNgayVaoDang6.Visible = false;
            // 
            // fieldNgayVaoDang7
            // 
            this.fieldNgayVaoDang7.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldNgayVaoDang7.AreaIndex = 2;
            this.fieldNgayVaoDang7.Caption = "Tháng";
            this.fieldNgayVaoDang7.FieldName = "NgayVaoDang";
            this.fieldNgayVaoDang7.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldNgayVaoDang7.Name = "fieldNgayVaoDang7";
            this.fieldNgayVaoDang7.UnboundFieldName = "fieldNgayVaoDang7";
            this.fieldNgayVaoDang7.Visible = false;
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
            this.pivotGridControl1.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGridControl1_CustomDrawCell);
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
            this.fieldSoTheDangVien1.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumnGrandTotal;
            this.fieldSoTheDangVien1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // pageReligion
            // 
            this.pageReligion.Controls.Add(this.pivotGridControl2);
            this.pageReligion.Name = "pageReligion";
            this.pageReligion.Size = new System.Drawing.Size(678, 298);
            this.pageReligion.Text = "Tôn giáo";
            // 
            // pivotGridControl2
            // 
            this.pivotGridControl2.DataSource = this.fBCtongiaoBindingSource;
            this.pivotGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl2.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldHoTen1,
            this.fieldNgayVaoDang4,
            this.fieldSoTheDangVien3,
            this.fieldSoTheDangVien4,
            this.fieldTonGiao,
            this.fieldNgayVaoDang5,
            this.fieldNgayVaoDang6,
            this.fieldNgayVaoDang7,
            this.fieldSoTheDangVien5});
            pivotGridGroup3.Fields.Add(this.fieldTonGiao);
            pivotGridGroup3.Fields.Add(this.fieldSoTheDangVien5);
            pivotGridGroup3.Fields.Add(this.fieldHoTen1);
            pivotGridGroup3.Fields.Add(this.fieldNgayVaoDang4);
            pivotGridGroup3.Hierarchy = null;
            pivotGridGroup3.ShowNewValues = true;
            pivotGridGroup4.Fields.Add(this.fieldNgayVaoDang5);
            pivotGridGroup4.Fields.Add(this.fieldNgayVaoDang6);
            pivotGridGroup4.Fields.Add(this.fieldNgayVaoDang7);
            pivotGridGroup4.Hierarchy = null;
            pivotGridGroup4.ShowNewValues = true;
            this.pivotGridControl2.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup3,
            pivotGridGroup4});
            this.pivotGridControl2.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl2.Name = "pivotGridControl2";
            this.pivotGridControl2.Size = new System.Drawing.Size(678, 298);
            this.pivotGridControl2.TabIndex = 0;
            this.pivotGridControl2.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGridControl1_CustomDrawCell);
            // 
            // fBCtongiaoBindingSource
            // 
            this.fBCtongiaoBindingSource.DataMember = "f_BC_tongiao";
            this.fBCtongiaoBindingSource.DataSource = this._Project_QLDVDataSet;
            // 
            // fieldSoTheDangVien3
            // 
            this.fieldSoTheDangVien3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSoTheDangVien3.AreaIndex = 0;
            this.fieldSoTheDangVien3.Caption = "Tổng số";
            this.fieldSoTheDangVien3.FieldName = "SoTheDangVien";
            this.fieldSoTheDangVien3.Name = "fieldSoTheDangVien3";
            this.fieldSoTheDangVien3.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // fieldSoTheDangVien4
            // 
            this.fieldSoTheDangVien4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSoTheDangVien4.AreaIndex = 1;
            this.fieldSoTheDangVien4.Caption = "Tỷ lệ";
            this.fieldSoTheDangVien4.FieldName = "SoTheDangVien";
            this.fieldSoTheDangVien4.Name = "fieldSoTheDangVien4";
            this.fieldSoTheDangVien4.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumnGrandTotal;
            this.fieldSoTheDangVien4.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            // 
            // f_BC_dantocTableAdapter
            // 
            this.f_BC_dantocTableAdapter.ClearBeforeFill = true;
            // 
            // f_BC_tongiaoTableAdapter
            // 
            this.f_BC_tongiaoTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBCtongiaoBindingSource)).EndInit();
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
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl2;
        private System.Windows.Forms.BindingSource fBCtongiaoBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHoTen1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNgayVaoDang4;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSoTheDangVien3;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSoTheDangVien4;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTonGiao;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNgayVaoDang5;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNgayVaoDang6;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNgayVaoDang7;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSoTheDangVien5;
        private _Project_QLDVDataSetTableAdapters.f_BC_tongiaoTableAdapter f_BC_tongiaoTableAdapter;
    }
}