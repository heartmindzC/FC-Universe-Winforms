using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FC_Universe_Winforms.Manager;

namespace FC_Universe_Winforms
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            pictureBoxLanguageVN.Visible = false;
            ConfigManager.Load();
            cbLanguage.SelectedItem = ConfigManager.Config.Language;
        }
        public void UpdateLanguage()
        {
            foreach (Control ctrl in this.Controls)
            {
                ApplyLanguage(ctrl);
            }
        }

        private void ApplyLanguage(Control ctrl)
        {
            if (ctrl.Tag != null)
            {
                string key = ctrl.Tag.ToString();
                ctrl.Text = LanguageManager.GetText(key);
            }

            // Nếu control chứa các control con (Panel, GroupBox, TabPage...)
            foreach (Control child in ctrl.Controls)
            {
                ApplyLanguage(child);
            }
        }


        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelLanguage.Text = cbLanguage.Text;
            ConfigManager.Config.Language = cbLanguage.Text;
            ConfigManager.Save();
            if (labelLanguage.Text == "English")
            {
                LanguageManager.SetLanguage("English");
                pictureBoxLanguage.Visible = true;
                pictureBoxLanguageVN.Visible = false;
                UpdateLanguage();

            }
            else
            {
                LanguageManager.SetLanguage("Vietnamese");
                pictureBoxLanguage.Visible = false;
                pictureBoxLanguageVN.Visible = true;
                UpdateLanguage();

            }
            
        }
    }
}
