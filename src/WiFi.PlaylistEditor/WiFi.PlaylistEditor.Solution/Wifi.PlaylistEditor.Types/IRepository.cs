using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor
{
    public interface IRepository : FileIdentifier
    {
        //string Extension { get; set; }
        //string Description { get; set; }

        void Load();
        void Save(string filepath, IPlaylist playlist);

        IPlaylist Load(string filePath);
    }

   
}

