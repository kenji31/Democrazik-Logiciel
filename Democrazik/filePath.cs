using Democrazik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Democrazik
{
    class filePath
    {

        static HttpClient client = new HttpClient();

        static async Task<Artiste> CreateArtisteAsync(Artiste artiste)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/artiste", artiste);
            response.EnsureSuccessStatusCode();

            artiste = await response.Content.ReadAsAsync<Artiste>();

            // return URI of the created resource.
            return artiste;
        }

        static async Task<Genre> CreateGenreAsync(Genre genre)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/genre", genre);
            response.EnsureSuccessStatusCode();

            genre = await response.Content.ReadAsAsync<Genre>();

            // return URI of the created resource.
            return genre;
        }

        static async Task<Session> CreateSessionAsync(Session session)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/session", session);
            response.EnsureSuccessStatusCode();

            session = await response.Content.ReadAsAsync<Session>();

            // return URI of the created resource.
            return session;
        }

        static async Task<Morceau> CreateMorceauAsync(Morceau morceau)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/morceau", morceau);
            response.EnsureSuccessStatusCode();

            morceau = await response.Content.ReadAsAsync<Morceau>();

            // return URI of the created resource.
            return morceau;
        }

        static async Task<Morceau> GetNextMorceauAsync(string id)
        { 
            Morceau morceau = null;
            HttpResponseMessage response = await client.GetAsync($"api/next-morceau/{id}");
            if (response.IsSuccessStatusCode)
            {
                morceau = await response.Content.ReadAsAsync<Morceau>();
            }
            return morceau;
        }

        static async Task<HttpStatusCode> DeleteSessionAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/sessions/{id}");
            return response.StatusCode;
        }

        static async Task<HttpStatusCode> DeleteVotesOfMorceauAsync(string id) // cette fois on envoie l'id du morceau
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/vote/morceau/{id}");
            return response.StatusCode;
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));


            public string adresse;

            string path = "C:\Users\Nathael\Documents\";
            string ext = "*.mp3";
            String[] listFilesCurrDir = System.IO.Directory.GetFiles(@path, ext);
        
            foreach (String file in listFilesCurrDir){

                var tfile = TagLib.File.Create(@file);
                String title = tfile.Tag.Title;
                String artist = tfile.Tag.Artist;
                String genre = tfile.Tag.Genre;
                    
        
                if (artist.Equals(""){
                    artist = "Anonyme";
                }

                if (genre.Equals(""){
                    genre = "Indéterminé";
                }

                Morceau m = new Morceau();

                morceau.titre.set(title);
                morceau.chemin.set(path+file);
                morceau.session.set(session); //voir comment recuperer la session actuelle
                Artiste a = new Artiste();
                a.nom.set(artist);
                Genre g = new Genre();
                g.nom.set(genre);
                a = CreateArtisteAsync(a);
                g = CreateGenreAsync(g);
                morceau.artiste.set(a);
                morceau.genre.set(g);
                m = CreateMorceauAsync(m);

            }
        }

    }
        // string pathToPlay;
        // axWindowsMediaPlayer1.URL = pathToPlay;

}
