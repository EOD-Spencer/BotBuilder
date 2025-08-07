using UIKit;

namespace BotBuilder.iOS;

/// <summary>
/// Represents the main entry point and application logic for the BotBuilder.iOS namespace.
/// This class serves as an essential component for handling lifecycle events, application state,
/// and other primary operations within the iOS environment.
/// </summary>
public static class Application
{
    /// <summary>
    /// Defines the main entry point for the application.
    /// This method initializes the iOS application by invoking the UIApplication.Main method.
    /// </summary>
    /// <param name="args">An array of strings containing the command-line arguments passed to the application at startup.</param>
    private static void Main(string[] args)
    {
        // if you want to use a different Application Delegate class from "AppDelegate"
        // you can specify it here.
        UIApplication.Main(args, null, typeof(AppDelegate));
    }
}