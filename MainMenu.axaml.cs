using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace RSOPredApp;

public partial class MainMenu : Window
{
    public MainMenu()
    {
        InitializeComponent();
    }

    private void MembersButton_OnClick(object? sender, RoutedEventArgs e)
    {
        MembersForm mform = new MembersForm();
        Hide();
        mform.Show();
    }

    private void Logon_OnClick(object? sender, RoutedEventArgs e)
    {
        LoginWindow lw = new LoginWindow();
        Hide();
        lw.Show();
    }
}