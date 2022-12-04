using NotepadPlus.ByTab.FileTab.File_Helpers;

namespace NotepadPlus
{
    partial class DesignerBlocker { }

    public partial class Form1 : Form
    {
        public void FileTab_OpenSpecific_Autosave()
        {
            ValidationResponse getFile = FindNote.GetFile(AppConfigurationCalls.AutosaveDirectory);

            if (getFile.Successful == false)
            {
                getFile.DisplayInformationToUser();
                return;
            }

            LoadedFilePath = getFile.Information;

            ValidationResponse text = LoadNote.LoadInText(LoadedFilePath);

            if (text.Successful == false)
            {
                text.DisplayInformationToUser();
                return;
            }

            GetNotePadArea.Text = text.Information;
        }
    }
}
