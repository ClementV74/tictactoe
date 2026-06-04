using System;
using System.Threading;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Tictactoe;


public partial class MainWindow : Window
{

 
    public MainWindow()
    {
        
        InitializeComponent();
        
    }


    private void Btn_Start(object? sender, RoutedEventArgs e)
    {
        Content = new Game();
    }
}