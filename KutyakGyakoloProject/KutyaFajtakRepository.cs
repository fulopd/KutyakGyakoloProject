using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakGyakoloProject
{
    class KutyaFajtakRepository
    {
        List<KutyaFajta> kutyaFajtakLista;

        public KutyaFajtakRepository()
        {
            kutyaFajtakLista = new List<KutyaFajta>();
            Beolvas();
        }

        private void Beolvas()
        {
            using (var sr = new StreamReader("forras/KutyaFajtak.csv"))
            {
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    var sor = sr.ReadLine().Split(';');
                    kutyaFajtakLista.Add(new KutyaFajta(
                        Convert.ToInt32(sor[0]),
                        sor[1],
                        sor[2]
                        ));
                }
            }
        }

        public KutyaFajta GetKutyaFajtaById(int id)
        {
            return kutyaFajtakLista.Find(x=>x.id.Equals(id));
        }
    }
}
