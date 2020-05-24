using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakGyakoloProject
{
    class KutyaNevekRepository
    {
        List<KutyaNev> kutyaNevekLista;

        public KutyaNevekRepository()
        {
            kutyaNevekLista = new List<KutyaNev>();
            Beolvas();
        }

        private void Beolvas()
        {
            using (var sr = new StreamReader("forras/KutyaNevek.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var sor = sr.ReadLine().Split(';');
                    kutyaNevekLista.Add(new KutyaNev(Convert.ToInt32(sor[0]), sor[1]));
                }
            }
        }

        public int Count()
        {
            return kutyaNevekLista.Count();
        }

        public KutyaNev GetKutyaNevById(int id)
        {
            return kutyaNevekLista.Find(x => x.id.Equals(id));
        }
    }
}
