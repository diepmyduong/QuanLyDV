using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQuanLyDangVien.Languages
{
    class VietnamGridLocalizer : GridLocalizer
    {
        public override string Language
        {
            get
            {
                return "VietNamese";
            }
        }

        public override string GetLocalizedString(GridStringId id)
        {
            switch (id)
            {
                // Grid Column
                case GridStringId.MenuColumnSortAscending: return "Sắp xếp tăng";
                case GridStringId.MenuColumnSortDescending: return "Sắp xếp giảm";
                case GridStringId.MenuColumnClearSorting: return "Không sắp xếp";
                case GridStringId.MenuColumnGroup: return "Nhóm cột";
                case GridStringId.MenuColumnUnGroup: return "Bỏ nhóm";
                case GridStringId.MenuGroupPanelClearGrouping: return "Bỏ tất cả nhóm";
                case GridStringId.MenuGroupPanelFullExpand: return "Sổ tất cả";
                case GridStringId.MenuGroupPanelFullCollapse: return "Đóng tất cả";
                case GridStringId.MenuColumnAutoFilterRowHide: return "Ẫn bộ lọc dòng";
                case GridStringId.MenuColumnAutoFilterRowShow: return "Hiện bộ lọc dòng";
                case GridStringId.MenuColumnClearAllSorting: return "Bỏ sắp xếp";
                case GridStringId.MenuGroupPanelHide: return "Ẫn bảng nhóm cột";
                case GridStringId.MenuGroupPanelShow: return "Hiện bảng nhóm cột";
                case GridStringId.MenuColumnRemoveColumn: return "Ẫn cột này";
                case GridStringId.MenuColumnColumnCustomization: return "Danh sách cột ẩn...";
                case GridStringId.MenuColumnBestFit: return "Tự động canh ngang";
                case GridStringId.MenuColumnBestFitAllColumns: return "Tự động canh ngang (Tất cả)";
                case GridStringId.MenuColumnFilterEditor: return "Bộ lọc nâng cao...";
                case GridStringId.MenuColumnFindFilterShow: return "Hiện thanh tìm kiếm";
                case GridStringId.MenuColumnFindFilterHide: return "Ẫn thanh tìm kiếm";

                // Dịch tiếp....
                default:
                    //string result;
                    //VietnameString.GridLocalizerString.TryGetValue(id,out result);
                    //if (string.IsNullOrEmpty(result))
                    //{
                    //    result = Libs.Translator.TranslateText(base.GetLocalizedString(id), Libs.Translator.Languages.VietNamese);
                    //    VietnameString.GridLocalizerString.Add(id, result);
                    //    return result;
                    //}
                    //else
                    //{
                    //    return VietnameString.GridLocalizerString[id];
                    //}
                    return base.GetLocalizedString(id);
            }
        }

    }

    class VietnameEditorsLocalizer : Localizer
    {
        
        public override string Language
        {
            get
            {
                return "VietNamese";
            }
        }

        public override string GetLocalizedString(StringId id)
        {
            switch (id)
            {
                case StringId.CalcError: return "Lỗi phép tính";
                case StringId.CaptionError: return "Lỗi";
                case StringId.CheckChecked: return "Đánh dấu chọn";
                case StringId.CheckIndeterminate: return "CheckIndeterminate";
                case StringId.CheckUnchecked: return "Không đánh dấu chọn";
                // Menu hình ảnh
                case StringId.PictureEditMenuPaste: return "Dán";
                case StringId.PictureEditMenuLoad: return "Duyệt...";
                case StringId.PictureEditMenuSave: return "Lưu lại...";
                case StringId.PictureEditMenuFullSize: return "Kích cỡ đầy đủ";
                case StringId.PictureEditMenuFitImage: return "Canh hình ảnh";
                case StringId.PictureEditMenuDelete: return "Xóa";
                case StringId.PictureEditMenuCut: return "Cắt";
                case StringId.PictureEditMenuCopy: return "Sao chép";
                case StringId.TakePictureMenuItem: return "Lấy hình từ Camera";
                // Menu textbox
                case StringId.TextEditMenuPaste: return "Dán";
                case StringId.TextEditMenuCopy: return "Sao Chép";
                case StringId.TextEditMenuDelete: return "Xóa";
                case StringId.TextEditMenuCut: return "Cắt";
                case StringId.TextEditMenuSelectAll: return "Chọn tất cả";
                case StringId.TextEditMenuUndo: return "Quay lại";

                // ..... dịch tiếp

                default:
                    //string result;
                    //VietnameString.EditorsLocalizer.TryGetValue(id, out result);
                    //if (string.IsNullOrEmpty(result))
                    //{
                    //    result = Libs.Translator.TranslateText(base.GetLocalizedString(id), Libs.Translator.Languages.VietNamese);
                    //    VietnameString.EditorsLocalizer.Add(id, result);
                    //    return result;
                    //}
                    //else
                    //{
                    //    return VietnameString.EditorsLocalizer[id];
                    //}
                    return base.GetLocalizedString(id);
            }
        }
    }

    class VietnameString
    {
        public static Dictionary<GridStringId, string> GridLocalizerString = new Dictionary<GridStringId, string>();
        public static Dictionary<StringId, string> EditorsLocalizer = new Dictionary<StringId, string>();
    }
}
