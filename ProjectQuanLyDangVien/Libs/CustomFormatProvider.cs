using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQuanLyDangVien.Libs
{
    class CustomFormatProvider : IFormatProvider,ICustomFormatter
    {
        // hiện thực IFormatProvider
        public object GetFormat(System.Type type)
        {
            return this;
        }

        // hiện thực ICustomFormatter
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            string formatValue = arg.ToString();
            switch (format)
            {
                case "gender":
                    Libs.Enums.Gender gender = (Libs.Enums.Gender)arg;
                    return Libs.Enumerations.GetEnumDescription(gender);
            }
            return formatValue;
        }
    }
}
