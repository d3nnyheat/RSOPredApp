using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RSOPredApp;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void LoginAttempt(object? sender, RoutedEventArgs e)
    {
        if (LoginTextBox.Text == "admin" && PasswordTextBox.Text == "admin" || LoginTextBox.Text == "client" && PasswordTextBox.Text == "client")
        {
            MainMenu menu = new MainMenu();
            Hide();
            menu.Show(); 
        }
        else
        {
            LoginError.IsVisible = true;
        }
    }

    private void AppExit(object? sender, RoutedEventArgs e)
    {
        Environment.Exit(0);
    }
}