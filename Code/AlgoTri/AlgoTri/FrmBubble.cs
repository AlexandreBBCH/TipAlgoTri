using System.Timers;

// Auteurs : Zamader Achraf, Babich Alexandre
// Date : 01.06.23
// Fichier : FrmBubble.cs

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
        bool isRunning;
        private void getExecutionSpeed()
        {
            if (rbStepByStep.Checked == true)
            {
                //timer1.Interval = 1;
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

        private void btnStartSort_Click(object sender, EventArgs e)
        {
            // Définit l'intervalle de temps entre deux appels de la méthode timer1_Tick à 500ms
            getExecutionSpeed();
            btnStop.Enabled = true;
            btnContinuer.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start(); 
        }
        private int currentStep = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isRunning == true || currentStep >= 1)
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
                        if (isRunning == true || currentStep == 2)
                        {
                            int temp = tab[i];
                            tab[i] = tab[i + 1];
                            tab[i + 1] = temp;
                            hasSwapped = true;
                            //currentPseudoCodeLine++;
                            ExecutePseudoCodeLine(currentPseudoCodeLine);
                            currentStep = 5;
                    
                        }
                
                }
            }

          
            ExecutePseudoCodeLine(currentPseudoCodeLine);// Passer à la prochaine ligne de pseudo-code

            if (currentPseudoCodeLine >= pseudoCodeLines.Length)
            {
                currentPseudoCodeLine = 0; // Revenir à la première ligne de pseudo-code
            }
            dc.DisplayElements(tab, panelResultat, Font);

           // Incrémente l'index de l'élément actuel

            if ((!hasSwapped || currentElementIndex >= tab.Length) && isRunning) // Si aucun échange ou si tous les éléments sont déjà triés
            {
                // On stop tout
                btnContinuer.Enabled = false;
                ((System.Windows.Forms.Timer)sender).Stop();
                // L'élément actuel revient à 0;
                currentElementIndex = 0;
            }

          }
        }
        private void ExecutePseudoCodeLine(int lineIndex)
        {
            // Mettre à jour le TextBox avec la ligne de pseudo-code en cours d'exécution
            currentStep++;
           
            if (pseudoCodeLines.Length-1 > lineIndex)
            {
                txbPseudoCode.Text = pseudoCodeLines[lineIndex];
            }
            else
            { 
                
                currentPseudoCodeLine = 0;

            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        const int MAX_STEP = 4;
        private void btnContinuer_Click(object sender, EventArgs e)
        {
            currentStep++;
            currentPseudoCodeLine++;
            if (currentStep > MAX_STEP)
            {
                currentStep = 1;
            }
        }
    }
}
