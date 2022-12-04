namespace NotepadPlus.ByTab.FormatTab
{
    public interface IFontOptionsUtil
    {
        Font ChangeFont();
        Font Font { get; set; }

        void SaveSettings();

        Font Restore();
    }
}