using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace LibraryGame.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public BitmapImage GameCover { get; set; }
    }
}
