using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor
{
    public class Playlist
    {
        public Playlist() {}

        private string _name;
        private string _autor;
        private DateTime _createArt;
        private List<IPlaylistItems> _itemList = new List<IPlaylistItems>();       



        

        public DateTime CreateArt 
        {
            get { return _createArt; }            
        }      


        private IPlaylistRepository _repository = new M3uRepository();  

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

                if (_itemList != null)
                {
                  

                    foreach (var item in _itemList)
                    {
                        duration = duration.Add(_itemList.Duration);
                    }

                   // duration = TimeSpan.FromSeconds(_itemList.Sum(x => x.Duration.TotalSeconds));
                }

                return duration;
            }
        }

    }
}
