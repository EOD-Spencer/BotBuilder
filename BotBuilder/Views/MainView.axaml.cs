// ********************************************************************
// File Name:  MainView.axaml.cs
// Project:       BotBuilder
// Author:        ${GitLabUser.Name}
// Copyright (c) 2025 William Spencer.  All Rights Reserved.
// Licensed under the MIT License.  See LICENSE.txt for details.
// ********************************************************************

#region

using Avalonia.Controls;

#endregion

namespace BotBuilder.Views;

/// <summary>
///     Represents the main view of the application. This class serves as the user interface
///     entry point, connecting the visual representation with the associated data and functionality.
/// </summary>
public partial class MainView : UserControl
{
    /// <summary>
    ///     Represents the primary user interface component displayed within the main window.
    ///     This control serves as a container for the application's content, connecting business logic
    ///     and data-binding with the visual elements defined in the corresponding XAML.
    /// </summary>
    public MainView()
    {
        InitializeComponent();
    }
}