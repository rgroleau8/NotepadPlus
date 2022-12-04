using NotepadPlus.ByTab.FileTab.File_Helpers;

namespace NotepadPlus
{
    partial class DesignerBlocker { }

    public partial class Form1 : Form
    {
        /// <summary>
        /// Prompts user to search for a valid file and saves the contents of the Notepad Area to it
        /// </summary>
        public void FileTab_SaveAs_SaveFileAs()
        {
            ValidationResponse getFile = FindNote.GetFile();

            if (getFile.Successful == false)
            {
                getFile.DisplayInformationToUser();
                return;
            }

            LoadedFilePath = getFile.Information;

            SaveNote.Save(LoadedFilePath, notePadArea.Text);

        }
    }
}
