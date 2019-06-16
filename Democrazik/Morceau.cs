using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Democrazik
{
    class Morceau
    {
        public long id { get; set; }
        public String titre { get; set; }
        public virtual Session session { get; set; }
        public virtual Artiste artiste { get; set; }
        public virtual Genre genre { get; set; }
        public String chemin { get; set; }
    }
}