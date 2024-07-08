using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using AvaloniaApp.ViewModels;

namespace AvaloniaApp;

public class ViewLocator : IDataTemplate
{
    /// <summary>
    /// Create and return a View from a View Model instance.
    /// </summary>
    public Control? Build(object? data)
    {
        if (data is null)
            return null;

        // Get the view name from the view model.
        var name = data.GetType().FullName!.Replace("ViewModel", "View", StringComparison.Ordinal);
        
        var type = Type.GetType(name);

        if (type == null)
        {
            return new TextBlock { Text = "Not Found: " + name };
        }
        
        // Create an instance of the view.
        var control = (Control)Activator.CreateInstance(type)!;
            
        // Set the data context of the view to the view model.
        control.DataContext = data;
        return control;
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}