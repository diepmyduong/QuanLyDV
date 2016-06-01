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

        #region Override
        public override void OnFormActive()
        {
            base.OnFormActive();
            _frmParent.iNew.Enabled = true;
            _frmParent.iExport.Enabled = true;
            _frmParent.iDelete.Enabled = true;
            _frmParent.iReLoad.Enabled = true;
            _frmParent.iSave.Enabled = true;
            _frmParent.iPrint.Enabled = true;
            _frmParent.iDetail.Enabled = true;
            _frmParent.iFind.Enabled = true;

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
                case "pageDetail":
                    break;
            }
        }
        #region Exports
        protected override void OnExport()
        {
            //switch (xtraTabControl1.SelectedTabPage.Name)
            //{
            //    case "pageLayout":

            //        break;
            //    case "pageTable":
                    
            //        break;
            //    case "pageDetail":
            //        break;
            //}
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
                case "pageDetail":
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
                case "pageDetail":
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
                case "pageDetail":
                    break;
            }
        }
        protected override void OnPrint()
        {
            switch (xtraTabControl1.SelectedTabPage.Name)
            {
                case "pageLayout":
                    break;
                case "pageTable":
                    gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
                    gridView1.ShowPrintPreview();
                    gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
                    break;
                case "pageDetail":
                    dataLayoutControl1.ShowPrintPreview();
                    break;
            }
        }
        protected override void OnNew()
        {
            _frmParent.openNewMemberForm();
            //switch (xtraTabControl1.SelectedTabPage.Name)
            //{
            //    case "pageLayout":
            //        layoutView1.AddNewRow();
            //        layoutView1.FocusedColumn = layoutView1.Columns.ColumnByFieldName("SoTheDangVien");
            //        break;
            //    case "pageTable":
            //        gridView1.AddNewRow();
            //        break;
            //    case "pageDetail":
            //        tbDangVienBindingSource1.AddNew();
            //        var items = dataLayoutControl1.Items.FindByName("SoTheDangVienTextEdit");
            //        SoTheDangVienTextEdit.Focus();
            //        break;
            //}
        }
        protected override void OnReload()
        {
            if (!_frmParent.splashScreenManager.IsSplashFormVisible)
            {
                _frmParent.splashScreenManager.ShowWaitForm();
            }
            var tempFocus = gridView1.FocusedRowHandle;
            gridView1.FocusedRowHandle = -1;
            gridView1.FocusedRowHandle = tempFocus;

            var dtChange = this._Project_QLDVDataSet.tbDangVien.GetChanges() as _Project_QLDVDataSet.tbDangVienDataTable;
            if (dtChange != null)
            {
                var result = XtraMessageBox.Show("Có thay đổi chưa lưu!\r\nBạn có muốn lưu lại thay đổi trước khi tải lại không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    OnSave();
                }
            }
            Stopwatch sw = Stopwatch.StartNew();
            
            StopAllLoad();
            this.tbSysTonGiaoTableAdapter.Fill(this._Project_QLDVDataSet.tbSysTonGiao); // Load Tôn giáo
            this.tbSysDanTocTableAdapter.Fill(this._Project_QLDVDataSet.tbSysDanToc); // Load Dân tộc
            this.tbSysTinhThanhTableAdapter.Fill(this._Project_QLDVDataSet.tbSysTinhThanh); //Load tỉnh thành
            this.tbDangVienTableAdapter.Fill(this._Project_QLDVDataSet.tbDangVien); //Load Đảng viên
            _currentDangVien = layoutView1.GetDataRow(layoutView1.VisibleRecordIndex) as _Project_QLDVDataSet.tbDangVienRow;
            loadPicture();
            sw.Stop();
            _frmParent.setFormStatus(string.Format("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds));
            if (_frmParent.splashScreenManager.IsSplashFormVisible)
            {
                _frmParent.splashScreenManager.CloseWaitForm();
            }
        }
        protected override void OnSave()
        {
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
                    //if (layoutView1.IsNewItemRow(layoutView1.FocusedRowHandle))
                    //{
                    //    layoutView1.CancelUpdateCurrentRow();
                    //    return;
                    //}
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
                //case "pageDetail":
                //    if((tbDangVienBindingSource1.Current as DataRowView).IsNew)
                //    {
                //        layoutView1.CancelUpdateCurrentRow();
                //        return;
                //    } 
                //    // Hỏi trước khi xóa
                //    result = XtraMessageBox.Show(string.Format("Bạn có muốn xóa \"{0}\" không?", _currentDangVien.HoTenDangDung), "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //    if (result == DialogResult.Yes)
                //    {
                //        _currentDangVien.Delete();
                //        OnSave();
                //    }
                //    break;
            }
        }
        public override void OnClose()
        {
            if(ActiveControl.Name == "dataLayoutControl1")
            {
                dataLayoutControl1.Validate();
                dataLayoutControl1.BindingContext[tbDangVienBindingSource1].EndCurrentEdit();
            }
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
            cbBonus.Items.AddEnum(typeof(Libs.Enums.Bonus), true); // Loại khen thưởng
            cbArmorial.Items.AddEnum(typeof(Libs.Enums.ArmorialYear), true); // Số huy hiệu
            cbGenger.Items.AddEnum(typeof(Libs.Enums.Genger), true); // Giới tính
            cbGenger2.Items.AddEnum(typeof(Libs.Enums.Genger), true); // Giới tính
            OnReload();
        }
            #region Quản lý Tabs
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch (xtraTabControl1.SelectedTabPage.Name)
            {
                case "pageLayout":
                    layoutView1.VisibleRecordIndex = tbDangVienBindingSource1.Position;
                    if(e.PrevPage.Name == "pageDetail")
                    {
                        dataLayoutControl1.BindingContext[tbDangVienBindingSource1].EndCurrentEdit();
                        OnSave();
                    }
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
                    if(e.PrevPage.Name == "pageDetail")
                    {
                        dataLayoutControl1.BindingContext[tbDangVienBindingSource1].EndCurrentEdit();
                        OnSave();
                    }
                    if (layoutView1.IsFindPanelVisible)
                    {
                        layoutView1.FindFilterText = "";
                    }
                    break;
                case "pageDetail":
                    if (e.PrevPage.Name == "pageLayout")
                    {
                        tbDangVienBindingSource1.Position = layoutView1.GetFocusedDataSourceRowIndex();
                    }
                    _currentDangVien = (tbDangVienBindingSource1.Current as DataRowView).Row as _Project_QLDVDataSet.tbDangVienRow;
                    if (_currentDangVien != null && _currentDangVien.HinhAnh == null) // Load hình nếu chưa có hình
                    {
                        loadPicture();
                    }
                    // Chuyển về tab quá trình hoạt động
                    if (xtraTabControl2.SelectedTabPageIndex != 0) 
                    {
                        xtraTabControl2.SelectedTabPageIndex = 0;
                    }
                    else
                    {
                        this.tbQuaTrinhHoatDongTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbQuaTrinhHoatDong, _currentDangVien.SoTheDangVien);
                    }
                    if (layoutView1.IsFindPanelVisible)
                    {
                        layoutView1.FindFilterText = "";
                    }
                    break;

            }
        }
        private void xtraTabControl2_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            // chọn tab nào mới load tab đó
            switch (xtraTabControl2.SelectedTabPage.Name)
            {
                case "pageProcess": //Quá trình hoạt động
                    this.tbQuaTrinhHoatDongTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbQuaTrinhHoatDong, _currentDangVien.SoTheDangVien);
                    break;
                case "pageTrainning": //Quá trình đào tạo, bồi dưỡng
                    this.tbDaoTaoTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbDaoTao, _currentDangVien.SoTheDangVien);
                    break;
                case "pageBonus": //Khen thưởng
                    this.tbKhenThuongTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbKhenThuong, _currentDangVien.SoTheDangVien);
                    break;
                case "pageArmorial": //So Huy hiệu
                    this.tbSoHuyHieuTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbSoHuyHieu, _currentDangVien.SoTheDangVien);
                    break;
                case "pageStylized": //Danh hiệu
                    this.tbDanhHieuTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbDanhHieu, _currentDangVien.SoTheDangVien);
                    break;
                case "pageDiscipline": //Kỷ luật
                    this.tbKyLuatTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbKyLuat, _currentDangVien.SoTheDangVien);
                    break;
                case "pageJailed": // Bắt tù, bị tù
                    this.tbBiTuTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbBiTu, _currentDangVien.SoTheDangVien);
                    break;
                case "pageOldJobs": // Công việc cũ
                    this.tbCongViecCheDoCuTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbCongViecCheDoCu, _currentDangVien.SoTheDangVien);
                    break;
                case "pageForeign": //Đi nước ngoài
                    this.tbDiNuocNgoaiTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbDiNuocNgoai, _currentDangVien.SoTheDangVien);
                    break;
                case "pageForeignRelationship": // Quan hệ nước ngoài
                    this.tbQuanHeNuocNgoaiTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbQuanHeNuocNgoai, _currentDangVien.SoTheDangVien);
                    break;
                case "pageForeignFamily": //Thân nhân nước ngoài
                    this.tbThanNhanNuocNgoaiTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbThanNhanNuocNgoai, _currentDangVien.SoTheDangVien);
                    break;
                case "pageFamily": // Quan hệ gia đình
                    this.tbThanNhanTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbThanNhan, _currentDangVien.SoTheDangVien);
                    break;
                case "pageAsset": // Tài sản
                    this.tbTaiSanTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbTaiSan, _currentDangVien.SoTheDangVien);
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
            if (_currentDangVien != null && _currentDangVien.HinhAnh == null)
            {
                loadPicture();
            }
            layoutView1.FocusedRowHandle = e.VisibleRecordIndex;
            Console.WriteLine(string.Format("focus: {0} & visibleIndex: {1}", layoutView1.FocusedRowHandle, e.VisibleRecordIndex));
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

        #region Quản lý tabDetail
        private void gridViewDetails_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var gridview = sender as GridView;
            gridview.SetRowCellValue(e.RowHandle, gridview.Columns["SoTheDangVien"], _currentDangVien.SoTheDangVien);
        }

            #region Quá trinh hoạt động
        // Sau khi quá trinh hoạt động cập nhật
        private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //Lấy dữ liệu người dùng thay đổi trong grid
            var dtChange = this._Project_QLDVDataSet.tbQuaTrinhHoatDong.GetChanges() as _Project_QLDVDataSet.tbQuaTrinhHoatDongDataTable;
            if (dtChange == null) return;
            try
            {
                tbQuaTrinhHoatDongTableAdapter.Update(dtChange);
                _Project_QLDVDataSet.tbQuaTrinhHoatDong.AcceptChanges();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

            #region Đào tạo và bồi dưỡng
            private void gridView4_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
            {
                //Lấy dữ liệu người dùng thay đổi trong grid
                var dtChange = this._Project_QLDVDataSet.tbDaoTao.GetChanges() as _Project_QLDVDataSet.tbDaoTaoDataTable;
                if (dtChange == null) return;
                try
                {
                    tbDaoTaoTableAdapter.Update(dtChange);
                    _Project_QLDVDataSet.tbDaoTao.AcceptChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }

            #endregion

            #region Khen Thưởng
        private void gridView5_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //Lấy dữ liệu người dùng thay đổi trong grid
            var dtChange = this._Project_QLDVDataSet.tbKhenThuong.GetChanges() as _Project_QLDVDataSet.tbKhenThuongDataTable;
            if (dtChange == null) return;
            try
            {
                tbKhenThuongTableAdapter.Update(dtChange);
                _Project_QLDVDataSet.tbKhenThuong.AcceptChanges();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

            #region Số Huy Hiệu
        private void gridView6_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //Lấy dữ liệu người dùng thay đổi trong grid
            var dtChange = this._Project_QLDVDataSet.tbSoHuyHieu.GetChanges() as _Project_QLDVDataSet.tbSoHuyHieuDataTable;
            if (dtChange == null) return;
            try
            {
                tbSoHuyHieuTableAdapter.Update(dtChange);
                _Project_QLDVDataSet.tbSoHuyHieu.AcceptChanges();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

            #region Danh Hiệu
        private void gridView7_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //Lấy dữ liệu người dùng thay đổi trong grid
            var dtChange = this._Project_QLDVDataSet.tbDanhHieu.GetChanges() as _Project_QLDVDataSet.tbDanhHieuDataTable;
            if (dtChange == null) return;
            try
            {
                tbDanhHieuTableAdapter.Update(dtChange);
                _Project_QLDVDataSet.tbDanhHieu.AcceptChanges();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

            #region Kỷ luật
        private void gridView8_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //Lấy dữ liệu người dùng thay đổi trong grid
            var dtChange = this._Project_QLDVDataSet.tbKyLuat.GetChanges() as _Project_QLDVDataSet.tbKyLuatDataTable;
            if (dtChange == null) return;
            try
            {
                tbKyLuatTableAdapter.Update(dtChange);
                _Project_QLDVDataSet.tbKyLuat.AcceptChanges();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

            #region Bị bắt, bị tù
            private void gridView9_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
            {
                //Lấy dữ liệu người dùng thay đổi trong grid
                var dtChange = this._Project_QLDVDataSet.tbBiTu.GetChanges() as _Project_QLDVDataSet.tbBiTuDataTable;
                if (dtChange == null) return;
                try
                {
                    tbBiTuTableAdapter.Update(dtChange);
                    _Project_QLDVDataSet.tbBiTu.AcceptChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }

            #endregion

            #region Công việc cũ
            private void gridView10_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
            {
                //Lấy dữ liệu người dùng thay đổi trong grid
                var dtChange = this._Project_QLDVDataSet.tbCongViecCheDoCu.GetChanges() as _Project_QLDVDataSet.tbCongViecCheDoCuDataTable;
                if (dtChange == null) return;
                try
                {
                    tbCongViecCheDoCuTableAdapter.Update(dtChange);
                    _Project_QLDVDataSet.tbCongViecCheDoCu.AcceptChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }

            #endregion

            #region Đi nước ngoài
            private void gridView11_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
            {
                //Lấy dữ liệu người dùng thay đổi trong grid
                var dtChange = this._Project_QLDVDataSet.tbDiNuocNgoai.GetChanges() as _Project_QLDVDataSet.tbDiNuocNgoaiDataTable;
                if (dtChange == null) return;
                try
                {
                    tbDiNuocNgoaiTableAdapter.Update(dtChange);
                    _Project_QLDVDataSet.tbDiNuocNgoai.AcceptChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }

            #endregion

            #region Quan hệ nước ngoài
            private void gridView12_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
            {
                //Lấy dữ liệu người dùng thay đổi trong grid
                var dtChange = this._Project_QLDVDataSet.tbQuanHeNuocNgoai.GetChanges() as _Project_QLDVDataSet.tbQuanHeNuocNgoaiDataTable;
                if (dtChange == null) return;
                try
                {
                    tbQuanHeNuocNgoaiTableAdapter.Update(dtChange);
                    _Project_QLDVDataSet.tbQuanHeNuocNgoai.AcceptChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }

            #endregion

            #region Thân nhân nước ngoài
            private void gridView13_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
            {
                //Lấy dữ liệu người dùng thay đổi trong grid
                var dtChange = this._Project_QLDVDataSet.tbThanNhanNuocNgoai.GetChanges() as _Project_QLDVDataSet.tbThanNhanNuocNgoaiDataTable;
                if (dtChange == null) return;
                try
                {
                    tbThanNhanNuocNgoaiTableAdapter.Update(dtChange);
                    _Project_QLDVDataSet.tbThanNhanNuocNgoai.AcceptChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }

            #endregion

            #region Quan hệ gia đình
            private void gridView14_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
            {
                //Lấy dữ liệu người dùng thay đổi trong grid
                var dtChange = this._Project_QLDVDataSet.tbThanNhan.GetChanges() as _Project_QLDVDataSet.tbThanNhanDataTable;
                if (dtChange == null) return;
                try
                {
                    tbThanNhanTableAdapter.Update(dtChange);
                    _Project_QLDVDataSet.tbThanNhan.AcceptChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }

            #endregion

            #region tài sản
            private void gridView15_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
            {
                //Lấy dữ liệu người dùng thay đổi trong grid
                var dtChange = this._Project_QLDVDataSet.tbTaiSan.GetChanges() as _Project_QLDVDataSet.tbTaiSanDataTable;
                if (dtChange == null) return;
                try
                {
                    tbTaiSanTableAdapter.Update(dtChange);
                    _Project_QLDVDataSet.tbTaiSan.AcceptChanges();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }


        #endregion

        private void dataLayoutControl1_CurrentRecordChanged(object sender, EventArgs e)
        {
            _currentDangVien = (tbDangVienBindingSource1.Current as DataRowView).Row as _Project_QLDVDataSet.tbDangVienRow;
            if (_currentDangVien != null && _currentDangVien.HinhAnh == null)
            {
                loadPicture();
            }
        }
        private void dataLayoutControl1_ItemSelectionChanged(object sender, EventArgs e)
        {
            // updateDangVien();
        }
            #region Cập nhật hình ảnh

        private void loadedPicture(RepositoryItemPictureEdit sender)
        {
            var oldvalue = sender.OwnerEdit.OldEditValue as byte[];
            var newvalue = sender.OwnerEdit.EditValue as byte[];
            if (oldvalue == null || newvalue == null || oldvalue.Length != newvalue.Length)
            {
                var adapterHinhAnh = new _Project_QLDVDataSetTableAdapters.tbHinhAnhTableAdapter();
                adapterHinhAnh.Update_HinhAnh(newvalue, _currentDangVien.SoTheDangVien);
            }
        }
        private void deletedPicture()
        {
            var adapterHinhAnh = new _Project_QLDVDataSetTableAdapters.tbHinhAnhTableAdapter();
            adapterHinhAnh.Update_HinhAnh(null, _currentDangVien.SoTheDangVien);
        }
        private void HinhAnhPictureEdit_Properties_PopupMenuShowing(object sender, DevExpress.XtraEditors.Events.PopupMenuShowingEventArgs e)
        {
            var menu = e.PopupMenu;
            if (_clickEvents.Count == 0)
            {
                _clickEvents.Add(new EventHandler(OnPictureEditMenuItemCutClick));
                _clickEvents.Add(new EventHandler(OnPictureEditMenuItemCopyClick));
                _clickEvents.Add(new EventHandler(OnPictureEditMenuItemPastClick));
                _clickEvents.Add(new EventHandler(OnPictureEditMenuItemDeleteClick));
                _clickEvents.Add(new EventHandler(OnPictureEditMenuItemLoadClick));
                menu.Items[0].Click += OnPictureEditMenuItemCutClick;
                menu.Items[1].Click += OnPictureEditMenuItemCopyClick;
                menu.Items[2].Click += OnPictureEditMenuItemPastClick;
                menu.Items[3].Click += OnPictureEditMenuItemDeleteClick;
                menu.Items[4].Click += OnPictureEditMenuItemLoadClick;

            }
        }

                #region Sự kiện cập nhật hình
        private void OnPictureEditMenuItemLoadClick(object sender, EventArgs e)
        {
            loadedPicture(HinhAnhPictureEdit.Properties);
        }

        private void OnPictureEditMenuItemPastClick(object sender, EventArgs e)
        {
            loadedPicture(HinhAnhPictureEdit.Properties);
        }

        private void OnPictureEditMenuItemDeleteClick(object sender, EventArgs e)
        {
            deletedPicture();
        }

        private void OnPictureEditMenuItemCopyClick(object sender, EventArgs e)
        {
        }

        private void OnPictureEditMenuItemCutClick(object sender, EventArgs e)
        {
            deletedPicture();
        }


        #endregion

        #endregion

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
            OnSave();
        }
    }
}
