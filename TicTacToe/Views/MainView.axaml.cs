
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TicTacToe.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }
        private void Btn_Start(object? sender, RoutedEventArgs e)
        {
            Content = new Game();
        }
    }
}