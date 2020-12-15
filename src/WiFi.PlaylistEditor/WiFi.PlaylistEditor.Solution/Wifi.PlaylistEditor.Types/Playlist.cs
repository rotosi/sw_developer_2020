using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor
{
    public class Playlist : IPlaylist
    {
        public Playlist() { }

        private string _name;
        private string _autor;
        private DateTime _createArt;
        private List<IPlaylistItems> _itemList = new List<IPlaylistItems>();
        private IPlaylistRepository _repository = new M3uRepository();

        //constructor
        public Playlist(string name, string author, DateTime createAt)
        {
            _name = name;
            _autor = author;
            _createArt = createAt;
        }

        public DateTime CreateArt
        {
            get { return _createArt; }
        }
        public IEnumerable<IPlaylistItems> ItemList
        {
            get { return _itemList; }
        }
        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void Add(IPlaylistItems item)
        {
            _itemList.Add(item);
            //_itemList.Add(newItem);
        }
        public void Remove(IPlaylistItems item)
        {
            _itemList.Remove(item);
        }
        public void Clear()
        {
            _itemList.Clear();
        }
        public void Load()
        {
            _repository.Load();
        }
        public void Save()
        {
            _repository.Save();
        }

        public TimeSpan Duration
        {
            get
            {
                TimeSpan duration = TimeSpan.Zero;

                if (ItemList != null)
                {
                    foreach (var item in ItemList)
                    {
                        duration = duration.Add(item.Duration);
                    }
                }
                return duration;
            }
        }

        public int Count
        {
            get => _itemList.Count;
        }
    }
}
