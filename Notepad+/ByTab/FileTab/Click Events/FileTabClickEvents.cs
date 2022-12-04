using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadPlus
{
    [System.ComponentModel.DesignerCategory("")]
    partial class DesignerBlocker { }

    public partial class Form1 : Form
    {
        //New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileTab_New_EraseNotePad();
        }

        //Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileTab_Open_GetNote();

        }

        //Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileTab_Save_SaveFile();
        }

        //Save As
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileTab_SaveAs_SaveFileAs();
        }

        //Restore Last Autosave
        private void restoreLastAutosaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileTab_OpenLastAutosave_Open();
        }

        //Open Specific Autosave
        private void openSpecificAutosaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileTab_OpenSpecific_Autosave();
        }
    }
}
