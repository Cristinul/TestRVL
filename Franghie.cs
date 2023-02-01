using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramRVL
{
    public class Franghie : ArticolInventar
    {
        public Franghie() : base(1, 1.5f) { }
        public Franghie(float greutate, float volum) : base(greutate, volum)
        {
            this.greutate = greutate;
            this.volum = volum;
        }
    }
}
