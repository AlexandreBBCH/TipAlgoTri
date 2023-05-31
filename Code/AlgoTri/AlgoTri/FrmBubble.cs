using System.Timers;

namespace AlgoTri
{
    public partial class FrmBubble : Form
    {
        // Liste à trier
        int[] tab = Enumerable.Range(1, 20).OrderBy(x => Guid.NewGuid()).Take(20).ToArray();
        DisplayClass dc;
        private string[] pseudoCodeLines = {
            "POUR i allant de 0 à longueur(tab) - 1 - currentElementIndex FAIRE",
            "SI tab[i] > tab[i + 1] ALORS",
            "ÉCHANGER tab[i] ET tab[i + 1]",
            "hasSwapped <- vrai",
            "FIN SI",
            "FIN POUR"
        };
        // Variable de l'élément actuel
        int currentElementIndex = 0;
        int currentPseudoCodeLine = 0;
        public FrmBubble()
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

        private void btnStartSort_Click(object sender, EventArgs e)
        {
            // Définit l'intervalle de temps entre deux appels de la méthode timer1_Tick à 500ms
            getExecutionSpeed();
            btnStop.Enabled = true;
            btnContinuer.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool hasSwapped = false;
            // Boucle sur les éléments du tableau non triés
            for (int i = 0; i < tab.Length - 1 - currentElementIndex; i++)
            {
                // Si l'élément courant est supérieur à l'élément suivant
                if (tab[i] > tab[i + 1])
                {
                    // Met de manière temporaire la valeur de l'élément actuel, remplace la valeur de l'élément actuel avec l'élément qui vient
                    // la valeur de l'élément suivant prend celle de "temp", "hasSwapped" est donc vrai
                    int temp = tab[i];
                    tab[i] = tab[i + 1];
                    tab[i + 1] = temp;
                    hasSwapped = true;
                }
            }
            ExecutePseudoCodeLine(currentPseudoCodeLine);

            currentPseudoCodeLine++; // Passer à la prochaine ligne de pseudo-code

            if (currentPseudoCodeLine >= pseudoCodeLines.Length)
            {
                currentPseudoCodeLine = 0; // Revenir à la première ligne de pseudo-code
            }
            dc.DisplayElements(tab, panelResultat, Font);

            currentElementIndex++; // Incrémente l'index de l'élément actuel

            if (!hasSwapped || currentElementIndex >= tab.Length) // Si aucun échange ou si tous les éléments sont déjà triés
            {
                // On stop tout
                btnContinuer.Enabled = false;
                ((System.Windows.Forms.Timer)sender).Stop();
                // L'élément actuel revient à 0;
                currentElementIndex = 0;
            }
        }
        private void ExecutePseudoCodeLine(int lineIndex)
        {
            // Mettre à jour le TextBox avec la ligne de pseudo-code en cours d'exécution
            txbPseudoCode.Text = pseudoCodeLines[lineIndex];
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
