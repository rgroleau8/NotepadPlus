using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadPlus.ByTab.FormatTab
{
    public class FontOptionsUtil : IFontOptionsUtil
    {

        #region Variables

        private FontDialog _fontDialog;

        #endregion

        #region Constructor

        public FontOptionsUtil()
        {
            _fontDialog = new FontDialog();
            LoadSettings();
        }

        #endregion

        #region Properties
        public Font Font
        {
            get { return _fontDialog.Font; }
            set { _fontDialog.Font = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Brings up Font Dialoge Options and returns the new user defined font
        /// Font is NOT saved to config to allow user to revert, user must Save manaully
        /// </summary>
        /// <returns>User Defined Font</returns>
        public Font ChangeFont()
        {
            DialogResult fontOptions = _fontDialog.ShowDialog();
            return Font;
        }

        /// <summary>
        /// Serialized Font to App.Config
        /// </summary>
        public void SaveSettings()
        {
            SerializeFont.Serialize(Font);
        }

        /// <summary>
        /// Sets Font to the values within App.Config and returns Font to be assigned to Main App Font
        /// </summary>
        /// <returns>Restored Font</returns>
        public Font Restore()
        {
            LoadSettings();
            return Font;
        }

        /// <summary>
        /// Deserializes font settings and style in App.Config and sets Font to the returned Font
        /// </summary>
        private void LoadSettings()
        {
            Font = DeserializeFont.Deserialize(AppConfigurationCalls.FontSettings, AppConfigurationCalls.FontStyle);
        }

        #endregion 

       

        



       
    }
}
