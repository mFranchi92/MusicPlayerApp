using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        List<string> trackPaths = new List<string>();

        String[] paths, files;

        private void selectSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    songList.Items.Add(files[i]);
                }
                for (int i = 0; i < paths.Length; i++)
                {
                    trackPaths.Add(paths[i]);
                }
            }
        }

        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = trackPaths[songList.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
