using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using FC_Universe_Winforms.Manager;
using System.Drawing.Text;

namespace FC_Universe_Winforms
{
    public partial class Home : Form
    {

        public Home()
        {
            
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;

            this.BackColor = Color.FromArgb(30, 30, 30);

            this.UpdateStyles();

        }
        public async Task InitDataAsync()
        {
            this.SuspendLayout();

            // Sử dụng Task.Run để đưa các tác vụ đọc file nặng ra khỏi UI thread
            var data = await Task.Run(() => {
                ConfigManager.Load();
                string profileName = GetFC25ProfileName();
                string appliedMods = CountAppliedMods().ToString();
                string backupTime = "N/A";
                string backupFilePath = Path.Combine(Application.StartupPath, "runtimes", "win", "lib", "net7.0", "System", "mm", "backup_json_profile", "FIFA Mod Manager.json");
                if (File.Exists(backupFilePath))
                {
                    backupTime = File.GetLastWriteTimeUtc(backupFilePath).ToString("dd/MM/yyyy HH:mm");
                }
                bool isOptionEnabled = ConfigManager.Config.IsRunOptionEnabled;
                string lastRestore = ConfigManager.Config.LastButtonClick.ToString("dd/MM/yyyy HH:mm");

                // Trả về một object chứa tất cả dữ liệu đã tải
                return new { profileName, appliedMods, backupTime, isOptionEnabled, lastRestore };
            });

            // Cập nhật các control trên UI thread sau khi đã có dữ liệu
            labelProfileName.Text = data.profileName;
            labelAppliedMod.Text = data.appliedMods;
            labelLastestBackupTime.Text = data.backupTime;
            checkboxOption.Checked = data.isOptionEnabled;
            labelLastestRestore.Text = data.lastRestore;

            this.ResumeLayout(true);
        }

        private void btnBackupProfile_Click(object sender, EventArgs e)
        {
            // get path file from browse path, then find json file in path browsed
            string path = Application.StartupPath;
            string jsonFilePath = System.IO.Path.Combine(path, "runtimes", "win", "lib", "net7.0", "System", "mm", "FIFA Mod Manager.json");
            string jsonFilePath2 = System.IO.Path.Combine(path, "runtimes", "win", "lib", "net7.0", "System", "mm", "FIFA Mod Manager.json.bak");
            string backupFilePath = System.IO.Path.Combine(path, "runtimes", "win", "lib", "net7.0", "System", "mm", "backup_json_profile");
            //check backup folder exist, if not create it
            if (!System.IO.Directory.Exists(backupFilePath))
            {
                System.IO.Directory.CreateDirectory(backupFilePath);
            }
            try
            {
                System.IO.File.Copy(jsonFilePath, backupFilePath + @"\FIFA Mod Manager.json", true);
                System.IO.File.Copy(jsonFilePath2, backupFilePath + @"\FIFA Mod Manager.json.bak", true);
                MessageBox.Show("Đã sao lưu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sao lưu: {ex.Message}", "Lỗi");
            }
        }
        private void btnRunNow_Click(object sender, EventArgs e)
        {
            string pathNew = Application.StartupPath;

            //try
            //{
            //    RunApplication(@"D:\EA SPORTS FC 25\FC25.exe", 10,false);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Lỗi khi chạy Origin: {ex.Message}", "Lỗi");
            //}
            if (checkboxOption.Checked)
            {
                try
                {
                    RunApplication(System.IO.Path.Combine(pathNew, "runtimes", "win", "lib", "net7.0", "System", "le", "Launcher.exe"), 5, false);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi chạy Live Editor: {ex.Message}", "Lỗi");
                }


                try
                {
                    RunApplication(System.IO.Path.Combine(pathNew, "runtimes", "win", "lib", "net7.0", "System", "mm", "FIFA Mod Manager.exe"), 5, false);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi chạy FIFA Mod Manager: {ex.Message}", "Lỗi");
                }
            }
            else
            {
                try
                {
                    RunApplication(System.IO.Path.Combine(pathNew, "runtimes", "win", "lib", "net7.0", "System", "mm", "FIFA Mod Manager.exe"), 5, false);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi chạy FIFA Mod Manager: {ex.Message}", "Lỗi");
                }
            }

        }
        private void checkboxOption_CheckedChanged(object sender, EventArgs e)
        {
            ConfigManager.Config.IsRunOptionEnabled = checkboxOption.Checked;
            ConfigManager.Save();
        }
        private void RunApplication(string appPath, int delaySeconds, bool requiresElevation, string autoUsername = null, string autoPassword = null)
        {
            if (System.IO.File.Exists(appPath))
            {
                try
                {
                    var startInfo = new ProcessStartInfo
                    {
                        FileName = appPath,
                        WorkingDirectory = System.IO.Path.GetDirectoryName(appPath),
                        UseShellExecute = true
                    };

                    if (requiresElevation)
                    {
                        startInfo.Verb = "runas";
                    }

                    Process process = Process.Start(startInfo);
                    System.Threading.Thread.Sleep(delaySeconds * 1000);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi chạy ứng dụng: {ex.Message}", "Lỗi");
                }

            }
            else
            {
                MessageBox.Show($"Không tìm thấy file: {appPath}", "Lỗi");
            }
        }
        // Hàm mở folder location
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            string pathNew = Application.StartupPath;
            string folderPath = System.IO.Path.Combine(pathNew, "runtimes", "win", "lib", "net7.0", "System", "mm");
            if (System.IO.Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show($"Không tìm thấy thư mục: {folderPath}", "Lỗi");
            }
        }
        //Hàm mở folder location trong local 
        private void btnOpenSquadsFolder_Click(object sender, EventArgs e)
        {
            string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string folderPath = System.IO.Path.Combine(localAppDataPath, "EA SPORTS FC 25", "settings");
            if (System.IO.Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show($"Không tìm thấy thư mục: {folderPath}", "Lỗi");
            }
        }
        private void btnCopySquad_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            string sourcePath = Path.Combine(path, "batch");

