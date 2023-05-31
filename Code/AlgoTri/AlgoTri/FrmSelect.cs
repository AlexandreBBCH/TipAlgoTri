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
        // Initialise un tableau de 20 entiers, triés aléatoirement à l'aide de la méthode OrderBy().
        int[] tab = Enumerable.Range(1, 20).OrderBy(x => Guid.NewGuid()).Take(20).ToArray();
        // Initialise un entier pour stocker l'index de la prochaine valeur à insérer
        int nextIndex;
        // Initialise un booléen pour indiquer si le tri est terminé
        bool isSorted = false;
        DisplayClass dc;
        public FrmSelect()
        {
            // Initialise l'index à 1, car le premier élément est considéré comme trié
            nextIndex = 1;
            InitializeComponent();
            dc = new DisplayClass();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Si toutes les valeurs ont été triées, arrêter le timer
            if (isSorted)
            {
                timer1.Stop();
                return;
            }

            // Recherche la valeur minimale dans la partie non triée du tableau
            int minIndex = nextIndex;
            for (int i = nextIndex + 1; i < tab.Length; i++)
            {
                if (tab[i] < tab[minIndex])
                {
                    minIndex = i;
                }
            }

            // Echange la valeur minimale avec la première valeur de la partie non triée du tableau
            int temp = tab[nextIndex - 1];
            tab[nextIndex - 1] = tab[minIndex];
            tab[minIndex] = temp;

            // Incrémente l'index de la prochaine valeur à insérer
            nextIndex++;

            // Si toutes les valeurs ont été insérées, le tableau est trié
            if (nextIndex == tab.Length)
            {
                isSorted = true;
                btnContinuer.Enabled = false; // Désactive le bouton "Continuer"
            }

            // Met à jour l'affichage
            dc.DisplayElements(tab, panelResultat, Font);
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
            getExecutionSpeed();
            btnStop.Enabled = true;
            btnContinuer.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
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
