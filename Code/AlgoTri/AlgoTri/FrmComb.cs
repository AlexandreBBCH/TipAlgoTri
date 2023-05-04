using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoTri
{
    public partial class FrmComb : Form
    {
        int[] tab = Enumerable.Range(1, 20).OrderBy(x => Guid.NewGuid()).Take(20).ToArray();
        int currentGap;
        bool hasSwapped = true;

        public FrmComb()
        {
            currentGap = tab.Length;
            InitializeComponent();

        }

        private void btnStartSort_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hasSwapped)
            {
                hasSwapped = false;
                for (int i = 0; i < tab.Length - currentGap; i++)
                {
                    int j = i + currentGap;
                    if (tab[i] > tab[j])
                    {
                        int temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;
                        hasSwapped = true;
                    }
                }
            }
            else
            {
                if (currentGap > 1)
                {
                    currentGap = (int)(currentGap / 1.3);
                }
                else
                {
                    currentGap = 1;
                    hasSwapped = true;
                }
            }

            DisplayElements();

            // Si le tri est terminé, continuer à afficher le dernier tableau
            if (currentGap == 1 && !hasSwapped)
            {
                currentGap = 0;
            }
        }


        private void DisplayElements()
        {
            int rectWidth = 30;
            int rectHeightFactor = 10;
            int rectSpacing = 10;
            int rectXOffset = 20;
            int rectYOffset = 20;

            Graphics g = panelResultat.CreateGraphics();
            g.Clear(Color.White);

            for (int i = 0; i < tab.Length; i++)
            {
                int rectHeight = tab[i] * rectHeightFactor;
                int rectX = rectXOffset + i * (rectWidth + rectSpacing);
                int rectY = rectYOffset + (200 - rectHeight);

                Rectangle rect = new Rectangle(rectX, rectY, rectWidth, rectHeight);
                g.DrawRectangle(Pens.Black, rect);
                g.DrawString(tab[i].ToString(), Font, Brushes.Black, rectX, rectY + rectHeight + 5);
            }
        }
    }
}
