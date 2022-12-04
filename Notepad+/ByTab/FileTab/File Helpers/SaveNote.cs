using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadPlus.ByTab.FileTab.File_Helpers
{
    public static class SaveNote
    {
        public static void Save(string filePath, string text)
        {
            FileStream filesStream = new FileStream(filePath, FileMode.Create);

            using (StreamWriter streamWriter = new StreamWriter(filesStream))
            {
                streamWriter.Write(text);
            }
        }
    }
}
