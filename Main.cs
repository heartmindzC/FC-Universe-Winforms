using System.Drawing.Drawing2D;
using System.Drawing;
using FontAwesome.Sharp;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FC_Universe_Winforms
{
    public partial class Main : Form
    {
        private Settings settings1;
        private LoadingScreen loadingScreen1;
        private Home home;
        private bool isHomeDataLoaded = false;
        public Main()
        {
            InitializeComponent();



            // Khởi tạo tất cả các màn hình con một lần
            settings1 = new Settings();
            loadingScreen1 = new LoadingScreen();
            home = new Home();

            // **PHẦN CẬP NHẬT QUAN TRỌNG**
            // Cấu hình các Form để có thể thêm vào Panel.
            // Đặt TopLevel = false để Form có thể hoạt động như một control con.
            settings1.TopLevel = false;
            settings1.FormBorderStyle = FormBorderStyle.None;

            loadingScreen1.TopLevel = false;
            loadingScreen1.FormBorderStyle = FormBorderStyle.None;

            home.TopLevel = false;
            home.FormBorderStyle = FormBorderStyle.None;

            // Thêm tất cả vào panel chính
            panelGradientBackground.Controls.Add(settings1);
            panelGradientBackground.Controls.Add(loadingScreen1);
            panelGradientBackground.Controls.Add(home);

            // Cấu hình thuộc tính Dock và Visible cho từng màn hình
            settings1.Dock = DockStyle.Fill;
            settings1.Visible = false;

            loadingScreen1.Dock = DockStyle.Fill;
            loadingScreen1.Visible = true; // Bắt đầu với màn hình loading

            home.Dock = DockStyle.Fill;
            home.Visible = false;

            // Cấu hình giao diện ban đầu
            btnClose.BringToFront();
            panelSelecting.Location = new Point(panelSelecting.Location.X, btnHome.Location.Y + 5);
            btnHome.IconColor = Color.FromArgb(232, 186, 59);

            // Timer để hiển thị màn hình Home sau khi loading ban đầu
            timer1.Interval = 3000; // 3 giây
            timer1.Tick += async (s, e) =>
            {
                timer1.Stop();
                await ShowHomeForm(); // Gọi hàm để hiển thị Home
            };
            timer1.Start();

        }

        private async Task ShowHomeForm()
        {
            // 1. Ẩn các màn hình khác và hiển thị loading để người dùng biết có tác vụ đang chạy
            settings1.Visible = false;
            home.Visible = false;
            loadingScreen1.Visible = true;
            loadingScreen1.BringToFront();
            btnClose.BringToFront();

            // 2. Chỉ tải dữ liệu NẾU chưa được tải trước đó (tối ưu hiệu năng)
            if (!isHomeDataLoaded)
            {
                // Gọi hàm bất đồng bộ InitDataAsync() từ form Home.cs
                // Giao diện sẽ không bị "đơ" trong lúc chờ
                await home.InitDataAsync();
                isHomeDataLoaded = true; // Đánh dấu là đã tải xong
            }

            // 3. Sau khi tải xong, ẩn loading và hiển thị màn hình Home
            home.Visible = true;
            home.BringToFront();
            loadingScreen1.Visible = false;
            btnClose.BringToFront();

            // 4. Cập nhật lại giao diện của thanh điều hướng (navigation bar)
            btnSettings.IconColor = Color.FromArgb(242, 238, 230);
            panelSelecting.Location = new Point(panelSelecting.Location.X, btnHome.Location.Y + 5);
            btnHome.IconColor = Color.FromArgb(232, 186, 59);
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

            openChildForm(new Settings());
            btnClose.BringToFront();
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

            await ShowHomeForm();


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
