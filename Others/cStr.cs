using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaperPlane
{
    class cStr
    {
        public static string RegExp(string data, string strMatch, bool fullValue = false)
        {
            string ret = "";

            System.Text.RegularExpressions.Regex oRegex = new System.Text.RegularExpressions.Regex(strMatch);
            System.Text.RegularExpressions.Match oMath = oRegex.Match(data);

            if (fullValue)
                return oMath.Value;

            while (oMath.Success)
            {
                for (int i = 1; i <= 2; i++)
                {
                    System.Text.RegularExpressions.Group g = oMath.Groups[i];
                    if (g.ToString() != "")
                    {
                        ret = g.ToString();
                        return ret;
                    }

                }
                oMath = oMath.NextMatch();
            }

            return ret;
        }
    }
}
