using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace PaperPlane
{
    class TrayMenu
    {
        static IContainer components = new System.ComponentModel.Container();
        static ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
        static MenuItem menuItem = new System.Windows.Forms.MenuItem();
        public static NotifyIcon notifyIcon;

        public static void Create()
        {
            //===================
            
            contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] { menuItem });
            menuItem.Index = 0;
            menuItem.Text = "E&xit";
            menuItem.Click += new System.EventHandler(menuItem_Click);
            
            // Create the NotifyIcon. 
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            notifyIcon.Icon = Resources.Resource1.Paper_plane;
            notifyIcon.ContextMenu = contextMenu;
            notifyIcon.Text = "Paper Media Player";
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += new System.EventHandler(notifyIcon_DoubleClick);

            //===================
        }
        ~TrayMenu()
        {
            components = null;
            contextMenu = null;
            menuItem = null;
            notifyIcon.Visible = false;
        }

        static void menuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }

        static void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Paper Media Player\t\nAuthor: Luong The Hai\nNickname: FASmile", "About:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            
    }
}
