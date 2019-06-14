using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace Democrazik


{
    public partial class Form2 : Form    {


        string filePath;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void BPlay_Click(object sender, EventArgs e)
        {
            MediaFile file = listBox1.SelectedItem as MediaFile;
            if (file != null)
            {
                axWindowsMediaPlayer1.URL = file.Path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void BStop_Click(object sender, EventArgs e)
        {
            MediaFile file = listBox1.SelectedItem as MediaFile;
            if (file != null)
            {
                axWindowsMediaPlayer1.URL = file.Path;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.Ctlcontrols.next();
            }
        }

        private void BPause_Click(object sender, EventArgs e)
        {

            MediaFile file = listBox1.SelectedItem as MediaFile;
            if (file != null)
            {
                axWindowsMediaPlayer1.URL = file.Path;
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }

        private void BPath_Click(object sender, EventArgs e)
        {



                using (FolderBrowserDialog fb = new FolderBrowserDialog()){

                 DialogResult result = fb.ShowDialog();

                 if (result == DialogResult.OK)
                 {

                     String[] files = Directory.GetFiles(fb.SelectedPath);
                      List<MediaFile> f = new List<MediaFile>();
                     List<filePath> fp = new List<filePath>{};

                     foreach (string fil in files)
                     {
                          FileInfo fi = new FileInfo(fil);
                          f.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                         //FileInfo fin = new FileInfo(fil);
                        // fp.Add(new filePath() { adresse = fin.FullName });

                     }
                        listBox1.DataSource = f;

                    /* List<MediaFile> f = new List<MediaFile>();
                         foreach (var filo in fp)
                          {
                             FileInfo fi = new FileInfo(filo);
                          f.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                          }
                         listBox1.DataSource = f;
                         */
                }

             }   




           /* using (OpenFileDialog o = new OpenFileDialog()
            {
                Multiselect = true,
                ValidateNames = true,
                Filter = "WMV|*.wmv|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv"
            })
            {
                if (o.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile> f = new List<MediaFile>();
                    foreach (var fil in o.FileNames)
                    {
                        FileInfo fi = new FileInfo(fil);
                        f.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                    }
                    listBox1.DataSource = f;

                }
            }*/


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.ValueMember = "Path";
            listBox1.DisplayMember = "FileName";

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile file = listBox1.SelectedItem as MediaFile;
            if (file != null)
            {
                axWindowsMediaPlayer1.URL = file.Path;
                /*axWindowsMediaPlayer1.Ctlcontrols.play();*/
            }

        }

        private void BNext_Click(object sender, EventArgs e)
        {/*
            Form3 frm = new Form3();
            frm.Show();
            this.Close();*/
        }

        
    }
}
