using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaperPlane
{
    class cTime
    {
        public static string min2Time(double allTime)
        {
            int hours = (int)(allTime / 3600);
            int min = (int)(allTime / 60 - hours * 60);
            int sec = (int)(allTime - hours * 3600 - min * 60);
            return String.Format("{0:D2}:{1:D2}:{2:D2}", hours, min, sec);
        }
    }
}
