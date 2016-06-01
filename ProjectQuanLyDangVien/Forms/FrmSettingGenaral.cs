using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanLyDangVien.Forms
{
    public partial class FrmSettingGenaral : FormBase
    {

        public static void LoadSetting()
        {
            var culture = Thread.CurrentThread.CurrentCulture;
            culture.DateTimeFormat.ShortDatePattern = Properties.Settings.Default.SettingDateType;
            culture.DateTimeFormat.ShortTimePattern = Properties.Settings.Default.SettingTimeType;
            culture.NumberFormat.CurrencyDecimalSeparator = Properties.Settings.Default.SettingDecimalSeparator;
            culture.NumberFormat.CurrencyGroupSeparator = Properties.Settings.Default.SettingGroupSeparator;
            culture.NumberFormat.CurrencyDecimalDigits = Properties.Settings.Default.SettingDecimalDigits;
            culture.NumberFormat.CurrencyNegativePattern = Properties.Settings.Default.SettingNegativePattern;
        }

        private CultureInfo culture = new CultureInfo("vi-VN");
        public FrmSettingGenaral()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = culture;
        }

        #region Override
        public override void OnFormActive()
        {
            base.OnFormActive();
            _frmParent.iClose.Enabled = true;
            _frmParent.iSave.Enabled = true;
        }

        public override void OnClose()
        {
            base.OnClose();
        }
        protected override void OnSave()
        {
            Properties.Settings.Default.SettingDateType = cbDateType.EditValue.ToString();
            Properties.Settings.Default.SettingTimeType = cbTimeType.EditValue.ToString();
            Properties.Settings.Default.SettingDecimalSeparator = cbDecimalSpace.EditValue.ToString();
            Properties.Settings.Default.SettingGroupSeparator = cbMillesimalSpace.EditValue.ToString();
            Properties.Settings.Default.SettingDecimalDigits = Convert.ToInt32(editRounding.Value);
            Properties.Settings.Default.SettingNegativePattern = cbNegative.SelectedIndex;

            // Save Setting
            Properties.Settings.Default.Save();
        }
        protected override void OnFormLoad()
        {
            base.OnFormLoad();
            OnReload();
        }

        protected override void OnReload()
        {
            cbDateType.SelectedItem = Properties.Settings.Default.SettingDateType;
            cbTimeType.SelectedItem = Properties.Settings.Default.SettingTimeType;
            cbDecimalSpace.SelectedItem = Properties.Settings.Default.SettingDecimalSeparator;
            cbMillesimalSpace.SelectedItem = Properties.Settings.Default.SettingGroupSeparator;
            editRounding.Value = Properties.Settings.Default.SettingDecimalDigits;
            cbNegative.SelectedIndex = Properties.Settings.Default.SettingNegativePattern;
        }

        #endregion

        private void cbDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            culture.DateTimeFormat.ShortDatePattern = cbDateType.Text;
            editExDateType.Text = DateTime.Today.ToShortDateString();
        }

        private void cbTimeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            culture.DateTimeFormat.ShortTimePattern = cbTimeType.Text;
            editExTimeType.Text = DateTime.Now.ToShortTimeString();
        }

        private void cbDecimalSpace_SelectedIndexChanged(object sender, EventArgs e)
        {
            culture.NumberFormat.CurrencyDecimalSeparator = cbDecimalSpace.Text;
            UpdateExam();
        }
        private void cbMillesimalSpace_SelectedIndexChanged(object sender, EventArgs e)
        {
            culture.NumberFormat.CurrencyGroupSeparator = cbMillesimalSpace.Text;
            UpdateExam();
        }

        private void editRounding_EditValueChanged(object sender, EventArgs e)
        {
            culture.NumberFormat.CurrencyDecimalDigits = Convert.ToInt32(editRounding.Text);
            UpdateExam();
        }

        private void cbNegative_SelectedIndexChanged(object sender, EventArgs e)
        {
            culture.NumberFormat.CurrencyNegativePattern = cbNegative.SelectedIndex;
            UpdateExam();
        }
        private void UpdateExam()
        {
            editExNumber.Text = (-555000000m).ToString("C");
        }
    }
}
