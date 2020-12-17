using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylistItemFactory
    {
        IPlaylistItems Create(string filepath);
        //hacer n filtro para leer solo mp3 formatos

    }
}
