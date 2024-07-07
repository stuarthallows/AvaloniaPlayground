using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Console.WriteLine("Button clicked!");
        TextBlock1.Text = "Button clicked!";
    }
}