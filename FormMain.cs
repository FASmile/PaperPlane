using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using System.Diagnostics;

namespace PaperPlane
{

    public partial class gMain : Form
    {
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;

        private object senders = null;
        private EventArgs es = null;

        private bool dragging;
        private Point pointClicked;

        OpenFileDialog openFileDialog = new OpenFileDialog();
        cMedia mMedia = null;

        cListview mList;
        PopupMenu menu;

        bool FullScreen = false;
        bool panelEvent = false;

        MenuItem mnLoop, mnMenu, mnFull;

        Form VolForm = new Form();
        public gMain(string[] data)
        {

            InitializeComponent();

            TrayMenu.Create();

            mList = new cListview(this);
            mList.Listview.DoubleClick += Listview_DoubleClick;
            mList.Listview.MouseUp +=Listview_MouseUp;

            openFileDialog.Multiselect = true;
            mMedia = new cMedia(this, this.plVideo, this.lbTitle, this.progress, this.lbCurrentTime, this.lbEndTime);

            menu = new PopupMenu();
            menu.Add_Item("Open File", new EventHandler(btOpen_Click));
            menu.Add_Item("Add File", new EventHandler(btAdd_Click));
            mnLoop = menu.Add_Item("Repeat", new EventHandler(Loop_Event));
            mnMenu = menu.Add_Item("Show Menu", new EventHandler(btMenu_Click));
            mnFull = menu.Add_Item("Full Screen", new EventHandler(btFullScreen));

            if (data.Length > 0)
            {
                for (int i = 0; i < data.Length; i++)
                    mMedia.Add_File(data[i]);
                btPlay_Click(senders, es);
                
            }

            AllowDrop = true;
        }

        void Listview_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                menu.Show(mList.Listview, e);
        }

        void Listview_DoubleClick(object sender, EventArgs e)
        {
            mMedia.Stop();            
            mMedia.LoadFile(mList.Listview.SelectedItems[0].Index);
            btPlay_Click(senders, es);
        }

