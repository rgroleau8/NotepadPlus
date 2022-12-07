
namespace NotepadPlus
{

    partial class DesignerBlocker { }

    public partial class Form1 : Form
    {
        /// <summary>
        /// Clears the Notepad area and resests TitleText and LoadedFile
        /// </summary>
        public void New()
        {

            GetNotePadArea.Clear();
            LoadedFilePath = "";
            TitleText = DefaultTitle;
          
        }

    }
    
}
