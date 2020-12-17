using System.Windows.Forms;

namespace Wifi.PlaylistEditor
{
    public interface INewPlaylistCreator
    {
        string Autor { get; }
        string Title { get; }

        DialogResult StartDialog();
    }
}