namespace ProjectQuanLyDangVien.Forms
{
    partial class FrmSysCity
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
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbSysTinhThanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Project_QLDVDataSet = new ProjectQuanLyDangVien._Project_QLDVDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTinhThanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTinhThanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBienSoXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUuTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.tbSysTinhThanhTableAdapter = new ProjectQuanLyDangVien._Project_QLDVDataSetTableAdapters.tbSysTinhThanhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysTinhThanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_QLDVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(689, 42);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(221, 23);
            this.lblFormTitle.Text = "Danh sách Tỉnh Thành";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 42);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(689, 345);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(683, 317);
            this.xtraTabPage1.Text = "Danh sách";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbSysTinhThanhBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(683, 317);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbSysTinhThanhBindingSource
            // 
            this.tbSysTinhThanhBindingSource.DataMember = "tbSysTinhThanh";
            this.tbSysTinhThanhBindingSource.DataSource = this._Project_QLDVDataSet;
            // 
            // _Project_QLDVDataSet
            // 
            this._Project_QLDVDataSet.DataSetName = "_Project_QLDVDataSet";
            this._Project_QLDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTinhThanh,
            this.colTenTinhThanh,
            this.colBienSoXe,
            this.colMaDienThoai,
            this.colDienGiai,
            this.colUuTien});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // colMaTinhThanh
            // 
            this.colMaTinhThanh.Caption = "Mã Tỉnh Thành";
            this.colMaTinhThanh.FieldName = "MaTinhThanh";
            this.colMaTinhThanh.Name = "colMaTinhThanh";
            this.colMaTinhThanh.Visible = true;
            this.colMaTinhThanh.VisibleIndex = 1;
            this.colMaTinhThanh.Width = 105;
            // 
            // colTenTinhThanh
            // 
            this.colTenTinhThanh.Caption = "Tên Tỉnh Thành";
            this.colTenTinhThanh.FieldName = "TenTinhThanh";
            this.colTenTinhThanh.Name = "colTenTinhThanh";
            this.colTenTinhThanh.Visible = true;
            this.colTenTinhThanh.VisibleIndex = 2;
            this.colTenTinhThanh.Width = 142;
            // 
            // colBienSoXe
            // 
            this.colBienSoXe.Caption = "Biển số xe";
            this.colBienSoXe.FieldName = "BienSoXe";
            this.colBienSoXe.Name = "colBienSoXe";
            this.colBienSoXe.Visible = true;
            this.colBienSoXe.VisibleIndex = 3;
            this.colBienSoXe.Width = 88;
            // 
            // colMaDienThoai
            // 
            this.colMaDienThoai.Caption = "Mã điện thoại";
            this.colMaDienThoai.FieldName = "MaDienThoai";
            this.colMaDienThoai.Name = "colMaDienThoai";
            this.colMaDienThoai.Visible = true;
            this.colMaDienThoai.VisibleIndex = 4;
            this.colMaDienThoai.Width = 96;
            // 
            // colDienGiai
            // 
            this.colDienGiai.Caption = "Diễn giải";
            this.colDienGiai.FieldName = "DienGiai";
            this.colDienGiai.Name = "colDienGiai";
            this.colDienGiai.Visible = true;
            this.colDienGiai.VisibleIndex = 5;
            this.colDienGiai.Width = 243;
            // 
            // colUuTien
            // 
            this.colUuTien.Caption = "Mức ưu tiên khi hiển thị (giảm dần)";
            this.colUuTien.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colUuTien.FieldName = "UuTien";
            this.colUuTien.Name = "colUuTien";
            this.colUuTien.Visible = true;
            this.colUuTien.VisibleIndex = 6;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // tbSysTinhThanhTableAdapter
            // 
            this.tbSysTinhThanhTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSysCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 387);
            this.Controls.Add(this.xtraTabControl1);
            this.FormTitle = "Danh sách Tỉnh Thành";
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.Name = "FrmSysCity";
            this.Text = "Danh sách Tỉnh Thành";
            this.Load += new System.EventHandler(this.FrmSysCity_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysTinhThanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_QLDVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private _Project_QLDVDataSet _Project_QLDVDataSet;
        private System.Windows.Forms.BindingSource tbSysTinhThanhBindingSource;
        private _Project_QLDVDataSetTableAdapters.tbSysTinhThanhTableAdapter tbSysTinhThanhTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTinhThanh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTinhThanh;
        private DevExpress.XtraGrid.Columns.GridColumn colBienSoXe;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colDienGiai;
        private DevExpress.XtraGrid.Columns.GridColumn colUuTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
    }
}