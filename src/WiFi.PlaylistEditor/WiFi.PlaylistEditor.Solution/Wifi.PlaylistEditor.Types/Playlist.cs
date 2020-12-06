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
        private List<IPlaylistItems> _itemList = new List<IPlaylistItems>();

        private IPlaylistRepository _repository = new JsonRepository();  

        public List<IPlaylistItems> ItemList
        {
            get { return _itemList; }
            set { _itemList = value; }
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

    }
}
