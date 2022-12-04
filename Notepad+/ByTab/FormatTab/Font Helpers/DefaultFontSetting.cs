using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadPlus.ByTab.FormatTab
{
    public static class DefaultFontSetting
    {
        /// <summary>
        /// By Default, Font in FontDialoge will be set as Times New Roman, 12 pt, Regular Style
        /// </summary>
        /// <returns>Default Font</returns>
        public static Font GetDefaultFont()
        {
            Font output = new Font("Times New Roman", 12, FontStyle.Regular);

            return output;
        }

    
    }
}
