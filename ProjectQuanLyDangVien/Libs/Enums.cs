
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQuanLyDangVien.Libs
{
    public class Enumerations
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
    public class Enums
    {
        public enum Genger // GIới tính
        {
            [System.ComponentModel.Description("Nữ")]
            Female = 0,
            [System.ComponentModel.Description("Nam")]
            Male = 1
        }

        public enum Bonus // Khen thưởng
        {
            [System.ComponentModel.Description("Khác")]
            Other = 0,
            [System.ComponentModel.Description("Huân chương, huy chương")]
            Medal = 1,
            [System.ComponentModel.Description("Bằng khen")]
            Merit = 2
        }

        public enum ArmorialYear // Năm huy hiệu
        {
            [System.ComponentModel.Description("Khác")]
            Other = 0,
            [System.ComponentModel.Description("40 Năm")]
            FourtyYear = 40,
            [System.ComponentModel.Description("50 Năm")]
            FiftyYear = 50,
            [System.ComponentModel.Description("60 Năm")]
            SixtyYear = 60,
            [System.ComponentModel.Description("70 Năm")]
            SeventyYear = 70,
        }

        public enum Activities // Sinh hoạt
        {
            [System.ComponentModel.Description("+")]
            In = 0,
            [System.ComponentModel.Description("-")]
            Out = 1,
            [System.ComponentModel.Description("x")]
            OutForeign = 2
        }
    }
    
}
