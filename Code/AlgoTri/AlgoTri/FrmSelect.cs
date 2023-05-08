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

        public FrmSelect()
        {
            // Initialise l'index à 1, car le premier élément est considéré comme trié
            nextIndex = 1;
            InitializeComponent();
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
            }

            // Met à jour l'affichage
            DisplayElements();
        }

        private void DisplayElements()
        {
            // On définit les dimensions des rectangles représentant les éléments
            int rectWidth = 30;
            int rectHeightFactor = 10;
            int rectSpacing = 10;
            int rectXOffset = 20;
            int rectYOffset = 20;

            // On crée un objet Graphics à partir du panneau
            Graphics g = panelResultat.CreateGraphics();
            g.Clear(Color.White);

            // On boucle sur tous les éléments du tableau
            for (int i = 0; i < tab.Length; i++)
            {
                // On calcule la hauteur et la position du rectangle
                int rectHeight = tab[i] * rectHeightFactor;
                int rectX = rectXOffset + i * (rectWidth + rectSpacing);
                int rectY = rectYOffset + (200 - rectHeight);

                // On dessine le rectangle et le texte à l'intérieur
                Rectangle rect = new Rectangle(rectX, rectY, rectWidth, rectHeight);
                g.DrawRectangle(Pens.Black, rect);
                g.DrawString(tab[i].ToString(), Font, Brushes.Black, rectX, rectY + rectHeight + 5);
            }
        }

        private void buttonStartSort_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
    }
}
