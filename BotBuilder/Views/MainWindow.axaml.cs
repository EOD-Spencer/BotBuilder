using Avalonia.Controls;

namespace BotBuilder.Views;

/// <summary>
/// Represents the main window of the application.
/// </summary>
/// <remarks>
/// This class serves as the root window in the Avalonia application framework.
/// It is initialized and displayed when the application starts.
/// </remarks>
public partial class MainWindow : Window
{
    /// <summary>
    /// Represents the main window of the Avalonia application.
    /// </summary>
    /// <remarks>
    /// The MainWindow class is derived from Avalonia.Controls.Window and acts as the primary interface
    /// for the application. This serves as the entry point for UI initialization.
    /// It is initialized automatically when the application launches.
    /// </remarks>
    public MainWindow()
    {
        InitializeComponent();
    }
}