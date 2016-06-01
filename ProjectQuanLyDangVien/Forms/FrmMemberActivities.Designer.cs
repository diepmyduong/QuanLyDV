namespace ProjectQuanLyDangVien.Forms
{
    partial class FrmMemberActivities
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
            this.pageActivities = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbSinhHoatDangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Project_QLDVDataSet = new ProjectQuanLyDangVien._Project_QLDVDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoTheDangVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchSoTheDangVien = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.tbDangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoTheDangVien1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTenKhaiSinh1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayVaoDang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayChinhThuc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDi_NoiDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDi_CapUyGioiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDi_CapUyNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDen_NoiDi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDen_CapUyGioiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDen_CapUyNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDen_NoiDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDen_NgoaiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbActivities = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colDen_TrongTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDen_TrongHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDi_NgoaiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDi_TrongTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDi_TrongHuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDi_NuocNgoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuyenTamThoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTenKhaiSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayChinhThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayHoatDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbSinhHoatDangTableAdapter = new ProjectQuanLyDangVien._Project_QLDVDataSetTableAdapters.tbSinhHoatDangTableAdapter();
            this.tbDangVienTableAdapter = new ProjectQuanLyDangVien._Project_QLDVDataSetTableAdapters.tbDangVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.pageActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSinhHoatDangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_QLDVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchSoTheDangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(788, 42);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 42);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.pageActivities;
            this.xtraTabControl1.Size = new System.Drawing.Size(788, 478);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageActivities});
            // 
            // pageActivities
            // 
            this.pageActivities.Controls.Add(this.gridControl1);
            this.pageActivities.Name = "pageActivities";
            this.pageActivities.Size = new System.Drawing.Size(782, 450);
            this.pageActivities.Text = "Danh sách";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbSinhHoatDangBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbActivities,
            this.searchSoTheDangVien});
            this.gridControl1.Size = new System.Drawing.Size(782, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbSinhHoatDangBindingSource
            // 
            this.tbSinhHoatDangBindingSource.DataMember = "tbSinhHoatDang";
            this.tbSinhHoatDangBindingSource.DataSource = this._Project_QLDVDataSet;
            // 
            // _Project_QLDVDataSet
            // 
            this._Project_QLDVDataSet.DataSetName = "_Project_QLDVDataSet";
            this._Project_QLDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoTheDangVien,
            this.colDi_NoiDen,
            this.colDi_CapUyGioiThieu,
            this.colDi_CapUyNhan,
            this.colDen_NoiDi,
            this.colDen_CapUyGioiThieu,
            this.colDen_CapUyNhan,
            this.colDen_NoiDen,
            this.colDen_NgoaiTinh,
            this.colDen_TrongTinh,
            this.colDen_TrongHuyen,
            this.colDi_NgoaiTinh,
            this.colDi_TrongTinh,
            this.colDi_TrongHuyen,
            this.colDi_NuocNgoai,
            this.colChuyenTamThoi,
            this.colHoTenKhaiSinh,
            this.colNgaySinh,
            this.colNgayChinhThuc,
            this.colNgayHoatDong});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgayHoatDong, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colSoTheDangVien
            // 
            this.colSoTheDangVien.ColumnEdit = this.searchSoTheDangVien;
            this.colSoTheDangVien.FieldName = "SoTheDangVien";
            this.colSoTheDangVien.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colSoTheDangVien.Name = "colSoTheDangVien";
            this.colSoTheDangVien.Visible = true;
            this.colSoTheDangVien.VisibleIndex = 3;
            this.colSoTheDangVien.Width = 81;
            // 
            // searchSoTheDangVien
            // 
            this.searchSoTheDangVien.AutoHeight = false;
            this.searchSoTheDangVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchSoTheDangVien.DataSource = this.tbDangVienBindingSource;
            this.searchSoTheDangVien.DisplayMember = "SoTheDangVien";
            this.searchSoTheDangVien.Name = "searchSoTheDangVien";
            this.searchSoTheDangVien.ValueMember = "SoTheDangVien";
            this.searchSoTheDangVien.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // tbDangVienBindingSource
            // 
            this.tbDangVienBindingSource.DataMember = "tbDangVien";
            this.tbDangVienBindingSource.DataSource = this._Project_QLDVDataSet;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSoTheDangVien1,
            this.colHoTenKhaiSinh1,
            this.colNgayVaoDang,
            this.colNgayChinhThuc1});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemSearchLookUpEdit1View.Click += new System.EventHandler(this.repositoryItemSearchLookUpEdit1View_Click);
            // 
            // colSoTheDangVien1
            // 
            this.colSoTheDangVien1.FieldName = "SoTheDangVien";
            this.colSoTheDangVien1.Name = "colSoTheDangVien1";
            this.colSoTheDangVien1.Visible = true;
            this.colSoTheDangVien1.VisibleIndex = 0;
            // 
            // colHoTenKhaiSinh1
            // 
            this.colHoTenKhaiSinh1.FieldName = "HoTenKhaiSinh";
            this.colHoTenKhaiSinh1.Name = "colHoTenKhaiSinh1";
            this.colHoTenKhaiSinh1.Visible = true;
            this.colHoTenKhaiSinh1.VisibleIndex = 1;
            // 
            // colNgayVaoDang
            // 
            this.colNgayVaoDang.FieldName = "NgayVaoDang";
            this.colNgayVaoDang.Name = "colNgayVaoDang";
            this.colNgayVaoDang.Visible = true;
            this.colNgayVaoDang.VisibleIndex = 2;
            // 
            // colNgayChinhThuc1
            // 
            this.colNgayChinhThuc1.FieldName = "NgayChinhThuc";
            this.colNgayChinhThuc1.Name = "colNgayChinhThuc1";
            this.colNgayChinhThuc1.Visible = true;
            this.colNgayChinhThuc1.VisibleIndex = 3;
            // 
            // colDi_NoiDen
            // 
            this.colDi_NoiDen.FieldName = "Di_NoiDen";
            this.colDi_NoiDen.Name = "colDi_NoiDen";
            this.colDi_NoiDen.Visible = true;
            this.colDi_NoiDen.VisibleIndex = 6;
            this.colDi_NoiDen.Width = 71;
            // 
            // colDi_CapUyGioiThieu
            // 
            this.colDi_CapUyGioiThieu.FieldName = "Di_CapUyGioiThieu";
            this.colDi_CapUyGioiThieu.Name = "colDi_CapUyGioiThieu";
            this.colDi_CapUyGioiThieu.Visible = true;
            this.colDi_CapUyGioiThieu.VisibleIndex = 7;
            this.colDi_CapUyGioiThieu.Width = 118;
            // 
            // colDi_CapUyNhan
            // 
            this.colDi_CapUyNhan.FieldName = "Di_CapUyNhan";
            this.colDi_CapUyNhan.Name = "colDi_CapUyNhan";
            this.colDi_CapUyNhan.Visible = true;
            this.colDi_CapUyNhan.VisibleIndex = 8;
            this.colDi_CapUyNhan.Width = 97;
            // 
            // colDen_NoiDi
            // 
            this.colDen_NoiDi.FieldName = "Den_NoiDi";
            this.colDen_NoiDi.Name = "colDen_NoiDi";
            this.colDen_NoiDi.Visible = true;
            this.colDen_NoiDi.VisibleIndex = 9;
            this.colDen_NoiDi.Width = 71;
            // 
            // colDen_CapUyGioiThieu
            // 
            this.colDen_CapUyGioiThieu.FieldName = "Den_CapUyGioiThieu";
            this.colDen_CapUyGioiThieu.Name = "colDen_CapUyGioiThieu";
            this.colDen_CapUyGioiThieu.Visible = true;
            this.colDen_CapUyGioiThieu.VisibleIndex = 10;
            this.colDen_CapUyGioiThieu.Width = 128;
            // 
            // colDen_CapUyNhan
            // 
            this.colDen_CapUyNhan.FieldName = "Den_CapUyNhan";
            this.colDen_CapUyNhan.Name = "colDen_CapUyNhan";
            this.colDen_CapUyNhan.Visible = true;
            this.colDen_CapUyNhan.VisibleIndex = 11;
            this.colDen_CapUyNhan.Width = 99;
            // 
            // colDen_NoiDen
            // 
            this.colDen_NoiDen.FieldName = "Den_NoiDen";
            this.colDen_NoiDen.Name = "colDen_NoiDen";
            this.colDen_NoiDen.Visible = true;
            this.colDen_NoiDen.VisibleIndex = 12;
            this.colDen_NoiDen.Width = 73;
            // 
            // colDen_NgoaiTinh
            // 
            this.colDen_NgoaiTinh.ColumnEdit = this.cbActivities;
            this.colDen_NgoaiTinh.FieldName = "Den_NgoaiTinh";
            this.colDen_NgoaiTinh.Name = "colDen_NgoaiTinh";
            this.colDen_NgoaiTinh.Visible = true;
            this.colDen_NgoaiTinh.VisibleIndex = 13;
            this.colDen_NgoaiTinh.Width = 49;
            // 
            // cbActivities
            // 
            this.cbActivities.AutoHeight = false;
            this.cbActivities.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbActivities.Name = "cbActivities";
            // 
            // colDen_TrongTinh
            // 
            this.colDen_TrongTinh.ColumnEdit = this.cbActivities;
            this.colDen_TrongTinh.FieldName = "Den_TrongTinh";
            this.colDen_TrongTinh.Name = "colDen_TrongTinh";
            this.colDen_TrongTinh.Visible = true;
            this.colDen_TrongTinh.VisibleIndex = 14;
            this.colDen_TrongTinh.Width = 49;
            // 
            // colDen_TrongHuyen
            // 
            this.colDen_TrongHuyen.ColumnEdit = this.cbActivities;
            this.colDen_TrongHuyen.FieldName = "Den_TrongHuyen";
            this.colDen_TrongHuyen.Name = "colDen_TrongHuyen";
            this.colDen_TrongHuyen.Visible = true;
            this.colDen_TrongHuyen.VisibleIndex = 15;
            this.colDen_TrongHuyen.Width = 49;
            // 
            // colDi_NgoaiTinh
            // 
            this.colDi_NgoaiTinh.ColumnEdit = this.cbActivities;
            this.colDi_NgoaiTinh.FieldName = "Di_NgoaiTinh";
            this.colDi_NgoaiTinh.Name = "colDi_NgoaiTinh";
            this.colDi_NgoaiTinh.Visible = true;
            this.colDi_NgoaiTinh.VisibleIndex = 16;
            this.colDi_NgoaiTinh.Width = 46;
            // 
            // colDi_TrongTinh
            // 
            this.colDi_TrongTinh.ColumnEdit = this.cbActivities;
            this.colDi_TrongTinh.FieldName = "Di_TrongTinh";
            this.colDi_TrongTinh.Name = "colDi_TrongTinh";
            this.colDi_TrongTinh.Visible = true;
            this.colDi_TrongTinh.VisibleIndex = 17;
            this.colDi_TrongTinh.Width = 44;
            // 
            // colDi_TrongHuyen
            // 
            this.colDi_TrongHuyen.ColumnEdit = this.cbActivities;
            this.colDi_TrongHuyen.FieldName = "Di_TrongHuyen";
            this.colDi_TrongHuyen.Name = "colDi_TrongHuyen";
            this.colDi_TrongHuyen.Visible = true;
            this.colDi_TrongHuyen.VisibleIndex = 18;
            this.colDi_TrongHuyen.Width = 49;
            // 
            // colDi_NuocNgoai
            // 
            this.colDi_NuocNgoai.ColumnEdit = this.cbActivities;
            this.colDi_NuocNgoai.FieldName = "Di_NuocNgoai";
            this.colDi_NuocNgoai.Name = "colDi_NuocNgoai";
            this.colDi_NuocNgoai.Visible = true;
            this.colDi_NuocNgoai.VisibleIndex = 19;
            this.colDi_NuocNgoai.Width = 44;
            // 
            // colChuyenTamThoi
            // 
            this.colChuyenTamThoi.ColumnEdit = this.cbActivities;
            this.colChuyenTamThoi.FieldName = "ChuyenTamThoi";
            this.colChuyenTamThoi.Name = "colChuyenTamThoi";
            this.colChuyenTamThoi.Visible = true;
            this.colChuyenTamThoi.VisibleIndex = 20;
            this.colChuyenTamThoi.Width = 60;
            // 
            // colHoTenKhaiSinh
            // 
            this.colHoTenKhaiSinh.FieldName = "HoTenKhaiSinh";
            this.colHoTenKhaiSinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colHoTenKhaiSinh.Name = "colHoTenKhaiSinh";
            this.colHoTenKhaiSinh.OptionsColumn.ReadOnly = true;
            this.colHoTenKhaiSinh.Visible = true;
            this.colHoTenKhaiSinh.VisibleIndex = 2;
            this.colHoTenKhaiSinh.Width = 90;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.OptionsColumn.ReadOnly = true;
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 5;
            // 
            // colNgayChinhThuc
            // 
            this.colNgayChinhThuc.FieldName = "NgayChinhThuc";
            this.colNgayChinhThuc.Name = "colNgayChinhThuc";
            this.colNgayChinhThuc.OptionsColumn.ReadOnly = true;
            this.colNgayChinhThuc.Visible = true;
            this.colNgayChinhThuc.VisibleIndex = 4;
            this.colNgayChinhThuc.Width = 61;
            // 
            // colNgayHoatDong
            // 
            this.colNgayHoatDong.FieldName = "NgayHoatDong";
            this.colNgayHoatDong.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colNgayHoatDong.Name = "colNgayHoatDong";
            this.colNgayHoatDong.Visible = true;
            this.colNgayHoatDong.VisibleIndex = 1;
            this.colNgayHoatDong.Width = 80;
            // 
            // tbSinhHoatDangTableAdapter
            // 
            this.tbSinhHoatDangTableAdapter.ClearBeforeFill = true;
            // 
            // tbDangVienTableAdapter
            // 
            this.tbDangVienTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMemberActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 520);
            this.Controls.Add(this.xtraTabControl1);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.Name = "FrmMemberActivities";
            this.Text = "FrmMemberActivities";
            this.Load += new System.EventHandler(this.FrmMemberActivities_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.pageActivities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSinhHoatDangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_QLDVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchSoTheDangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage pageActivities;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private _Project_QLDVDataSet _Project_QLDVDataSet;
        private System.Windows.Forms.BindingSource tbSinhHoatDangBindingSource;
        private _Project_QLDVDataSetTableAdapters.tbSinhHoatDangTableAdapter tbSinhHoatDangTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTheDangVien;
        private DevExpress.XtraGrid.Columns.GridColumn colDi_NoiDen;
        private DevExpress.XtraGrid.Columns.GridColumn colDi_CapUyGioiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn colDi_CapUyNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colDen_NoiDi;
        private DevExpress.XtraGrid.Columns.GridColumn colDen_CapUyGioiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn colDen_CapUyNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colDen_NoiDen;
        private DevExpress.XtraGrid.Columns.GridColumn colDen_NgoaiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDen_TrongTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDen_TrongHuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colDi_NgoaiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDi_TrongTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDi_TrongHuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colDi_NuocNgoai;
        private DevExpress.XtraGrid.Columns.GridColumn colChuyenTamThoi;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTenKhaiSinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayChinhThuc;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayHoatDong;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit searchSoTheDangVien;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cbActivities;
        private System.Windows.Forms.BindingSource tbDangVienBindingSource;
        private _Project_QLDVDataSetTableAdapters.tbDangVienTableAdapter tbDangVienTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTheDangVien1;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTenKhaiSinh1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayVaoDang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayChinhThuc1;
    }
}