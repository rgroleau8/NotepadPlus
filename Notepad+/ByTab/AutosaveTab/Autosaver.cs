using System.Configuration;

namespace NotepadPlus.ByTab.AutosaveTab
{
    public class Autosaver : IAutosaver
    {

        #region Variables

        /// <summary>
        /// The most recently saved RichTextBox, set in an event handler for the Notepad area when text is changed.
        /// </summary>
        private RichTextBox _currentRTB;

        /// <summary>
        /// Used as a temp variable to store the last saved autosave.  Used to check against the current one to see if a save is needed.
        /// </summary>
        private RichTextBox _lastSavedRTB;

        //Object path is written out fully to make sure it uses Forms and not Thread
        private System.Windows.Forms.Timer _timer;

        /// <summary>
        /// All autosave files will start with autosave-
        /// </summary>
        private const string _startFileNameWIth = "autosave-";

        #endregion

        #region Constructor

        public Autosaver()
        {
            _currentRTB = new RichTextBox();
            _lastSavedRTB = new RichTextBox(); ;
            SetupTimerBasedOnConfig();

        }

        #endregion

        #region Properties


        public RichTextBox GetCurrentRTB
        {
            get { return _currentRTB; }
            set { _currentRTB = value; }
        }

        public string StartFileNameWith
        {
            get { return _startFileNameWIth; }
        }

        private RichTextBox GetLastSavedRTB
        {
            get { return _lastSavedRTB; }
            set { _lastSavedRTB = value; }
        }

         

        #endregion

        #region Methods

        #region MainSetup

        public void SetupTimerBasedOnConfig()
        {
            SetTimerToNewInstance();

            SetTimerEnableOrDisabled();

            if (_timer.Enabled == true)
            {
                SetTimerInterval();
                StartTimer();
                SetUpTickEventHandler();
            }
            else
            {
                StopTimer();
            }
        }

        #endregion

        #region TimerTickEvent

        private void SetUpTickEventHandler()
        {
            _timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Nothing has been typed yet, so no need to autosave anything
            if (GetCurrentRTB.Text == "")
                return;

            //GetCurrentRTB is set in an eventhandler when the NotepadArea text is changed.  
            //If the CurrentRTB isnt equal to the last saved one, then it will autosave the new one.
            if (GetCurrentRTB.Text != GetLastSavedRTB.Text)
            {
                if (Directory.Exists(AppConfigurationCalls.AutosaveDirectory) == false)
                {
                    StopTimer();
                    MessageBox.Show("Output Directory doesnt exist");
                }

                //Stores the current saved RTB into GetLastSavedRTB for the next timer tick check to be checked against the current.
                GetLastSavedRTB.Text = GetCurrentRTB.Text;

                //ex. autosave-12-07-2022 192534.txt
                string filePath = AppConfigurationCalls.AutosaveDirectory + StartFileNameWith + DateTime.Now.ToString("MM-dd-yyyy HHmmss") + ".txt";
                GetCurrentRTB.SaveFile(filePath, RichTextBoxStreamType.PlainText);


            }


        }

        #endregion

        #region TimerCoreEvents

        private void SetTimerEnableOrDisabled()
        {
            _timer.Enabled = AppConfigurationCalls.AutosaveEnabledStatus;
        }

        private void SetTimerInterval()
        {
            _timer.Interval = AppConfigurationCalls.AutosaveInterval;
        }

        private void StartTimer()
        {
            _timer.Start();
        }

        private void StopTimer()
        {
            _timer.Stop();
        }

        private void SetTimerToNewInstance()
        {
            _timer = new System.Windows.Forms.Timer();
        }

        #endregion

        #endregion


    }
}
