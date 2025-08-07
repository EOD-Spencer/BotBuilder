using System.Threading.Tasks;
using Avalonia;
using Avalonia.Browser;

namespace BotBuilder.Browser;

/// <summary>
/// Entry point class for the application.
/// This class is responsible for configuring and building the Avalonia application.
/// </summary>
internal static class Program
{
    /// <summary>
    /// The entry point of the application.
    /// Configures and launches the Avalonia application for the browser platform.
    /// </summary>
    /// <param name="args">An array of command-line arguments passed to the application.</param>
    /// <returns>A task representing the asynchronous operation of initializing and starting the application.</returns>
    private static Task Main(string[] args) => BuildAvaloniaApp()
        .WithInterFont()
        .StartBrowserAppAsync("out");

    /// <summary>
    /// Configures and builds the Avalonia application.
    /// Used to set up application-specific configurations and dependencies.
    /// </summary>
    /// <returns>An <see cref="AppBuilder"/> instance configured for the application.</returns>
    private static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>();
}