using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramRVL
{
    public class Ghiozdan
    {
        List<ArticolInventar> articole = new List<ArticolInventar>();     
        int maxArticole;
        float maxGreutate;
        float maxVolum;

        public int NumarArticole => articole.Count;
        public float Greutate => CalculeazaGreutate();
        public float Volum => CalculeazaVolum();
        public int MaxArticole => maxArticole;
        public float MaxGreutate => maxGreutate;
        public float MaxVolum => maxVolum;

        public Ghiozdan(int maxArticole, float maxGreutate, float maxVolum)
        {
            this.maxArticole = maxArticole;
            this.maxGreutate = maxGreutate;
            this.maxVolum = maxVolum;
        }

        private float CalculeazaGreutate()
        {
            return articole.Sum(art => art.greutate);
        }

        private float CalculeazaVolum()
        {
            return articole.Sum(art => art.volum);
        }

        public bool Adauga(ArticolInventar articol)
        {
            float greutate = CalculeazaGreutate();
            float volum = CalculeazaVolum();

            if (articole.Count > maxArticole || greutate + articol.greutate > maxGreutate || volum + articol.volum > maxVolum)
            {
                return false;
            }

            articole.Add(articol);

            return true;
        }


    }
}
