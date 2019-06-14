using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Democrazik
{
    class Morceaux
    {
        public String titre { get; set; }
        
        public virtual Session session { get; set; }
        public virtual Artiste artiste { get; set; }

    }
}
