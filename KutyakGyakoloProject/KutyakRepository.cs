using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakGyakoloProject
{
    class KutyakRepository
    {
        List<Kutya> kutyakLista;
        KutyaFajtakRepository kf = new KutyaFajtakRepository();
        KutyaNevekRepository kn = new KutyaNevekRepository();

        public KutyakRepository()
        {
            kutyakLista = new List<Kutya>();
            Beolvas();
        }
        public int GetKutyaNevekCount()
        {
            return kn.Count();
        }
        private void Beolvas()
        {
            using (var sr = new StreamReader("forras/Kutyak.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    var sor = sr.ReadLine().Split(';');
                    kutyakLista.Add(new Kutya(
                        Convert.ToInt32(sor[0]),
                        kf.GetKutyaFajtaById(Convert.ToInt32(sor[1])),
                        kn.GetKutyaNevById(Convert.ToInt32(sor[2])),
                        Convert.ToInt32(sor[3]),
                        Convert.ToDateTime(sor[4])
                        ));
                }
            }
        }

        public double GetAtlagEletkor()
        {
            var atlag = kutyakLista.Average(x => x.eletkor);
            atlag = Math.Round(atlag, 2);
            return atlag;
        }

        public Kutya GetLegidosebbKutya()
        {
            return kutyakLista.OrderByDescending(x => x.eletkor).ToList()[0];            
        }

        public void GetFajtankentStatisztika()
        {
            var fajtankent = kutyakLista.Where(x => x.utolsoorvosiellenorzes.Equals(new DateTime(2018, 01, 10))).GroupBy(x=>x.fajta.nev).ToList();
            foreach (var item in fajtankent)
            {
                Console.WriteLine("\t{0,-30} {1} kutya",item.Key, item.Count());
            }
        }

        public void LegjobbanLeterhelveARendelo()
        {
            var terhelve = kutyakLista.GroupBy(x => x.utolsoorvosiellenorzes).OrderByDescending(x=> x.Count()).ToList();

            Console.WriteLine("Legjobban leterhelt nap: " + terhelve[0].Key.ToShortDateString() + ": " +terhelve[0].Count() + " kutya");
        }

        public void NevekStatFileba()
        {
            var nevek = kutyakLista.GroupBy(x => x.nev.nev).OrderByDescending(x => x.Count()).ToList();
            using (var sw = new StreamWriter("Nevstatisztika.txt", false, Encoding.UTF8))
            {
                nevek.ForEach(x => sw.WriteLine(x.Key + ";" + x.Count()));
            }
        }
    }
}
