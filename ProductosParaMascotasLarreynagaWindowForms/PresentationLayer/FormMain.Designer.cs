
namespace PresentationLayer
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelUserInfo = new System.Windows.Forms.Panel();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.ImageButtonMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ImageButtonClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.PictureBoxUser = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.PanelLeft.SuspendLayout();
            this.PanelUserInfo.SuspendLayout();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(25)))));
            this.PanelLeft.Controls.Add(this.PanelUserInfo);
            this.PanelLeft.Controls.Add(this.PanelButtons);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(304, 744);
            this.PanelLeft.TabIndex = 0;
            // 
            // PanelUserInfo
            // 
            this.PanelUserInfo.Controls.Add(this.PictureBoxUser);
            this.PanelUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelUserInfo.Location = new System.Drawing.Point(0, 0);
            this.PanelUserInfo.Name = "PanelUserInfo";
            this.PanelUserInfo.Size = new System.Drawing.Size(304, 131);
            this.PanelUserInfo.TabIndex = 1;
            // 
            // PanelButtons
            // 
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(0, 131);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(304, 613);
            this.PanelButtons.TabIndex = 0;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(185)))), ((int)(((byte)(174)))));
            this.PanelTop.Controls.Add(this.ImageButtonMinimize);
            this.PanelTop.Controls.Add(this.ImageButtonClose);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(34)))));
            this.PanelTop.Location = new System.Drawing.Point(304, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1062, 38);
            this.PanelTop.TabIndex = 1;
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(304, 38);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1062, 706);
            this.PanelContainer.TabIndex = 2;
            // 
            // ImageButtonMinimize
            // 
            this.ImageButtonMinimize.ActiveImage = null;
            this.ImageButtonMinimize.AllowAnimations = true;
            this.ImageButtonMinimize.AllowBuffering = false;
            this.ImageButtonMinimize.AllowToggling = false;
            this.ImageButtonMinimize.AllowZooming = true;
            this.ImageButtonMinimize.AllowZoomingOnFocus = false;
            this.ImageButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonMinimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonMinimize.ErrorImage")));
            this.ImageButtonMinimize.FadeWhenInactive = false;
            this.ImageButtonMinimize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonMinimize.Image = global::PresentationLayer.Main.chrome_minimize_main;
            this.ImageButtonMinimize.ImageActive = null;
            this.ImageButtonMinimize.ImageLocation = null;
            this.ImageButtonMinimize.ImageMargin = 0;
            this.ImageButtonMinimize.ImageSize = new System.Drawing.Size(23, 23);
            this.ImageButtonMinimize.ImageZoomSize = new System.Drawing.Size(24, 24);
            this.ImageButtonMinimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonMinimize.InitialImage")));
            this.ImageButtonMinimize.Location = new System.Drawing.Point(993, 7);
            this.ImageButtonMinimize.Name = "ImageButtonMinimize";
            this.ImageButtonMinimize.Rotation = 0;
            this.ImageButtonMinimize.ShowActiveImage = true;
            this.ImageButtonMinimize.ShowCursorChanges = true;
            this.ImageButtonMinimize.ShowImageBorders = false;
            this.ImageButtonMinimize.ShowSizeMarkers = false;
            this.ImageButtonMinimize.Size = new System.Drawing.Size(24, 24);
            this.ImageButtonMinimize.TabIndex = 1;
            this.ImageButtonMinimize.ToolTipText = "";
            this.ImageButtonMinimize.WaitOnLoad = false;
            this.ImageButtonMinimize.Zoom = 0;
            this.ImageButtonMinimize.ZoomSpeed = 10;
            this.ImageButtonMinimize.Click += new System.EventHandler(this.ImageButtonMinimize_Click);
            // 
            // ImageButtonClose
            // 
            this.ImageButtonClose.ActiveImage = null;
            this.ImageButtonClose.AllowAnimations = true;
            this.ImageButtonClose.AllowBuffering = false;
            this.ImageButtonClose.AllowToggling = false;
            this.ImageButtonClose.AllowZooming = true;
            this.ImageButtonClose.AllowZoomingOnFocus = false;
            this.ImageButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonClose.ErrorImage")));
            this.ImageButtonClose.FadeWhenInactive = false;
            this.ImageButtonClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonClose.Image = global::PresentationLayer.Main.chrome_close_main;
            this.ImageButtonClose.ImageActive = null;
            this.ImageButtonClose.ImageLocation = null;
            this.ImageButtonClose.ImageMargin = 0;
            this.ImageButtonClose.ImageSize = new System.Drawing.Size(23, 23);
            this.ImageButtonClose.ImageZoomSize = new System.Drawing.Size(24, 24);
            this.ImageButtonClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonClose.InitialImage")));
            this.ImageButtonClose.Location = new System.Drawing.Point(1031, 7);
            this.ImageButtonClose.Name = "ImageButtonClose";
            this.ImageButtonClose.Rotation = 0;
            this.ImageButtonClose.ShowActiveImage = true;
            this.ImageButtonClose.ShowCursorChanges = true;
            this.ImageButtonClose.ShowImageBorders = false;
            this.ImageButtonClose.ShowSizeMarkers = false;
            this.ImageButtonClose.Size = new System.Drawing.Size(24, 24);
            this.ImageButtonClose.TabIndex = 0;
            this.ImageButtonClose.ToolTipText = "";
            this.ImageButtonClose.WaitOnLoad = false;
            this.ImageButtonClose.Zoom = 0;
            this.ImageButtonClose.ZoomSpeed = 10;
            this.ImageButtonClose.Click += new System.EventHandler(this.ImageButtonClose_Click);
            // 
            // PictureBoxUser
            // 
            this.PictureBoxUser.AllowFocused = false;
            this.PictureBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxUser.AutoSizeHeight = true;
            this.PictureBoxUser.BorderRadius = 0;
            this.PictureBoxUser.Image = global::PresentationLayer.Main.LOGO;
            this.PictureBoxUser.IsCircle = true;
            this.PictureBoxUser.Location = new System.Drawing.Point(101, 7);
            this.PictureBoxUser.Name = "PictureBoxUser";
            this.PictureBoxUser.Size = new System.Drawing.Size(103, 103);
            this.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxUser.TabIndex = 0;
            this.PictureBoxUser.TabStop = false;
            this.PictureBoxUser.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(205)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1366, 744);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelLeft);
            this.Font = new System.Drawing.Font("Mulish", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 744);
            this.MinimumSize = new System.Drawing.Size(1364, 734);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Para Mascotas Larreynaga";
            this.PanelLeft.ResumeLayout(false);
            this.PanelUserInfo.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelTop;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonClose;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonMinimize;
        private System.Windows.Forms.Panel PanelUserInfo;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Panel PanelContainer;
        public Bunifu.UI.WinForms.BunifuPictureBox PictureBoxUser;
    }
}