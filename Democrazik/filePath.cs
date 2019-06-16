using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Democrazik
{
    class filePath
    {
       public string adresse;

               string path = @"C:\Users\Nathael\Documents\";
               string ext = "*.mp3";
               string[] listFilesCurrDir = System.IO.Directory.GetFiles(path, ext);
               List<string> lsArtist = new List<string>();
               List<Artiste> lsArtistes = new List<Artiste>();
               foreach (string file in listFilesCurrDir){

                    var tfile = TagLib.File.Create(@pathToPlay);
                    string title = tfile.Tag.Title;
                    string artist = tfile.Tag.Artist;
                    string genre = tfile.Tag.Genre;

                    if (!lsArtist.Contains(artist)){
                        lsArtist.Add(artist);
                        
                        

	{

	})


        // string pathOfFile = @"C:\Users\Nathael\Desktop\tel\SD\Sons\Booba - Nouvelle Ecole.mp3";
        //var tfile = TagLib.File.Create(@pathToPlay);
        //string title = tfile.Tag.Title;

        // string pathToPlay;
        // axWindowsMediaPlayer1.URL = pathToPlay;

    }
}
