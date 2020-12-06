using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Items
{
    class mp3Item : IPlaylistItems
    {
        private string _title;
        private string _artist;
        private TimeSpan _duration;
        private string _path;


        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        public TimeSpan Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }


    }
}
