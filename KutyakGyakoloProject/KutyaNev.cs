using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakGyakoloProject
{
    class KutyaNev
    {
        //id;kutyanév
        //1;Akina
        public int id { get; set; }
        public string nev { get; set; }
        
        public KutyaNev(int id, string nev)
        {
            this.id = id;
            this.nev = nev;
        }

        


    }
}
