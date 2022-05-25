using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_reg
{
        //Bok klassen som lägger till författare och antal sidor 
    class Book : Media
    {
        public string Author { get; set; }

        public string NrOfPages { get; set; }

        //bok klassens översättning till en string
        public override string ToString()
        {
            return Title + " (" + Author + ", " + NrOfPages + " sidor)";
        }
    }
}
