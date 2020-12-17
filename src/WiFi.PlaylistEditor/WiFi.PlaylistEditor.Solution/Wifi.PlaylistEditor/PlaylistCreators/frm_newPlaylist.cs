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
    public partial class frm_newPlaylist : Form, INewPlaylistCreator
    {
        public frm_newPlaylist()
        {
            InitializeComponent();
        }

        private void Frm_newPlaylist_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        public string Title
        {

            get
            {
                return txt_title.Text;
            }
        }

        public string Autor
        {

            get => txt_autor.Text;

        }


        public DialogResult StartDialog()
        {
            return (ShowDialog());
        }


        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_title.Text) || string.IsNullOrWhiteSpace(txt_autor.Text))

                MessageBox.Show("Title und Author dürfen nicht leer sein!", "Fehlereingabe",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
