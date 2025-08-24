using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_Universe_Winforms.Manager
{
    class LanguageManager
    {
        public static string CurrentLanguage { get; private set; } = "English";

        // Dictionary chứa các từ khóa và bản dịch
        private static Dictionary<string, (string EN, string VN)> translations =
            new Dictionary<string, (string EN, string VN)>
        {
            { "Home", ("Home", "Trang Chủ") },
            { "Settings", ("Settings", "Cài Đặt") },
            { "Language", ("Language", "Ngôn Ngữ") },
            { "Exit", ("Exit", "Thoát") },
            { "Welcome", ("Welcome to FC Universe", "Chào mừng đến với FC Universe") },
            { "System", ("System", "Hệ Thống") },
            { "Switching other languages", ("Switching other languages", "Chuyển đổi ngôn ngữ") },
            { "Current language:", ("Current language:", "Ngôn ngữ hiện tại:") }

        };

        // Hàm đổi ngôn ngữ
        public static void SetLanguage(string lang)
        {
            if (lang == "English" || lang == "Vietnamese")
            {
                CurrentLanguage = lang;
            }
        }

        // Hàm lấy text theo key
        public static string GetText(string key)
        {
            if (translations.ContainsKey(key))
            {
                var value = translations[key];
                return CurrentLanguage == "English" ? value.EN : value.VN;
            }
            return key; // fallback nếu không có key
        }
    }
}
