using NotepadPlus.ByTab.FormatTab;
using NotepadPlus.ByTab.AutosaveTab;

namespace NotepadPlus
{
    public partial class Form1 : Form
    {

        #region Variables

        private IFontOptionsUtil _fontOptionsUtil;
        private IAutosaver _autosaver;
        private string _loadedFilePath;
        private const string _defaultTitleName = "Untitled - Notepad+";
        private string _titleText;

        #endregion

        #region Constructor

        public Form1(IFontOptionsUtil fontOptionsUtil, IAutosaver autosaver)
        {
            InitializeComponent();
            _fontOptionsUtil = fontOptionsUtil;
            _autosaver = autosaver;
            SetUpAutosaveOptions();
            GetNotePadArea.Font = _fontOptionsUtil.Font;
            this.Text = DefaultTitle;
        }

        #endregion


        #region Properties

        public RichTextBox GetNotePadArea
        {
            get { return notePadArea; }
            set { notePadArea = value; }
        }

        public string DefaultTitle
        {
            get { return _defaultTitleName; }
        }

        public string TitleText
        {
            get { return _titleText; }
            set 
            { 
                _titleText = value;
                
            }
        }

        public string LoadedFilePath
        {
            get { return _loadedFilePath; }
            set
            {
                _loadedFilePath = value;

                string justFileName = (new FileInfo(value).Name.Replace(".txt", ""));

                if (justFileName.StartsWith(_autosaver.StartFileNameWith))
                {
                    //don't want file being saved to the autosave file, user can specify a new file to save it to           
                    TitleText = DefaultTitle;
                    return;
                }

                TitleText = justFileName + " - Notepad+";
            }
        }

        #endregion

        #region Methods

        private void SetUpAutosaveOptions()
        {
            //if this is called more than once at some point, this will prevent it from adding things more than once
            if (ConfigureEnabledMenu.Items.Count == 0)
            {
                ConfigureEnabledMenu.Items.Add("Enabled");
                ConfigureEnabledMenu.Items.Add("Disabled");
            }

            if (AppConfigurationCalls.AutosaveEnabledStatus == true)
                ConfigureEnabledMenu.SelectedText = "Enabled";
            else
                ConfigureEnabledMenu.SelectedText = "Disabled";

            ConfigureTimerIntervalTextbox.Text = AppConfigurationCalls.AutosaveInterval.ToString();

            ConfigureOutputDirTxtBox.Text = AppConfigurationCalls.AutosaveDirectory;

        }



        #endregion

        #region Events

        private void notePadArea_TextChanged(object sender, EventArgs e)
        {
            _autosaver.GetCurrentRTB = GetNotePadArea;
        }


        #endregion





        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void timerIntervalinMillisecToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}