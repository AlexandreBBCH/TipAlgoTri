using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlgoTri
{
    public partial class FrmInsert : Form
    {
        // Initialise un tableau de 20 entiers, triés aléatoirement à l'aide de la méthode OrderBy().
        int[] tab = Enumerable.Range(1, 20).OrderBy(x => Guid.NewGuid()).Take(20).ToArray();
        // Initialise un entier pour stocker l'index de la prochaine valeur à insérer
        int nextIndex;
        // Initialise un booléen pour indiquer si le tri est terminé
        bool isSorted = false;
        private string[] pseudoCodeLines = {
            "TANT QUE(currentIndex > 0 ET tab[currentIndex - 1] > nextValue)",
            "tab[currentIndex] = tab[currentIndex - 1]",
            "currentIndex = currentIndex - 1",
            "FIN TANT QUE",
            "tab[currentIndex] = nextValue",
            "nextIndex = nextIndex + 1",
            "SI(nextIndex = taille de tab)",
            "isSorted = VRAI",
            "btnContinuer.Enabled = FAUX",
            "FIN SI",
        };
        int currentPseudoCodeLine = 0;

        DisplayClass dc;

        public FrmInsert()
        {
            // Initialise l'index à 1, car le premier élément est considéré comme trié
            nextIndex = 1;
            InitializeComponent();
            dc = new DisplayClass();
        }

        bool isRunning;
        private void getExecutionSpeed()
        {
            if (rbStepByStep.Checked == true)
            {
                timer1.Interval = 1;
                isRunning = false;
            }
            else if (rbVerySlow.Checked == true)
            {
                timer1.Interval = 2500;
                isRunning = true;
            }
            else if (rbSlow.Checked == true)
            {
                timer1.Interval = 2000;
                isRunning = true;

            }
            else if (rbNormal.Checked == true)
            {
                timer1.Interval = 1000;
                isRunning = true;

            }
            else if (rbFast.Checked == true)
            {
                timer1.Interval = 500;
                isRunning = true;

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


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Si toutes les valeurs ont été triées, arrêter le timer
            if (isSorted)
            {
                timer1.Stop();
                return;
            }

            // Récupère la prochaine valeur à insérer et son index
            int nextValue = tab[nextIndex];
            int currentIndex = nextIndex;

            // Boucle sur les valeurs triées précédentes pour trouver la position d'insertion
            while (currentIndex > 0 && tab[currentIndex - 1] > nextValue)
            {
                // Déplace la valeur triée vers la droite pour faire de la place pour l'insertion
                tab[currentIndex] = tab[currentIndex - 1];
                currentIndex--;
            }

            // Insère la valeur à sa position correcte
            tab[currentIndex] = nextValue;

            // Incrémente l'index de la prochaine valeur à insérer
            nextIndex++;

            // Si toutes les valeurs ont été insérées, le tableau est trié
            if (nextIndex == tab.Length)
            {
                isSorted = true;
                btnContinuer.Enabled = false;
            }

            currentPseudoCodeLine++;

            ExecutePseudoCodeLine(currentPseudoCodeLine);

            if (currentPseudoCodeLine >= pseudoCodeLines.Length)
            {
                currentPseudoCodeLine = 0; // Revenir à la première ligne de pseudo-code
            }

            // Met à jour l'affichage
            dc.DisplayElements(tab, panelResultat, Font);

            // Arrêter le timer à chaque étape
            if (!isRunning)
            {
                timer1.Stop();
            }
        
        }

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            stepByStepState++;
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        int stepByStepState = 1;


        private void ExecutePseudoCodeLine(int lineIndex)
        {
            stepByStepState++;
            if (pseudoCodeLines.Length - 1 > lineIndex)
            {
                txbPseudoCode.Text = pseudoCodeLines[lineIndex];
            }
            else
            {
                currentPseudoCodeLine = 0;
            }
        }

    }
}


