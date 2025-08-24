namespace FC_Universe_Winforms
{
    partial class Settings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            labelTitle = new Label();
            panelGradientCardTools = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            labelLanguage = new Label();
            labelCurrentLanguage = new Label();
            pictureBoxLanguageVN = new PictureBox();
            pictureBoxLanguage = new PictureBox();
            cbLanguage = new Guna.UI2.WinForms.Guna2ComboBox();
            labelDescCard = new Label();
            labelTitleCard = new Label();
            labelTypeCard = new Label();
            panelGradientCardTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLanguageVN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLanguage).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(40, 47);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(177, 54);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Settings";
            // 
            // panelGradientCardTools
            // 
            panelGradientCardTools.BackColor = Color.Transparent;
            panelGradientCardTools.BorderColor = Color.Silver;
            panelGradientCardTools.BorderRadius = 20;
            panelGradientCardTools.BorderThickness = 1;
            panelGradientCardTools.Controls.Add(labelLanguage);
            panelGradientCardTools.Controls.Add(labelCurrentLanguage);
            panelGradientCardTools.Controls.Add(pictureBoxLanguageVN);
            panelGradientCardTools.Controls.Add(pictureBoxLanguage);
            panelGradientCardTools.Controls.Add(cbLanguage);
            panelGradientCardTools.Controls.Add(labelDescCard);
            panelGradientCardTools.Controls.Add(labelTitleCard);
            panelGradientCardTools.Controls.Add(labelTypeCard);
            panelGradientCardTools.CustomizableEdges = customizableEdges3;
            panelGradientCardTools.FillColor = Color.FromArgb(63, 80, 83);
            panelGradientCardTools.FillColor2 = Color.FromArgb(46, 30, 24);
            panelGradientCardTools.FillColor3 = Color.FromArgb(28, 20, 20);
            panelGradientCardTools.FillColor4 = Color.FromArgb(0, 64, 64);
            panelGradientCardTools.Location = new Point(73, 145);
            panelGradientCardTools.Name = "panelGradientCardTools";
            panelGradientCardTools.RightToLeft = RightToLeft.No;
            panelGradientCardTools.ShadowDecoration.BorderRadius = 4;
            panelGradientCardTools.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelGradientCardTools.ShadowDecoration.Depth = 10;
            panelGradientCardTools.ShadowDecoration.Shadow = new Padding(5, 5, 5, 10);
            panelGradientCardTools.Size = new Size(561, 241);
            panelGradientCardTools.TabIndex = 4;
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            labelLanguage.ForeColor = Color.White;
            labelLanguage.Location = new Point(156, 204);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(54, 19);
            labelLanguage.TabIndex = 7;
            labelLanguage.Text = "English";
            // 
            // labelCurrentLanguage
            // 
            labelCurrentLanguage.AutoSize = true;
            labelCurrentLanguage.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            labelCurrentLanguage.ForeColor = Color.White;
            labelCurrentLanguage.Location = new Point(39, 204);
            labelCurrentLanguage.Name = "labelCurrentLanguage";
            labelCurrentLanguage.Size = new Size(122, 19);
            labelCurrentLanguage.TabIndex = 6;
            labelCurrentLanguage.Text = "Current language:";
            // 
            // pictureBoxLanguageVN
            // 
            pictureBoxLanguageVN.Image = (Image)resources.GetObject("pictureBoxLanguageVN.Image");
            pictureBoxLanguageVN.Location = new Point(219, -71);
            pictureBoxLanguageVN.Name = "pictureBoxLanguageVN";
            pictureBoxLanguageVN.Size = new Size(439, 371);
            pictureBoxLanguageVN.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLanguageVN.TabIndex = 5;
            pictureBoxLanguageVN.TabStop = false;
            pictureBoxLanguageVN.Visible = false;
            // 
            // pictureBoxLanguage
            // 
            pictureBoxLanguage.Image = Properties.Resources.closeup_union_jack_flag_copy;
            pictureBoxLanguage.Location = new Point(219, -12);
            pictureBoxLanguage.Name = "pictureBoxLanguage";
            pictureBoxLanguage.Size = new Size(396, 263);
            pictureBoxLanguage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLanguage.TabIndex = 4;
            pictureBoxLanguage.TabStop = false;
            // 
            // cbLanguage
            // 
            cbLanguage.BackColor = Color.Transparent;
            cbLanguage.CustomizableEdges = customizableEdges1;
            cbLanguage.DrawMode = DrawMode.OwnerDrawFixed;
            cbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLanguage.FocusedColor = Color.Green;
            cbLanguage.FocusedState.BorderColor = Color.Green;
            cbLanguage.Font = new Font("Segoe UI", 10F);
            cbLanguage.ForeColor = Color.FromArgb(68, 88, 112);
            cbLanguage.ItemHeight = 30;
            cbLanguage.Items.AddRange(new object[] { "English" });
            cbLanguage.Location = new Point(39, 154);
            cbLanguage.MaxDropDownItems = 2;
            cbLanguage.Name = "cbLanguage";
            cbLanguage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbLanguage.Size = new Size(140, 36);
            cbLanguage.TabIndex = 3;
            cbLanguage.SelectedIndexChanged += cbLanguage_SelectedIndexChanged;
            // 
            // labelDescCard
            // 
            labelDescCard.AutoSize = true;
            labelDescCard.Font = new Font("Segoe UI", 12F);
            labelDescCard.ForeColor = Color.White;
            labelDescCard.Location = new Point(30, 117);
            labelDescCard.Name = "labelDescCard";
            labelDescCard.Size = new Size(194, 21);
            labelDescCard.TabIndex = 2;
            labelDescCard.Text = "Switching other languages";
            // 
            // labelTitleCard
            // 
            labelTitleCard.AutoSize = true;
            labelTitleCard.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitleCard.ForeColor = Color.White;
            labelTitleCard.Location = new Point(30, 68);
            labelTitleCard.Name = "labelTitleCard";
            labelTitleCard.Size = new Size(149, 37);
            labelTitleCard.TabIndex = 1;
            labelTitleCard.Text = "Language ";
            // 
            // labelTypeCard
            // 
            labelTypeCard.AutoSize = true;
            labelTypeCard.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTypeCard.ForeColor = Color.FromArgb(232, 186, 59);
            labelTypeCard.Location = new Point(30, 25);
            labelTypeCard.Name = "labelTypeCard";
            labelTypeCard.Size = new Size(94, 32);
            labelTypeCard.TabIndex = 0;
            labelTypeCard.Text = "System";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelGradientCardTools);
            Controls.Add(labelTitle);
            Name = "Settings";
            Size = new Size(1206, 720);
            panelGradientCardTools.ResumeLayout(false);
            panelGradientCardTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLanguageVN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLanguage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Label labelTitle;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelGradientCardTools;
        private Label labelDescCard;
        private Label labelTitleCard;
        private Label labelTypeCard;
        private Guna.UI2.WinForms.Guna2ComboBox cbLanguage;
        private PictureBox pictureBoxLanguage;
        private PictureBox pictureBoxLanguageVN;
        private Label labelLanguage;
        private Label labelCurrentLanguage;
    }
}
