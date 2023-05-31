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
        private void getExecutionSpeed()
        {
            if (rbStepByStep.Checked == true)
            {
                timer1.Interval = 1;
            }
            else if (rbVerySlow.Checked == true)
            {
                timer1.Interval = 2500;
            }
            else if (rbSlow.Checked == true)
            {
                timer1.Interval = 2000;
            }
            else if (rbNormal.Checked == true)
            {
                timer1.Interval = 1000;
            }
            else if (rbFast.Checked == true)
            {
                timer1.Interval = 500;
            }
        }
        private void buttonStartSort_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnContinuer.Enabled = true;
            ShellSort();
        }
        private void ShellSort()
        {
            getExecutionSpeed();
            int n = tab.Length;
            int gap = n / 2;
            int i = gap;
            timer1.Tick += (sender, e) =>
            {
                if (i < n)
                {
                    int temp = tab[i];
                    int j;
                    for (j = i; j >= gap && tab[j - gap] > temp; j -= gap)
                    {
                        tab[j] = tab[j - gap];
                        dc.DisplayElements(tab, panelResultat, Font);
                    }
                    tab[j] = temp;
                    dc.DisplayElements(tab, panelResultat, Font);
                    i++;
                }
                else
                {
                    timer1.Stop();
                    btnContinuer.Enabled = false; // Désactive le bouton "Continuer" lorsque le tri est terminé
                }
            };
            timer1.Start();
        }

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}