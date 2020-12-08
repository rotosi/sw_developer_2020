using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Wifi.PlaylistEditor.Items
{
    public class Mp3Item : IPlaylistItems
    {
        private string _path;
        private string _title;
        private string _artist;
        private TimeSpan _duration;
        private TagLib.IPicture[] _pictures;

        public Mp3Item(string path)
        {
            _path = path;
            Read(_path);
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                var tfile = TagLib.File.Create(_path);
                tfile.Tag.Title = _title;
                tfile.Save();
            }
        }
        public string Artist
        {
            get { return _artist; }
            set
            {
                _artist = value;
                var tfile = TagLib.File.Create(_path);
                tfile.Tag.AlbumArtists = new string[] { _artist };
                tfile.Save();
            }
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
        override public string ToString()
        {
            return _title + " (" + _artist + ")";
        }

        private void Read(string path)
        {
            var tfile = TagLib.File.Create(path);
            _title = tfile.Tag.Title;
            _duration = tfile.Properties.Duration;
            _artist = tfile.Tag.JoinedAlbumArtists;
            _pictures = tfile.Tag.Pictures;            
        }
    }
}
