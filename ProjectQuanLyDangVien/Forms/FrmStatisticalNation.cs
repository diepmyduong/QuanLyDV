using DevExpress.XtraEditors;
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
    public partial class FrmStatisticalNation : FormBase
    {
        public FrmStatisticalNation()
        {
            InitializeComponent();
        }

        #region Override
        public override void OnFormActive()
        {
            base.OnFormActive();

            _frmParent.iReLoad.Enabled = true;
            _frmParent.iExport.Enabled = true;
        }

        protected override void OnExport()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Data Files (*.xlsx)|*.xlsx";
            dlg.DefaultExt = "xlsx";
            dlg.AddExtension = true;
            dlg.ShowDialog();
            if (!string.IsNullOrWhiteSpace(dlg.FileName))
            {
                pivotGridControl1.ExportToXlsx(dlg.FileName);
                var result = XtraMessageBox.Show("Bạn có muốn mở tập tin vừa lưu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process process = new Process();
                    process.StartInfo.FileName = dlg.FileName;
                    process.Start();
                }
            }
        }
        protected override void OnReload()
        {
            f_BC_dantocTableAdapter.Fill(_Project_QLDVDataSet.f_BC_dantoc, dateFrom.DateTime, dateTo.DateTime);
        }

        protected override void OnFormLoad()
        {
            base.OnFormLoad();
            dateFrom.DateTime = DateTime.Today;
            dateTo.DateTime = DateTime.Today;

            OnReload();
        }
        #endregion
    }
}
