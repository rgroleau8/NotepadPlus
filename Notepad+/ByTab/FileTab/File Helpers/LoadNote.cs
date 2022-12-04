using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadPlus.ByTab.FileTab.File_Helpers
{
    public static class LoadNote
    {
        /// <summary>
        /// Checks if the file exists and is of extention type .txt
        /// </summary>
        /// <param name="fileName">File Path of the txt file </param>
        /// <returns>Text from file</returns>
        /// <exception cref="FileLoadException">Thrown if the file ext isnt .txt</exception>
        /// <exception cref="FileNotFoundException">Thrown if the file doesnt exist</exception>
        public static ValidationResponse LoadInText(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);

            if (fileInfo.Exists)
            {
                if (fileInfo.Extension == ".txt")
                {
                    FileStream fileSteam = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                    using (StreamReader reader = new StreamReader(fileSteam))
                    {
                        string output = reader.ReadToEnd();

                        reader.Close();
                        fileSteam.Close();

                        return new ValidationResponse(true, output);

                    }
                }
                else
                {
                    //if file extension isnt .txt
                    return new ValidationResponse(false, "File Extension Isnt .txt", true);
                }

            }
            else
            {
                //if file doesnt exist
                return new ValidationResponse(false, "File Doesn't Exist", true);
            }


        }
    }
}
