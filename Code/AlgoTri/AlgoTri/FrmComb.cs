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
    {

        float timer = 0f;
        private displaySort displaySort;
        public FrmComb()
        {
            InitializeComponent();


        }

        private void btnStartSort_Click(object sender, EventArgs e)
        {
            sortLikeAComb();
            displaySort.DrawRectangle(this.CreateGraphics());
        }





        private void sortLikeAComb()
        {
            int[] tab = new int[20] { 11, 2, 7, 20, 3, 17, 6, 1, 15, 8, 10, 12, 14, 16, 19, 9, 18, 4, 13, 5 };
            foreach (int i in tab)
            {
                txbComb.Text += i + " ";

            }
            txbComb.Text += "\r\n";
            int gap = tab.Length;
            bool swapped = true;
            while (gap > 1 || swapped)
            {
                if (gap > 1)
                {
                    gap = (int)(gap / 1.3);
                }
                int i = 0;
                swapped = false;
                while (i + gap < tab.Length)
                {
                    if (tab[i].CompareTo(tab[i + gap]) > 0)
                    {
                        int t = tab[i];
                        tab[i] = tab[i + gap];
                        tab[i + gap] = t;
                        swapped = true;
                        displaySort = new displaySort(20 + i * 5, 40, 20, i + 10);
                    }
                    i++;

                }
            }
            foreach (int i in tab)
            {
                txbComb.Text += i + " ";
            }
            txbComb.Text += "\r\n";


        }


    }
}
