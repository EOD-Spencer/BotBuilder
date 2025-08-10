// ********************************************************************
// File Name:  ViewModelBase.cs
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
///     Serves as the base class for all view models in the application. Inherits from
///     <see cref="ObservableObject" />, providing built-in support for property change
///     notifications and data binding.
/// </summary>
public abstract class ViewModelBase : ObservableObject;