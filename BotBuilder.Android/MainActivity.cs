using Android.App;
using Android.Content.PM;
using Avalonia;
using Avalonia.Android;

namespace BotBuilder.Android;

/// <summary>
/// Represents the main activity for the Android version of the BotBuilder application.
/// This activity is the entry point of the Android application and is responsible for
/// initializing and configuring the Avalonia framework on the Android platform.
/// </summary>
/// <remarks>
/// This activity is configured with specific Android attributes such as label, theme,
/// icon, main launcher status, and configuration changes handling.
/// It inherits from <see cref="Avalonia.Android.AvaloniaMainActivity{TApp}"/>
/// to integrate Avalonia functionality with the Android platform.
/// </remarks>
[Activity(
    Label = "BotBuilder.Android",
    Theme = "@style/MyTheme.NoActionBar",
    Icon = "@drawable/icon",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
    /// <summary>
    /// Customizes the application builder for the Android version of the BotBuilder application.
    /// Enables additional configurations or extensions to the default Avalonia application builder.
    /// </summary>
    /// <param name="builder">The <see cref="AppBuilder"/> instance to be customized.</param>
    /// <returns>The customized <see cref="AppBuilder"/> instance with additional configuration.</returns>
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithInterFont();
    }
}