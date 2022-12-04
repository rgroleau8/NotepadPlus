using System.Text.Json;
using System.ComponentModel;

namespace NotepadPlus.ByTab.FormatTab
{
    public static class DeserializeFont
    {
        /// <summary>
        /// Convets the string FontSettings to Font and string FontStyle to an Enum.FontStyle and creates a new font with converted values and returns it
        /// </summary>
        /// <param name="fontsettings">String of Serialized FontSettings</param>
        /// <param name="fontStyle">String of Serialized FontStyle</param>
        /// <returns>Deserialized Font</returns>
        public static Font Deserialize(string fontsettings, string fontStyle)
        {
            //Checks if either value is the default, if so it sets up the inital Default Font and returns that font
            if (fontsettings == "" || fontStyle == "")
            {
                SerializeFont.Serialize(DefaultFontSetting.GetDefaultFont());
                return DefaultFontSetting.GetDefaultFont();
            }

            TypeConverter fontConverter = TypeDescriptor.GetConverter(typeof(Font));

            FontStyle fntStyle = (FontStyle)Enum.Parse(typeof(FontStyle), fontStyle, true);

            Font tempFontWithoutStyle = (Font)fontConverter.ConvertFromString(fontsettings);

            //Font Style cant be modifed, a new font must be created with the fntStyle added
            Font output = new Font(tempFontWithoutStyle.FontFamily, tempFontWithoutStyle.Size, fntStyle);

            return output;

        }
    }
}
