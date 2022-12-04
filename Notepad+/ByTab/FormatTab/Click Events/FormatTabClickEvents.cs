
namespace NotepadPlus
{
    partial class DesignerBlocker { }

    public partial class Form1 : Form
    {
        //Change Font
        private void changeSettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GetNotePadArea.Font = _fontOptionsUtil.ChangeFont();
        }

        //Save Settings
        private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fontOptionsUtil.SaveSettings();
        }
       

        //Restore Settings
        private void restoreSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetNotePadArea.Font = _fontOptionsUtil.Restore();
        }
   

    }
}
