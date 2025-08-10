// ********************************************************************
// File Name:  ViewLocator.cs
// Project:       BotBuilder
// Author:        ${GitLabUser.Name}
// Copyright (c) 2025 William Spencer.  All Rights Reserved.
// Licensed under the MIT License.  See LICENSE.txt for details.
// ********************************************************************

#region

using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using BotBuilder.ViewModels;

#endregion

namespace BotBuilder;

/// <summary>
///     Provides functionality for locating and constructing views based on the ViewModel type.
///     Implements the <see cref="IDataTemplate" /> interface to support templating in Avalonia
///     applications by matching ViewModel types to their corresponding View types.
/// </summary>
public class ViewLocator : IDataTemplate
{
    /// <summary>
    ///     Constructs a view for the specified data context by locating the corresponding view type
    ///     based on the provided ViewModel type. If a matching type is not found, a default
    ///     <see cref="TextBlock" /> is returned displaying an error message.
    /// </summary>
    /// <param name="param">
    ///     The data context (typically a ViewModel) for which the
    ///     corresponding view needs to be constructed. This can be null.
    /// </param>
    /// <returns>
    ///     A <see cref="Control" /> instance representing the constructed view, or a
    ///     <see cref="TextBlock" /> with an error message if a matching view type is not found.
    ///     Returns null if the provided data context is null.
    /// </returns>
    public Control? Build(object? param)
    {
        string? fullName = param?.GetType().FullName;
        if (fullName is null)
        {
            return null;
        }

        string name = fullName.Replace("ViewModel", "View", StringComparison.Ordinal);
        Type? type = Type.GetType(name);

        if (type != null)
        {
            return Activator.CreateInstance(type) as Control;
        }

        return new TextBlock { Text = "Not Found: " + name };

    }

    /// <summary>
    ///     Determines whether the specified data is an instance of <see cref="ViewModelBase" />,
    ///     indicating that it corresponds to a recognized ViewModel type for which views can be located.
    /// </summary>
    /// <param name="data">
    ///     The object to examine. It is typically the data context associated
    ///     with a view and can potentially be null.
    /// </param>
    /// <returns>
    ///     <c>true</c> if the data is of type <see cref="ViewModelBase" />; otherwise, <c>false</c>.
    /// </returns>
    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}