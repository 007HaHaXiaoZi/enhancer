using HaKid.Base;

namespace HaKid.Enhancer {

internal partial class Settings : ProjectSettings {

[Setting("Theme")]
public ThemeSettings theme = new ThemeSettings();

[Setting("Sidebar")]
public SidebarSettings sidebar = new SidebarSettings();

}

}
