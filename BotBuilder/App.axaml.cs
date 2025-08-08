using System.Linq;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using BotBuilder.ViewModels;
using BotBuilder.Views;

namespace BotBuilder;

/// <summary>
/// Represents the main application class for the BotBuilder application.
/// This class initializes and configures the Avalonia application.
/// </summary>
public class App : Application
{
    /// <summary>
    /// Initializes the Avalonia application by loading the necessary XAML resources.
    /// This method is called during application startup to prepare the UI components and layout.
    /// </summary>
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    /// <summary>
    /// Completes the framework initialization for the application by configuring the main windows or views
    /// depending on the application lifetime mode.
    /// This method ensures the correct setup of the data context and disables redundant data validation plugins.
    /// </summary>
    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Avoid duplicate validations from both Avalonia and the CommunityToolkit.
            // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
            DisableAvaloniaDataAnnotationValidation();
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel()
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = new MainViewModel()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}