using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramRVL
{
    public class Sageata : ArticolInventar
    {
        public Sageata() : base(0.1f, 0.05f) { }
        public Sageata(float greutate, float volum) : base(greutate, volum)
        {
            this.greutate = greutate;
            this.volum = volum;
        }
    }
}
