using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramRVL
{
    public class ArticolInventar
    {
        public string numeArticol;
        public float greutate;
        public float volum;

        public ArticolInventar()
        {
            greutate = 0;
            volum = 0;
        }

        public ArticolInventar(float greutate, float volum)
        {
            this.greutate = greutate;
            this.volum = volum;
        }
    }
}
