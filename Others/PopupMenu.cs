using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace PaperPlane
{
    class PopupMenu
    {
        private System.Windows.Forms.ContextMenu popUpMenu;
        
        public PopupMenu()
        {
            popUpMenu = new System.Windows.Forms.ContextMenu();
        }

        public MenuItem Add_Item(string Name, EventHandler Event)
        {

            return popUpMenu.MenuItems.Add(Name, Event);
        }
        public void Show(Control ctr, MouseEventArgs e)
        {
            System.Drawing.Point mPoint = new System.Drawing.Point(e.X, e.Y);
            popUpMenu.Show(ctr, mPoint);
        }
    }
}
