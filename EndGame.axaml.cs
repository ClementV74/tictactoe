using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Tictactoe;

public partial class EndGame : UserControl
{


    public EndGame()
    {
        InitializeComponent();
        ShowWinner();
    }
    public void ShowWinner()
    {
        Winner.Text = $"{Win.WhoWin} a gagné !";
        
    }
    private void BtnNewGameClick(object? sender, RoutedEventArgs e)
    {
        Content = new Game();
    }
}