namespace FC_Universe_Winforms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelGradientNavBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            panelSelecting = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox1 = new PictureBox();
            btnDownload = new FontAwesome.Sharp.IconButton();
            btnNews = new FontAwesome.Sharp.IconButton();
            btnQA = new FontAwesome.Sharp.IconButton();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panelGradientBackground = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            btnClose = new FontAwesome.Sharp.IconButton();
            timer1 = new System.Windows.Forms.Timer(components);
            panelGradientNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelGradientBackground.SuspendLayout();
            SuspendLayout();
            // 
            // panelGradientNavBar
            // 
            panelGradientNavBar.BorderColor = Color.FromArgb(55, 55, 55);
            panelGradientNavBar.BorderThickness = 1;
            panelGradientNavBar.Controls.Add(panelSelecting);
            panelGradientNavBar.Controls.Add(pictureBox1);
            panelGradientNavBar.Controls.Add(btnDownload);
            panelGradientNavBar.Controls.Add(btnNews);
            panelGradientNavBar.Controls.Add(btnQA);
            panelGradientNavBar.Controls.Add(btnSettings);
            panelGradientNavBar.Controls.Add(btnHome);
            panelGradientNavBar.CustomizableEdges = customizableEdges3;
            panelGradientNavBar.Dock = DockStyle.Left;
            panelGradientNavBar.FillColor = Color.Black;
            panelGradientNavBar.FillColor2 = Color.FromArgb(64, 73, 94);
            panelGradientNavBar.FillColor3 = Color.Black;
            panelGradientNavBar.FillColor4 = Color.FromArgb(64, 73, 94);
            panelGradientNavBar.Location = new Point(0, 0);
            panelGradientNavBar.Name = "panelGradientNavBar";
            panelGradientNavBar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelGradientNavBar.Size = new Size(74, 720);
            panelGradientNavBar.TabIndex = 0;
            // 
            // panelSelecting
            // 
            panelSelecting.BackColor = Color.Transparent;
            panelSelecting.BorderRadius = 8;
            panelSelecting.CustomizableEdges = customizableEdges1;
            panelSelecting.FillColor = Color.FromArgb(232, 186, 59);
            panelSelecting.Location = new Point(-13, 150);
            panelSelecting.Name = "panelSelecting";
            panelSelecting.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelSelecting.Size = new Size(19, 46);
            panelSelecting.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo_bo_tròn;
            pictureBox1.Location = new Point(8, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.Transparent;
            btnDownload.FlatAppearance.BorderSize = 0;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnDownload.IconColor = Color.FromArgb(242, 238, 230);
            btnDownload.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnDownload.IconSize = 42;
            btnDownload.Location = new Point(12, 243);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(57, 64);
            btnDownload.TabIndex = 4;
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.MouseEnter += btnNavBar_MouseEnter;
            btnDownload.MouseLeave += btnNavBar_MouseLeave;
            // 
            // btnNews
            // 
            btnNews.BackColor = Color.Transparent;
            btnNews.FlatAppearance.BorderSize = 0;
            btnNews.FlatStyle = FlatStyle.Flat;
            btnNews.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnNews.IconColor = Color.FromArgb(242, 238, 230);
            btnNews.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnNews.IconSize = 42;
            btnNews.Location = new Point(12, 457);
            btnNews.Name = "btnNews";
            btnNews.Size = new Size(57, 64);
            btnNews.TabIndex = 3;
            btnNews.UseVisualStyleBackColor = false;
            btnNews.MouseEnter += btnNavBar_MouseEnter;
            btnNews.MouseLeave += btnNavBar_MouseLeave;
            // 
            // btnQA
            // 
            btnQA.BackColor = Color.Transparent;
            btnQA.FlatAppearance.BorderSize = 0;
            btnQA.FlatStyle = FlatStyle.Flat;
            btnQA.IconChar = FontAwesome.Sharp.IconChar.Question;
            btnQA.IconColor = Color.FromArgb(242, 238, 230);
            btnQA.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnQA.IconSize = 42;
            btnQA.Location = new Point(12, 352);
            btnQA.Name = "btnQA";
            btnQA.Size = new Size(57, 64);
            btnQA.TabIndex = 2;
            btnQA.UseVisualStyleBackColor = false;
            btnQA.MouseEnter += btnNavBar_MouseEnter;
            btnQA.MouseLeave += btnNavBar_MouseLeave;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnSettings.IconColor = Color.FromArgb(242, 238, 230);
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSettings.IconSize = 42;
            btnSettings.Location = new Point(12, 563);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(57, 64);
            btnSettings.TabIndex = 1;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            btnSettings.MouseEnter += btnNavBar_MouseEnter;
            btnSettings.MouseLeave += btnNavBar_MouseLeave;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHome.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnHome.IconColor = Color.FromArgb(232, 186, 59);
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnHome.IconSize = 42;
            btnHome.Location = new Point(10, 141);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(57, 64);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            btnHome.MouseEnter += btnNavBar_MouseEnter;
            btnHome.MouseLeave += btnNavBar_MouseLeave;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            guna2BorderlessForm1.BorderRadius = 20;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelGradientBackground
            // 
            panelGradientBackground.BorderColor = Color.FromArgb(55, 55, 55);
            panelGradientBackground.Controls.Add(btnClose);
            panelGradientBackground.CustomizableEdges = customizableEdges5;
            panelGradientBackground.Dock = DockStyle.Right;
            panelGradientBackground.FillColor = Color.FromArgb(29, 30, 36);
            panelGradientBackground.FillColor2 = Color.FromArgb(46, 47, 54);
            panelGradientBackground.FillColor3 = Color.Black;
            panelGradientBackground.FillColor4 = Color.FromArgb(90, 58, 40);
            panelGradientBackground.Location = new Point(73, 0);
            panelGradientBackground.Name = "panelGradientBackground";
            panelGradientBackground.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelGradientBackground.Size = new Size(1207, 720);
            panelGradientBackground.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 30;
            btnClose.Location = new Point(1141, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 47);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelGradientNavBar);
            Controls.Add(panelGradientBackground);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FC Universe Modding Management";
            panelGradientNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelGradientBackground.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelGradientNavBar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelGradientBackground;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnQA;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnNews;
        private FontAwesome.Sharp.IconButton btnDownload;
        private PictureBox pictureBox1;
        private Home home1;
        private Guna.UI2.WinForms.Guna2Panel panelSelecting;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Timer timer1;
    }
}
