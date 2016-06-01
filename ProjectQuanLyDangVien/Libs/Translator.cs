using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Yandex.Translator;

namespace ProjectQuanLyDangVien.Libs
{
    public class Translator
    {
        public static string TranslateText(string text, string languagePair)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                IYandexTranslator translator = Yandex.Translator.Yandex.Translator(api => api.ApiKey(Properties.Resources.YandexAPIKey).Format(ApiDataFormat.Json));
                var a = translator.Translate(languagePair, text);
                return a.Text;
            }
            else return string.Empty;
            
        }

        public class Languages
        {
            public static string VietNamese = "vi";
        }
    }
}
