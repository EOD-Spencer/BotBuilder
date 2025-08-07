using Avalonia.Controls;

namespace BotBuilder.Views;

/// <summary>
/// Represents the main view of the application. This class serves as the user interface
/// entry point, connecting the visual representation with the associated data and functionality.
/// </summary>
public partial class MainView : UserControl
{
    /// <summary>
    /// Represents the primary user interface component displayed within the main window.
    /// This control serves as a container for the application's content, connecting business logic
    /// and data-binding with the visual elements defined in the corresponding XAML.
    /// </summary>
    public MainView()
    {
        InitializeComponent();
    }
}