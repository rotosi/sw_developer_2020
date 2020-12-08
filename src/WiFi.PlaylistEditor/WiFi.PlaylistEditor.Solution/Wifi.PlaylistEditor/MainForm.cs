using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi.PlaylistEditor
{
    public partial class MainForm : Form
    {
        Playlist playlist = new Playlist();
        public MainForm()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private static ListViewItem createListViewItem(IPlaylistItems item)
        {            
            ListViewItem lvi = new ListViewItem();
            lvi.Text = item.ToString();
            lvi.Tag = item;             
            return lvi;
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditMp3 editMp3 = new FormEditMp3();
            if (editMp3.ShowDialog() == DialogResult.OK)
            {
                Items.Mp3Item mp3 = new Items.Mp3Item(editMp3.GetPath());
                //mp3.Artist = editMp3.GetArtist();
                //mp3.Title = editMp3.GetTitle();                
                var lvi = createListViewItem(mp3);
                listView.Items.Add(lvi);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView.SelectedItems)
            {
                listView.Items.Remove(item);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
        }
    }
}
