// ********************************************************************
// File Name:  MainViewModel.cs
// Project:       BotBuilder
// Author:        ${GitLabUser.Name}
// Copyright (c) 2025 William Spencer.  All Rights Reserved.
// Licensed under the MIT License.  See LICENSE.txt for details.
// ********************************************************************

#region

using CommunityToolkit.Mvvm.ComponentModel;

#endregion

namespace BotBuilder.ViewModels;

/// <summary>
///     Represents the main view model for the application. This class serves as the bridge
///     between the application's view and underlying logic by providing properties, commands,
///     and any necessary functionality for data binding and interaction.
/// </summary>
public partial class MainViewModel : ViewModelBase
{
    /// <summary>
    ///     Stores the greeting message displayed within the application's main view.
    /// </summary>
    [ObservableProperty] private string _greeting = "Welcome to Avalonia!";
}