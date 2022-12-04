namespace NotepadPlus.ByTab.AutosaveTab
{
    public interface IAutosaver
    {
        RichTextBox GetCurrentRTB { get; set; }
        string StartFileNameWith { get; }
        void SetupTimerBasedOnConfig();
    }
}