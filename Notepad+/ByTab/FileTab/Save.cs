using NotepadPlus.ByTab.FileTab.File_Helpers;

namespace NotepadPlus
{
    partial class DesignerBlocker { }

    public partial class Form1 : Form
    {
        /// <summary>
        /// Checks if the loadedFilePath is exists, if not does a Save As
        /// </summary>
        public void FileTab_Save_SaveFile()
        {
            //checks if the file has the default name template
            if (new FileInfo(LoadedFilePath).Exists == false)
            {
                FileTab_SaveAs_SaveFileAs();
                return;
            }

            SaveNote.Save(LoadedFilePath, notePadArea.Text);

        }
    }
}
