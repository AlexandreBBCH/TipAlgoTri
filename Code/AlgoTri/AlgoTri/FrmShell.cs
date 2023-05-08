using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoTri
{
    public partial class FrmShell : Form
    {
        int[] tab = Enumerable.Range(1, 20).OrderBy(x => Guid.NewGuid()).Take(20).ToArray();
        public FrmShell()
        {
            InitializeComponent();
        }

        private void buttonStartSort_Click(object sender, EventArgs e)
        {
            ShellSort();
        }
        private void ShellSort()
        {
            int n = tab.Length;
            int gap = n / 2;
            Graphics g = panelResultat.CreateGraphics();

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = tab[i];

                    int j;
                    for (j = i; j >= gap && tab[j - gap] > temp; j -= gap)
                    {
                        tab[j] = tab[j - gap];
                        DisplayElements(g);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(500);
                    }

                    tab[j] = temp;
                }

                gap /= 2;
            }

            DisplayElements(g);
        }

        private void DisplayElements(Graphics g)
        {
            int rectWidth = 30;
            int rectHeightFactor = 10;
            int rectSpacing = 10;
            int rectXOffset = 20;
            int rectYOffset = 20;

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