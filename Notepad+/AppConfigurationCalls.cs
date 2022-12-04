using System.Configuration;

namespace NotepadPlus
{
    public static class AppConfigurationCalls
    {

        #region Autosave

        #region KeyNames

        private static string _autosaveEnabled = "AutosaveEnabled";
        private static string _autosaveInterval = "AutosaveInterval";
        private static string _autosaveDir = "AutosaveDir";

        #endregion

        #region Properties
        public static Boolean AutosaveEnabledStatus
        {
            get { return Convert.ToBoolean(GetAppSettings(_autosaveEnabled)); }
            set { UpdateAppSettings(_autosaveEnabled, value.ToString()); }
        }

        public static int AutosaveInterval
        {
            get { return Convert.ToInt32(GetAppSettings(_autosaveInterval)); }
            set { UpdateAppSettings(_autosaveInterval, value.ToString()); }
        }

        public static string AutosaveDirectory
        {
            get { return GetAppSettings(_autosaveDir); }
            set
            {
                //will add the \ at the end if its not there, the double \\ translates to just \
                if (value.EndsWith("\\") == false)
                    value = value + "\\";

                UpdateAppSettings(_autosaveDir, value);
            }
        }

        #endregion

        #endregion

        #region Font

        #region KeyNames

        private static string _fontSettings = "FontSettings";
        private static string _fontStyle = "FontStyle";

        #endregion

        #region Properties
        public static string FontSettings
        {
            get { return GetAppSettings(_fontSettings); }
            set { UpdateAppSettings(_fontSettings, value); }
        }

        public static string FontStyle
        {
            get { return GetAppSettings(_fontStyle); }
            set { UpdateAppSettings(_fontStyle, value); }
        }

        #endregion

        #endregion

        #region Modify

        /// <summary>
        /// Looks in the app.config file for the key and returns the value assisgned to it
        /// </summary>
        /// <param name="key">Label for Key in App.Config</param>
        /// <returns>Value of Key in Config File</returns>
        public static string GetAppSettings(string key)
        {
            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;

            return settings[key].Value;

        }

        /// <summary>
        /// Sets the value of Key in App.Conifg with the string value
        /// </summary>
        /// <param name="key">Label for Key in App.Config</param>
        /// <param name="value">String to set value of Key</param>
        public static void UpdateAppSettings(string key, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show($"Failed to update app setting {key} because no value was given.");
                return;
            }

            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;

            settings[key].Value = value;

            configFile.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

        }

    
        #endregion


        

    }
}
