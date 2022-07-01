using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MaturskiRad
{
    class Display
    {
        Vsegment[] vertical = new Vsegment[4];
        Hsegment[] horizontal = new Hsegment[3];

        public Display(Point glava, int a, int h)
        {
            for (int i = 0; i < 3; i++)
            {
                horizontal[i] = new Hsegment();
                horizontal[i].Postavi(glava);
                glava.Y += 10 * h;
            }

            vertical[0] = new Vsegment();
            vertical[1] = new Vsegment();
            vertical[2] = new Vsegment();
            vertical[3] = new Vsegment();

            vertical[0].Postavi(new Point(glava.X - h / 4, glava.Y - 7 * h - a));
            vertical[1].Postavi(new Point(glava.X + 4 * h + a, glava.Y - 7 * h - a));
            vertical[2].Postavi(new Point(glava.X + 4 * h + a, glava.Y - 13 * h - 2 * a));
            vertical[3].Postavi(new Point(glava.X - h / 4, glava.Y - 13 * h - 2 * a));
        }

        public void CrtajDisplay(Graphics g)
        {
            for (int i = 0; i < 3; i++)
            {
                horizontal[i].Crtaj(g);
            }
            vertical[0].Crtaj(g);
            vertical[1].Crtaj(g);
            vertical[2].Crtaj(g);
            vertical[3].Crtaj(g);

        }
        public void ObojCifru(bool[] current, Graphics g)
        {
            for (int i = 0; i < 3; i++)
            {
                if (current[i]) horizontal[i].Pali(g);
                else horizontal[i].Gasi(g);
            }

            if (current[3]) vertical[0].Pali(g);
            else vertical[0].Gasi(g);
            if (current[4]) vertical[1].Pali(g);
            else vertical[1].Gasi(g);
            if (current[5]) vertical[2].Pali(g);
            else vertical[2].Gasi(g);
            if (current[6]) vertical[3].Pali(g);
            else vertical[3].Gasi(g);
        }
    }
}
