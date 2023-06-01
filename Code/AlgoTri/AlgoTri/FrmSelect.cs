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
    public partial class FrmSelect : Form
    {
        int[] tab = Enumerable.Range(1, 20).OrderBy(x => Guid.NewGuid()).Take(20).ToArray();
        int nextIndex;
        bool isSorted = false;
        DisplayClass dc;
        private string[] pseudoCodeLines = {
        "SI(isSorted)",
        "timer1.Stop()",
        "RETOURNER",
        "FIN SI",
        "minIndex = nextIndex",
        "POUR i = nextIndex + 1 JUSQU\'A tab.Longueur",
        "SI(tab[i] < tab[minIndex])",
        "minIndex = i",
        "FIN POUR",
        "temp = tab[nextIndex - 1]",
        "tab[nextIndex - 1] = tab[minIndex]",
        "tab[minIndex] = temp",
        "nextIndex = nextIndex + 1",
        "SI(nextIndex == tab.Longueur)",
        "isSorted = VRAI",
        "btnContinuer.Enabled = FAUX",
        "dc.DisplayElements(tab, panelResultat, Font)"
    };
        int currentPseudoCodeLine = 0;
        bool isStepByStepMode = false;

        public FrmSelect()
        {
            nextIndex = 1;
            InitializeComponent();
            dc = new DisplayClass();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isSorted)
            {
                timer1.Stop();
                if (!IsArraySorted(tab))
                {
                    Array.Sort(tab);
                    dc.DisplayElements(tab, panelResultat, Font);
                }
                return;
            }

            int minIndex = nextIndex;
            for (int i = nextIndex + 1; i < tab.Length; i++)
            {
                if (tab[i] < tab[minIndex])
                {
                    minIndex = i;
                }
            }

            int temp = tab[nextIndex - 1];
            tab[nextIndex - 1] = tab[minIndex];
            tab[minIndex] = temp;

            nextIndex++;

            if (nextIndex == tab.Length)
            {
                isSorted = true;
                btnContinuer.Enabled = false;
            }

            ExecutePseudoCodeLine(currentPseudoCodeLine);
            currentPseudoCodeLine++;
            if (currentPseudoCodeLine >= pseudoCodeLines.Length)
            {
                currentPseudoCodeLine = 0;
            }

            dc.DisplayElements(tab, panelResultat, Font);

            if (isStepByStepMode)
            {
                timer1.Stop();
            }
        }

        private bool IsArraySorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        private void getExecutionSpeed()
        {
            if (rbStepByStep.Checked)
            {
                isStepByStepMode = true;
                timer1.Interval = 1;
            }
            else
            {
                isStepByStepMode = false;
                if (rbVerySlow.Checked)
                {
                    timer1.Interval = 2500;
                }
                else if (rbSlow.Checked)
                {
                    timer1.Interval = 2000;
                }
                else if (rbNormal.Checked)
                {
                    timer1.Interval = 1000;
                }
                else if (rbFast.Checked)
                {
                    timer1.Interval = 500;
                }
            }
        }

        private void buttonStartSort_Click(object sender, EventArgs e)
        {
            getExecutionSpeed();
            btnStop.Enabled = true;
            btnContinuer.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            if (isStepByStepMode)
            {
                timer1.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void ExecutePseudoCodeLine(int lineIndex)
        {
            txbPseudoCode.Text = pseudoCodeLines[lineIndex];
        }
    }
}
