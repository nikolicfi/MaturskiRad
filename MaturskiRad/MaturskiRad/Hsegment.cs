using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturskiRad
{
    class Hsegment:Segment
    {
        public override void SetSestougao()
        {
            rep.X = glava.X + a;
            rep.Y = glava.Y;
            sestougao[0] = glava;
            sestougao[1].X = sestougao[0].X + h; sestougao[1].Y = sestougao[0].Y - h;
            sestougao[2].X = sestougao[0].X + a - h; sestougao[2].Y = sestougao[0].Y - h;
            sestougao[3] = rep;
            sestougao[4].X = sestougao[0].X + a - h; sestougao[4].Y = sestougao[0].Y + h;
            sestougao[5].X = sestougao[0].X + h; sestougao[5].Y = sestougao[0].Y + h;
        }
    }
}
