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
        //undo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTab_UndoRedo_Undo();
        }

        //redo
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTab_UndoRedo_Redo();
        }

        /// <summary>
        /// Notepad area
        /// When key is pressed down, it will check if it's a space or enter or tab and save the text written 
        /// to improve the default undo redo operation that RichtTxtBoxes have
        /// </summary>
        private void notePadArea_KeyDown(object sender, KeyEventArgs e)
        {
            EditTab_UndoRedo_StoreData(e);
        }
    }
}
