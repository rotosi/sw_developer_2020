using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Items
{
    class PictureItem : IPlaylistItems
    {

        private string _title;
        private string _artist;
        private TimeSpan _duration;
        private string _path;
        private Image _thumbnail;

        public Image Thumbnail
        {
            get { return _thumbnail; }
            set { _thumbnail = value; }
        }


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
        }
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        
    }
}
