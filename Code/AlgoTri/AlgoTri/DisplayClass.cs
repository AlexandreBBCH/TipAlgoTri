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
    internal class DisplayClass
    {


        public void DisplayElements(int[] tab, Panel panelResultat, Font Font)
        {
            // Affichage des rectangles
            int rectWidth = 30;
            int rectHeightFactor = 10;
            int rectSpacing = 10;
            int rectXOffset = 20;
            int rectYOffset = 20;

            Graphics g = panelResultat.CreateGraphics(); // Initialise un objet Graphics pour dessiner les rectangles sur le panel
            g.Clear(Color.White); // Couleur blanche

            // Tableau de couleurs pour les rectangles
            Color[] colors = new Color[]
            {
        Color.Red,
        Color.Blue,
        Color.Green,
        Color.Yellow,
        Color.Orange,
        Color.Purple,
        Color.Cyan,
        Color.Magenta,
        Color.Lime,
        Color.Teal,
        Color.Pink,
        Color.Silver,
        Color.Gold,
        Color.Navy,
        Color.Olive,
        Color.Maroon,
        Color.Indigo,
        Color.Salmon,
        Color.Turquoise,
        Color.Violet
            };

            // Boucle pour dessiner les rectangles avec chaque valeur
            for (int i = 0; i < tab.Length; i++)
            {
                // Pour chaque itération, la hauteur est calculée avec la valeur de l'élément (multiplication)
                int rectHeight = tab[i] * rectHeightFactor;
                // La position en x du rectangle est calculée en ajoutant à "rectXOffset" le numéro de l'élément multiplié par la largeur du rectangle et de l'espacement entre ces derniers.
                int rectX = rectXOffset + i * (rectWidth + rectSpacing);
                // Pour la position en y, on fait la différence entre la hauteur maximale des rectangles qui est *200* et la hauteur de l'élément. Puis, on l'ajoute à "rectYOffset". 
                int rectY = rectYOffset + (200 - rectHeight);

                // On crée le rectangle avec les valeurs qu'on a calculées
                Rectangle rect = new Rectangle(rectX, rectY, rectWidth, rectHeight);
                // On utilise une couleur différente pour chaque rectangle en fonction de sa valeur
                Color rectColor = colors[tab[i] - 1];
                // On le dessine avec la couleur choisie et on met la valeur de l'élément en question en dessous avec la bonne police et la bonne couleur (noire)
                using (Brush brush = new SolidBrush(rectColor))
                {
                    g.FillRectangle(brush, rect);
                }
                g.DrawRectangle(Pens.Black, rect);
                g.DrawString(tab[i].ToString(), Font, Brushes.Black, rectX, rectY + rectHeight + 5);
            }
        }


    }
}
