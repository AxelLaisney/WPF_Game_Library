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

        }
        public void BackButton(object s, RoutedEventArgs e)
        {
            this.Frame.NavigationService.GoBack();
        }
    }

}
