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
        /// A hack to bypass the normal undo redo operation of the Richtextbox, will save the text prior to one of the below keys.
        /// Undo and redo will work on everyword typed, not just the 1 word back or forward
        /// </summary>
        private void StoreData(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Tab)
            {
                this.SuspendLayout();        
                Undo();
                Redo();
                this.ResumeLayout();
            }
        }


        /// <summary>
        /// Performs an undo operation on the Notepad area using the RichTextBox feature Undo
        /// </summary>
        private void Undo()
        {
            GetNotePadArea.Undo();
        }

        /// <summary>
        /// Performs an redo operation on the Notepad area using the RichTextBox feature Redo
        /// </summary>
        private void Redo()
        {
            GetNotePadArea.Redo();
        }
    }
}
