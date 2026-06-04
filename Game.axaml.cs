using System;
using System.Threading;
using Avalonia.Controls;
using Avalonia.Interactivity;


namespace Tictactoe;


public static class Win
{

    public static bool IsWin(int[,] g)
    {
        // lignes
        for (int i = 0; i < 3; i++)
        {
            if (g[i, 0] != 2 &&
                g[i, 0] == g[i, 1] &&
                g[i, 1] == g[i, 2])
            {
                return true;
            }
        }

        // colonnes
        for (int j = 0; j < 3; j++)
        {
            if (g[0, j] != 2 &&
                g[0, j] == g[1, j] &&
                g[1, j] == g[2, j])
            {
                return true;
            }
        }

        // Diagonale haut gauche 
        if (g[0, 0] != 2 &&
            g[0, 0] == g[1, 1] &&
            g[1, 1] == g[2, 2])
        {
            return true;
        }

        // Diagonale haut droit 
        if (g[0, 2] != 2 &&
            g[0, 2] == g[1, 1] &&
            g[1, 1] == g[2, 0])
        {
            return true;
        }

        return false;
    }
}
public class Player
{
    private bool _toor;
    public bool tour
    {
        get => _toor;
        set
        {
            _toor = value;
        }
    }
    
    public Player(bool tour)
    {
        this.tour = tour;
    }
}


public partial class Game : UserControl
{
    public Player p { get; set; } = new Player(true); 
        
    private int[,] Matrice =
    {
        {2,2,2},
        {2,2,2},
        {2,2,2}
    };
    
    public Game()
    {
        InitializeComponent();
        ResetBoard();

    }
    
    private void ResetBoard()
    {
        
        foreach (var box in GameGrid.Children)
        {
            if (box is Button btn)
            {
                btn.Content = "   ";
          
            }
            
        }

        
    }
    
    private void LockSize()
    {
        foreach (var box in GameGrid.Children)
        {
            if (box is Button btn)
            {   
                btn.Width = btn.Bounds.Width;
                btn.Height = btn.Bounds.Height;
          
            }
            
        }
    
    }


    private void BTN_Click(object? sender, RoutedEventArgs e)
    {
        LockSize();
        var btn = sender as Button;
        if (btn == null) return;

        int row = Grid.GetRow(btn);
        int col = Grid.GetColumn(btn);

        if (Matrice[row, col] != 2)
            return; // case déjà prise

        if (p.tour)
        {
            btn.Content = "O";
            Matrice[row, col] = 0;
        }
        else
        {
            btn.Content = "X";
            Matrice[row, col] = 1;
        }

        p.tour = !p.tour;

        if (Win.IsWin(Matrice))
        {
            Console.WriteLine("WIN !");
        }
    }
}


   