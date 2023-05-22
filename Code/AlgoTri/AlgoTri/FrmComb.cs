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
    {// Initialise un tableau de 20 entiers, triés aléatoirement à l'aide de la méthode OrderBy().
        int[] tab = Enumerable.Range(1, 20).OrderBy(x => Guid.NewGuid()).Take(20).ToArray();
        // Initialise un entier pour stocker la taille actuelle de l'intervalle de tri
        int currentGap;
        // Initialise un booléen pour indiquer si des échanges ont été effectués lors de la dernière itération de tri.
        bool hasSwapped = true;

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
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // Si on a déjà effectué un échange lors du dernier cycle
            if (hasSwapped)
            {
                // On repart du principe qu'il n'y aura pas d'échange
                hasSwapped = false;

                // On boucle sur tous les éléments du tableau
                for (int i = 0; i < tab.Length - currentGap; i++)
                {
                    int j = i + currentGap;

                    // Si l'élément i est plus grand que l'élément j, on les échange
                    if (tab[i] > tab[j])
                    {
                        int temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;
                        hasSwapped = true;
                    }
                }
            }
            else // Si on a fini un cycle sans effectuer d'échange
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

            // On met à jour l'affichage
            dc.DisplayElements(tab, panelResultat, Font);

            // Si le tri est terminé, continuer à afficher le dernier tableau
            if (currentGap == 1 && !hasSwapped)
            {
                currentGap = 0;
            }
        }

        // Cette fonction dessine les éléments du tableau dans un panneau
      
    }
}
