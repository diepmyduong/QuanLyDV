using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using ProjectQuanLyDangVien.Forms;
using DevExpress.XtraEditors.Popup;
using System.Threading;
using ProjectQuanLyDangVien._Project_QLDVDataSetTableAdapters;
using DevExpress.XtraNavBar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace ProjectQuanLyDangVien
{
    public partial class FormMain : RibbonForm
    {

        private Thread _timer;
        private bool _isExit = false;
        private Dictionary<int,List<ItemClickEventHandler>> _barBtnEvents = new Dictionary<int, List<ItemClickEventHandler>>();
        public FormMain()
        {
            InitializeComponent();
            InitSkinGallery();
            FrmSettingGenaral.LoadSetting();
            setFormStatus("Starting Date Time....");
            this.MdiChildActivate += FormMain_MdiChildActivate;
        }

        private void FormMain_MdiChildActivate(object sender, EventArgs e)
        {
            DisableAllBarButton();
            RemoveAllBarButtonEvent();
            defaultSetting();
            //Gọi hàm active của form con để foramt 1 vài chức năng được phép hoạt động
            FormBase f = this.ActiveMdiChild as FormBase;
            if (f != null)
            {
                f.OnFormActive();
            }
        }
        private void defaultSetting()
        {
            setFormStatus("Prepare default setting...");
            iNew.ButtonStyle = BarButtonStyle.Default;
        }
        public void DisableAllBarButton()
        {
            setFormStatus("Disable all bar button");
            this.iExport.Enabled = false;
            this.iOpen.Enabled = false;
            this.iClose.Enabled = false;
            this.iFind.Enabled = false;
            this.iSave.Enabled = false;
            this.iSaveAs.Enabled = false;
            this.alignButtonGroup.Enabled = false;
            this.fontStyleButtonGroup.Enabled = false;
            this.iNew.Enabled = false;
            this.iDelete.Enabled = false;
            this.iReLoad.Enabled = false;
            this.iPrint.Enabled = false;
            this.iDetail.Enabled = false;
        }

        public void RemoveAllBarButtonEvent()
        {
            setFormStatus("Removing all bar button event");
            foreach(var item in _barBtnEvents)
            {
                BarButtonItem btn = ribbonControl.Manager.Items.FindById(item.Key) as BarButtonItem;
                if (btn != null)
                {
                    foreach(var ev in item.Value)
                    {
                        btn.ItemClick -= ev;
                    }
                }
            }
            _barBtnEvents.Clear();
        }

        public void AddBarButtonEvent(int btnId,ItemClickEventHandler ev)
        {
            BarButtonItem btn = ribbonControl.Manager.Items.FindById(btnId) as BarButtonItem;
            if(btn != null)
            {
                btn.Reset();
                btn.ItemClick += ev;
                var del = _barBtnEvents.Where(d => d.Key == btnId).FirstOrDefault().Value;
                if(del != null)
                {
                    del.Add(ev);
                }
                else
                {
                    _barBtnEvents.Add(btnId, new List<ItemClickEventHandler> { ev });
                }
            }
        }
        void InitSkinGallery()
        {
            setFormStatus("init Skin Gallery...");
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        #region Mở Form
        /// <summary>
        /// Lấy form con trong document
        /// </summary>
        /// <param name="frmName"> Tên form cần lấy</param>
        /// <returns></returns>
        public Form getChildFormByName(string frmName)
        {
            return this.MdiChildren.FirstOrDefault(f => f.Name == frmName);
        }
        /// <summary>
        /// Mở form con
        /// </summary>
        /// <param name="nameSpace">Tên miền chứa form</param>
        /// <param name="frmName">Tên form</param>
        public void openChildFormByName(string nameSpace, string frmName)
        {
            if(!splashScreenManager.IsSplashFormVisible) splashScreenManager.ShowWaitForm();
            Form f = getChildFormByName(frmName);
            if (f == null)
            {
                try
                {
                    f = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(nameSpace + "." + frmName) as Form;
                    f.Name = frmName;
                    f.MdiParent = this;
                    f.Show();
                    f.Activate();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
            else f.Activate();
            if (splashScreenManager.IsSplashFormVisible) splashScreenManager.CloseWaitForm();
        }
        public void openDetailForm(_Project_QLDVDataSet.tbDangVienRow member)
        {
            splashScreenManager.ShowWaitForm();
            Form f = getChildFormByName(member.SoTheDangVien);
            if (f == null)
            {
                try
                {
                    var frm = new Forms.FrmMemberDetail();
                    frm.CurrentMember = member;
                    frm.Name = member.SoTheDangVien;
                    frm.Text = string.Format("Chi tiết {0}", member.SoTheDangVien);
                    frm.FormTitle = string.Format("Chi tiết Đảng viên {0}", member.SoTheDangVien);
                    frm.MdiParent = this;
                    frm.Show();
                    frm.Activate();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
            else f.Activate();
            splashScreenManager.CloseWaitForm();
        }
        public void openNewMemberForm()
        {
            splashScreenManager.ShowWaitForm();
            Form f = getChildFormByName("FrmNewMember");
            if (f == null)
            {
                try
                {
                    var frm = new Forms.FrmMemberDetail();
                    frm.CurrentMember = null;
                    frm.Name = "FrmNewMember";
                    frm.Text = "Thêm mới Đảng viên";
                    frm.FormTitle = "Thêm mới Đảng viên";
                    frm.MdiParent = this;
                    frm.Show();
                    frm.Activate();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
            else f.Activate();
            splashScreenManager.CloseWaitForm();
        }

        #endregion
        #region Navigation Bar
        private void NavBarItemLinked (object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var item = sender as NavBarItem;
            var tag = item.Tag as string[];
            openChildFormByName(tag[0],tag[1]);
        }
        #endregion

        #region Sự kiện
        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            onFormClose();
        }
        /// <summary>
        /// Hiện cột menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnNavBar.Show();
        }
        private void iSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            openChildFormByName("ProjectQuanLyDangVien.Forms", "FrmSettingGenaral");
        }
        private void iReportDesigner_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager.ShowWaitForm();
            Libs.Reports.ReportBase report = new Libs.Reports.ReportBase();
            report.DataAdapter = new tbDangVienTableAdapter();
            report.DataSource = _Project_QLDVDataSet.tbDangVien;
            ReportDesignTool tool = new ReportDesignTool(report);
            tool.ShowRibbonDesigner();
            splashScreenManager.CloseWaitForm();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            splashScreenManager.ShowWaitForm();
            // TODO: This line of code loads data into the '_Project_QLDVDataSet.tbDocumentManager' table. You can move, or remove it, as needed.
            this.tbDocumentManagerTableAdapter.Fill(this._Project_QLDVDataSet.tbDocumentManager);
            _timer = new Thread(runTimer);
            _timer.Start();
            setFormStatus("");

            //Load menu
            tbDocumentManager_GroupTableAdapter docGroupAdapter = new tbDocumentManager_GroupTableAdapter();
            _Project_QLDVDataSet.tbDocumentManager_GroupDataTable docGroups = docGroupAdapter.GetData();
            foreach (var group in docGroups)
            {
                tbDocumentManagerTableAdapter docAdapter = new tbDocumentManagerTableAdapter();
                _Project_QLDVDataSet.tbDocumentManagerDataTable docItems = docAdapter.GetDataByMaNhom(group.MaNhom);
                NavBarGroup navGroup = new NavBarGroup();
                navGroup.Caption = group.DienGiai;
                navGroup.Expanded = true;
                foreach (var doc in docItems)
                {
                    NavBarItem navItem = new NavBarItem();
                    navItem.Caption = doc.DienGiai;
                    var tag = new string[] { doc.TenMien, doc.TenForm };
                    navItem.Tag = tag;
                    navItem.LinkClicked += new NavBarLinkEventHandler(NavBarItemLinked);
                    navBarControl1.Items.Add(navItem);
                    navGroup.ItemLinks.Add(new NavBarItemLink(navItem));
                }
                navBarControl1.Groups.Add(navGroup);
            }

            repositoryItemSearchLookUpEdit1.View.ExpandAllGroups();
            splashScreenManager.CloseWaitForm();

        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isExit)
            {
                onFormClose();
                e.Cancel = true;
            }
        }
        private void onFormClose()
        {
            _isExit = true;
            foreach(FormBase child in this.MdiChildren)
            {
                child.OnClose();
            }
            this.Dispose();
            this.Close();
        }
        #endregion

        /// <summary>
        /// Cập nhật trạng thái phần mềm
        /// </summary>
        /// <param name="status"></param>
        public void setFormStatus(string status)
        {
            this.siStatus.Caption = status;
        }
        /// <summary>
        /// Cập nhật thông tin phần mềm
        /// </summary>
        /// <param name="info"></param>
        public void setFormInFo(string info)
        {
            this.siInfo.Caption = info;
        }
        public void setDateTime()
        {
            this.siDateTime.Caption = String.Format("Ngày giờ : {0}", DateTime.Now);
        }
        
        private void runTimer()
        {
            while (!_isExit)
            {
                Thread.Sleep(1000);
                setDateTime();
            }
        }
        private void repositoryItemSearchLookUpEdit1View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var grid = sender as GridView;
            if (grid.IsGroupRow(e.RowHandle)) return;
            _Project_QLDVDataSet.tbDocumentManagerRow doc = grid.GetFocusedDataRow() as _Project_QLDVDataSet.tbDocumentManagerRow;
            if (doc != null)
            {
                openChildFormByName(doc.TenMien, doc.TenForm);
            }
        }

        
    }
}