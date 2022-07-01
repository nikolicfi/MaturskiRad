using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MaturskiRad
{
    public partial class Form1 : Form
    {
        int a = 40, h = 10;
        bool[] curr1 = new bool[7];
        bool[] curr2 = new bool[7];
        bool[] curr3 = new bool[7];
        bool[] curr4 = new bool[7];
        int broj1, broj2;

        bool[] NadjiCifru(int cifra)
        {
            bool[] c = new bool[7];
            switch (cifra)
            {


                case 0:
                    c = Cifra.Cifra0;
                    break;
                case 1:
                    c = Cifra.Cifra1;
                    break;
                case 2:
                    c = Cifra.Cifra2;
                    break;
                case 3:
                    c = Cifra.Cifra3;
                    break;
                case 4:
                    c = Cifra.Cifra4;
                    break;
                case 5:
                    c = Cifra.Cifra5;
                    break;
                case 6:
                    c = Cifra.Cifra6;
                    break;
                case 7:
                    c = Cifra.Cifra7;
                    break;
                case 8:
                    c = Cifra.Cifra8;
                    break;
                case 9:
                    c = Cifra.Cifra9;
                    break;
                case 10:
                    c = Cifra.Cifra0;
                    break;
            }
            return c;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            curr1 = NadjiCifru(broj1 / 10);
            curr2 = NadjiCifru(broj1 % 10);
            Point glava = new Point(ClientRectangle.Width / 10 - a / 10, ClientRectangle.Height / 6);
            Display Domaci = new Display(glava, a, h);
            Domaci.CrtajDisplay(e.Graphics);
            glava = new Point(ClientRectangle.Width / 10 - a / 10 + 4 * a, ClientRectangle.Height / 6);
            Display Domaci2 = new Display(glava, a, h);
            Domaci2.CrtajDisplay(e.Graphics);

            // Display za goste
            curr3 = NadjiCifru(broj2 / 10);
            curr4 = NadjiCifru(broj2 % 10);

            // Display za domace
            glava = new Point(ClientRectangle.Width / 2 + 5 * a, ClientRectangle.Height / 6);
            Display Gosti = new Display(glava, a, h);
            Gosti.CrtajDisplay(e.Graphics);
            glava = new Point(ClientRectangle.Width / 2 + 9 * a, ClientRectangle.Height / 6);
            Display Gosti2 = new Display(glava, a, h);
            Gosti2.CrtajDisplay(e.Graphics);

            Domaci.ObojCifru(curr1, e.Graphics);
            Domaci2.ObojCifru(curr2, e.Graphics);
            Gosti.ObojCifru(curr3, e.Graphics);
            Gosti2.ObojCifru(curr4, e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (broj1 < 99)
            {
                broj1++;
                Refresh();
            }
            else
            {
                MessageBox.Show("Broj ne može biti veći od 99!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (broj1 > 0)
            {
                broj1--;
                Refresh();
            }
            else
            {
                MessageBox.Show("Broj ne može biti negativan!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (broj2 < 99)
            {
                broj2++;
                Refresh();
            }
            else
            {
                MessageBox.Show("Broj ne može biti veći od 99!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (broj2 > 0)
            {
                broj2--;
                Refresh();
            }
            else
            {
                MessageBox.Show("Broj ne može biti negativan!");
            }
        }
    }
}
