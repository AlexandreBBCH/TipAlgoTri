using System.Timers;

namespace AlgoTri
{
    public partial class FrmBubble : Form
    {
        int[] tab = new int[20] { 11, 2, 7, 20, 3, 17, 6, 1, 15, 8, 10, 12, 14, 16, 19, 9, 18, 4, 13, 5 };
        int currentElementIndex = 0;
        public FrmBubble()
        {
            InitializeComponent();
        }

        private void btnStartSort_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            bool hasSwapped = false;
            for (int i = 0; i < tab.Length - 1 - currentElementIndex; i++)
            {
                if (tab[i] > tab[i + 1])
                {
                    int temp = tab[i];
                    tab[i] = tab[i + 1];
                    tab[i + 1] = temp;
                    hasSwapped = true;
                }
            }

            DisplayElements();
            currentElementIndex++;

            if (!hasSwapped || currentElementIndex >= tab.Length)
            {
                ((System.Windows.Forms.Timer)sender).Stop();
                currentElementIndex = 0;
            }
        }

        private void DisplayElements()
        {
            int rectWidth = 30;
            int rectHeightFactor = 10;
            int rectSpacing = 10;
            int rectXOffset = 20;
            int rectYOffset = 20;

            Graphics g = panelResultat.CreateGraphics();
            g.Clear(Color.White);

            for (int i = 0; i < tab.Length; i++)
            {
                int rectHeight = tab[i] * rectHeightFactor;
                int rectX = rectXOffset + i * (rectWidth + rectSpacing);
                int rectY = rectYOffset + (200 - rectHeight);

                Rectangle rect = new Rectangle(rectX, rectY, rectWidth, rectHeight);
                g.DrawRectangle(Pens.Black, rect);
                g.DrawString(tab[i].ToString(), Font, Brushes.Black, rectX, rectY + rectHeight + 5);
            }
        }


    }
}
