using System.Drawing.Drawing2D;
using System.Drawing;
using FontAwesome.Sharp;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FC_Universe_Winforms
{
    public partial class Main : Form
    {
        Settings settings1 = new Settings();
        LoadingScreen loadingScreen1 = new LoadingScreen();
        public Main()
        {
            InitializeComponent();

            panelGradientBackground.Controls.Add(settings1);
            panelGradientBackground.Controls.Add(loadingScreen1);

            settings1.Visible = false;
            settings1.Dock = DockStyle.Left;
            settings1.Width = 1207;
            loadingScreen1.Dock = DockStyle.Left;
            loadingScreen1.Width = 1207;

            // Ban đầu chỉ hiển thị loading

            btnClose.BringToFront();
            panelSelecting.Location = new Point(panelSelecting.Location.X, btnHome.Location.Y + 5);
            btnHome.IconColor = Color.FromArgb(232, 186, 59);

            // Timer để delay 3s rồi chuyển qua home2
            
            timer1.Interval = 3000; // 3 giây
            timer1.Tick += (s, e) =>
            {
                timer1.Stop();
                loadingScreen1.Visible = false;
                settings1.Visible = false;
                btnClose.BringToFront();

            };
            timer1.Start();

        }
   
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.IconSize = 36;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconSize = 30;
        }

        private void btnNavBar_MouseEnter(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.IconSize = 48;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnNavBar_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.IconSize = 42;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private async void btnSettings_Click(object sender, EventArgs e)
        {



           
            loadingScreen1.BringToFront();
            loadingScreen1.Refresh();
            await Task.Run(() =>
            {
                // Load dữ liệu, gọi API, khởi tạo control nặng...

                System.Threading.Thread.Sleep(1500); // giả lập
            });
            loadingScreen1.Hide();

            settings1.Show();
            btnHome.IconColor = Color.FromArgb(242, 238, 230);
            panelSelecting.Location = new Point(panelSelecting.Location.X, btnSettings.Location.Y + 5);
            btnSettings.IconColor = Color.FromArgb(232, 186, 59);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                   activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //childForm.Width = 1207;
            childForm.Visible = false;
            panelGradientBackground.SuspendLayout();
            panelGradientBackground.Controls.Add(childForm);
            panelGradientBackground.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panelGradientBackground.ResumeLayout();
            childForm.Visible = true;
            
        }
        private async void btnHome_Click(object sender, EventArgs e)
        {

            openChildForm(new Home());
            settings1.Hide();
            btnClose.BringToFront();
            btnSettings.IconColor = Color.FromArgb(242, 238, 230);
            panelSelecting.Location = new Point(panelSelecting.Location.X, btnHome.Location.Y + 5);
            btnHome.IconColor = Color.FromArgb(232, 186, 59);


            //loadingScreen1.Visible = true;
            //loadingScreen1.BringToFront();
            //loadingScreen1.Refresh();
            //home2.Visible = false;


            //// Load data trong Home (tốn thời gian)
            ////await Task.Run(() => home2.InitData());

            //// Hide loading, show home






        }



    }
}
