using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanLyDangVien.Forms
{
    public partial class FrmMemberActivities : FormBase
    {
        #region Private properties
        private _Project_QLDVDataSet.tbDangVienRow _selectedMember;
        private string _fieldHoTen, _fieldNgaySinh, _fieldNgayVaoDang, _fieldSoTheDV;
        #endregion
        public FrmMemberActivities()
        {
            InitializeComponent();
        }

        #region Override
        public override void OnFormActive()
        {
            base.OnFormActive();

            _frmParent.iReLoad.Enabled = true;
            _frmParent.iNew.Enabled = true;
            _frmParent.iDelete.Enabled = true;
            _frmParent.iDetail.Enabled = true;
            _frmParent.iExport.Enabled = true;
            _frmParent.iSave.Enabled = true;

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

       

        protected override void OnReload()
        {
            //Trước khi reload
            var dtChange = this._Project_QLDVDataSet.tbSinhHoatDang.GetChanges() as _Project_QLDVDataSet.tbSinhHoatDangDataTable;
            if (dtChange != null)
            {
                var result = XtraMessageBox.Show("Có thay đổi chưa lưu!\r\nBạn có muốn lưu lại thay đổi trước khi tải lại không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    OnSave();
                }else if(result == DialogResult.Cancel)
                {
                    return;
                }
            }
            // Bắt đầu reload
            cbActivities.Items.AddEnum(typeof(Libs.Enums.Activities), true);
            this.tbDangVienTableAdapter.Fill(this._Project_QLDVDataSet.tbDangVien);
            this.tbSinhHoatDangTableAdapter.Fill(this._Project_QLDVDataSet.tbSinhHoatDang);
        }
        protected override void OnNew()
        {
            gridView1.AddNewRow();
        }
        protected override void OnDelete()
        {
            if (gridView1.SelectedRowsCount != 0)
            {
                var result = XtraMessageBox.Show(string.Format("Bạn có muốn xóa \"{0}\" dữ liệu đã chọn không?", gridView1.SelectedRowsCount), "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Đóng các form chi tiết đang mở
                    var rows = gridView1.GetSelectedRows();
                    gridView1.DeleteSelectedRows();
                }
            }
        }
        protected override void OnDetailClick()
        {
            if (gridView1.SelectedRowsCount != 0)
            {
                var adapter = new _Project_QLDVDataSetTableAdapters.tbDangVienTableAdapter();
                foreach (int row in gridView1.GetSelectedRows())
                {
                    var sothedangvien = (gridView1.GetDataRow(row) as _Project_QLDVDataSet.tbSinhHoatDangRow).SoTheDangVien;
                    _Project_QLDVDataSet.tbDangVienRow dangvien = adapter.GetDataByDangVien(sothedangvien).FirstOrDefault();
                    if(dangvien != null)
                    {
                        _frmParent.openDetailForm(dangvien);
                    }
                }
            }
        }
        #region Export
        protected override void OnExport()
        {
        }
        private void IExportToXlsx_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Data Files (*.xlsx)|*.xlsx";
            dlg.DefaultExt = "xlsx";
            dlg.AddExtension = true;
            dlg.ShowDialog();
            if (!string.IsNullOrWhiteSpace(dlg.FileName))
            {
                gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
                gridControl1.ExportToXlsx(dlg.FileName);
                gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
                var result = XtraMessageBox.Show("Bạn có muốn mở tập tin vừa lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process process = new Process();
                    process.StartInfo.FileName = dlg.FileName;
                    process.Start();
                }
            }
        }

        private void IExportToPdf_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Data Files (*.pdf|*.pdf";
            dlg.DefaultExt = "pdf";
            dlg.AddExtension = true;
            dlg.ShowDialog();
            if (!string.IsNullOrWhiteSpace(dlg.FileName))
            {
                gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
                DevExpress.XtraPrinting.PdfExportOptions option = new DevExpress.XtraPrinting.PdfExportOptions();
                gridControl1.ExportToPdf(dlg.FileName);
                gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
                var result = XtraMessageBox.Show("Bạn có muốn mở tập tin vừa lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process process = new Process();
                    process.StartInfo.FileName = dlg.FileName;
                    process.Start();
                }
            }
        } 
        #endregion
        protected override void OnSave()
        {
            _frmParent.setFormStatus("Đang lưu...");
            var tempRow = gridView1.FocusedRowHandle;
            gridView1.FocusedRowHandle = -1;
            gridView1.FocusedRowHandle = tempRow;
            var dtChange = this._Project_QLDVDataSet.tbSinhHoatDang.GetChanges() as _Project_QLDVDataSet.tbSinhHoatDangDataTable;
            if (dtChange != null)
            {
                try
                {
                    tbSinhHoatDangTableAdapter.Adapter.Update(dtChange);
                }catch(Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
            _frmParent.setFormStatus("Đã lưu...");
        }
        public override void OnClose()
        {
            //Trước khi đóng
            var dtChange = this._Project_QLDVDataSet.tbSinhHoatDang.GetChanges() as _Project_QLDVDataSet.tbSinhHoatDangDataTable;
            if (dtChange != null)
            {
                var result = XtraMessageBox.Show("Có thay đổi chưa lưu!\r\nBạn có muốn lưu lại thay đổi trước khi đóng lại không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    OnSave();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            //Đóng form
            base.OnClose();
        }
        #endregion

        #region Sự kiện chính
        private void FrmMemberActivities_Load(object sender, EventArgs e)
        {
            _fieldHoTen = _Project_QLDVDataSet.tbDangVien.HoTenKhaiSinhColumn.ColumnName;
            _fieldNgaySinh = _Project_QLDVDataSet.tbDangVien.NgaySinhColumn.ColumnName;
            _fieldNgayVaoDang = _Project_QLDVDataSet.tbDangVien.NgayChinhThucColumn.ColumnName;
            _fieldSoTheDV = _Project_QLDVDataSet.tbDangVien.SoTheDangVienColumn.ColumnName;
            OnReload();
        }

        private void repositoryItemSearchLookUpEdit1View_Click(object sender, EventArgs e)
        {
            var grid = sender as GridView;
            Console.WriteLine("Select");
            var data = grid.GetFocusedDataRow() as _Project_QLDVDataSet.tbDangVienRow;
            if(data != null)
            {
                _selectedMember = data;
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var grid = sender as GridView;
            if(e.Column == grid.Columns.ColumnByFieldName(_fieldSoTheDV))
            {
                if (_selectedMember != null)
                {
                    grid.SetRowCellValue(e.RowHandle, grid.Columns.ColumnByFieldName(_fieldHoTen), _selectedMember.HoTenKhaiSinh);
                    grid.SetRowCellValue(e.RowHandle, grid.Columns.ColumnByFieldName(_fieldNgaySinh), _selectedMember.NgaySinh);
                    grid.SetRowCellValue(e.RowHandle, grid.Columns.ColumnByFieldName(_fieldNgayVaoDang), _selectedMember.NgayChinhThuc);
                }
            }
            
            Console.WriteLine("Cell update");
        }

        #region Xem chi tiết Đảng viên
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
                var sothedangvien = ((tbSinhHoatDangBindingSource.Current as DataRowView).Row as _Project_QLDVDataSet.tbSinhHoatDangRow).SoTheDangVien;
                if (string.IsNullOrEmpty(sothedangvien)) return;
                var adapter = new _Project_QLDVDataSetTableAdapters.tbDangVienTableAdapter();
                var dangvien = adapter.GetDataByDangVien(sothedangvien).FirstOrDefault();
                if(dangvien != null)
                {
                    _frmParent.openDetailForm(dangvien);
                }
            }
        } 
        #endregion
        #endregion

    }
}
