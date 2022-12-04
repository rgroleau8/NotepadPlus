using Autofac;
using NotepadPlus.ByTab.FormatTab;
using NotepadPlus.ByTab.AutosaveTab;

namespace NotepadPlus
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FontOptionsUtil>().As<IFontOptionsUtil>().SingleInstance();
            builder.RegisterType<Autosaver>().As<IAutosaver>().SingleInstance();
            builder.RegisterType<Form1>().AsSelf().SingleInstance();

            return builder.Build();
        }
    }
}
