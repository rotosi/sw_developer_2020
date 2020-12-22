using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.PlaylistEditor.Properties;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor
{
    public partial class MainForm : Form
    {      

        Playlist _playlist = new Playlist();
        private readonly INewPlaylistCreator _newPlaylistCreator;
        private IPlaylistItemFactory _playlistFactory;

        public MainForm(INewPlaylistCreator newPlaylistCreator, IPlaylistItemFactory _playlistItemFactory) //intansierung von constructor 
        {
            InitializeComponent();
            _newPlaylistCreator = newPlaylistCreator;
            _playlistFactory = _playlistItemFactory;
        }        

        private static ListViewItem createListViewItem(IPlaylistItems item)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = item.ToString();
            lvi.Tag = item;
            return lvi;
        }
        //nuevo desde items
        //private void newToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FormEditMp3 editMp3 = new FormEditMp3();
        //    if (editMp3.ShowDialog() == DialogResult.OK)
        //    {
        //        Items.Mp3Item mp3 = new Items.Mp3Item(editMp3.GetPath());
        //        //mp3.Artist = editMp3.GetArtist();
        //        //mp3.Title = editMp3.GetTitle();                
        //        var lvi = createListViewItem(mp3);
        //        ListView1.Items.Add(lvi);
        //    }
        //}
        //remove desde itnems
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListView1.SelectedItems)
            {
                ListView1.Items.Remove(item);
            }
        }
        //clear all from items
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView1.Items.Clear();
        }
        //remove item from sweeping broom 
        private void ClearAllList_Click(object sender, EventArgs e)
        {
            //ListView1.Items.Clear();

            _playlist.Clear();

            //update view

            lbl_playlistDetails.Text = string.Empty; // se limpia toda la lista incluso la parte de abajo la del pie de pagina
            DisplayPlaylistDetails(_playlist);
            DisplayPlaylistItems(_playlist);


        }
        //create a new file from icon file
        private void NewPlaylistButton_Click(object sender, EventArgs e)
        {
            //frm_newPlaylist newPlaylistDialog = new frm_newPlaylist(); //llamamos la clase del dialogo donde esta el autor y el titulo

            if (_newPlaylistCreator.StartDialog() != DialogResult.OK)
                {
                return;
            }

            var title = _newPlaylistCreator.Title;
            var autor = _newPlaylistCreator.Autor; //levamos todos los datos del usuario a la clase principal

            //now create new playlist // instaciamos la clase // levamos todos los datos del usuario a la clase principal 
            _playlist = new Playlist(title, autor, DateTime.Now);

            //update view
            enableItemCommands(true);
            DisplayPlaylistDetails(_playlist);
            DisplayPlaylistItems(_playlist);
        }

        private void DisplayPlaylistItems(Playlist playlist)
        {
            int index = 0;

            ListView1.Items.Clear();
            imageList1.Images.Clear();

            foreach (var item in playlist.ItemList)
            {
                ListViewItem lvi = new ListViewItem(item.ToString());
                lvi.ImageIndex = index;
                lvi.Tag = item;

                if (item.Thumbnail != null)
                {
                    imageList1.Images.Add(item.Thumbnail);
                }
                else
                {
                    imageList1.Images.Add(Resources.no_image);
                }                

                ListView1.Items.Add(lvi);
                index++;
            }
            ListView1.LargeImageList = imageList1;

        }

        private void DisplayPlaylistDetails(Playlist playlist)
        {
            lbl_playlistTitle.Text = playlist.Name;
            lbl_playlistDetails.Text =$"Spielzeit: { playlist.Duration} | Autor: { playlist.Autor}"; //este muestra en la parte de arriba y abajo
        }

        //clear all from icon
        private void RemoveItemFromList_Click(object sender, EventArgs e)
        {
            //foreach (ListViewItem item in ListView1.SelectedItems)
            //{
            //    ListView1.Items.Remove(item);
            //}

            var playlistItems = GetSelectedPlaylistItem();
            if (playlistItems != null)
            {
                _playlist.Remove(playlistItems);

                //
                DisplayPlaylistDetails(_playlist);
                DisplayPlaylistItems(_playlist);
               
            }
        }

        private void AddNewItemToPlaylist_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            foreach (var file in OpenFileDialog1.FileNames)
            {
                var item = _playlistFactory.Create(file);
                if (item != null)
                { 
                _playlist.Add(item);
                }
            }

            //update view
            DisplayPlaylistDetails(_playlist);
            DisplayPlaylistItems(_playlist);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbl_playlistTitle.Text = string.Empty;
            //Playlist Dauer: 00:15:12 | Autor: Sia
            lbl_playlistDetails.Text = "Spielzeit: 00:00:00 | Autor: -";

            enableItemCommands(false);
        }

        private void enableItemCommands(bool enabled) // cuando queremos que las cosas inicien desabled
        {
            toolStripButton4.Enabled = enabled;
            toolStripButton5.Enabled = enabled;
            toolStripButton6.Enabled = enabled;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var ListViewIem in ListView1.SelectedItems)
            {

                var playlistItems = GetSelectedPlaylistItem();
                if (playlistItems != null) 
                {
                    //artist: Max Sänger
                    lbl_playlistDetails.Text = $"Artist {playlistItems.Artist} | Title: {playlistItems.Title} " +
                                               $"| Duration: {playlistItems.Duration.ToString("hh\\:mm\\:ss")} |  {playlistItems.Path }" ;
                }


            }
        }

        private IPlaylistItems GetSelectedPlaylistItem()
        {
            foreach (ListViewItem item in ListView1.SelectedItems)
            {
                return item.Tag as IPlaylistItems;
            
            }
            return null;
        }
        
    }
}
