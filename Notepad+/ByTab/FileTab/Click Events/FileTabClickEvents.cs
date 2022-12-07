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
            New();
        }

        //Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();

        }

        //Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        //Save As
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        //Restore Last Autosave
        private void restoreLastAutosaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLastAutosave();
        }

        //Open Specific Autosave
        private void openSpecificAutosaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSpecificAutosave();
        }
    }
}
