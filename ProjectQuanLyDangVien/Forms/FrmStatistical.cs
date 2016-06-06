using DevExpress.Utils;
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
    public partial class FrmStatistical : FormBase
    {
        public FrmStatistical()
        {
            InitializeComponent();
        }

        #region Override
        public override void OnFormActive()
        {
            base.OnFormActive();
            _frmParent.iReLoad.Enabled = true;
            _frmParent.iDelete.Enabled = true;
        }

        protected override void OnReload()
        {
            // Show Waitting Form
            if (!_frmParent.splashScreenManager.IsSplashFormVisible)
            {
                _frmParent.splashScreenManager.ShowWaitForm();
            }
            this.tbDangVienTableAdapter.Fill(this._Project_QLDVDataSet.tbDangVien); // Load Đảng viên
            // Close Waitting Form
            if (_frmParent.splashScreenManager.IsSplashFormVisible)
            {
                _frmParent.splashScreenManager.CloseWaitForm();
            }
        }

        protected override void OnDelete()
        {
            _frmParent.setFormStatus("On Delete....");
        }
        #endregion
        private void FrmStatistical_Load(object sender, EventArgs e)
        {
            cbGenger.Items.AddEnum(typeof(Libs.Enums.Genger), true);
            //Đĩnh nghĩa cột giới tính.
            fieldGioiTinh.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            fieldGioiTinh.ValueFormat.FormatString = "genger";
            fieldGioiTinh.ValueFormat.Format = new Libs.CustomFormatProvider();
            OnReload();
        }
    }
}
