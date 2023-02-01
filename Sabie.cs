using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramRVL
{
    public class Sabie : ArticolInventar
    {
        public Sabie() : base(5, 3) { }
        public Sabie(float greutate, float volum) : base(greutate, volum)
        {
            this.greutate = greutate;
            this.volum = volum;
        }
    }
}
