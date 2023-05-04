using System.Timers;

namespace AlgoTri
{
    public partial class FrmBubble : Form
    {
        // Liste à trier
        int[] tab = new int[20] { 11, 2, 7, 20, 3, 17, 6, 1, 15, 8, 10, 12, 14, 16, 19, 9, 18, 4, 13, 5 };
        // Variable de l'élément actuel
        int currentElementIndex = 0;
        public FrmBubble()
        {
            InitializeComponent();
        }

        private void btnStartSort_Click(object sender, EventArgs e)
        {
            // Définit l'intervalle de temps entre deux appels de la méthode timer1_Tick à 500ms
            timer1.Interval = 500; 
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
         

            DisplayElements(); // Affiche le tableau trié
            currentElementIndex++; // Incrémente l'index de l'élément actuel

            if (!hasSwapped || currentElementIndex >= tab.Length) // Si aucun échange ou si tous les éléments sont déjà triés
            {
                // On stop tout
                ((System.Windows.Forms.Timer)sender).Stop();
                // L'élément actuel revient à 0;
                currentElementIndex = 0;
            }
        }

        private void DisplayElements()
        {
            // Affichage des rectangles
            int rectWidth = 30;
            int rectHeightFactor = 10;
            int rectSpacing = 10;
            int rectXOffset = 20;
            int rectYOffset = 20;

            Graphics g = panelResultat.CreateGraphics(); // Initialise un objet Graphics pour dessiner les rectangles sur le panel
            g.Clear(Color.White); // Couleur blanche
            // Boucle pour dessiner les rectangles avec chaque valeur
            for (int i = 0; i < tab.Length; i++)
            {
                // Pour chaque itération, la hauteur est calculée avec la valeur de l'élément (multiplication)
                int rectHeight = tab[i] * rectHeightFactor;
                // La position en x du rectangle est calculée en ajoutant à "rectXOffset" le numéro de l'élément multiplié par la largeur du rectangle et de l'espacement entre ces derniers.
                int rectX = rectXOffset + i * (rectWidth + rectSpacing);
                // Pour la position en y, on fait la différence entre la hauteur maximale des rectangles qui est *200* et la hauteur de l'élément. Puis, on l'ajoute à "rectYOffset". 
                int rectY = rectYOffset + (200 - rectHeight);

                // On créer le rectangle avec les valeurs qu'on a calculé
                Rectangle rect = new Rectangle(rectX, rectY, rectWidth, rectHeight);
                // On le dessine en noir et on met la valeur de l'élément en question en dessous avec la bonne police et la bonne couleur (noire)
                g.DrawRectangle(Pens.Black, rect);
                g.DrawString(tab[i].ToString(), Font, Brushes.Black, rectX, rectY + rectHeight + 5);
            }
        }


    }
}
