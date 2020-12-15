using System;
using System.Collections.Generic;

namespace Wifi.PlaylistEditor
{
    public interface IPlaylist
    {
        string Autor { get; set; }
        int Count { get; }
        DateTime CreateArt { get; }
        TimeSpan Duration { get; }
        IEnumerable<IPlaylistItems> ItemList { get; }
        string Name { get; set; }

        void Add(IPlaylistItems item);
        void Clear();
        void Load();
        void Remove(IPlaylistItems item);
        void Save();
    }
}