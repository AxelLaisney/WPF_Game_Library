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
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Page
    {
        private Frame Frame;
        private GameViewModel GameVM;
        private Game Game;

        public Edit()
        {
            InitializeComponent();
        }

        public Edit(Frame frame1, GameViewModel gameVM, Game game1)
        {
            InitializeComponent();
            this.Frame = frame1;
            this.GameVM = gameVM;
            this.Game = game1;

            this.Tbox_title.Text = game1.Title;
            this.Tbox_genre.Text = game1.Genre;
            this.Tbox_publisher.Text = game1.Publisher;
            this.Tbox_date.Text = game1.ReleaseDate.ToString();
        }


        private void EditButtonClick(object s, RoutedEventArgs e)
        {
            Game updatedGame = new Game();
            updatedGame.Id = Game.Id;
            updatedGame.Title = Tbox_title.Text;
            updatedGame.Genre = Tbox_genre.Text;
            updatedGame.Publisher = Tbox_publisher.Text;
            updatedGame.ReleaseDate = DateTime.Parse(Tbox_date.Text);
            GameVM.EditRecord(updatedGame);
            MessageBox.Show("A game has been edited");
        }

        private void BackButtonClick(object s, RoutedEventArgs e)
        {
            this.Frame.NavigationService.GoBack();
        }
    }
}
