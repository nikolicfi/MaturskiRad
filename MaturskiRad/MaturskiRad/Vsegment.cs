using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturskiRad
{
    class Vsegment:Segment
    {
        public override void SetSestougao()
        {
            rep.X = glava.X;
            rep.Y = glava.Y - a;
            sestougao[0] = glava;
            sestougao[1].X = sestougao[0].X + h; sestougao[1].Y = sestougao[0].Y - h;
            sestougao[2].X = sestougao[0].X + h; sestougao[2].Y = sestougao[0].Y - a + h;
            sestougao[3] = rep;
            sestougao[4].X = sestougao[0].X - h; sestougao[4].Y = sestougao[0].Y - a + h;
            sestougao[5].X = sestougao[0].X - h; sestougao[5].Y = sestougao[0].Y - h;
        }
    }
}
