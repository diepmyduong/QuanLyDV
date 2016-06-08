namespace ProjectQuanLyDangVien.Forms
{
    partial class FrmSysReligion
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._Project_QLDVDataSet = new ProjectQuanLyDangVien._Project_QLDVDataSet();
            this.tbSysTonGiaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSysTonGiaoTableAdapter = new ProjectQuanLyDangVien._Project_QLDVDataSetTableAdapters.tbSysTonGiaoTableAdapter();
            this.colMaTonGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTonGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUuTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_QLDVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysTonGiaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(677, 42);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Size = new System.Drawing.Size(193, 23);
            this.lblFormTitle.Text = "Danh sách tôn giáo";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 42);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(677, 331);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(671, 303);
            this.xtraTabPage1.Text = "Danh sách";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbSysTonGiaoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(671, 303);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTonGiao,
            this.colTenTonGiao,
            this.colDienGiai,
            this.colUuTien});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // _Project_QLDVDataSet
            // 
            this._Project_QLDVDataSet.DataSetName = "_Project_QLDVDataSet";
            this._Project_QLDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSysTonGiaoBindingSource
            // 
            this.tbSysTonGiaoBindingSource.DataMember = "tbSysTonGiao";
            this.tbSysTonGiaoBindingSource.DataSource = this._Project_QLDVDataSet;
            // 
            // tbSysTonGiaoTableAdapter
            // 
            this.tbSysTonGiaoTableAdapter.ClearBeforeFill = true;
            // 
            // colMaTonGiao
            // 
            this.colMaTonGiao.Caption = "Mã tôn giáo";
            this.colMaTonGiao.FieldName = "MaTonGiao";
            this.colMaTonGiao.Name = "colMaTonGiao";
            this.colMaTonGiao.Visible = true;
            this.colMaTonGiao.VisibleIndex = 1;
            this.colMaTonGiao.Width = 129;
            // 
            // colTenTonGiao
            // 
            this.colTenTonGiao.Caption = "Tên tôn giáo";
            this.colTenTonGiao.FieldName = "TenTonGiao";
            this.colTenTonGiao.Name = "colTenTonGiao";
            this.colTenTonGiao.Visible = true;
            this.colTenTonGiao.VisibleIndex = 2;
            this.colTenTonGiao.Width = 176;
            // 
            // colDienGiai
            // 
            this.colDienGiai.Caption = "Diễn giải";
            this.colDienGiai.FieldName = "DienGiai";
            this.colDienGiai.Name = "colDienGiai";
            this.colDienGiai.Visible = true;
            this.colDienGiai.VisibleIndex = 3;
            this.colDienGiai.Width = 202;
            // 
            // colUuTien
            // 
            this.colUuTien.Caption = "Mức ưu tiên khi hiển thị (giảm dần)";
            this.colUuTien.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colUuTien.FieldName = "UuTien";
            this.colUuTien.Name = "colUuTien";
            this.colUuTien.Visible = true;
            this.colUuTien.VisibleIndex = 4;
            this.colUuTien.Width = 107;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // FrmSysReligion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 373);
            this.Controls.Add(this.xtraTabControl1);
            this.FormTitle = "Danh sách tôn giáo";
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.Name = "FrmSysReligion";
            this.Text = "Danh sách tôn giáo";
            this.Load += new System.EventHandler(this.FrmSysReligion_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_QLDVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysTonGiaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private _Project_QLDVDataSet _Project_QLDVDataSet;
        private System.Windows.Forms.BindingSource tbSysTonGiaoBindingSource;
        private _Project_QLDVDataSetTableAdapters.tbSysTonGiaoTableAdapter tbSysTonGiaoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTonGiao;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTonGiao;
        private DevExpress.XtraGrid.Columns.GridColumn colDienGiai;
        private DevExpress.XtraGrid.Columns.GridColumn colUuTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
    }
}