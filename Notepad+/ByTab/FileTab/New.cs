
namespace NotepadPlus
{

    partial class DesignerBlocker { }

    public partial class Form1 : Form
    {
        /// <summary>
        /// Clears the Notepad area and resests TitleText and LoadedFile
        /// </summary>
        public void FileTab_New_EraseNotePad()
        {

            GetNotePadArea.Clear();
            LoadedFilePath = "";
            TitleText = DefaultTitle;
          
        }

    }
    
}
