using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Items;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Factories
{
    public class PlaylistItemFactory : IPlaylistItemFactory
    {
        public IPlaylistItems Create(string filepath)
        {
            IPlaylistItems playlistItems = null;

            if (string.IsNullOrEmpty(filepath)) 
            {
                return null;
            }

            var extension = Path.GetExtension(filepath);

            switch (extension)
            {
             
                case ".mp3":
                    playlistItems = new Mp3Item(filepath);
                    break;

                //case ".jpg":
                //    playlistItems = new PictureItem(filepath); // cuando no es conocido el formato va a el default
                //    break;

                default:
                    playlistItems = null;
                    break;
            }

            return playlistItems;
        }
    }
}
