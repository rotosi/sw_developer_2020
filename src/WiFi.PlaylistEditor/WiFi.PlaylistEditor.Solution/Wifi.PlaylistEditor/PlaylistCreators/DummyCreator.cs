using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi.PlaylistEditor.PlaylistCreators
{
    public class DummyCreator : INewPlaylistCreator
    {
        public string Autor => "Gandalf de Wiese";

        public string Title => "Superplaylist Charts 2020";

        public DialogResult StartDialog()
        {
            throw new NotImplementedException();
        }
    }
}
