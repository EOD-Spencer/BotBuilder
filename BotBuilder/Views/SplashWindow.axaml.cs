// ********************************************************************
// File Name:  SplashWindow.axaml.cs
// Project:       BotBuilder
// Author:        ${GitLabUser.Name}
// Copyright (c) 2025 William Spencer.  All Rights Reserved.
// Licensed under the MIT License.  See LICENSE.txt for details.
// ********************************************************************

#region

using System;
using System.Threading.Tasks;
using Avalonia.Interactivity;
using Avalonia.Threading;

#endregion

namespace BotBuilder.Views;

/// <summary>
///     Represents a splash screen window displayed at the start of the application.
/// </summary>
/// <remarks>
///     The <see cref="SplashWindow" /> class inherits from <see cref="MainWindow" /> and is
///     used as an introductory window when the application is launched.
///     This window appears as a simplified and visually minimal interface, often serving
///     as a loading screen or branding utility before the main application interface is loaded.
///     By default, the splash screen window:
///     - Appears at the center of the screen.
///     - Has no system decorations (e.g., window borders or title bar).
///     - Displays application-related content in a predefined layout.
///     Upon completing its initialization, the splash window triggers the main application
///     logic through the provided callback action.
/// </remarks>
public partial class SplashWindow : MainWindow
{
    /// <summary>
    ///     Holds a delegate or method reference representing the main action
    ///     to be performed after the splash screen completes its initialization and loading process.
    /// </summary>
    /// <remarks>
    ///     This variable is used to trigger the main application logic once the splash screen finishes its purpose,
    ///     such as displaying introductory content or performing preliminary tasks.
    ///     If the action is provided, it will be invoked right before the splash screen closes.
    /// </remarks>
    private readonly Action? _mainAction;

    /// <summary>
    ///     The <c>SplashWindow</c> class represents a splash screen window that is displayed
    ///     during the application's initialization phase. It is a partial class derived from
    ///     <see cref="MainWindow" /> and is used to execute a specific action when initialized.
    /// </summary>
    public SplashWindow(Action mainAction)
    {
        InitializeComponent();
        _mainAction = mainAction;
    }

    /// <summary>
    ///     Handles the event triggered when the <see cref="SplashWindow" /> is fully loaded.
    ///     Performs initialization tasks and invokes further logic associated with the splash screen lifecycle.
    /// </summary>
    /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data for the Loaded event.</param>
    protected override void OnLoaded(RoutedEventArgs e)
    {
        DummyLoad();
    }

    /// <summary>
    ///     The <c>DummyLoad</c> method simulates a background loading operation by performing
    ///     an asynchronous delay. It executes a predefined action upon completion and then closes
    ///     the window.
    /// </summary>
    /// <remarks>
    ///     This method is invoked during the splash screen's load event to simulate application
    ///     initialization. It uses a 3-second delay to mimic background tasks and ensures the
    ///     specified callback action and window closure are performed on the UI thread.
    /// </remarks>
    // ReSharper disable once AsyncVoidMethod
    private async void DummyLoad()
    {
        // Do some background stuff here.
        await Task.Delay(3000);

        // Invoke the main action and close the splash window on the UI thread.
        await Dispatcher.UIThread.InvokeAsync(() =>
        {
            _mainAction?.Invoke();
            Close();
        });
    }
}