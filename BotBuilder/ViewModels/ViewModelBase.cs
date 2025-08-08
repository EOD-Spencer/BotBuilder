using CommunityToolkit.Mvvm.ComponentModel;

namespace BotBuilder.ViewModels
{
    /// <summary>
    /// Serves as the base class for all view models in the application. Inherits from
    /// <see cref="ObservableObject"/>, providing built-in support for property change
    /// notifications and data binding.
    /// </summary>
    public abstract class ViewModelBase : ObservableObject { }
}