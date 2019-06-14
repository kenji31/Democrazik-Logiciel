using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Democrazik
{
    public partial class Form1 : Form
    {
        Session s = new Session();
        public Form1()
        {
            InitializeComponent();
        }

        private void BNomServ_Click(object sender, EventArgs e)
        {
            
            s.nom = textBox1.Text;
            
        }

        private void BUrlServ_Click(object sender, EventArgs e)
        {
            s.code = textBox2.Text;
        }

        private void BLancer_Click(object sender, EventArgs e)
        {
            var uri = "http://localhost:8080/session";

            Uri u = new Uri(uri);
            string sesJso = JsonConvert.SerializeObject(s);

            HttpContent c = new StringContent(sesJso, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(u, c));
            t.Wait();
            MessageBox.Show(t.Result, "res", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Form2 frm = new Form2();
            frm.Show();
           
        }


        static async Task<string> PostURI(Uri u, HttpContent c)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.PostAsync(u, c);
                if (result.IsSuccessStatusCode)
                {
                    response = result.StatusCode.ToString();
                }
            }
            return response;
        }

        static async Task<string> GetURI(Uri u)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(u);
                if (result.IsSuccessStatusCode)
                {
                    response = await result.Content.ReadAsStringAsync();
                }
            }
            return response;
        }




        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();



            //test envois morceaux
            /*---------------------------------------------------------------------------------------------------
            Artiste ar = new Artiste();
             ar.nom = "Barbara";

            List<Artiste> art = new List<Artiste>();
            List<Morceaux> mrc = new List<Morceaux>();
            art.Add(ar);
             // art.Add(new Artiste { nom = "Green Day" });
            //  mrc.Add(new Morceaux { titre = "Killer Queen" });
            mrc.Add(new Morceaux { titre = "l'aigle noir", session = s, artiste = ar });

            foreach (var a in art)
            {

                var uri = "http://localhost:8080/artiste"; //--------------------------------------------------------------------------------------------------------

                Uri u = new Uri(uri);
                string sesJso = JsonConvert.SerializeObject(a);

                HttpContent c = new StringContent(sesJso, Encoding.UTF8, "application/json");
                var t = Task.Run(() => PostURI(u, c));
                t.Wait();
                MessageBox.Show(t.Result, "artiste Envoye", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //--------------------------------------------------------------------------------------------------------------------



                var t2 = Task.Run(() => GetURI(new Uri("http://localhost:8080/artistes/{"+ ar.nom +"}")));
                t2.Wait();
                //     JArray j = Newtonsoft.Json.Linq.JArray.Parse(t2.Result);
                Console.WriteLine(t2.Result);
                Console.ReadLine();

                List<Artiste> artouste = JsonConvert.DeserializeObject<List<Artiste>>(t2.Result);
                //Artiste myDeserializedObj = (Artiste)JavaScriptConvert.DeserializeObject(GetURI(new Uri("http://localhost:8080/artistes/{" + ar.nom + "}")));, typeof(Artiste));
                ar.id = 30;
            }



            mrc.Add(new Morceaux { titre = "Holidays", session = s, artiste = ar });



            foreach (var mo in mrc)
            {

                var uri = "http://localhost:8080/morceau"; //--------------------------------------------------------------------------------------------------------

                Uri u = new Uri(uri);
                string sesJso = JsonConvert.SerializeObject(mo);

                HttpContent c = new StringContent(sesJso, Encoding.UTF8, "application/json");
                var t = Task.Run(() => PostURI(u, c));
                t.Wait();
               // MessageBox.Show(t.Result, "res", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }*/

        }





    }


}
