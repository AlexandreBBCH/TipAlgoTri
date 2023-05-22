using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoTri
{
    public partial class FrmShell : Form
    {
        int[] tab = Enumerable.Range(1, 20).OrderBy(x => Guid.NewGuid()).Take(20).ToArray();
        DisplayClass dc;
        public FrmShell()
        {
            InitializeComponent();
            dc = new DisplayClass();
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
                        dc.DisplayElements(tab, panelResultat, Font);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(500);
                    }

                    tab[j] = temp;
                }

                gap /= 2;
            }

         
        }

     

    }
}