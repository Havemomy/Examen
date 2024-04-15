using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Joker.Models;

namespace Joker.Views;

public partial class Prog : Window
{
    private List<Player> _players;
    private List<Positions> _positions;
    public Prog()
    {
        _players = new ObservableCollection<Player>();
        InitializeComponent();
        Player player1 = new Player("Дон беброн", "Либера(ха)", 60, 220, Convert.ToDateTime("11/11/2001"),
            Convert.ToDateTime("10/04/2022"), "Команда 1");
        Player player2 = new Player("Дон скуфон", "Защитник", 100, 150, Convert.ToDateTime("31/12/2007"), 
            Convert.ToDateTime("10/04/2023"), "Команда 2");
        Player player3 = new Player("Дон антон", "нападающий", 10, 195, Convert.ToDateTime("22/02/2013"), 
            Convert.ToDateTime("15/11/2025"), "Команда 1");
        _players.Add(player1);
        _players.Add(player2);
        _players.Add(player3);
        PlayersGrid.ItemsSource = _players;
    }
    public void Search()
    {
        var searchTextInfo = _players.Where(x =>
            x.PlayerName.Contains(SerTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
        DataGrid.ItemsSource = searchTextInfo;
    }

    private void SerTextBox_OnTextChanging(object? sender, TextChangingEventArgs e)
    {
        Search();
    }
    private void DelButton_OnClick(object? sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void AddButton_OnClick(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }
}