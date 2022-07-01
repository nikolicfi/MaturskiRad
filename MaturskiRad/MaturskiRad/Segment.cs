using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MaturskiRad
{
    abstract class Segment
    {
        public Point glava, rep;
        public int h = 10;
        public int a;
        Color bojaOn = Color.Transparent;
        Color bojaOff = Color.Transparent;
        public Point[] sestougao = new Point[6];


        public void Postavi(Point glava)
        {
            this.glava = glava;
            a = 8 * h;
            SetSestougao();
        }

        public void Postavi(Point glava, int a, int h)
        {
            if (a >= 4 * h)
            {
                this.glava = glava;
                this.h = h;
                this.a = a;
                SetSestougao();
            }
            else
            {
                throw new Exception("Mora biti dužina segmenta veća.");
            }

        }
        public void Crtaj(Graphics g)
        {
            Pen p = new Pen(bojaOn, 2);
            SolidBrush b = new SolidBrush(bojaOff);
            g.DrawPolygon(p, sestougao);
            g.FillPolygon(b, sestougao);
        }

        public void Pali(Graphics g)
        {
            Pen p = new Pen(bojaOn, 2);
            g.DrawPolygon(p, sestougao);
            SolidBrush bp = new SolidBrush(Color.Red);
            g.FillPolygon(bp, sestougao);
        }

        public void Gasi(Graphics g)
        {
            Pen p = new Pen(bojaOn, 2);
            g.DrawPolygon(p, sestougao);
            SolidBrush b = new SolidBrush(Color.Transparent);
            g.FillPolygon(b, sestougao);

        }
        public virtual void SetSestougao() { }
    }

}
