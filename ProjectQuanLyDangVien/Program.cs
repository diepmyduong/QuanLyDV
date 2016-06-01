using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraEditors.Controls;
using System.Threading;

namespace ProjectQuanLyDangVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle(Properties.Resources.SkinBlue);

            //Việt hóa phần mềm
            //GridLocalizer.Active = new Languages.VietnamGridLocalizer();
            //Localizer.Active = new Languages.VietnameEditorsLocalizer();


            Application.Run(new FormMain());
        }
    }
}