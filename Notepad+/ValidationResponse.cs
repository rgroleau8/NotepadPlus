using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadPlus
{
    public class ValidationResponse
    {
        public bool Successful { get; set; }
        public string Information { get; set; }
        public bool CanAlert { get; set; }

        public ValidationResponse(bool successful, string information, bool alertUser = false)
        {
            Successful = successful;
            Information = information;
            CanAlert = alertUser;
        }

        public void DisplayInformationToUser()
        {
             if (CanAlert == true)
            {
                MessageBox.Show(Information);
            }
             
        }
    }
}
