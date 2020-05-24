using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutyakGyakoloProject
{
    class Program
    {
        static void Main(string[] args)
        {
            KutyakRepository repo = new KutyakRepository();
            //3. feladat
            Console.WriteLine("3. Feladat: Kutyanevek száma: " + repo.GetKutyaNevekCount());

            //6. feladat
            Console.WriteLine("6. feladat: Kutyák átlag életkora: {0}", repo.GetAtlagEletkor());

            //7. feladat
            var legidosebb = repo.GetLegidosebbKutya();
            Console.WriteLine("7. feladat: A legidősebb kutya neve és fajtája: " + legidosebb.nev.nev + ", " + legidosebb.fajta.nev);

            //8. feladat
            Console.WriteLine("8. feladat: Január 10. -én vizsgált kutya fajták:");
            repo.GetFajtankentStatisztika();

            //9. feladat
            Console.Write("9. feladat: ");
            repo.LegjobbanLeterhelveARendelo();

            //10. feladat
            repo.NevekStatFileba();
            Console.WriteLine("10. feladat: névstatisztika.txt");


            Console.ReadKey();
        }
    }
}
