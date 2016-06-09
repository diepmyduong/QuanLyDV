using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraBars;

namespace ProjectQuanLyDangVien.Forms
{
    
    public partial class FrmMembers : FormBase
    {
        #region Private Properties
        private _Project_QLDVDataSet.tbDangVienRow _currentDangVien;
        private List<Thread> _loadPictures = new List<Thread>();
        private delegate void UploadPicture(_Project_QLDVDataSet.tbDangVienRow data, byte[] source);
        private List<EventHandler> _clickEvents = new List<EventHandler>();
        #endregion
        public FrmMembers()
        {
            InitializeComponent();
        }

        private enum _Created
        {
            Nation = 0,
            Religion = 1,
            City = 2
        }
        #region Override
        public override void OnFormActive()
        {
            base.OnFormActive();
            _frmParent.iNew.Enabled = true;
            _frmParent.iExport.Enabled = true;
            _frmParent.iDelete.Enabled = true;
            _frmParent.iReLoad.Enabled = true;
            _frmParent.iSave.Enabled = true;
            _frmParent.iDetail.Enabled = true;
            _frmParent.iFind.Enabled = true;
            _frmParent.iCreated.Enabled = true;

            // Thêm popup menu cho Export
            _frmParent.iExport.ButtonStyle = BarButtonStyle.DropDown;
            BarButtonItem iExportToPdf = new BarButtonItem();
            iExportToPdf.Caption = "Xuất file PDF (.pdf)";
            iExportToPdf.ItemClick += IExportToPdf_ItemClick;
            BarButtonItem iExportToXlsx = new BarButtonItem();
            iExportToXlsx.Caption = "Xuất file Excel (.xlsx)";
            iExportToXlsx.ItemClick += IExportToXlsx_ItemClick;
            _frmParent.pExportMenu.ClearLinks();
            _frmParent.pExportMenu.AddItem(iExportToPdf);
            _frmParent.pExportMenu.AddItem(iExportToXlsx);
            // Thêm popup menu cho Created
            _frmParent.iCreated.ButtonStyle = BarButtonStyle.DropDown;
                // Tạo danh sách các links liên quan dựa vào Enum Created
            Dictionary<object, string> createdItemLinks = new Dictionary<object, string>();
            createdItemLinks.Add(_Created.Nation, "Dân tộc");
            createdItemLinks.Add(_Created.Religion, "Tôn giáo");
            createdItemLinks.Add(_Created.City, "Quê quán");
                // Sử dụng hàm add links vào button Created
            addItemLinksToCreatedButton(createdItemLinks);
        }
        // Thao tác khi các link created được chọn
        protected override void OnCreatedPopupMenuItemClicked(object tag, string caption)
        {
            _Created type = (_Created)Enum.Parse(typeof(_Created), tag.ToString());
            switch (type)
            {
                case _Created.Nation:
                    _frmParent.openChildFormByName("ProjectQuanLyDangVien.Forms", "FrmSysNation");
                    break;
                case _Created.Religion:
                    _frmParent.openChildFormByName("ProjectQuanLyDangVien.Forms", "FrmSysReligion");
                    break;
                case _Created.City:
                    _frmParent.openChildFormByName("ProjectQuanLyDangVien.Forms", "FrmSysCity");
                    break;
            }
        }
        protected override void OnFind()
        {
            switch (xtraTabControl1.SelectedTabPage.Name)
            {
                case "pageLayout":
                    break;
                case "pageTable":
                    if (gridView1.IsFindPanelVisible)
                    {
                        gridView1.HideFindPanel();
                    }
                    else
                    {
                        gridView1.ShowFindPanel();
                    }
                    break;
            }
        }
        #region Exports
        protected override void OnExport()
        {
        }
        private void IExportToXlsx_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Data Files (*.xlsx)|*.xlsx";
            dlg.DefaultExt = "xlsx";
            dlg.AddExtension = true;
            switch (xtraTabControl1.SelectedTabPage.Name)
            {
                case "pageLayout":
                    break;
                case "pageTable":
                    dlg.ShowDialog();
                    if (!string.IsNullOrWhiteSpace(dlg.FileName))
                    {
                        gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
                        grTable.ExportToXlsx(dlg.FileName);
                        gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
                        var result = XtraMessageBox.Show("Bạn có muốn mở tập tin vừa lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Process process = new Process();
                            process.StartInfo.FileName = dlg.FileName;
                            process.Start();
                        }
                    }
                    break;
            }
        }