            string localPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string destinationPath = System.IO.Path.Combine(localPath, "EA SPORTS FC 25", "settings");
            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại!", "Lỗi");
                return;
            }

            // Tạo thư mục đích nếu chưa tồn tại
            Directory.CreateDirectory(destinationPath);

            // Lấy tất cả các file trong thư mục nguồn
            string[] files = Directory.GetFiles(sourcePath);

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);

                if (fileName.IndexOf("squads", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    string destFile = Path.Combine(destinationPath, fileName);
                    File.Copy(file, destFile, true); // Ghi đè nếu file đã tồn tại
                }
            }
            MessageBox.Show("Đã sao chép squads thành công!", "Thông báo");
        }

        public static string GetFC25ProfileName()
        {
            string patha = Application.StartupPath;
            string jsonPath = System.IO.Path.Combine(patha, "runtimes", "win", "lib", "net7.0", "System", "mm", "FIFA Mod Manager.json");
            var json = File.ReadAllText(jsonPath);
            var root = JObject.Parse(json);

            var profileName = root["Profiles"]?["FC25"]?[0]?["Name"]?.ToString();
            return profileName ?? "(No profile found)";
        }
        public static int CountAppliedMods()
        {
            string patha = Application.StartupPath;
            string jsonPath = System.IO.Path.Combine(patha, "runtimes", "win", "lib", "net7.0", "System", "mm", "FIFA Mod Manager.json");
            var json = File.ReadAllText(jsonPath);
            var root = JObject.Parse(json);

            var mods = root["Profiles"]?["FC25"]?[0]?["AppliedMods"] as JArray;
            return mods?.Count ?? 0;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

            ConfigManager.Config.LastButtonClick = DateTime.Now;
            ConfigManager.Save();
            labelLastestRestore.Text = ConfigManager.Config.LastButtonClick.ToString("dd-MM-yyyy HH:mm");

            // copy 2 files json from backup folder to txtPath1 path\
            string path = Application.StartupPath;
            string jsonFilePath = System.IO.Path.Combine(path, "runtimes", "win", "lib", "net7.0", "System", "mm", "backup_json_profile", "FIFA Mod Manager.json");
            string jsonFilePath2 = System.IO.Path.Combine(path, "runtimes", "win", "lib", "net7.0", "System", "mm", "backup_json_profile", "FIFA Mod Manager.json.bak");
            string backupFilePath = System.IO.Path.Combine(path, "runtimes", "win", "lib", "net7.0", "System", "mm", "backup_json_profile");
            string restoreFilePath = System.IO.Path.Combine(path, "runtimes", "win", "lib", "net7.0", "System", "mm");
            if (!System.IO.Directory.Exists(backupFilePath))
            {
                MessageBox.Show("Thư mục sao lưu không tồn tại!", "Lỗi");
            }
            // copy 2 files json from backup folder to txtPath1 path\
            try
            {
                System.IO.File.Copy(jsonFilePath, restoreFilePath + @"\FIFA Mod Manager.json", true);
                System.IO.File.Copy(jsonFilePath2, restoreFilePath + @"\FIFA Mod Manager.json.bak", true);
                MessageBox.Show("Đã khôi phục thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khôi phục: {ex.Message}", "Lỗi");
            }
        }
    }
}
