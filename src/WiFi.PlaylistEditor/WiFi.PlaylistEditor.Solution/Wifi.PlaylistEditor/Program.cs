using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Wifi.PlaylistEditor.PlaylistCreators;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Applikation start
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var container = new UnityContainer();

            //Type registrieren
            container.RegisterType<INewPlaylistCreator, frm_newPlaylist>();
            container.RegisterType<IPlaylistItemFactory, IPlaylistItemFactory>();

            //konkrete instanzen erzeugen
            //INewPlaylistCreator playlistCreator = new frm_newPlaylist();
            //INewPlaylistCreator playlistCreator = new DummyCreator(); //con esta clase no se llama el dialogo sino que se muestra directamente el autor titulo en el encabezado del form

           // IPlaylistItemFactory playlistItemFactory = new IPlaylistItemFactory();


            Application.Run(container.Resolve<MainForm>());
        }
    }
}
