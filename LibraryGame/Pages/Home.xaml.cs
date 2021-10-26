
using LibraryGame.Models;
using LibraryGame.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryGame.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        GameViewModel GameVM;
        Frame Frame;

        public Home()
        {
            InitializeComponent();
        }
        public Home(Frame frame1, GameViewModel gameVM)
        {
            InitializeComponent();
            this.Frame = frame1;
            this.GameVM = gameVM;
            this.GameGrid.ItemsSource = GameVM.Games;
        }

        private void GameGridAutoGeneratingColoumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "Id")
            {
                e.Column = null;
            }

            if (e.PropertyType == typeof(DateTime))
            {
                e.Column = new DataGridTextColumn()
                { 
                    Header = "Release Date",
                    Binding = new Binding(e.PropertyName) { StringFormat = "dd-MM-yyyy"}
                };
            }
        }

        private void AddButton(object s, RoutedEventArgs e)
        {
            Frame.Navigate(new Add(Frame, GameVM));
        }

        private void EditButton(object s, RoutedEventArgs e)
        {
            Game selectedGame = (Game)GameGrid.SelectedItem;
            Frame.Navigate(new Edit(Frame, GameVM, selectedGame));
        }

        private void DeleteButton(object s, RoutedEventArgs e)
        {
            Game game = (Game)GameGrid.SelectedItem;
            GameVM.DeleteRecord(game.Id);
            GameGrid.Items.Refresh();
        }
    }
}
