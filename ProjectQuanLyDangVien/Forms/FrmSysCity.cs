using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmSysCity : FormBase
    {
        public FrmSysCity()
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
            _frmParent.iSave.Enabled = true;
            _frmParent.iExport.Enabled = true;
        }
        protected override void OnReload()
        {
            //Kiểm tra có dữ liệu được cập nhật không
            var dtChange = this._Project_QLDVDataSet.tbSysTinhThanh.GetChanges() as _Project_QLDVDataSet.tbSysTinhThanhDataTable;
            if (dtChange != null)
            {
                var result = XtraMessageBox.Show("Có thay đổi chưa lưu!\r\nBạn có muốn lưu lại thay đổi trước khi tải lại không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    OnSave();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            // Show Waitting Form
            if (!_frmParent.splashScreenManager.IsSplashFormVisible)
            {
                _frmParent.splashScreenManager.ShowWaitForm();
            }
            // TODO: This line of code loads data into the '_Project_QLDVDataSet.tbSysDanToc' table. You can move, or remove it, as needed.
            this.tbSysTinhThanhTableAdapter.Fill(this._Project_QLDVDataSet.tbSysTinhThanh);

            // Close Waitting Form
            if (_frmParent.splashScreenManager.IsSplashFormVisible)
            {
                _frmParent.splashScreenManager.CloseWaitForm();
            }
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
                    gridView1.DeleteSelectedRows();
                }
            }
        }
        protected override void OnSave()
        {
            //Bỏ focus để cập nhật dữ liệu
            var tempFocus = gridView1.FocusedRowHandle;
            gridView1.FocusedRowHandle = -1;
            gridView1.FocusedRowHandle = tempFocus;
            //Lấy dữ liệu người dùng thay đổi trong grid
            var dtChange = this._Project_QLDVDataSet.tbSysTinhThanh.GetChanges() as _Project_QLDVDataSet.tbSysTinhThanhDataTable;
            if (dtChange == null) return;
            try
            {
                tbSysTinhThanhTableAdapter.Update(dtChange);
                _Project_QLDVDataSet.tbSysTinhThanh.AcceptChanges();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        protected override void OnExport()
        {
            //Khởi tạo form Save File
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Data Files (*.xlsx)|*.xlsx"; // Save thành file Excel
            dlg.DefaultExt = "xlsx";
            dlg.AddExtension = true;
            dlg.ShowDialog();
            if (!string.IsNullOrWhiteSpace(dlg.FileName))
            {
                gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect; // Bỏ cột select trước khi export
                gridControl1.ExportToXlsx(dlg.FileName);
                gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect; // Mở lại cột select
                //Mở file vừa save
                var result = XtraMessageBox.Show("Bạn có muốn mở tập tin vừa lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process process = new Process();
                    process.StartInfo.FileName = dlg.FileName;
                    process.Start();
                }
            }
        }
        public override void OnClose()
        {
            //Kiểm tra có dữ liệu được cập nhật không
            var dtChange = this._Project_QLDVDataSet.tbSysTinhThanh.GetChanges() as _Project_QLDVDataSet.tbSysTinhThanhDataTable;
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

        private void FrmSysCity_Load(object sender, EventArgs e)
        {
            OnReload();
        }
    }
}
