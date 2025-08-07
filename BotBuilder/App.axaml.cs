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

    /// <summary>
    /// Disables Avalonia's default data annotation validation plugins to prevent redundant data validation processes.
    /// This is particularly useful when using additional validation frameworks, ensuring that only the intended validation logic is applied.
    /// </summary>
    private void DisableAvaloniaDataAnnotationValidation()
    {
        // Get an array of plugins to remove
        DataAnnotationsValidationPlugin[] dataValidationPluginsToRemove =
            BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

        // remove each entry found
        foreach (DataAnnotationsValidationPlugin plugin in dataValidationPluginsToRemove)
        {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }
}