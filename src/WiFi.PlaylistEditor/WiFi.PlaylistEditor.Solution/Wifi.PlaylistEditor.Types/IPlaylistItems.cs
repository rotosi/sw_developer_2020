using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor
{
    public interface IPlaylistItems
    {
        string Title { get; set; }
        string Artist { get; set; }
        TimeSpan Duration { get; }
        string Path { get; set; }
        Image Thumbnail { get; set; }          
    }
}
