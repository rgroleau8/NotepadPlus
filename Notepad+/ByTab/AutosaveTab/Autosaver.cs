using System.Configuration;

namespace NotepadPlus.ByTab.AutosaveTab
{
    public class Autosaver : IAutosaver
    {

        #region Variables

        private System.Windows.Forms.Timer _timer;
        private RichTextBox _currentRTB;
        private RichTextBox _lastSavedRTB;
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

            if (GetCurrentRTB.Text != GetLastSavedRTB.Text)
            {
                if (Directory.Exists(AppConfigurationCalls.AutosaveDirectory) == false)
                {
                    StopTimer();
                    MessageBox.Show("Output Directory doesnt exist");
                }

                GetLastSavedRTB.Text = GetCurrentRTB.Text;

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
