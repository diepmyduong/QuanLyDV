using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanLyDangVien.Forms
{
    public partial class FrmMemberDetail : FormBase
    {
        public FrmMemberDetail()
        {
            InitializeComponent();
        }

        #region Private Properties
        #endregion

        #region Public Properties
        public _Project_QLDVDataSet.tbDangVienRow CurrentMember { get; set;}

        #endregion

        #region Override
        public override void OnFormActive()
        {
            base.OnFormActive();
            _frmParent.iReLoad.Enabled = true;
            _frmParent.iNew.Enabled = true;
            _frmParent.iDelete.Enabled = true;
            _frmParent.iSave.Enabled = true;
            _frmParent.iClose.Enabled = true;
        }
        protected override void OnReload()
        {
            xtraTabControl2.SelectedTabPageIndex = 0;
            this.tbSysTonGiaoTableAdapter.Fill(this._Project_QLDVDataSet.tbSysTonGiao); // Load Tôn giáo
            this.tbSysDanTocTableAdapter.Fill(this._Project_QLDVDataSet.tbSysDanToc); // Load Dân tộc
            this.tbSysTinhThanhTableAdapter.Fill(this._Project_QLDVDataSet.tbSysTinhThanh); // Load quê quán
            if (CurrentMember == null)
            {
                //tbDangVienBindingSource.ResetBindings(true);
                var items = dataLayoutControl1.Items.FindByName("SoTheDangVienTextEdit");
                SoTheDangVienTextEdit.Focus();
            }
            else
            {
                tbDangVienTableAdapter.FillByDangVien(_Project_QLDVDataSet.tbDangVien, CurrentMember.SoTheDangVien);
                tbDangVienBindingSource.Position = 0;
                CurrentMember = (tbDangVienBindingSource.Current as DataRowView).Row as _Project_QLDVDataSet.tbDangVienRow;
            }
        }
        protected override void OnNew()
        {
            _frmParent.openNewMemberForm();
        }
        protected override void OnDelete()
        {
            if (tbDangVienBindingSource.Current != null && (tbDangVienBindingSource.Current as DataRowView).IsNew)
            {
                OnClose();
                return;
            }
            else
            {
                // Hỏi trước khi xóa
                var result = XtraMessageBox.Show(string.Format("Bạn có muốn xóa \"{0}\" không?", CurrentMember.HoTenDangDung), "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FrmMembers frm = _frmParent.getChildFormByName("FrmMembers") as FrmMembers;
                    if(frm != null)
                    {
                        frm.RemoveMember(CurrentMember.SoTheDangVien);
                    }
                    OnClose();
                }
            }
        }
        protected override void OnSave()
        {
            dataLayoutControl1.Validate();
            if (dxValidationProvider1.Validate())
            {
                if (CurrentMember != null)
                {
                    tbDangVienBindingSource.EndEdit();
                    //Lấy dữ liệu người dùng thay đổi trong grid
                    var dtChange = this._Project_QLDVDataSet.tbDangVien.GetChanges() as _Project_QLDVDataSet.tbDangVienDataTable;
                    if (dtChange == null) return;
                    try
                    {
                        tbDangVienTableAdapter.Update(dtChange);
                        _Project_QLDVDataSet.tbDangVien.AcceptChanges();
                        this.Name = CurrentMember.SoTheDangVien;
                        this.Text = string.Format("Chi tiết {0}", CurrentMember.SoTheDangVien);
                        this.FormTitle = string.Format("Chi tiết Đảng viên {0}", CurrentMember.SoTheDangVien);
                        var adapterHinhAnh = new _Project_QLDVDataSetTableAdapters.tbHinhAnhTableAdapter();
                        try
                        {
                            adapterHinhAnh.Insert(CurrentMember.HinhAnh, CurrentMember.SoTheDangVien);
                        }
                        catch
                        {
                            adapterHinhAnh.Update_HinhAnh(CurrentMember.HinhAnh, CurrentMember.SoTheDangVien);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if(tbDangVienBindingSource.Current != null)
                    {
                        CurrentMember = (tbDangVienBindingSource.Current as DataRowView).Row as _Project_QLDVDataSet.tbDangVienRow;
                        _Project_QLDVDataSet.tbDangVien.AddtbDangVienRow(CurrentMember);
                        OnSave();
                    }
                }
            }
        }
        public override void OnClose()
        {
            base.OnClose();
        }
        #endregion

        private void FrmMemberDetail_Load(object sender, EventArgs e)
        {
           
            cbBonus.Items.AddEnum(typeof(Libs.Enums.Bonus), true); // Loại khen thưởng
            cbArmorial.Items.AddEnum(typeof(Libs.Enums.ArmorialYear), true); // Số huy hiệu
            GioiTinhTextEdit.Properties.Items.AddEnum(typeof(Libs.Enums.Gender), true); // Giới tính
            GioiTinhTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            if(CurrentMember == null)
            {
                tbDangVienBindingSource.AddNew();
            }
            OnReload();
        }
        #region Quản lý tabDetail
        private void xtraTabControl2_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            // chọn tab nào mới load tab đó
            switch (xtraTabControl2.SelectedTabPage.Name)
            {
                case "pageProcess": //Quá trình hoạt động
                    if(CurrentMember == null)
                    {
                        grProcess.Enabled = false;
                    }
                    else
                    {
                        grProcess.Enabled = true;
                        this.tbQuaTrinhHoatDongTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbQuaTrinhHoatDong, CurrentMember.SoTheDangVien);
                    }
                    break;
                case "pageTrainning": //Quá trình đào tạo, bồi dưỡng
                    if (CurrentMember == null)
                    {
                        grTranning.Enabled = false;
                    }
                    else
                    {
                        grTranning.Enabled = true;
                        this.tbDaoTaoTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbDaoTao, CurrentMember.SoTheDangVien);
                    }
                    break;
                case "pageBonus": //Khen thưởng
                    if (CurrentMember == null)
                    {
                        grBonus.Enabled = false;
                    }
                    else
                    {
                        grBonus.Enabled = true;
                        this.tbKhenThuongTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbKhenThuong, CurrentMember.SoTheDangVien);
                    }
                    break;
                case "pageArmorial": //So Huy hiệu
                    if (CurrentMember == null)
                    {
                        grArmorial.Enabled = false;
                    }
                    else
                    {
                        grArmorial.Enabled = true;
                        this.tbSoHuyHieuTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbSoHuyHieu, CurrentMember.SoTheDangVien);
                    }
                    break;
                case "pageStylized": //Danh hiệu
                    if (CurrentMember == null)
                    {
                        grStylized.Enabled = false;
                    }
                    else
                    {
                        grStylized.Enabled = true;
                        this.tbDanhHieuTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbDanhHieu, CurrentMember.SoTheDangVien);
                    }
                    break;
                case "pageDiscipline": //Kỷ luật
                    if (CurrentMember == null)
                    {
                        grDiscipline.Enabled = false;
                    }
                    else
                    {
                        grDiscipline.Enabled = true;
                        this.tbKyLuatTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbKyLuat, CurrentMember.SoTheDangVien);
                    }
                    break;
                case "pageJailed": // Bắt tù, bị tù
                    if (CurrentMember == null)
                    {
                        grJailed.Enabled = false;
                    }
                    else
                    {
                        grJailed.Enabled = true;
                        this.tbBiTuTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbBiTu, CurrentMember.SoTheDangVien);
                    }
                    break;
                case "pageOldJobs": // Công việc cũ
                    if (CurrentMember == null)
                    {
                        grOldJobs.Enabled = false;
                    }
                    else
                    {
                        grOldJobs.Enabled = true;
                        this.tbCongViecCheDoCuTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbCongViecCheDoCu, CurrentMember.SoTheDangVien);
                    }
                    break;
                case "pageForeign": //Đi nước ngoài
                    if (CurrentMember == null)
                    {
                        grForeign.Enabled = false;
                    }
                    else
                    {
                        grForeign.Enabled = true;
                        this.tbDiNuocNgoaiTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbDiNuocNgoai, CurrentMember.SoTheDangVien);
                    }
                    break;
                case "pageForeignRelationship": // Quan hệ nước ngoài
                    if (CurrentMember == null)
                    {
                        grForeignRelationship.Enabled = false;
                    }
                    else
                    {
                        grForeignRelationship.Enabled = true;
                        this.tbQuanHeNuocNgoaiTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbQuanHeNuocNgoai, CurrentMember.SoTheDangVien);
                    }
                    break;
                case "pageForeignFamily": //Thân nhân nước ngoài
                    if (CurrentMember == null)
                    {
                        grForeignFamily.Enabled = false;
                    }
                    else
                    {
                        grForeignFamily.Enabled = true;
                        this.tbThanNhanNuocNgoaiTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbThanNhanNuocNgoai, CurrentMember.SoTheDangVien);
                    }
                    break;
                case "pageFamily": // Quan hệ gia đình
                    if (CurrentMember == null)
                    {
                        grFamily.Enabled = false;
                    }
                    else
                    {
                        grFamily.Enabled = true;
                        this.tbThanNhanTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbThanNhan, CurrentMember.SoTheDangVien);
                    }
                    break;
                case "pageAsset": // Tài sản
                    if (CurrentMember == null)
                    {
                        grAsset.Enabled = false;
                    }
                    else
                    {
                        grAsset.Enabled = true;
                        this.tbTaiSanTableAdapter.FillByDangVien(this._Project_QLDVDataSet.tbTaiSan, CurrentMember.SoTheDangVien);
                    }
                    break;
            }
        }
        private void gridViewDetails_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var gridview = sender as GridView;
            gridview.SetRowCellValue(e.RowHandle, gridview.Columns["SoTheDangVien"], CurrentMember.SoTheDangVien);
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

        //private void dataLayoutControl1_CurrentRecordChanged(object sender, EventArgs e)
        //{
        //    _currentDangVien = (tbDangVienBindingSource1.Current as DataRowView).Row as _Project_QLDVDataSet.tbDangVienRow;
        //    if (_currentDangVien != null && _currentDangVien.HinhAnh == null)
        //    {
        //        loadPicture();
        //    }
        //}
        //private void dataLayoutControl1_ItemSelectionChanged(object sender, EventArgs e)
        //{
        //    // updateDangVien();
        //}

        #endregion
    }
}
