using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakGyakoloProject
{
    class KutyaFajta
    {
        //id;név;eredeti név
        //1; Abruzzói juhászkutya; Cane da pastore Maremmano-Abruzzese
        public int id { get; set; }
        public string nev { get; set; }
        public string eredetiNev { get; set; }
        
        public KutyaFajta(int id, string nev, string eredetiNev)
        {
            this.id = id;
            this.nev = nev;
            this.eredetiNev = eredetiNev;
        }

    }
}
