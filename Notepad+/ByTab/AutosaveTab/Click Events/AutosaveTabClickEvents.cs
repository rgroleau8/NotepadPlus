using System.Diagnostics;
using NotepadPlus.ByTab.AutosaveTab;

namespace NotepadPlus
{
    partial class DesignerBlocker { }

    public partial class Form1 : Form
    {
        //Configure
        private void changeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ConfigureSaveChanges_Click(object sender, EventArgs e)
        {
            if (ConfigureEnabledMenu.SelectedText == "Enabled")
                AppConfigurationCalls.AutosaveEnabledStatus = true;
            else
                AppConfigurationCalls.AutosaveEnabledStatus = false;

            int parseTypeCheck = 0;

            if (int.TryParse(ConfigureTimerIntervalTextbox.Text, out parseTypeCheck) == false)
            {
                MessageBox.Show("Not a valid number for the Timer Interval");
                return;
            }

            AppConfigurationCalls.AutosaveInterval = Convert.ToInt32(ConfigureTimerIntervalTextbox.Text);

            if (Directory.Exists(ConfigureOutputDirTxtBox.Text) == false)
            {
                try
                {
                    Directory.CreateDirectory(ConfigureOutputDirTxtBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Directory chosen cant be created and does not exist");
                    return;
                }

            }

            AppConfigurationCalls.AutosaveDirectory = ConfigureOutputDirTxtBox.Text;

            _autosaver.SetupTimerBasedOnConfig();

        }

        private void openSaveLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", AppConfigurationCalls.AutosaveDirectory);
        }

        //Clear cache
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCache.DeleteAllFiles(AppConfigurationCalls.AutosaveDirectory);
        }

        //Search For Directory
        private void SetAutosaveDir_Click_1(object sender, EventArgs e)
        {
            using (var folderDB = new FolderBrowserDialog())
            {
                DialogResult result = folderDB.ShowDialog();

                if (result == DialogResult.OK & !string.IsNullOrWhiteSpace(folderDB.SelectedPath))
                {
                    ConfigureOutputDirTxtBox.Text = folderDB.SelectedPath;
                }
            }
        }
    }
}
