using NotepadPlus.ByTab.FileTab.File_Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadPlus
{
    partial class DesignerBlocker { }

    public partial class Form1 : Form
    {
      /// <summary>
      /// Prompts the user to search for a file and loads the file into the Notepad Area
      /// </summary>
        public void Open()
        {
            ValidationResponse getFile = FindNote.GetFile();

            if (getFile.Successful == false)
            {
                getFile.DisplayInformationToUser();
                return;
            }

            LoadedFilePath = getFile.Information;

            ValidationResponse loadInText = LoadNote.LoadInText(LoadedFilePath);

            if (loadInText.Successful == false)
            {
                loadInText.DisplayInformationToUser();
                return;
            }

            GetNotePadArea.Text = loadInText.Information;

        }

    }
}
