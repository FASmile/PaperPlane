using System;
using System.Windows.Forms;
using System.Drawing;

using QuartzTypeLib;

namespace PaperPlane
{
    struct FileManager
    {
        public string FileDir;
        public string FileName;
        public string FileType;

    }
    class cMedia
    {
        FilgraphManagerClass Filgraph = null;
        IMediaControl MediaControl = null;
        IMediaEventEx MediaEvent = null;
        IMediaPosition MediaPosition = null;
        IVideoWindow VideoWindow = null;

        Label lbEndTime, lbCurrentTime, lbName;
        Panel plVideo;
        Form mForm;

        ProgressBar Progress;
        double duration;
        
        public cMedia()
        {

        }
        public cMedia(Form mForms, Panel plVideos, Label lbNames = null, ProgressBar ProgressBars = null, Label lbCurrentTimes = null, Label lbEndTimes = null)
        {
            LoadData(mForms, plVideos, lbNames, ProgressBars, lbCurrentTimes, lbEndTimes);
        }
        ~cMedia()
        {
            CloseInterfaces();
        }
        void InitInterfaces()
        {
            try
            {
                Filgraph = new FilgraphManagerClass();
                MediaControl = Filgraph as IMediaControl;
                MediaEvent = Filgraph as IMediaEventEx;
                MediaPosition = Filgraph as IMediaPosition;
                VideoWindow = Filgraph as IVideoWindow;

            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't start");
            }
        }
        void CloseInterfaces()
        {
            if (MediaControl != null)
            {
                MediaControl.StopWhenReady();
                MediaEvent.SetNotifyWindow((int)0, cWindowStyle.WM_GRAPHNOTIFY, (int)0);
            }
            MediaControl = null;
            MediaEvent = null;
            MediaPosition = null;

            VideoWindow = null;
            if (Filgraph != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(this.Filgraph);
            Filgraph = null;
        }
        //======================================================================================================================
        
        FileManager[] ListFile = new FileManager[1000];
        public int IDC = -1;
        public int MaxFile = 0;
        //======================================================================================================================
        public int Get_MaxList()
        {
            return MaxFile;
        }
        public FileManager[] Get_List()
        {
            return ListFile;
        }
        public void LoadList(string[] FileName)
        {
            MaxFile = FileName.Length;
            IDC = 0;
            for (int i = 0; i < MaxFile; i++)
            {
                ListFile[i].FileDir = FileName[i];
                ListFile[i].FileName = FileName[i].Substring(FileName[i].LastIndexOf("\\") + 1);
                ListFile[i].FileType = FileName[i].Substring(FileName[i].LastIndexOf(".") + 1);
            }
            LoadFile(ListFile[IDC].FileDir);
        }

        public void Add_File(string FileName)
        {
            ListFile[MaxFile].FileDir = FileName;
            ListFile[MaxFile].FileName = FileName.Substring(FileName.LastIndexOf("\\") + 1);
            ListFile[MaxFile].FileType = FileName.Substring(FileName.LastIndexOf(".") + 1);

            IDC += 1;
            MaxFile += 1;
            if (mFlag == MediaFlags.None)
            {
                mFlag = MediaFlags.Stopped;
                LoadFile(ListFile[IDC].FileDir);
            }
            
        }

        public void LoadFile(string FlieDirectory)
        {
            this.CloseInterfaces();
            this.InitInterfaces();
            int width = 0, height = 0;
            
            try
            {
                Filgraph.RenderFile(FlieDirectory);

                VideoWindow.Owner = (int)plVideo.Handle;

                width = VideoWindow.Width;
                height = VideoWindow.Height + 51;
            }
            catch (Exception e) // Bat duoc moi loai loi~. gia tri tra ve chi chung chung.
            {
                Filgraph.RenderFile(FlieDirectory);
                
            }
            finally
            {
                lbName.Text = ListFile[IDC].FileName;

                mFlag = MediaFlags.Stopped;

                Screen Desktop = Screen.PrimaryScreen;


                if (width > Desktop.WorkingArea.Width)
                {
                    width = Desktop.WorkingArea.Width;
                }

                if (height > Desktop.WorkingArea.Height)
                {
                    height = Desktop.WorkingArea.Height;
                }

                mForm.Top = (Desktop.WorkingArea.Height - height) / 2;
                mForm.Left = (Desktop.WorkingArea.Width - width) / 2;

                mForm.Width = width;
                mForm.Height = height;

                this.Update2Form();
            }
            
        }
        public void LoadFile(int FileNumber)
        {
            this.CloseInterfaces();
            this.InitInterfaces();
            int width = 0, height = 0;
            
            IDC = FileNumber;

            try
            {
                Filgraph.RenderFile(ListFile[IDC].FileDir);

                VideoWindow.Owner = (int)plVideo.Handle;

                width = VideoWindow.Width;
                height = VideoWindow.Height + 51;
            }
            catch (Exception)
            {
                Filgraph.RenderFile(ListFile[IDC].FileDir);
            }

            lbName.Text = ListFile[IDC].FileName;

            mFlag = MediaFlags.Stopped;

            Screen Desktop = Screen.PrimaryScreen;


            if (width > Desktop.WorkingArea.Width)
            {
                width = Desktop.WorkingArea.Width;
            }

            if (height > Desktop.WorkingArea.Height)
            {
                height = Desktop.WorkingArea.Height;
            }

            mForm.Top = (Desktop.WorkingArea.Height - height) / 2;
            mForm.Left = (Desktop.WorkingArea.Width - width) / 2;

            mForm.Width = width;
            mForm.Height = height;
            

            this.Update2Form();
        }

        public void LoadData(Form mForms, Panel plVideos, Label lbNames = null, ProgressBar ProgressBars = null, Label lbCurrentTimes = null, Label lbEndTimes = null)
        {
            mForm = mForms;
            lbCurrentTime = lbCurrentTimes;
            lbEndTime = lbEndTimes;
            plVideo = plVideos;
            lbName = lbNames;
            Progress = ProgressBars;

            Update2Form();
        }

        public void Update2Form()
        {

            if (MediaControl != null && mFlag != MediaFlags.None)
            {
                

                try
                {
                    VideoWindow.WindowStyle = cWindowStyle.WS_CHILD | cWindowStyle.WS_CLIPSIBLINGS | cWindowStyle.WS_CLIPCHILDREN;
                    Rectangle rc = plVideo.ClientRectangle;
                    VideoWindow.SetWindowPosition(0, 0, rc.Right, rc.Bottom);
                    MediaEvent.SetNotifyWindow((int)plVideo.Handle, cWindowStyle.WM_GRAPHNOTIFY, 0);
                    
                    VideoWindow.Width = plVideo.Width;
                    VideoWindow.Height = plVideo.Height;

                }
                catch (Exception)
                {
                }
                finally
                {
                   
                }

                duration = MediaPosition.Duration;

                lbEndTime.Text = cTime.min2Time(duration);
            }
        }
        //=========================================================================================
        
        enum MediaFlags { None, Played, Paused, Stopped }
        MediaFlags mFlag = MediaFlags.None;
        public string Get_Flag()
        {
            return mFlag.ToString();
        }
        public double Get_Duration()
        {
            return duration;
        }

        public void Set_CurrentTime(double Time)
        {
            if (MediaControl != null && mFlag == MediaFlags.Played)
            {
                MediaPosition.CurrentPosition = Time;
            }
        }
        public bool loop = false;
        public void Set_Pos2Form()
        {
            if (MediaControl != null && mFlag == MediaFlags.Played)
            {
                if (MediaPosition.CurrentPosition >= MediaPosition.Duration && !loop && IDC >= MaxFile - 1)
                {
                    Stop();
                }

                else if (MediaPosition.CurrentPosition >= MediaPosition.Duration - 1)
                {
                    Next();
                    Play();
                }
                lbCurrentTime.Text = cTime.min2Time(MediaPosition.CurrentPosition);
                Progress.Value = (int)(MediaPosition.CurrentPosition / MediaPosition.Duration * 1000);
            }
        }
        //==========================================================================================

        public void Play()
        {
            if (MediaControl != null && mFlag != MediaFlags.None)
            {
                mFlag = MediaFlags.Played;
                Update2Form();

                MediaControl.Run();

                Filgraph.Rate = (double)Seek;
                
                
            }
        }
        public void Pause()
        {
            if (MediaControl != null && mFlag != MediaFlags.None)
            {
                mFlag = MediaFlags.Paused;
                MediaControl.Pause();
            }
        }
        public void Stop()
        {
            if (MediaControl != null && mFlag != MediaFlags.None)
            {
                mFlag = MediaFlags.Stopped;
                MediaControl.Stop();
            }
        }
        public void Next()
        {
            if (MediaControl != null && mFlag != MediaFlags.None)
            {
                IDC++;
                if (IDC >= MaxFile)
                    IDC = 0;
                if (IDC < 0)
                    IDC = MaxFile - 1;
                LoadFile(ListFile[IDC].FileDir);
            }
        }
        public void Prev()
        {
            if (MediaControl != null && mFlag != MediaFlags.None)
            {
                IDC--;
                if (IDC >= MaxFile)
                    IDC = 0;
                if (IDC < 0)
                    IDC = MaxFile - 1;
                LoadFile(ListFile[IDC].FileDir);
            }
        }

        double Seek = 1;
        public void DecreateSeek()
        {
            if (MediaControl != null && mFlag != MediaFlags.None)
            {
                Seek--;
                if (Seek < 1)
                    Seek = 1;
                Filgraph.Rate = (double)Seek;
            }
        }
        public void IncreateSeek()
        {
            if (MediaControl != null && mFlag != MediaFlags.None)
            {
                Seek++;
                if (Seek > 4)
                    Seek = 4;
                Filgraph.Rate = (double)Seek;
            }
        }
        public void Increase_Pos(double value)
        {
            this.MediaPosition.CurrentPosition = MediaPosition.CurrentPosition + value;
        }
        public void Decrease_Pos(double value)
        {
            this.MediaPosition.CurrentPosition = MediaPosition.CurrentPosition - value;
        }
        public void Increase_Volume(int value)
        {
            if (this.Filgraph.Volume < 0)
            this.Filgraph.Volume = Filgraph.Volume + value;
        }
        public void Decrease_Volume(int value)
        {
            this.Filgraph.Volume = Filgraph.Volume - value;
        }
    }
}