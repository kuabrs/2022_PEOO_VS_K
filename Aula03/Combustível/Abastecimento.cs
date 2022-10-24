using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustível
{
    class Abastecimento
    {
        private double Vl, Vp, kmr;
        public void SetValorL(double v)
        {
            if (v > 0) Vl = v;
        }
        public void SetValorP(double v)
        {
            if (v > 0) Vp = v;
        }
        public void Setkmr(double v)
        {
            if (v > 0) kmr = v;
        }
        public double Mkml()
        {
            return kmr / (Vp / Vl);
        }
        public double MVkm() => Vp / kmr;
        
    }
}
