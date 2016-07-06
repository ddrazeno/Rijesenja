using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceleratio_ZAD2
{
    public class Popis
    {
        List<Zadatak> zadToDo { get; set; }
        List<Zadatak> zadInProg { get; set; }
        List<Zadatak> zadDone { get; set; }

        public Popis()
        {
            zadToDo = new List<Zadatak>();
            zadInProg = new List<Zadatak>();
            zadDone = new List<Zadatak>();
        }

        public void Dodaj(Zadatak zad)
        {
            if (zad != null)
            {
                zadToDo.Add(zad);
            }
        }

        public void OznaciInProg(int id)
        {
            Zadatak zad = zadToDo[id];
            zad.stanje = "In Progress";
            zadInProg.Add(zad);
            zadToDo.Remove(zad);
        }

        public List<Zadatak> DohvatiToDo()
        {
            return zadToDo;
        }

        public List<Zadatak> DohvatiinProg()
        {
            return zadInProg;
        }

        public List<Zadatak> DohvatiDone()
        {
            return zadDone;
        }
    }
}
