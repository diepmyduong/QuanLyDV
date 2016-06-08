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
            // Mở Form Save File
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Data Files (*.xlsx)|*.xlsx"; // Export thành file Excel
            dlg.DefaultExt = "xlsx";
            dlg.AddExtension = true;
            dlg.ShowDialog();
            if (!string.IsNullOrWhiteSpace(dlg.FileName))
            {
                // Export theo tab page
                switch (xtraTabControl1.SelectedTabPage.Name)
                {
                    case "pageNation": // Trang dân tộc
                        pivotGridControl1.ExportToXlsx(dlg.FileName);
                        break;
                    case "pageReligion": // Trang tôn giáo
                        pivotGridControl2.ExportToXlsx(dlg.FileName);
                        break;
                }
                // Mở tập tin vừa lưu
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
            switch (xtraTabControl1.SelectedTabPage.Name)
            {
                case "pageNation": // Trang dân tộc
                    f_BC_dantocTableAdapter.Fill(_Project_QLDVDataSet.f_BC_dantoc, dateFrom.DateTime, dateTo.DateTime);
                    break;
                case "pageReligion": // Trang tôn giáo
                    f_BC_tongiaoTableAdapter.Fill(_Project_QLDVDataSet.f_BC_tongiao, dateFrom.DateTime, dateTo.DateTime);
                    break;
            }
            
        }

        protected override void OnFormLoad()
        {
            base.OnFormLoad();
            dateFrom.DateTime = DateTime.Today;
            dateTo.DateTime = DateTime.Today;

            OnReload();
        }
        #endregion

        #region Custom PivotGrid Color
        private void pivotGridControl1_CustomDrawCell(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs e)
        {
            if(e.RowIndex % 2 == 0)
            {
                e.Appearance.BackColor = Color.AliceBlue;
            }
        }
        #endregion

    }
}
