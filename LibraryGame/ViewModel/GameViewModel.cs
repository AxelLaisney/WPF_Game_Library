using LibraryGame.Models;
using LibraryGame.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace LibraryGame.ViewModel
{
    public class GameViewModel
    {
        public ObservableCollection<Game> Games { get; set; }
        private GameRepository GameRepository { get; set; }

        public GameViewModel()
        {
            GameRepository = new GameRepository();
            Games = new ObservableCollection<Game>(GameRepository.gameRepository);
            Games.CollectionChanged += Games_CollectionChanged;
        }

        private void Games_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                int newIndex = e.NewStartingIndex;
                GameRepository.AddRecordDB(Games[newIndex]);
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                List<Game> TempGamesList = e.OldItems.OfType<Game>().ToList();
                GameRepository.DeleteRecordDB(TempGamesList[0].Id);
            }
            else if(e.Action == NotifyCollectionChangedAction.Replace)
            {
                List<Game> TempGameList = e.NewItems.OfType<Game>().ToList();
                GameRepository.EditRecordDB(TempGameList[0]);
            }
        }

        public void DeleteRecord(int id)
        {
            if (id < 0)
            {
                throw new Exception("ID can't be negative");
            }

            int i = 0;
            while (i < Games.Count)
            {
                if(Games[i].Id == id)
                {
                    Games.RemoveAt(i);
                    break;
                }
                i++;
            }
        }

        public void AddRecord(Game game)
        {
            if (game == null)
            {
                throw new ArgumentNullException("Error: argument null");
            }

            Games.Add(game);
        }

        public void EditRecord(Game game)
        {
            if (game.Id < 0)
            {
                throw new Exception("Error: Negative ID");
            }

            int i = 0;
            while(i < Games.Count)
            {
                if(Games[i].Id == game.Id)
                {
                    Games[i] = game;
                    break;
                }
                i++;
            }
        }
    }
}
