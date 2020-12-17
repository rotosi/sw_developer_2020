using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace Wifi.PlaylistEditor.Items
{
  public class Mp3Item : IPlaylistItems
  {
    private string _path;
    private string _title;
    private string _artist;
    private TimeSpan _duration;
    private Image _thumbnail;
    private TagLib.IPicture[] _pictures;

    public Mp3Item(string path)
    {
      _path = path;
      Read(_path);

      if (string.IsNullOrWhiteSpace(_path) || !File.Exists(_path))
      {
        InitFieldsWithEmpty();
      }
      else
      {
        ReadIdv3TagsFromFile();
      }
    }
    private void InitFieldsWithEmpty()
    {
      _artist = string.Empty;
      _duration = TimeSpan.Zero;
      _thumbnail = null;
      _title = "--[File not found]--";
    }
    public string Title
    {
      get { return _title; }
      set
      {
        _title = value;
        var tfile = TagLib.File.Create(_path);
        tfile.Tag.Title = _title; //el nombre no se cambiara pero se ha creado por si al caso 
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
    public Image Thumbnail
    {
      get => _thumbnail;
      set => _thumbnail = value;
    }
    override public string ToString()
    {
      return _title + " (" + _artist + ")";

            //something is missing here form Atilla 
    }
    private void Read(string path)
    {
      var tfile = TagLib.File.Create(path);
      _title = tfile.Tag.Title;
      _duration = tfile.Properties.Duration;
      _artist = tfile.Tag.JoinedAlbumArtists; //firtAlbumArtist
      _pictures = tfile.Tag.Pictures;
    }
            



    private void ReadIdv3TagsFromFile()
    {
      var tfile = TagLib.File.Create(_path);

      _title = tfile.Tag.Title;
      _duration = tfile.Properties.Duration;
      _artist = tfile.Tag.FirstPerformer;

      if (tfile.Tag.Pictures != null && tfile.Tag.Pictures.Length > 0)
      {
        //https://stackoverflow.com/questions/10247216/c-sharp-mp3-id-tags-with-taglib-album-art
        _thumbnail = Image.FromStream(new MemoryStream(tfile.Tag.Pictures[0].Data.Data));
      }
      else
      {
        _thumbnail = null;
        Debug.WriteLine($"{System.IO.Path.GetFileName(_path)}: No Image stream found.");
      }
    }
  }
}