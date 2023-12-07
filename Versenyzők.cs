using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace snookerWPF
{
    class Versenyzők
    {
        int helyezes;
        string nev;
        string orszag;
        int nyeremeny;


        public Versenyzők(int helyezes,string nev,string orszag,int nyeremeny)
        {
            this.helyezes = helyezes;
            this.nev = nev;
            this.orszag = orszag;
            this.nyeremeny = nyeremeny;
        }
        public Versenyzők(string sor) 
        {
            List<string> elemekLista = sor.Split(';').ToList();
            this.helyezes = int.Parse(elemekLista[0]);
            this.nev = elemekLista[1];
            this.orszag = elemekLista[2];
            this.nyeremeny = int.Parse(elemekLista[3]);
        }
        public int Helyezes { get => helyezes; }
        public string Nev { get => nev;}
        public string Orszag { get => orszag;}
        public int Nyeremeny { get => nyeremeny;}
    }
}
