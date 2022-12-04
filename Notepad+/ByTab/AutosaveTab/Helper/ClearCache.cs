using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadPlus.ByTab.AutosaveTab
{
    public static class ClearCache
    {
        /// <summary>
        /// Will delete all files under the specified location as long as the file ext is .txt and filename begins with autosave-
        /// </summary>
        public static void DeleteAllFiles(string location)
        {
            var directory = new DirectoryInfo(location);

            foreach (var file in directory.GetFiles())
            {
                if (file.Extension == ".txt" && file.Name.StartsWith("autosave-"))
                {
                    file.Delete();                 
                }
                
            }
            MessageBox.Show("Autosave Cache has been deleted");
        }
    }
}
