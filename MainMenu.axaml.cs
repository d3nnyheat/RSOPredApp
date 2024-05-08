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

    private void CatalogButton_OnClick(object? sender, RoutedEventArgs e)
    {
        CatalogForm catalogForm = new CatalogForm();
        Hide();
        catalogForm.Show();
    }

    private void StaffButton_OnClick(object? sender, RoutedEventArgs e)
    {
        StaffForm staffForm = new StaffForm();
        Hide();
        staffForm.Show();
    }

    private void OrdersButton_OnClick(object? sender, RoutedEventArgs e)
    {
        OrdersForm orders = new OrdersForm();
        Hide();
        orders.Show();
    }

    private void SquadButton_OnClick(object? sender, RoutedEventArgs e)
    {
        SquadForm squadForm = new SquadForm();
        Hide();
        squadForm.Show();
    }

    private void LaureatesButton_OnClick(object? sender, RoutedEventArgs e)
    {
        LaureatesForm lf = new LaureatesForm();
        Hide();
        lf.Show();
    }

    private void EventsButton_OnClick(object? sender, RoutedEventArgs e)
    {
        EventsForm eventsForm = new EventsForm();
        Hide();
        eventsForm.Show();
    }
}