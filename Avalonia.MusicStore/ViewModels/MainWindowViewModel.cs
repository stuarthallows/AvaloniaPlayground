﻿using ReactiveUI;
using System.Windows.Input;

namespace Avalonia.MusicStore.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ICommand BuyMusicCommand { get; }

    public MainWindowViewModel()
    {
        BuyMusicCommand = ReactiveCommand.Create(() =>
        {
            // Code here will be executed when the button is clicked.
        });
    }
}
