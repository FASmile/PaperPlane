using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaperPlane
{
    class cListview
    {
        public ListView Listview;
        PictureBox top, bot;
        Form ListForm;
        PictureBox btClose;

        FileManager[] List;
        int Max = 0;
        bool showList = false;
        int MaxInList = 0;

        public cListview(Form ower = null)
        {
            List = new FileManager[1000];

            ListForm = new Form();
            ListForm.AllowTransparency = true;
            ListForm.AllowDrop = true;
            

            ListForm.Icon = Resources.Resource1.Paper_plane;
            ListForm.FormBorderStyle = FormBorderStyle.None;
            ListForm.Width = 300;
            ListForm.Height = 350;
            ListForm.BackColor = System.Drawing.Color.Black;

            // Panel Top
            Panel listTopPanel;

            ListForm.Controls.Add(listTopPanel = new Panel());
            listTopPanel.BackColor = System.Drawing.Color.Transparent;
            listTopPanel.BackgroundImage = Resources.Resource1.top;
            listTopPanel.Location = new System.Drawing.Point(0, 0);
            listTopPanel.Size = new System.Drawing.Size(ListForm.Width, 20);
            listTopPanel.Controls.Add(top);

            listTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(Draw_MouseDown);
            listTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(Draw_MouseMove);
            listTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(Draw_MouseUp);


            // Close button
            listTopPanel.Controls.Add(btClose = new PictureBox());
            btClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btClose.BackColor = System.Drawing.Color.Transparent;
            btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btClose.Image = Resources.Resource1.close;
            btClose.Click += btClose_Click;
            btClose.Width = 20;
            btClose.Height = 20;
            btClose.Top = 0;
            btClose.Left =  ListForm.Width - btClose.Width;




            // Bot picture
            ListForm.Controls.Add((bot = new PictureBox()));
            bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            bot.Image = Resources.Resource1.top;
            bot.Name = "BotForm";
            bot.Location = new System.Drawing.Point(0, ListForm.Height - 30);
            bot.Size = new System.Drawing.Size(ListForm.Width, 30); 
            bot.MouseDown += new System.Windows.Forms.MouseEventHandler(Draw_MouseDown);
            bot.MouseMove += new System.Windows.Forms.MouseEventHandler(Draw_MouseMove);
            bot.MouseUp += new System.Windows.Forms.MouseEventHandler(Draw_MouseUp);

            ListForm.Controls.Add((Listview = new ListView()));
            Listview.Size = new System.Drawing.Size(ListForm.Width - 4, ListForm.Height - 50);
            Listview.BorderStyle = BorderStyle.None;
            Listview.AllowDrop = true;
            Listview.FullRowSelect = true;
            Listview.MultiSelect = false;

            if (ower != null)
                ListForm.Owner = ower;
        }

        void btClose_Click(object sender, EventArgs e)
        {
            ListForm.Visible = false;
        }
        //======================
        
        //======================
        private void CleanList()
        {
            Listview.Clear();
            Listview.Size = new System.Drawing.Size(ListForm.Width - 4, ListForm.Height - 50);
            Listview.Location = new System.Drawing.Point(2, 20);
            Listview.AllowColumnReorder = false;
            Listview.View = View.Details;
            Listview.FullRowSelect = true;
            

            Listview.Columns.Add("Name", ListForm.Width - 4);
        }
        private void Add_Item(FileManager[] aList, int MaxList, int MaxInList = -1)
        {
            for (int i = 0; i < MaxList; i++)
            {
                Listview.Items.Add(new ListViewItem(new string[] { aList[i].FileName }));
            }

        }
        public void LoadData(FileManager[] ListIn, int MaxListIn)
        {
            List = ListIn;
            Max = MaxListIn;
        }
        public void Update()
        {
            CleanList();
            Add_Item(List, Max, MaxInList);
        }
        public bool Show()
        {
            try
            {
                ListForm.Visible = !ListForm.Visible;
                
            }
            catch { }
            Update();
            return ListForm.Visible;
        }

        //================================
        bool drag = false;
        private System.Drawing.Point pointClicked;

        private void Draw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
                pointClicked = new System.Drawing.Point(e.X, e.Y);
            }
            else
            {
                drag = false;
            }
        }
        private void Draw_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                System.Drawing.Point pointMoveTo;
                pointMoveTo = ListForm.PointToScreen(new System.Drawing.Point(e.X, e.Y));
                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);
                ListForm.Location = pointMoveTo;
            }
        }
    }
}
