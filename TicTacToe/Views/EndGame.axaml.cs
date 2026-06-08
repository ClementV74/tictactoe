using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TicTacToe.Views;

public partial class EndGame : UserControl
{
    private int nb_;

    public EndGame(int nb = 0)
    {
        nb_ = nb;
        InitializeComponent();
        ShowWinner();

    }
    public void ShowWinner()
    {
        if (nb_ == 2)
        {
            Winner.Text = "Match nul !";
        }
        else
        {

            Winner.Text = $"{Win.WhoWin} a gagné !";

        }
    }
    private void BtnNewGameClick(object? sender, RoutedEventArgs e)
    {
        Content = new Game();
    }
}