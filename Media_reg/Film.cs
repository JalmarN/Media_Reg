using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_reg
{
    //Film klassen som lägger till regissör och filmlängd.
    class Film : Media
    {
        public string Director { get; set; }

        public string Length { get; set; }

        //film klassens översättning till en string
        public override string ToString()
        {
            return this.Title + " (" + this.Director + ", " + this.Length + " minuter)".ToString();
        }
    }
}
