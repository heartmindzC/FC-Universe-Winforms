using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_Universe_Winforms
{
    class AppConfig
    {
        public bool IsRunOptionEnabled { get; set; } = false;
        public DateTime LastButtonClick { get; set; } = DateTime.MinValue;
        public string Language { get; set; } = "English";

        // Ví dụ dễ mở rộng sau này
        public string Theme { get; set; } = "Light";
        public int WindowWidth { get; set; } = 1024;
        public int WindowHeight { get; set; } = 768;
    }
}
