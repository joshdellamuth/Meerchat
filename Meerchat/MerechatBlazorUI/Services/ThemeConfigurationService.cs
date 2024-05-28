namespace MeerchatBlazorUI.Data
{
    public class ThemeConfigurationService
    {
        public bool isDarkMode { get; set; } = false;

        public void SwitchDarkMode()
        {
            isDarkMode = !isDarkMode;
        }
    }
}
