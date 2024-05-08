using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MySql.Data.MySqlClient;

namespace RSOPredApp;

public partial class LaureatesForm : Window
{
    public LaureatesForm()
    {
        InitializeComponent();
        string fullTableShow = "SELECT * FROM laureate;";
        ShowTable(fullTableShow);
    }
    private List<Laureate> laureate;
    private string connString = "server=localhost;database=rsodatabase;User Id=root;password=landoNorris4";
    private MySqlConnection conn;
    private void ShowTable(string sql)
    {
        laureate = new List<Laureate>();
        conn = new MySqlConnection(connString);
        conn.Open();
        MySqlCommand command = new MySqlCommand(sql, conn);
        MySqlDataReader reader = command.ExecuteReader();
        while (reader.Read() && reader.HasRows)
        {
            var fulllaureate = new Laureate()
            {
                ID = reader.GetInt32("ID"),
                Surname = reader.GetString("Surname"),
                Name = reader.GetString("Name"),
                Award_Name = reader.GetString("Award_Name"),
                ID_Staff = reader.GetInt32("ID_Staff")
            };
            laureate.Add(fulllaureate);
        }
        conn.Close();
        LaureateGrid.ItemsSource = laureate;
    }
    private void SearchTextBox_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        var laureates = laureate;
        laureates = laureates.Where(x => x.Surname.Contains(SearchTextBox.Text)).ToList();
        LaureateGrid.ItemsSource = laureates;
    }

    private void BackToMenu(object? sender, RoutedEventArgs e)
    {
        MainMenu menu = new MainMenu();
        Close();
        menu.Show();
    }
}