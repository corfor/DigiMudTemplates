namespace MudBlazor.Template.Components.Theme;

/// <summary>
/// Provides DigiKey's theme configuration for MudBlazor components.
/// </summary>
public static class DigiKeyTheme
{
    /// <summary>
    /// Gets the DigiKey MudBlazor theme with light and dark mode palettes.
    /// </summary>
    public static MudTheme Theme => new()
    {
        PaletteLight = new PaletteLight
        {
            Primary = "#FF2100",       // DigiKey Red
            PrimaryDarken = "#6a0a06", // Dark Red
            PrimaryLighten = "#FFBCB3",// Light Red
            Secondary = "#480BBE",     // Blurple
            SecondaryDarken = "#080623", // Dark Blurple
            SecondaryLighten = "#D4D8FB", // Light Blurple
            Info = "#217ae2",
            Success = "#289c28",
            Warning = "#eec201",
            Error = "#cc0000",
            AppbarText = "#222",       // Onyx Grey
            AppbarBackground = "rgba(255,255,255,0.8)",
            DrawerBackground = "#ffffff",
            TextPrimary = "#222",      // Onyx Grey
            TextSecondary = "#666",    // Stone Grey
            Background = "#fff",       // White
            Surface = "#f5f5f5",      // Ice Grey
            DrawerIcon = "#222",
            DrawerText = "#222",
            GrayLight = "#eaeaea",    // Wispy Grey
            GrayLighter = "#f5f5f5",  // Ice Grey
            LinesDefault = "#ddd",    // Outline Grey
            Divider = "#ddd",
            TableLines = "#ddd",
            OverlayLight = "#f5f5f580"
        },
        PaletteDark = new PaletteDark
        {
            Primary = "#FFBCB3",      // Light Red for dark mode
            PrimaryDarken = "#A30000", // Dark Red for dark mode
            Secondary = "#D4D8FB",    // Light Blurple for dark mode
            Info = "#217ae2",
            Success = "#74E092",
            Warning = "#eec201",
            Error = "#F74141",
            Surface = "#080623",      // Dark Blurple
            Background = "#222",      // Onyx Grey
            BackgroundGray = "#444",  // Slate Grey
            AppbarText = "#fff",
            AppbarBackground = "rgba(34,34,34,0.8)", // Onyx Grey with transparency
            DrawerBackground = "#222",
            TextPrimary = "#fff",
            TextSecondary = "#ccc",   // Cloud Grey
            DrawerIcon = "#fff",
            DrawerText = "#fff",
            GrayLight = "#444",       // Slate Grey
            GrayLighter = "#4b4b4b",  // Slate Grey Lighten
            LinesDefault = "#666",    // Stone Grey
            TableLines = "#666",
            Divider = "#666",
            OverlayLight = "#22222280"
        },
        LayoutProperties = new LayoutProperties
        {
            DefaultBorderRadius = "4px",
            DrawerWidthLeft = "260px",
            DrawerMiniWidthLeft = "80px"
        }
    };
}
