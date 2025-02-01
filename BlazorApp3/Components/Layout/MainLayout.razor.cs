using MudBlazor;

namespace BlazorApp3.Components.Layout
{
    public partial class MainLayout
    {
        private DrawerClipMode ClipMode { get; set; } = DrawerClipMode.Always;
        private Breakpoint Breakpoint { get; set; } = Breakpoint.Sm;
        private bool DrawerOpen { get; set; }
        public void DrawerToggle()
        {
            DrawerOpen = !DrawerOpen;
        }
    }
}
