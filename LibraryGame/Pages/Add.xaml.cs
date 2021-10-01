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
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        GameViewModel GameVM;
        Frame Frame;
        public Add()
        {
            InitializeComponent();
        }

        public Add(Frame frame1, GameViewModel gameVM)
        {
            InitializeComponent();
            this.Frame = frame1;
            this.GameVM = gameVM;
        }

        public void AddButton(object s, RoutedEventArgs e)
        {
            Game game = new Game();
            if(Tbox_title.Text == "" || Tbox_genre.Text == "" || Tbox_publisher.Text == "" || Tbox_date.Text == "")
            {
                MessageBox.Show("One of the field is empty!");
            }
            else
            {
                game.Title = Tbox_title.Text;
                game.Genre = Tbox_genre.Text;
                game.Publisher = Tbox_publisher.Text;
                game.ReleaseDate = DateTime.Parse(Tbox_date.Text);
                GameVM.AddRecord(game);
                MessageBox.Show("A game has been added!");
            }
        }
        public void BackButton(object s, RoutedEventArgs e)
        {
            this.Frame.NavigationService.GoBack();
        }

        private void Tbox_title_GotFocus(object s, RoutedEventArgs e)
        {
            Tbox_title.Text = "";
            Tbox_title.FontStyle = FontStyles.Normal;
            Tbox_title.FontWeight = FontWeights.Normal;
        }

        private void Tbox_genre_GotFocus(object s, RoutedEventArgs e)
        {
            Tbox_genre.Text = "";
            Tbox_genre.FontStyle = FontStyles.Normal;
            Tbox_genre.FontWeight = FontWeights.Normal;
        }
        private void Tbox_publisher_GotFocus(object s, RoutedEventArgs e)
        {
            Tbox_publisher.Text = "";
            Tbox_publisher.FontStyle = FontStyles.Normal;
            Tbox_publisher.FontWeight = FontWeights.Normal;
        }

        private void Tbox_date_GotFocus(object s, RoutedEventArgs e)
        {
            Tbox_date.FontStyle = FontStyles.Normal;
            Tbox_date.FontWeight = FontWeights.Normal;
        }
    }
}