        private void IExportToPdf_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Data Files (*.pdf)|*.pdf";
            dlg.DefaultExt = "pdf";
            dlg.AddExtension = true;
            switch (xtraTabControl1.SelectedTabPage.Name)
            {
                case "pageLayout":
                    break;
                case "pageTable":
                    dlg.ShowDialog();
                    if (!string.IsNullOrWhiteSpace(dlg.FileName))
                    {
                        gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
                        grTable.ExportToPdf(dlg.FileName);
                        gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
                        var result = XtraMessageBox.Show("Bạn có muốn mở tập tin vừa lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Process process = new Process();
                            process.StartInfo.FileName = dlg.FileName;
                            process.Start();
                        }
                    }
                    break;
            }
        } 
        #endregion
        protected override void OnDetailClick()
        {
            switch (xtraTabControl1.SelectedTabPage.Name)
            {
                case "pageLayout":
                    _frmParent.openDetailForm(_currentDangVien);
                    break;
                case "pageTable":
                    if (gridView1.SelectedRowsCount != 0)
                    {
                        foreach(int row in gridView1.GetSelectedRows())
                        {
                            _frmParent.openDetailForm(gridView1.GetDataRow(row) as _Project_QLDVDataSet.tbDangVienRow);
                        }
                    }
                    break;
            }
        }
        protected override void OnNew()
        {
            _frmParent.openNewMemberForm();
        }
        protected override void OnReload()
        {
            //Bỏ focus để update dữ liệu
            var tempFocus = gridView1.FocusedRowHandle;
            gridView1.FocusedRowHandle = -1;
            gridView1.FocusedRowHandle = tempFocus;
            // Kiểm tra có dữ liệu được cập nhật chưa
            var dtChange = this._Project_QLDVDataSet.tbDangVien.GetChanges() as _Project_QLDVDataSet.tbDangVienDataTable;
            if (dtChange != null)
            {
                var result = XtraMessageBox.Show("Có thay đổi chưa lưu!\r\nBạn có muốn lưu lại thay đổi trước khi tải lại không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    OnSave();
                }
            }
            if (!_frmParent.splashScreenManager.IsSplashFormVisible)
            {
                _frmParent.splashScreenManager.ShowWaitForm();
            }
            //Gọi bộ đếm thời gian thực hiện load
            Stopwatch sw = Stopwatch.StartNew();
            StopAllLoad(); // Tắt tất cả các thread load hình
            this.tbSysTonGiaoTableAdapter.Fill(this._Project_QLDVDataSet.tbSysTonGiao); // Load Tôn giáo
            this.tbSysDanTocTableAdapter.Fill(this._Project_QLDVDataSet.tbSysDanToc); // Load Dân tộc
            this.tbSysTinhThanhTableAdapter.Fill(this._Project_QLDVDataSet.tbSysTinhThanh); //Load tỉnh thành
            this.tbDangVienTableAdapter.Fill(this._Project_QLDVDataSet.tbDangVien); //Load Đảng viên
            // Lưu lại đảng viên hiện tại đang thao tác
            _currentDangVien = layoutView1.GetDataRow(layoutView1.VisibleRecordIndex) as _Project_QLDVDataSet.tbDangVienRow;
            //Gọi thread load hình ảnh
            if(_currentDangVien != null && _currentDangVien.HinhAnh == null)
            {
                loadPicture();
            }
            sw.Stop(); //ngững đồng hồ đếm và thông báo thời gian thực hiện
            _frmParent.setFormStatus(string.Format("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds));
            if (_frmParent.splashScreenManager.IsSplashFormVisible)
            {
                _frmParent.splashScreenManager.CloseWaitForm();
            }
        }
        protected override void OnSave()
        {
            //Bỏ focus để cập nhật dữ liệu
            var tempFocus = gridView1.FocusedRowHandle;
            gridView1.FocusedRowHandle = -1;
            gridView1.FocusedRowHandle = tempFocus;
            //Lấy dữ liệu người dùng thay đổi trong grid
            var dtChange = this._Project_QLDVDataSet.tbDangVien.GetChanges() as _Project_QLDVDataSet.tbDangVienDataTable;
            if (dtChange == null) return;
            try
            {
                tbDangVienTableAdapter.Update(dtChange);
                _Project_QLDVDataSet.tbDangVien.AcceptChanges();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        protected override void OnDelete()
        {
            _Project_QLDVDataSet.tbDangVienRow dangvien;
            DialogResult result;
            switch (xtraTabControl1.SelectedTabPage.Name)
            {
                case "pageLayout":
                    dangvien = layoutView1.GetFocusedDataRow() as _Project_QLDVDataSet.tbDangVienRow;
                    // Hỏi trước khi xóa
                    result = XtraMessageBox.Show(string.Format("Bạn có muốn xóa \"{0}\" không?",dangvien.HoTenDangDung), "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var f = _frmParent.getChildFormByName(dangvien.SoTheDangVien);
                        if (f != null)
                        {
                            f.Dispose();
                            f.Close();
                        }
                        layoutView1.DeleteRow(layoutView1.FocusedRowHandle);
                        OnSave();
                    }
                    break;
                case "pageTable":
                    if(gridView1.SelectedRowsCount != 0)
                    {
                        result = XtraMessageBox.Show(string.Format("Bạn có muốn xóa \"{0}\" dữ liệu đã chọn không?", gridView1.SelectedRowsCount), "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            //Đóng các form chi tiết đang mở
                            var rows = gridView1.GetSelectedRows();
                            foreach(var row in rows)
                            {
                                dangvien = gridView1.GetDataRow(row) as _Project_QLDVDataSet.tbDangVienRow;
                                var f = _frmParent.getChildFormByName(dangvien.SoTheDangVien);
                                if(f != null)
                                {
                                    f.Dispose();
                                    f.Close();
                                }
                            }
                            gridView1.DeleteSelectedRows();
                            OnSave();
                        }
                    }
                    break;
            }
        }
        public override void OnClose()
        {
            //Kiểm tra có dữ liệu được cập nhật không
            var dtChange = this._Project_QLDVDataSet.tbDangVien.GetChanges() as _Project_QLDVDataSet.tbDangVienDataTable;
            if (dtChange != null)
            {
                var result = XtraMessageBox.Show("Có thay đổi chưa lưu!\r\nBạn có muốn lưu lại thay đổi trước khi thoát không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    OnSave();
                }
                else if (result == DialogResult.No)
                {
                    base.OnClose();
                }
                else return;
            }
            base.OnClose();
        }
        #endregion

        #region Sự kiện chính
        private void FrmMembers_Load_1(object sender, EventArgs e)
        {
            cbGenger.Items.AddEnum(typeof(Libs.Enums.Gender), true); // Giới tính
            cbGenger2.Items.AddEnum(typeof(Libs.Enums.Gender), true); // Giới tính
            OnReload();
        }
            #region Quản lý Tabs
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch (xtraTabControl1.SelectedTabPage.Name)
            {
                case "pageLayout":
                    layoutView1.VisibleRecordIndex = tbDangVienBindingSource1.Position;
                    if (_currentDangVien != null && _currentDangVien.HinhAnh == null)
                    {
                        loadPicture();
                    }
                    break;
                case "pageTable":
                    if (e.PrevPage.Name == "pageLayout")
                    {
                        tbDangVienBindingSource1.Position = layoutView1.GetFocusedDataSourceRowIndex();
                    }
                    if (layoutView1.IsFindPanelVisible)
                    {
                        layoutView1.FindFilterText = "";
                    }
                    break;
            }
        }
        #endregion

        #endregion

        #region Quản lý tabLayout
        private void layoutView1_CardClick(object sender, DevExpress.XtraGrid.Views.Layout.Events.CardClickEventArgs e)
        {
            _currentDangVien = layoutView1.GetFocusedDataRow() as _Project_QLDVDataSet.tbDangVienRow;
            if (_currentDangVien != null && _currentDangVien.HinhAnh == null)
            {
                loadPicture();
            }
        }
        private void layoutView1_VisibleRecordIndexChanged(object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewVisibleRecordIndexChangedEventArgs e)
        {
            _currentDangVien = layoutView1.GetDataRow(layoutView1.VisibleRecordIndex) as _Project_QLDVDataSet.tbDangVienRow;
            if (_currentDangVien != null && _currentDangVien.HinhAnh == null && xtraTabControl1.SelectedTabPage.Name != "pageTable")
            {
                loadPicture();
            }
            layoutView1.FocusedRowHandle = e.VisibleRecordIndex;
        }
        private void uploadPicture(_Project_QLDVDataSet.tbDangVienRow data, byte[] source)
        {
            if (data != null && data.HinhAnh == null)
            {
                data.HinhAnh = source;
                OnSave();
                _Project_QLDVDataSet.tbDangVien.AcceptChanges();
            }
        }
        /// <summary>
        /// Tạo thêm 1 thread để load hình
        /// </summary>
        private void loadPicture()
        {
            Thread loadPictureThread = new Thread(loadPictureThreadStart);
            _loadPictures.Add(loadPictureThread);
            loadPictureThread.Start();
        }
        /// <summary>
        /// Duyệt hình ảnh cho Đảng viên đang chọn
        /// </summary>
        private void loadPictureThreadStart()
        {
            var adapter = new _Project_QLDVDataSetTableAdapters.tbHinhAnhTableAdapter();
            var source = (adapter.GetDataByTheDangVien(_currentDangVien.SoTheDangVien) as _Project_QLDVDataSet.tbHinhAnhDataTable).FirstOrDefault();
            if (source == null) return;
            if (grLayout.InvokeRequired)
            {
                UploadPicture function = new UploadPicture(uploadPicture);
                grLayout.BeginInvoke(function, new object[] { _currentDangVien, source.HinhAnh });
            }
            else
            {
                uploadPicture(_currentDangVien, source.HinhAnh);
            }
        }
        /// <summary>
        /// Tạm dừng tất cả các thread load hình
        /// </summary>
        [SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void StopAllLoad()
        {
            foreach (var thread in _loadPictures)
            {
                thread.Abort();
            }
            _loadPictures.Clear();
        }
        // Khi cập nhật hình ảnh
        private void layoutView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == layoutView1.Columns.ColumnByFieldName("HinhAnh"))
            {
                var data = layoutView1.GetDataRow(e.RowHandle) as _Project_QLDVDataSet.tbDangVienRow;
                var adapterHinhAnh = new _Project_QLDVDataSetTableAdapters.tbHinhAnhTableAdapter();
                adapterHinhAnh.Update_HinhAnh(data.HinhAnh, data.SoTheDangVien);
            }
            else
            {
                layoutView1.UpdateCurrentRow();
            }
        }
        private void layoutView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            OnSave();
        }
        #endregion

        private void layoutView1_DoubleClick(object sender, EventArgs e)
        {
            _frmParent.openDetailForm(_currentDangVien);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                _frmParent.openDetailForm((tbDangVienBindingSource1.Current as DataRowView).Row as _Project_QLDVDataSet.tbDangVienRow);
            }
        }

        public void RemoveMember(string SoTheDangVien)
        {
            int index = tbDangVienBindingSource1.Find("SoTheDangVien", SoTheDangVien);
            tbDangVienBindingSource1.RemoveAt(index);
            OnSave();
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //OnSave();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView currentView = sender as GridView;
            if (e.Column.FieldName == "HoTenKhaiSinh")
            {
                var isdead = currentView.GetRowCellValue(e.RowHandle, currentView.Columns.ColumnByFieldName("DaChet"));
                if(isdead != null && (bool)isdead)
                { 
                    e.Appearance.BackColor = Color.Red;
                }
            }
        }
    }
}
