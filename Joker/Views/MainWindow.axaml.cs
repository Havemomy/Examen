using Avalonia.Controls;
using Avalonia.Interactivity;
using Joker.Views;

namespace Joker;

public partial class MainWindow : Window
{
    public static int Role;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AdminButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Role = 1;
        var prog = new Prog();
        prog.Show();
        this.Close();
    }
    private void ManagerButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Role = 2;
        var prog = new Prog();
        prog.Show();
        this.Close();;
    }
}