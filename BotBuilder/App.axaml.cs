// ********************************************************************
// File Name:  App.axaml.cs
// Project:       BotBuilder
// Author:        ${GitLabUser.Name}
// Copyright (c) 2025 William Spencer.  All Rights Reserved.
// Licensed under the MIT License.  See LICENSE.txt for details.
// ********************************************************************

#region

using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using BotBuilder.ViewModels;
using BotBuilder.Views;

#endregion

namespace BotBuilder;

/// <summary>
///     Represents the main application class for the BotBuilder application.
///     This class initializes and configures the Avalonia application.
/// </summary>
public class App : Application
{
    /// <summary>
    ///     Initializes the Avalonia application by loading the necessary XAML resources.
    ///     This method is called during application startup to prepare the UI components and layout.
    /// </summary>
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    /// <summary>
    ///     Completes the framework initialization for the application by configuring the main windows or views
    ///     depending on the application lifetime mode.
    ///     This method ensures the correct setup of the data context and disables redundant data validation plugins.
    /// </summary>
    public override void OnFrameworkInitializationCompleted()
    {
        switch (ApplicationLifetime)
        {
            case IClassicDesktopStyleApplicationLifetime desktop:
                desktop.MainWindow = new SplashWindow(() =>
                {
                    MainWindow mainWindow = new()
                    {
                        DataContext = new MainViewModel()
                    };

                    mainWindow.Show();
                    mainWindow.Focus();

                    desktop.MainWindow = mainWindow;
                });
                break;
            case ISingleViewApplicationLifetime singleViewPlatform:
                singleViewPlatform.MainView = new MainView
                {
                    DataContext = new MainViewModel()
                };
                break;
        }

        base.OnFrameworkInitializationCompleted();
    }
}