

namespace NotepadPlus.ByTab.FileTab.File_Helpers
{
    public static class FindNote
    {
        /// <summary>
        /// Gets the name of the file via an Open File Dialog.
        /// </summary>
        /// <returns></returns>      
        public static ValidationResponse GetFile(string defaultOpenLocation = null)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Title = "Find a txt file to open";

                openFileDialog.Filter = "Text File (*.txt)|*.txt";

                if (defaultOpenLocation != null)
                {
                    if (new DirectoryInfo(defaultOpenLocation).Exists)
                    {
                        openFileDialog.InitialDirectory = defaultOpenLocation;
                    }                    
                }

                //openFileDialog.InitialDirectory

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (!string.IsNullOrWhiteSpace(openFileDialog.FileName))
                    {
                        return new ValidationResponse(true, openFileDialog.FileName);

                    }
                    else
                    {
                        return new ValidationResponse(false, "File Operation Error", true);
                    }
                }
                else
                {
                    return new ValidationResponse(false, "User Has Canceled Operation");
                }
            }
        }    
    }
}
