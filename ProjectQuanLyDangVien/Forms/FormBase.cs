using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace ProjectQuanLyDangVien.Forms
{
    public partial class FormBase : DevExpress.XtraEditors.XtraForm
    {
        protected FormMain _frmParent;
        public FormBase()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Cấu hình các phím chức năng được phép sử dụng khi mở form
        /// </summary>
        public virtual void OnFormActive()
        {

            #region Mở chức năng các nút
            //_frmParent.iExport.Enabled = true;
            //_frmParent.iOpen.Enabled = true;
            _frmParent.iClose.Enabled = true;
            //_frmParent.iFind.Enabled = true;
            //_frmParent.iSave.Enabled = true;
            //_frmParent.iSaveAs.Enabled = true;
            //_frmParent.alignButtonGroup.Enabled = true;
            //_frmParent.fontStyleButtonGroup.Enabled = true;
            //_frmParent.iNew.Enabled = true;
            //_frmParent.iDelete.Enabled = true;
            _frmParent.iReLoad.Enabled = true;
            #endregion

            #region Thêm sự kiện cho từng nút
            _frmParent.AddBarButtonEvent(_frmParent.iExport.Id, new ItemClickEventHandler(IExport_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iOpen.Id, new ItemClickEventHandler(IOpen_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iClose.Id, new ItemClickEventHandler(IClose_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iFind.Id, new ItemClickEventHandler(IFind_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iSave.Id, new ItemClickEventHandler(ISave_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iSaveAs.Id, new ItemClickEventHandler(ISaveAs_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iBoldFontStyle.Id, new ItemClickEventHandler(IBoldFontStyle_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iItalicFontStyle.Id, new ItemClickEventHandler(IItalicFontStyle_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iUnderlinedFontStyle.Id, new ItemClickEventHandler(IUnderlinedFontStyle_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iLeftTextAlign.Id, new ItemClickEventHandler(ILeftTextAlign_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iCenterTextAlign.Id, new ItemClickEventHandler(ICenterTextAlign_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iRightTextAlign.Id, new ItemClickEventHandler(IRightTextAlign_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iNew.Id, new ItemClickEventHandler(INew_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iDelete.Id, new ItemClickEventHandler(IDelete_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iReLoad.Id, new ItemClickEventHandler(IReLoad_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iPrint.Id, new ItemClickEventHandler(IPrint_ItemClick));
            _frmParent.AddBarButtonEvent(_frmParent.iDetail.Id, new ItemClickEventHandler(IDetail_ItemClick));
            #endregion
        }

        #region Sự kiện
        private void IDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnDetailClick();
        }
        private void IPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnPrint();
        }
        private void IReLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            OnReload();
        }
        private void IDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
        }
        private void INew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnNew();
        }
        private void IRightTextAlign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnRightTextAlign();
        }
        private void ICenterTextAlign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnCenterTextAlign();
        }
        private void ILeftTextAlign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnLeftTextAlign();
        }
        private void IUnderlinedFontStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnUnderlinedFontStyle();
        }
        private void IItalicFontStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnItalicFontStyle();
        }
        private void IBoldFontStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnBoldFontStyle();
        }
        private void ISaveAs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnSaveAs();
        }
        private void ISave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnSave();
        }
        private void IFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnFind();
        }
        private void IClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnClose();
        }
        private void IOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnOpen();
        }
        private void IExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnExport();
        }
        private void FormBase_Load(object sender, EventArgs e)
        {
            OnFormLoad();
        }
        #endregion
        #region Viturl Functions
        protected virtual void OnDetailClick()
        {
            
        }
        protected virtual void OnPrint()
        {
     
        }
        protected virtual void OnReload()
        {
        }
        protected virtual void OnDelete(){}
        protected virtual void OnRightTextAlign(){}
        protected virtual void OnCenterTextAlign(){}
        protected virtual void OnLeftTextAlign()
        {
        }
        protected virtual void OnUnderlinedFontStyle()
        {

        }
        protected virtual void OnItalicFontStyle()
        {
        }
        protected virtual void OnBoldFontStyle()
        {
        }
        protected virtual void OnSaveAs()
        {
        }
        protected virtual void OnSave()
        {
        }
        protected virtual void OnFind()
        {
        }
        public virtual void OnClose()
        {
            this.Close();
        }
        protected virtual void OnOpen()
        {
            throw new NotImplementedException();
        }
        protected virtual void OnExport()
        {
        }
        protected virtual void OnNew()
        {
        }
        protected virtual void OnFormLoad()
        {
            _frmParent = this.MdiParent as FormMain;
        }
        #endregion
        public string FormTitle
        {
            get
            {
                return this.lblFormTitle.Text;
            }
            set
            {
                this.lblFormTitle.Text = value;
            }
        }
    }
}