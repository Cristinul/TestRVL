using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramRVL
{
    public class PortieDeMancare : ArticolInventar
    {
        public PortieDeMancare() : base(1, 0.5f) { }
        public PortieDeMancare(float greutate, float volum) : base(greutate, volum)
        {
            this.greutate = greutate;
            this.volum = volum;
        }
    }
}
