namespace NotepadPlus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreLastAutosaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSpecificAutosaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigureEnabledMenu = new System.Windows.Forms.ToolStripComboBox();
            this.timerIntervalinMillisecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigureTimerIntervalTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.outputDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigureOutputDirTxtBox = new System.Windows.Forms.ToolStripTextBox();
            this.SetAutoSaveDir = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigureSaveChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.openSaveLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notePadArea = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.autosaveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.restoreLastAutosaveToolStripMenuItem,
            this.openSpecificAutosaveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // restoreLastAutosaveToolStripMenuItem
            // 
            this.restoreLastAutosaveToolStripMenuItem.Name = "restoreLastAutosaveToolStripMenuItem";
            this.restoreLastAutosaveToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.restoreLastAutosaveToolStripMenuItem.Text = "Restore Last Autosave";
            this.restoreLastAutosaveToolStripMenuItem.Click += new System.EventHandler(this.restoreLastAutosaveToolStripMenuItem_Click);
            // 
            // openSpecificAutosaveToolStripMenuItem
            // 
            this.openSpecificAutosaveToolStripMenuItem.Name = "openSpecificAutosaveToolStripMenuItem";
            this.openSpecificAutosaveToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.openSpecificAutosaveToolStripMenuItem.Text = "Open Specific Autosave";
            this.openSpecificAutosaveToolStripMenuItem.Click += new System.EventHandler(this.openSpecificAutosaveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeFontToolStripMenuItem,
            this.saveSettingsToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSettingsToolStripMenuItem1,
            this.restoreSettingsToolStripMenuItem});
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.changeFontToolStripMenuItem.Text = "Change Font";
            // 
            // changeSettingsToolStripMenuItem1
            // 
            this.changeSettingsToolStripMenuItem1.Name = "changeSettingsToolStripMenuItem1";
            this.changeSettingsToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.changeSettingsToolStripMenuItem1.Text = "Change Settings";
            this.changeSettingsToolStripMenuItem1.Click += new System.EventHandler(this.changeSettingsToolStripMenuItem1_Click);
            // 
            // restoreSettingsToolStripMenuItem
            // 
            this.restoreSettingsToolStripMenuItem.Name = "restoreSettingsToolStripMenuItem";
            this.restoreSettingsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.restoreSettingsToolStripMenuItem.Text = "Restore Settings";
            this.restoreSettingsToolStripMenuItem.Click += new System.EventHandler(this.restoreSettingsToolStripMenuItem_Click);
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
            // 
            // autosaveToolStripMenuItem
            // 
            this.autosaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSettingsToolStripMenuItem,
            this.openSaveLocationToolStripMenuItem,
            this.clearCacheToolStripMenuItem});
            this.autosaveToolStripMenuItem.Name = "autosaveToolStripMenuItem";
            this.autosaveToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.autosaveToolStripMenuItem.Text = "Autosave";
            // 
            // changeSettingsToolStripMenuItem
            // 
            this.changeSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigureEnabledMenu,
            this.timerIntervalinMillisecToolStripMenuItem,
            this.outputDirectoryToolStripMenuItem,
            this.ConfigureSaveChanges});
            this.changeSettingsToolStripMenuItem.Name = "changeSettingsToolStripMenuItem";
            this.changeSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeSettingsToolStripMenuItem.Text = "Configure";
            this.changeSettingsToolStripMenuItem.Click += new System.EventHandler(this.changeSettingsToolStripMenuItem_Click);
            // 
            // ConfigureEnabledMenu
            // 
            this.ConfigureEnabledMenu.Name = "ConfigureEnabledMenu";
            this.ConfigureEnabledMenu.Size = new System.Drawing.Size(180, 23);
            this.ConfigureEnabledMenu.Text = "Enabled";
            this.ConfigureEnabledMenu.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // timerIntervalinMillisecToolStripMenuItem
            // 
            this.timerIntervalinMillisecToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigureTimerIntervalTextbox});
            this.timerIntervalinMillisecToolStripMenuItem.Name = "timerIntervalinMillisecToolStripMenuItem";
            this.timerIntervalinMillisecToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.timerIntervalinMillisecToolStripMenuItem.Text = "Timer Interval (in millisec)";
            this.timerIntervalinMillisecToolStripMenuItem.Click += new System.EventHandler(this.timerIntervalinMillisecToolStripMenuItem_Click);
            // 
            // ConfigureTimerIntervalTextbox
            // 
            this.ConfigureTimerIntervalTextbox.Name = "ConfigureTimerIntervalTextbox";
            this.ConfigureTimerIntervalTextbox.Size = new System.Drawing.Size(100, 23);
            // 
            // outputDirectoryToolStripMenuItem
            // 
            this.outputDirectoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigureOutputDirTxtBox,
            this.SetAutoSaveDir});
            this.outputDirectoryToolStripMenuItem.Name = "outputDirectoryToolStripMenuItem";
            this.outputDirectoryToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.outputDirectoryToolStripMenuItem.Text = "Output Directory";
            // 
            // ConfigureOutputDirTxtBox
            // 
            this.ConfigureOutputDirTxtBox.Name = "ConfigureOutputDirTxtBox";
            this.ConfigureOutputDirTxtBox.Size = new System.Drawing.Size(100, 23);
            // 
            // SetAutoSaveDir
            // 
            this.SetAutoSaveDir.Name = "SetAutoSaveDir";
            this.SetAutoSaveDir.Size = new System.Drawing.Size(180, 22);
            this.SetAutoSaveDir.Text = "Search For Folder";
            this.SetAutoSaveDir.Click += new System.EventHandler(this.SetAutosaveDir_Click_1);
            // 
            // ConfigureSaveChanges
            // 
            this.ConfigureSaveChanges.Name = "ConfigureSaveChanges";
            this.ConfigureSaveChanges.Size = new System.Drawing.Size(240, 22);
            this.ConfigureSaveChanges.Text = "Save Changes";
            this.ConfigureSaveChanges.Click += new System.EventHandler(this.ConfigureSaveChanges_Click);
            // 
            // openSaveLocationToolStripMenuItem
            // 
            this.openSaveLocationToolStripMenuItem.Name = "openSaveLocationToolStripMenuItem";
            this.openSaveLocationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openSaveLocationToolStripMenuItem.Text = "Open Save Location";
            this.openSaveLocationToolStripMenuItem.Click += new System.EventHandler(this.openSaveLocationToolStripMenuItem_Click);
            // 
            // clearCacheToolStripMenuItem
            // 
            this.clearCacheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.clearCacheToolStripMenuItem.Name = "clearCacheToolStripMenuItem";
            this.clearCacheToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearCacheToolStripMenuItem.Text = "Clear Cache";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // notePadArea
            // 
            this.notePadArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notePadArea.Location = new System.Drawing.Point(0, 27);
            this.notePadArea.Name = "notePadArea";
            this.notePadArea.Size = new System.Drawing.Size(799, 430);
            this.notePadArea.TabIndex = 1;
            this.notePadArea.Text = "";
            this.notePadArea.WordWrap = false;
            this.notePadArea.TextChanged += new System.EventHandler(this.notePadArea_TextChanged);
            this.notePadArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.notePadArea_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notePadArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private RichTextBox notePadArea;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem changeFontToolStripMenuItem;
        private ToolStripMenuItem autosaveToolStripMenuItem;
        private ToolStripMenuItem changeSettingsToolStripMenuItem;
        private ToolStripComboBox ConfigureEnabledMenu;
        private ToolStripMenuItem timerIntervalinMillisecToolStripMenuItem;
        private ToolStripTextBox ConfigureTimerIntervalTextbox;
        private ToolStripMenuItem outputDirectoryToolStripMenuItem;
        private ToolStripTextBox ConfigureOutputDirTxtBox;
        private ToolStripMenuItem ConfigureSaveChanges;
        private ToolStripMenuItem SetAutoSaveDir;
        private ToolStripMenuItem openSaveLocationToolStripMenuItem;
        private ToolStripMenuItem clearCacheToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem changeSettingsToolStripMenuItem1;
        private ToolStripMenuItem restoreSettingsToolStripMenuItem;
        private ToolStripMenuItem saveSettingsToolStripMenuItem;
        private ToolStripMenuItem restoreLastAutosaveToolStripMenuItem;
        private ToolStripMenuItem openSpecificAutosaveToolStripMenuItem;
    }
}