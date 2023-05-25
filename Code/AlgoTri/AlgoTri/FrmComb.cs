using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlgoTri
{
    public partial class FrmComb : Form
    {
        // Initialise un tableau de 20 entiers, triés aléatoirement à l'aide de la méthode OrderBy().
        int[] tab = Enumerable.Range(1, 20).OrderBy(x => Guid.NewGuid()).Take(20).ToArray();

        // Initialise un entier pour stocker la taille actuelle de l'intervalle de tri
        int currentGap;

        // Initialise un booléen pour indiquer si des échanges ont été effectués lors de la dernière itération de tri.
        bool hasSwapped = true;

        int currentPseudoCodeLine = 0;

        // Gestion du mode pas à pas
        private bool isRunning = false;
        private bool isPaused = false;
        private int currentStep = 1;
        private string[] pseudoCodeLines = {
            "SI(isRunning est vrai ou currentStep est supérieur ou égal à 1) ET non isPaused ALORS",
            "SI hasSwapped est vrai ALORS",
            "Afficher les éléments du tableau",
            "Attendre 200 millisecondes",
            "SI hasSwapped est vrai ALORS",
            "hasSwapped est faux",
            "SI(isRunning est vrai ou currentStep est supérieur ou égal à 2) ALORS",
            "POUR i allant de 0 à la longueur du tableau moins currentGap FAIRE",
            "j<- i + currentGap",
            "SI tab[i] est plus grand que tab[j] ALORS",
            "SI (isRunning est vrai ou currentStep est égal à 3) ALORS",
            "Échanger les éléments tab[i] et tab[j]",
            "hasSwapped est vrai",
            "currentStep <- 5",
            "SINON",
            "SI (isRunning est vrai ou currentStep est supérieur ou égal à 2) ALORS",
            "SI currentGap est supérieur à 1 ALORS",
            "currentGap <- arrondi(currentGap / 1.3)",
            "SINON",
            "currentGap<- 1",
            "hasSwapped est vrai",
            "SI (isRunning est vrai ou currentStep est supérieur ou égal à 3) ALORS",
            "SI hasSwapped est vrai ALORS",
            "Afficher les éléments du tableau",
            "SI(isRunning est vrai ou currentStep est supérieur ou égal à 4) ALORS",
            "SI currentGap est égal à 1 ET hasSwapped est faux ALORS",
            "currentGap <- 0",
            "Arrêter timer1",
            "FIN SI"
        };
        const int MAX_STEP = 4;

        DisplayClass dc;

        public FrmComb()
        {
            // Initialise la taille de l'intervalle de tri à la taille du tableau
            currentGap = tab.Length;
            InitializeComponent();
            dc = new DisplayClass();
        }

        private void btnStartSort_Click(object sender, EventArgs e)
        {
            // Définit l'intervalle de temps entre chaque itération de tri
            getExecutionSpeed();

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Si on a déjà effectué un échange lors du dernier cycle
            if ((isRunning == true || currentStep >= 1) && !isPaused)
            {
                if (hasSwapped)
                {
                    dc.DisplayElements(tab, panelResultat, Font);
                }

                System.Threading.Thread.Sleep(200);

                if (hasSwapped)
                {
                    // On repart du principe qu'il n'y aura pas d'échange
                    hasSwapped = false;

                    if (isRunning == true || currentStep >= 2)
                    {
                        // On boucle sur tous les éléments du tableau
                        for (int i = 0; i < tab.Length - currentGap; i++)
                        {
                            int j = i + currentGap;

                            // Si l'élément i est plus grand que l'élément j, on les échange
                            if (tab[i] > tab[j])
                            {
                                if (isRunning == true || currentStep == 3)
                                {
                                    int temp = tab[i];
                                    tab[i] = tab[j];
                                    tab[j] = temp;
                                    hasSwapped = true;
                                    currentStep = 5;
                                }
                            }

                            ExecutePseudoCodeLine(currentPseudoCodeLine);
                            currentPseudoCodeLine++; // Passer à la prochaine ligne de pseudo-code

                            if (currentPseudoCodeLine >= pseudoCodeLines.Length)
                            {
                                currentPseudoCodeLine = 0; // Revenir à la première ligne de pseudo-code
                            }
                        }
                    }
                }
                else // Si on a fini un cycle sans effectuer d'échange
                {
                    if (isRunning == true || currentStep >= 2)
                    {
                        // On diminue la distance entre les éléments à comparer
                        if (currentGap > 1)
                        {
                            currentGap = (int)(currentGap / 1.3);
                        }
                        else // Si la distance est déjà minimale
                        {
                            currentGap = 1;
                            hasSwapped = true;
                        }
                    }
                }

                // On met à jour l'affichage
                //System.Threading.Thread.Sleep(2000);
                if (isRunning == true || currentStep >= 3)
                {
                    if (hasSwapped)
                    {
                        dc.DisplayElements(tab, panelResultat, Font);
                    }
                }

                if (isRunning == true || currentStep >= 4)
                {
                    // Si le tri est terminé, continuer à afficher le dernier tableau
                    if (currentGap == 1 && !hasSwapped)
                    {
                        currentGap = 0;
                        timer1.Stop();
                    }
                }
            }
        }

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            currentStep++;
            if (isRunning == true || currentStep > MAX_STEP)
            {
                currentStep = 1;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                btnStop.Text = "Reprendre";
            }
            else
            {
                btnStop.Text = "Stop";
            }
        }

        // Cette fonction dessine les éléments du tableau dans un panneau
        private void ExecutePseudoCodeLine(int lineIndex)
        {
            // Mettre à jour le TextBox avec la ligne de pseudo-code en cours d'exécution
            txbPseudoCode.Text = pseudoCodeLines[lineIndex];
        }
    }
}
