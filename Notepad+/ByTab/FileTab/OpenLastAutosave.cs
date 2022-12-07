using System.Linq;
using NotepadPlus.ByTab.FileTab.File_Helpers;


namespace NotepadPlus
{
    partial class DesignerBlocker { }

    public partial class Form1 : Form
    {

        public void OpenLastAutosave()
        {
            DirectoryInfo autoSaveDir = new DirectoryInfo(AppConfigurationCalls.AutosaveDirectory);

            if (autoSaveDir.Exists)
            {
                if (autoSaveDir.GetFiles().Count() == 0)
                {
                    MessageBox.Show($"No autosaves in directory: {AppConfigurationCalls.AutosaveDirectory} ");
                    return;
                }

                FileInfo lastSavedFile = autoSaveDir.GetFiles().OrderByDescending(f => f.CreationTime).First();

                ValidationResponse text = LoadNote.LoadInText(lastSavedFile.ToString());

                if (text.Successful == false)
                {
                    text.DisplayInformationToUser();
                    return;
                }

                GetNotePadArea.Text = text.Information;

            }
            else
            {
                Directory.CreateDirectory(AppConfigurationCalls.AutosaveDirectory);

                MessageBox.Show("Autosave Directory doesnt exist or has been moved!, new folder has been created");

                return;
            }
        }

    }
   
}
