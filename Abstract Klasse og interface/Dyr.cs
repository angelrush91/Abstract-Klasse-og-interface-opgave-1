using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Klasse_og_interface
{
    abstract class Dyr
    {

        private string navn;

        public string Navn
        { 
            get { return navn; } 
            set { navn = value; }
        }
        public abstract string Eating();
        


    }
}
