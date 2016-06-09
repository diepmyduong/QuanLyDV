using DevExpress.Spreadsheet;
using DevExpress.XtraGrid.Views.BandedGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanLyDangVien.Forms
{
    public partial class FrmImport : FormBase
    {
        #region Private Properties
        #endregion
        #region Public Properties
        public string FilePath { get; set; }
        #endregion
        public FrmImport()
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
        }

        protected override void OnReload()
        {
            // Show Waitting Form
            if (!_frmParent.splashScreenManager.IsSplashFormVisible)
            {
                _frmParent.splashScreenManager.ShowWaitForm();
            }
            var spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            btnBrowse.Text = FilePath;
            // Load a workbook from a stream. 
            using (FileStream stream = File.Open(FilePath, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                spreadsheetControl1.LoadDocument(stream, DocumentFormat.Xls);
            }
            // Xóa bớt các dòng không cần thiết
            Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
            if (worksheet != null)
            {
                worksheet.Rows.Remove(0, 8);
            }
            // Lưu lại thành file tạm
            string tempPath = Libs.ExcelDataBaseHelper.CreateTempFile_MemberList(spreadsheetControl1);
            if (!String.IsNullOrEmpty(tempPath))
            {
                #region Mở sheet1 trong file excel
                DataTable data = Libs.ExcelDataBaseHelper.OpenFile(tempPath, "Sheet1") as DataTable;
                int i = 0;
                while (i < data.Rows.Count)
                {
                    var record = data.Rows[i];
                    if (String.IsNullOrEmpty(record.ItemArray[0].ToString()))
                    {
                        if (i >= 1 && data.Rows[i - 1] != null)
                        {
                            var currentRow = data.Rows[i - 1];
                            currentRow.BeginEdit();
                            currentRow.SetModified();
                            for (int j = 0; j < record.ItemArray.Length - 1; j++)
                            {
                                if (!string.IsNullOrEmpty(record.ItemArray[j].ToString()))
                                {
                                    currentRow[j] += " " + record.ItemArray[j];
                                }
                            }
                            currentRow.EndEdit();
                            currentRow.AcceptChanges();
                        }
                        data.Rows.Remove(record);
                    }
                    else
                    {
                        i++;
                    }
                }
                #endregion
                #region Chuyên data vừa import thành danh sách Đảng viên
                var view = bandedGridView1; // view hiển thị lên
                _Project_QLDVDataSet.tbDangVien.Clear();
                _Project_QLDVDataSet.tbDangVien.AcceptChanges();
                i = 0;
                while (i < data.Rows.Count)
                {
                    try
                    {
                        var record = data.Rows[i]; // Duyệt tửng dòng của data import

                        view.AddNewRow(); // Khởi tạo 1 row mới
                        int newRowHandle = view.FocusedRowHandle; // Lấy đối tượng Đảng viên mới vừa tạo
                        if (view.IsNewItemRow(newRowHandle))
                        {
                            var dangvien = view.GetDataRow(newRowHandle) as _Project_QLDVDataSet.tbDangVienRow;
                            if (dangvien != null)
                            {
                                #region Chuyển dự liệu từ data sàng đối tượng Đảng viên
                                dangvien.HoTenKhaiSinh = record.ItemArray[1].ToString();
                                dangvien.HoTenDangDung = record.ItemArray[1].ToString();
                                if (string.IsNullOrEmpty(record.ItemArray[2].ToString()))
                                {
                                    // Nếu là nữ
                                    dangvien.GioiTinh = 0;
                                    dangvien.NgaySinh = DateTime.Parse(record.ItemArray[3].ToString());
                                }
                                else if (string.IsNullOrEmpty(record.ItemArray[3].ToString()))
                                {
                                    // Nếu là nam
                                    dangvien.GioiTinh = 1;
                                    dangvien.NgaySinh = DateTime.Parse(record.ItemArray[2].ToString());
                                }
                                dangvien.SoLyLich = record.ItemArray[4].ToString().Replace(".", "");
                                dangvien.SoTheDangVien = record.ItemArray[5].ToString();
                                dangvien.NgayVaoDang = DateTime.Parse(record.ItemArray[6].ToString());
                                dangvien.NgayChinhThuc = DateTime.Parse(record.ItemArray[7].ToString());
                                dangvien.CongViecChinh = record.ItemArray[8].ToString();
                                dangvien.TrinhDo = record.ItemArray[10].ToString();
                                dangvien.HocVi = record.ItemArray[11].ToString();
                                dangvien.HocHam = record.ItemArray[12].ToString();
                                dangvien.LyLuanChinhTri = record.ItemArray[13].ToString();
                                dangvien.ChiBo = record.ItemArray[14].ToString();
                                dangvien.GhiChu = record.ItemArray[15].ToString();
                                #endregion
                                view.UpdateCurrentRow();
                            }
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        i++;
                    }
                } 
                #endregion
            }
            _Project_QLDVDataSet.tbDangVien.AcceptChanges();
            // Close Waitting Form
            if (_frmParent.splashScreenManager.IsSplashFormVisible)
            {
                _frmParent.splashScreenManager.CloseWaitForm();
            }
        }
        protected override void OnNew()
        {
            bandedGridView1.AddNewRow();
        }
        protected override void OnDelete()
        {
            
        }
        protected override void OnSave()
        {
        }
        #endregion

        private void btnBrowse_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //mở from Open File
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Data Files (*.xlsx; *.xls)|*.xlsx;*.xls"; // open file Excel
            dialog.ShowDialog();
            btnBrowse.Text = dialog.FileName;
            FilePath = dialog.FileName;
            OnReload();
        }

        private void FrmImport_Load(object sender, EventArgs e)
        {
            OnReload();
        }

        private void bandedGridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            var view = sender as BandedGridView;
            if(e.Column.Name == "colSTT")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
