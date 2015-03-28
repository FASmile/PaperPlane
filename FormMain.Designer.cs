using System.Drawing;

namespace PaperPlane
{
    partial class gMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gMain));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.RezieForm = new System.Windows.Forms.Timer(this.components);
            this.plVideo = new System.Windows.Forms.Panel();
            this.plControl = new System.Windows.Forms.Panel();
            this.btConfig = new System.Windows.Forms.PictureBox();
            this.btVol = new System.Windows.Forms.PictureBox();
            this.btSeekForward = new System.Windows.Forms.PictureBox();
            this.btSeekBackward = new System.Windows.Forms.PictureBox();
            this.btNext = new System.Windows.Forms.PictureBox();
            this.btOpen = new System.Windows.Forms.PictureBox();
            this.btStop = new System.Windows.Forms.PictureBox();
            this.btMenu = new System.Windows.Forms.PictureBox();
            this.btPrev = new System.Windows.Forms.PictureBox();
            this.btPlay = new System.Windows.Forms.PictureBox();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.plHeader = new System.Windows.Forms.Panel();
            this.btMini = new System.Windows.Forms.PictureBox();
            this.btMaxi = new System.Windows.Forms.PictureBox();
            this.btCloseForm = new System.Windows.Forms.PictureBox();
            this.pIcon = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.plRight = new System.Windows.Forms.Panel();
            this.plLeft = new System.Windows.Forms.Panel();
            this.plTop = new System.Windows.Forms.Panel();
            this.plBot = new System.Windows.Forms.Panel();
            this.plControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSeekForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSeekBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPlay)).BeginInit();
            this.plHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RezieForm
            // 
            this.RezieForm.Interval = 1;
            this.RezieForm.Tick += new System.EventHandler(this.RezieForm_Tick);
            // 
            // plVideo
            // 
            this.plVideo.AllowDrop = true;
            this.plVideo.BackColor = System.Drawing.Color.Transparent;
            this.plVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plVideo.Enabled = false;
            this.plVideo.Location = new System.Drawing.Point(43, 45);
            this.plVideo.Margin = new System.Windows.Forms.Padding(0);
            this.plVideo.Name = "plVideo";
            this.plVideo.Size = new System.Drawing.Size(404, 190);
            this.plVideo.TabIndex = 5;
            this.plVideo.Click += new System.EventHandler(this.plVideo_Click);
            this.plVideo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.plVideo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.plVideo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // plControl
            // 
            this.plControl.BackColor = System.Drawing.Color.Transparent;
            this.plControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plControl.BackgroundImage")));
            this.plControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plControl.Controls.Add(this.btConfig);
            this.plControl.Controls.Add(this.btVol);
            this.plControl.Controls.Add(this.btSeekForward);
            this.plControl.Controls.Add(this.btSeekBackward);
            this.plControl.Controls.Add(this.btNext);
            this.plControl.Controls.Add(this.btOpen);
            this.plControl.Controls.Add(this.btStop);
            this.plControl.Controls.Add(this.btMenu);
            this.plControl.Controls.Add(this.btPrev);
            this.plControl.Controls.Add(this.btPlay);
            this.plControl.Controls.Add(this.lbEndTime);
            this.plControl.Controls.Add(this.progress);
            this.plControl.Controls.Add(this.lbCurrentTime);
            this.plControl.Location = new System.Drawing.Point(43, 235);
            this.plControl.Name = "plControl";
            this.plControl.Size = new System.Drawing.Size(404, 52);
            this.plControl.TabIndex = 20;
            this.plControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.plControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.plControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btConfig
            // 
            this.btConfig.Image = global::PaperPlane.Properties.Resources.config;
            this.btConfig.Location = new System.Drawing.Point(41, 17);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(32, 32);
            this.btConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btConfig.TabIndex = 29;
            this.btConfig.TabStop = false;
            this.btConfig.Visible = false;
            // 
            // btVol
            // 
            this.btVol.Image = global::PaperPlane.Properties.Resources.media_podcast;
            this.btVol.Location = new System.Drawing.Point(324, 15);
            this.btVol.Name = "btVol";
            this.btVol.Size = new System.Drawing.Size(32, 32);
            this.btVol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btVol.TabIndex = 28;
            this.btVol.TabStop = false;
            this.btVol.Visible = false;
            this.btVol.Click += new System.EventHandler(this.btVol_Click);
            // 
            // btSeekForward
            // 
            this.btSeekForward.Image = ((System.Drawing.Image)(resources.GetObject("btSeekForward.Image")));
            this.btSeekForward.Location = new System.Drawing.Point(273, 15);
            this.btSeekForward.Name = "btSeekForward";
            this.btSeekForward.Size = new System.Drawing.Size(32, 32);
            this.btSeekForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btSeekForward.TabIndex = 26;
            this.btSeekForward.TabStop = false;
            this.btSeekForward.Click += new System.EventHandler(this.btSeekForward_Click);
            // 
            // btSeekBackward
            // 
            this.btSeekBackward.Image = ((System.Drawing.Image)(resources.GetObject("btSeekBackward.Image")));
            this.btSeekBackward.Location = new System.Drawing.Point(89, 17);
            this.btSeekBackward.Name = "btSeekBackward";
            this.btSeekBackward.Size = new System.Drawing.Size(32, 32);
            this.btSeekBackward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btSeekBackward.TabIndex = 24;
            this.btSeekBackward.TabStop = false;
            this.btSeekBackward.Click += new System.EventHandler(this.btSeekBackward_Click);
            // 
            // btNext
            // 
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNext.Image = ((System.Drawing.Image)(resources.GetObject("btNext.Image")));
            this.btNext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btNext.Location = new System.Drawing.Point(237, 15);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(32, 32);
            this.btNext.TabIndex = 21;
            this.btNext.TabStop = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btOpen
            // 
            this.btOpen.BackColor = System.Drawing.Color.Transparent;
            this.btOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOpen.Image = ((System.Drawing.Image)(resources.GetObject("btOpen.Image")));
            this.btOpen.InitialImage = ((System.Drawing.Image)(resources.GetObject("btOpen.InitialImage")));
            this.btOpen.Location = new System.Drawing.Point(362, 16);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(32, 32);
            this.btOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btOpen.TabIndex = 22;
            this.btOpen.TabStop = false;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btStop
            // 
            this.btStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btStop.Image = ((System.Drawing.Image)(resources.GetObject("btStop.Image")));
            this.btStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btStop.Location = new System.Drawing.Point(201, 15);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(32, 32);
            this.btStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btStop.TabIndex = 21;
            this.btStop.TabStop = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btMenu
            // 
            this.btMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMenu.Image = ((System.Drawing.Image)(resources.GetObject("btMenu.Image")));
            this.btMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btMenu.Location = new System.Drawing.Point(11, 20);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(25, 25);
            this.btMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btMenu.TabIndex = 21;
            this.btMenu.TabStop = false;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // btPrev
            // 
            this.btPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPrev.Image = ((System.Drawing.Image)(resources.GetObject("btPrev.Image")));
            this.btPrev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btPrev.Location = new System.Drawing.Point(127, 15);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(32, 32);
            this.btPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btPrev.TabIndex = 21;
            this.btPrev.TabStop = false;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btPlay
            // 
            this.btPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPlay.Image = ((System.Drawing.Image)(resources.GetObject("btPlay.Image")));
            this.btPlay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btPlay.Location = new System.Drawing.Point(164, 15);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(32, 32);
            this.btPlay.TabIndex = 21;
            this.btPlay.TabStop = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbEndTime.Location = new System.Drawing.Point(348, 0);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(51, 13);
            this.lbEndTime.TabIndex = 19;
            this.lbEndTime.Text = "00:00:00";
            this.lbEndTime.Click += new System.EventHandler(this.lbEndTime_Click);
            this.lbEndTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.lbEndTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.lbEndTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.progress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progress.ForeColor = System.Drawing.Color.ForestGreen;
            this.progress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progress.Location = new System.Drawing.Point(54, 4);
            this.progress.MarqueeAnimationSpeed = 10000;
            this.progress.Maximum = 1000;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(296, 10);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress.TabIndex = 17;
            this.progress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.progress_MouseUp);
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbCurrentTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCurrentTime.Location = new System.Drawing.Point(1, 4);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(51, 13);
            this.lbCurrentTime.TabIndex = 18;
            this.lbCurrentTime.Text = "00:00:00";
            this.lbCurrentTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.lbCurrentTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.lbCurrentTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // plHeader
            // 
            this.plHeader.BackColor = System.Drawing.Color.Transparent;
            this.plHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plHeader.BackgroundImage")));
            this.plHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plHeader.Controls.Add(this.btMini);
            this.plHeader.Controls.Add(this.btMaxi);
            this.plHeader.Controls.Add(this.btCloseForm);
            this.plHeader.Controls.Add(this.pIcon);
            this.plHeader.Controls.Add(this.lbTitle);
            this.plHeader.Location = new System.Drawing.Point(43, 22);
            this.plHeader.Margin = new System.Windows.Forms.Padding(0);
            this.plHeader.Name = "plHeader";
            this.plHeader.Size = new System.Drawing.Size(404, 23);
            this.plHeader.TabIndex = 19;
            this.plHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.plHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.plHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btMini
            // 
            this.btMini.Image = global::PaperPlane.Properties.Resources.appbar_window_minimize;
            this.btMini.Location = new System.Drawing.Point(325, 0);
            this.btMini.Name = "btMini";
            this.btMini.Size = new System.Drawing.Size(25, 23);
            this.btMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btMini.TabIndex = 22;
            this.btMini.TabStop = false;
            this.btMini.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btMaxi
            // 
            this.btMaxi.BackColor = System.Drawing.Color.Transparent;
            this.btMaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMaxi.Image = global::PaperPlane.Properties.Resources.appbar_window_maximize;
            this.btMaxi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btMaxi.Location = new System.Drawing.Point(351, -1);
            this.btMaxi.Name = "btMaxi";
            this.btMaxi.Size = new System.Drawing.Size(25, 23);
            this.btMaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btMaxi.TabIndex = 21;
            this.btMaxi.TabStop = false;
            this.btMaxi.Click += new System.EventHandler(this.btMiniForm_Click);
            // 
            // btCloseForm
            // 
            this.btCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCloseForm.Image = global::PaperPlane.Properties.Resources.close;
            this.btCloseForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btCloseForm.Location = new System.Drawing.Point(383, 0);
            this.btCloseForm.Name = "btCloseForm";
            this.btCloseForm.Size = new System.Drawing.Size(20, 20);
            this.btCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btCloseForm.TabIndex = 21;
            this.btCloseForm.TabStop = false;
            this.btCloseForm.Click += new System.EventHandler(this.btCloseForm_Click);
            // 
            // pIcon
            // 
            this.pIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pIcon.Image = ((System.Drawing.Image)(resources.GetObject("pIcon.Image")));
            this.pIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pIcon.Location = new System.Drawing.Point(0, -3);
            this.pIcon.Name = "pIcon";
            this.pIcon.Size = new System.Drawing.Size(30, 30);
            this.pIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pIcon.TabIndex = 19;
            this.pIcon.TabStop = false;
            this.pIcon.Click += new System.EventHandler(this.ptIcon_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel);
            this.lbTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTitle.Location = new System.Drawing.Point(32, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTitle.Size = new System.Drawing.Size(292, 20);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Paper Plane";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.DoubleClick += new System.EventHandler(this.btMiniForm_Click);
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.lbTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.lbTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // plRight
            // 
            this.plRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.plRight.Enabled = false;
            this.plRight.Location = new System.Drawing.Point(476, 0);
            this.plRight.Margin = new System.Windows.Forms.Padding(5);
            this.plRight.Name = "plRight";
            this.plRight.Size = new System.Drawing.Size(17, 315);
            this.plRight.TabIndex = 21;
            // 
            // plLeft
            // 
            this.plLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plLeft.Enabled = false;
            this.plLeft.Location = new System.Drawing.Point(0, 0);
            this.plLeft.Name = "plLeft";
            this.plLeft.Size = new System.Drawing.Size(21, 315);
            this.plLeft.TabIndex = 22;
            // 
            // plTop
            // 
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Enabled = false;
            this.plTop.Location = new System.Drawing.Point(21, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(455, 15);
            this.plTop.TabIndex = 23;
            // 
            // plBot
            // 
            this.plBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBot.Enabled = false;
            this.plBot.Location = new System.Drawing.Point(21, 298);
            this.plBot.Name = "plBot";
            this.plBot.Size = new System.Drawing.Size(455, 17);
            this.plBot.TabIndex = 24;
            // 
            // gMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 315);
            this.Controls.Add(this.plBot);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.plLeft);
            this.Controls.Add(this.plRight);
            this.Controls.Add(this.plControl);
            this.Controls.Add(this.plHeader);
            this.Controls.Add(this.plVideo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::PaperPlane.Resources.Resource1.Paper_plane;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "gMain";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paper Plane - FASmile";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.Resize += new System.EventHandler(this.RezieForm_Tick);
            this.plControl.ResumeLayout(false);
            this.plControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSeekForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSeekBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPlay)).EndInit();
            this.plHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plVideo;
        private System.Windows.Forms.Panel plHeader;
        private System.Windows.Forms.PictureBox pIcon;
        private System.Windows.Forms.Panel plControl;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.PictureBox btCloseForm;
        private System.Windows.Forms.PictureBox btMaxi;
        private System.Windows.Forms.PictureBox btNext;
        private System.Windows.Forms.PictureBox btOpen;
        private System.Windows.Forms.PictureBox btStop;
        private System.Windows.Forms.PictureBox btMenu;
        private System.Windows.Forms.PictureBox btPrev;
        private System.Windows.Forms.PictureBox btPlay;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox btSeekBackward;
        private System.Windows.Forms.PictureBox btSeekForward;
        private System.Windows.Forms.PictureBox btMini;
        private System.Windows.Forms.PictureBox btVol;
        private System.Windows.Forms.Timer RezieForm;
        private System.Windows.Forms.Panel plRight;
        private System.Windows.Forms.Panel plLeft;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Panel plBot;
        private System.Windows.Forms.PictureBox btConfig;
    }
}

