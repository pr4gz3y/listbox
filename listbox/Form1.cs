using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        static List<int> feltoltes = new List<int>();
        static List<int> bfeltoltes = new List<int>();
        static List<int> ametszetb = new List<int>();
        static List<int> auniob = new List<int>();
        static List<int> aminusb = new List<int>();
        static List<int> bminusa = new List<int>();
        Random rand = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void feltolt_Click(object sender, EventArgs e)
        {
            ahalmaz.Items.Clear();
            bhalmaz.Items.Clear();
            ab.Items.Clear();
            ba.Items.Clear();
            aunio.Items.Clear();
            ametszet.Items.Clear();

            auniob.Clear();
            ametszetb.Clear();
            feltoltes.Clear();
            bfeltoltes.Clear();

            for (int i = 0; i < aszam.Value; i++)
            {
                int max = Convert.ToInt32(aszam.Value);
                int szam = rand.Next(0, 20);

                while (feltoltes.Contains(szam))
                {
                    szam = rand.Next(1, 20);
                }


                feltoltes.Add(szam);
            }

            feltoltes.Sort();
            foreach (var item in feltoltes)
            {
                ahalmaz.Items.Add(item);
            }

            for (int i = 0; i < bszam.Value; i++)
            {
                int szam = rand.Next(1, 20);

                while (bfeltoltes.Contains(szam))
                {
                    szam = rand.Next(1, 20);
                }

                
                bfeltoltes.Add(szam);
            }

            bfeltoltes.Sort();

            foreach (var item in bfeltoltes)
            {
                bhalmaz.Items.Add(item);
            }

            foreach (var item in feltoltes)
            {
                auniob.Add(item);
            }

            foreach (var item in bfeltoltes)
            {
                if (!auniob.Contains(item))
                {
                    auniob.Add(item);
                }
            }

            auniob.Sort();

            foreach (var item in auniob)
            {
                aunio.Items.Add(item);
            }

            foreach (var item in feltoltes)
            {
                if (bfeltoltes.Contains(item))
                {
                    ametszetb.Add(item);
                }
            }

            ametszetb.Sort();

            foreach (var item in ametszetb)
            {
                ametszet.Items.Add(item);
            }

            foreach (var item in feltoltes)
            {
                if (!bfeltoltes.Contains(item))
                {
                    aminusb.Add(item);
                }
            }

            aminusb.Sort();

            foreach (var item in aminusb)
            {
                ab.Items.Add(item);
            }

            foreach (var item in bfeltoltes)
            {
                if (!feltoltes.Contains(item))
                {
                    bminusa.Add(item);
                }
            }

            bminusa.Sort();

            foreach (var item in bminusa)
            {
                ba.Items.Add(item);
            }
        }
    }
}
