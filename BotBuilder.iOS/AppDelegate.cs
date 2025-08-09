// ********************************************************************
// File Name:  AppDelegate.cs
// Project:       BotBuilder.iOS
// Author:        ${GitLabUser.Name}
// Copyright (c) 2025 William Spencer.  All Rights Reserved.
// Licensed under the MIT License.  See LICENSE.txt for details.
// ********************************************************************

#region

using Avalonia;
using Avalonia.iOS;
using Foundation;

#endregion

namespace BotBuilder.iOS;

// The UIApplicationDelegate for the application. This class is responsible for launching the
// User Interface of the application, as well as listening (and optionally responding) to
// application events from iOS.
[Register("AppDelegate")]
#pragma warning disable CA1711 // Identifiers should not have incorrect suffix
public class AppDelegate : AvaloniaAppDelegate<App>
#pragma warning restore CA1711 // Identifiers should not have incorrect suffix
{
    /// <summary>
    ///     Customizes the application builder by applying additional configurations or settings.
    ///     This method is invoked during the application startup sequence to modify how the app is built.
    /// </summary>
    /// <param name="builder">The <see cref="AppBuilder" /> instance representing the application builder.</param>
    /// <returns>The modified instance of <see cref="AppBuilder" /> with the applied customizations.</returns>
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithInterFont();
    }
}