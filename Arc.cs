using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramRVL
{
    public class Arc : ArticolInventar
    {
        public Arc() : base(1, 4) { }
        public Arc(float greutate, float volum) : base(greutate, volum)
        {
            this.greutate = greutate;
            this.volum = volum;
        }
    }
}