        ~gMain()
        {
            
        }
        //=====================================================================
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.F11):
                    {
                        //btFullScreen(senders, es);
                        btFullScreen(senders, es);

                        break;
                    }
                case Keys.Escape:
                    {
                        btFullScreen(senders, es);
                        break;
                    }
                case Keys.Space:
                    {
                        btPlay_Click(senders, es);
                        break;
                    }
                case (Keys.Control | Keys.O):
                    {
                        object a = new object();
                        EventArgs b = new EventArgs();
                        btOpen_Click(a, b);
                        break;
                    }
                case (Keys.Left):
                    {
                        mMedia.Decrease_Pos(10);
                        break;
                    }
                case (Keys.Right):
                    {
                        mMedia.Increase_Pos(10);
                        break;
                    }
                case (Keys.Up):
                    {
                        mMedia.Increase_Volume(100);
                        break;
                    }
                case (Keys.Down):
                    {
                        mMedia.Decrease_Volume(100);
                        break;
                    }

                case (Keys.Control | Keys.Right):
                    {
                        btNext_Click(senders, es);
                        break;
                    }
                case (Keys.Control | Keys.Left):
                    {
                        btPrev_Click(senders, es);
                        break;
                    }
                case (Keys.Control | Keys.Up):
                    {
                        btMenu_Click(senders, es);
                        break;
                    }
                case (Keys.Control | Keys.Down):
                    {
                        //btPrev_Click(senders, es);
                        break;
                    }
            }
            return true;
        }
        #region Resize for Winform
        ReSize resize = new ReSize();
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        //set MinimumSize to Form
        public override Size MinimumSize
        {
            get
            {
                return base.MinimumSize;
            }
            set
            {
                base.MinimumSize = new Size(350, 82);
            }
        }

        //
        //override  WndProc  
        //
        protected override void WndProc(ref Message m)
        {
            //****************************************************************************
            if (!FullScreen) 
            { 
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);               //get x mouse position
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);   //get y mouse position  you can gave (x,y) it from "MouseEventArgs" too
                Point pt = PointToClient(new Point(x, y));

                if (m.Msg == 0x84)
                {
                    switch (resize.getMosuePosition(pt, this))
                    {
                        case "l": m.Result = (IntPtr)10; return;  // the Mouse on Left Form
                        case "r": m.Result = (IntPtr)11; return;  // the Mouse on Right Form
                        case "a": m.Result = (IntPtr)12; return;
                        case "la": m.Result = (IntPtr)13; return;
                        case "ra": m.Result = (IntPtr)14; return;
                        case "u": m.Result = (IntPtr)15; return;
                        case "lu": m.Result = (IntPtr)16; return;
                        case "ru": m.Result = (IntPtr)17; return; // the Mouse on Right_Under Form
                        case "": m.Result = pt.Y < 32 /*mouse on title Bar*/ ? (IntPtr)2 : (IntPtr)1; return;
                    }
                }
            }
            base.WndProc(ref m);

        }
        #endregion
        //=====================================================================
        #region Draw WinForm
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                pointClicked = new Point(e.X, e.Y);
            }
            else
            {
                dragging = false;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                menu.Show(plHeader, e);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point pointMoveTo;
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));
                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);
                this.Location = pointMoveTo;
            }
        }
        #endregion

        private void btCloseForm_Click(object sender, EventArgs e)
        {

            //Application.Exit();
            this.Close();
        }

        private void btMiniForm_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }
        //===============================================================================
        private void btOpen_Click(object sender, EventArgs e)
        {
            // Set filter options and filter index.
            openFileDialog.Filter = "Support File|*.mp3;*.mkv;*.mp4;*.flv|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            openFileDialog.Multiselect = true;

            // Process input if the user clicked OK.
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mMedia.LoadList(openFileDialog.FileNames);
                btPlay_Click(sender, e);

                mList.LoadData(mMedia.Get_List(), mMedia.Get_MaxList());
                mList.Update();
            }
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            if (mMedia.Get_Flag() == "Paused" || mMedia.Get_Flag() == "Stopped")
            {
                mMedia.Play();
                btPlay.Image = (System.Drawing.Image)(Resources.Resource1.media_playback_pause);
            }
            else if (mMedia.Get_Flag() == "Played")
            {

                mMedia.Pause();
                btPlay.Image = (System.Drawing.Image)(Resources.Resource1.media_playback_start);
            }
            else
                btOpen_Click(sender, e);
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            mMedia.Prev();
            btPlay_Click(sender, e);
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            mMedia.Next();
            btPlay_Click(sender, e);
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            if (mMedia.Get_Flag() == "Played" || mMedia.Get_Flag() == "Paused")
            { 
                btPlay.Image = (System.Drawing.Image)(Resources.Resource1.media_playback_start);
                mMedia.Set_CurrentTime(0);
                this.progress.Value = 0;
                this.lbCurrentTime.Text = "00:00:00";
                mMedia.Stop();
            }
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            mList.LoadData(mMedia.Get_List(), mMedia.Get_MaxList());
            
            if (mList.Show())
                mnMenu.Text = "Hide menu";
            else
                mnMenu.Text = "Show menu";
        }

        private void ptIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Paper Media Player\t\nAuthor: Luong The Hai\nNickname: FASmile", "About:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btSeekForward_Click(object sender, EventArgs e)
        {
            mMedia.IncreateSeek();
        }

        private void btSeekBackward_Click(object sender, EventArgs e)
        {
            mMedia.DecreateSeek();
        }

        private void progress_MouseUp(object sender, MouseEventArgs e)
        {
            if (mMedia.Get_Flag() != "None")
                mMedia.Set_CurrentTime(mMedia.Get_Duration() * ((double)e.X / this.progress.Width));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            mMedia.Set_Pos2Form();
        }

        private void RezieForm_Tick(object sender, EventArgs e)
        {
            int fWidth = this.Width, fHeight = this.Height;

            plLeft.Width = 2;
            
            plRight.Width = 2;
            
            plTop.Height = 2;
            
            plBot.Height = 2;
            

            if (!panelEvent) {
                plHeader.Width = fWidth - (plLeft.Width + plRight.Width);
                plHeader.Height = 20;
                plHeader.Left = plLeft.Width;
                plHeader.Top = plTop.Height;

                plControl.Width = fWidth - (plLeft.Width + plRight.Width);
                plControl.Height = 52;
                plControl.Top = fHeight - plControl.Height;
                plControl.Left = plLeft.Width;


                lbTitle.Width = fWidth - btMaxi.Width - btMini.Width;
                lbTitle.Left = pIcon.Left + pIcon.Width;
                //==========
                btCloseForm.Left = plHeader.Width - btCloseForm.Width - 4;
                btMaxi.Left = btCloseForm.Left - btMaxi.Width;
                btMini.Left = btMaxi.Left - btMini.Width;

                //==========
                plVideo.Top = plHeader.Height;
                plVideo.Left = 0;
                plVideo.Width = fWidth;
                plVideo.Height = fHeight - plHeader.Height - plControl.Height;

                lbEndTime.Left = fWidth - 5 - lbEndTime.Width;

                progress.Width = plHeader.Width - lbCurrentTime.Width - lbEndTime.Width;


                //==========
                btPlay.Left = fWidth / 2 - btPlay.Width;
                btPrev.Left = btPlay.Left - btPrev.Width;
                btSeekBackward.Left = btPrev.Left - btSeekBackward.Width;

                btStop.Left = btPlay.Left + btPlay.Width;
                btNext.Left = btStop.Left + btStop.Width;
                btSeekForward.Left = btNext.Left + btNext.Width;

                btOpen.Left = fWidth - btOpen.Width - 20;
                btVol.Left = btOpen.Left - btVol.Width;
            //============
            }
            else
            {
                plHeader.Height = 0;
                plControl.Height = 0;

                //==========
                //==========

                plVideo.Top = plHeader.Height;
                plVideo.Left = 0;

                plVideo.Width = fWidth;
                plVideo.Height = fHeight;
            }
            
	    
            mMedia.Update2Form();
        }

        private void lbEndTime_Click(object sender, EventArgs e)
        {
            // Xem phim online
            //http://download-a419.fshare.vn/vip/twMXOOMIxQ_foE9gInTsFqgt/Captain.America.The.First.Avenger.2011.mHD.BluRay.DD5.1.x264-EPiK.mkv
            string path = Microsoft.VisualBasic.Interaction.InputBox("Enter Link", "Test", "");
            if (path != "")
            {
                string FileName = path.Substring(path.LastIndexOf("/") + 1);

                System.Net.WebClient webClient = new System.Net.WebClient();
                webClient.DownloadFileAsync(new Uri(path), FileName);

                System.Threading.Thread.Sleep(1000 * 10);

                mMedia.LoadFile(FileName);
                mMedia.Play();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Minimized;
        }

        private void btVol_Click(object sender, EventArgs e)
        {
            VolForm.Visible = !VolForm.Visible;
            VolForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            VolForm.Left = 0;// btVol.Left;
            VolForm.Top = 0;// btVol.Top - btVol.Height - VolForm.Height;
            VolForm.Width = 50;
            VolForm.Height = 100;
            
            // ==
            TrackBar trVol = new TrackBar();
            trVol.Value = 0;
            trVol.TickStyle = TickStyle.Both;
            trVol.Orientation = Orientation.Vertical;
            
            trVol.Left = 0;
            trVol.Top = 0;
            trVol.Width = VolForm.Width;
            trVol.Height = VolForm.Height;

            VolForm.Controls.Add(trVol);
            
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            // Set filter options and filter index.
            openFileDialog.Filter = "Support File|*.mp3;*.mkv;*.mp4|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            openFileDialog.Multiselect = true;

            // Process input if the user clicked OK.
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                    mMedia.Add_File(openFileDialog.FileNames[i]);

                mList.LoadData(mMedia.Get_List(), mMedia.Get_MaxList());
                mList.Update();
            }
        }

        private void Loop_Event(object sender, EventArgs e)
        {
            if (mMedia.loop = !mMedia.loop)
                mnLoop.Text = "Unrepeat";
            else
                mnLoop.Text = "Repeat";
        }

        private void plVideo_Click(object sender, EventArgs e)
        {

        }
        
        private void btFullScreen(object sender, EventArgs e)
        {
            panelEvent = !panelEvent;
            this.TopMost = !TopMost;
            
            RezieForm_Tick(senders, es);

            if (FullScreen = !FullScreen)
            {
                this.WindowState = FormWindowState.Maximized;
                mnFull.Text = "Normal Screen";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                mnFull.Text = "Full Screen";
            }
        }
        
        //================================================================================

    }
}
