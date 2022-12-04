using System.Text.Json;
using System.ComponentModel;

namespace NotepadPlus.ByTab.FormatTab
{
    public static class SerializeFont
    {
        /// <summary>
        /// Converts the inputed Font to to a string value and saves to App.Config under FontSettings and FontStyle
        /// </summary>
        /// <param name="font">Font to Serialize to App.Config</param>
        public static void Serialize(Font font)
        {

            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));

            TypeConverter fontstyle = TypeDescriptor.GetConverter(typeof(FontStyle));

            AppConfigurationCalls.FontSettings = converter.ConvertToString(font);

            AppConfigurationCalls.FontStyle = fontstyle.ConvertToString(font.Style);

        }
    }
}
