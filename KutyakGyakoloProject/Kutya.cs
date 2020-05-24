using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakGyakoloProject
{
    class Kutya
    {
        //id;fajta_id;név_id;életkor;utolsó orvosi ellenőrzés
        //1;307;107;14;2017.11.27
        public int id { get; set; }
        public KutyaFajta fajta { get; set; }
        public KutyaNev nev { get; set; }
        public int eletkor { get; set; }
        public DateTime utolsoorvosiellenorzes { get; set; }
       
        public Kutya(int id, KutyaFajta fajta, KutyaNev nev, int eletkor, DateTime utolsoorvosiellenorzes)
        {
            this.id = id;
            this.fajta = fajta;
            this.nev = nev;
            this.eletkor = eletkor;
            this.utolsoorvosiellenorzes = utolsoorvosiellenorzes;
        }

    }
}
