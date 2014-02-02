using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Labb_1_Rakna_Versaler;
using System.Web.UI.WebControls;
namespace Labb_1_Rakna_Versaler.Model
{
    public static class Math
    {
        public static int getNumber(string text)
        {

            var counttxt = 0;
            var countversaler = 0;
            var output = 0;
            if (string.IsNullOrWhiteSpace(text) || int.TryParse(text, out output))
            {
                throw new ArgumentException();
            }
            for (counttxt = 0; counttxt < text.Length; counttxt++)
            {
                if (Char.IsUpper(text[counttxt]))
                {
                    countversaler++;
                }
            }

            return countversaler;
        }
    }

}
