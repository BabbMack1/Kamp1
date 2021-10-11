using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckerBoardDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];
            int top=0;
            int left=0 ;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)///Burada for döngüsünü buttonun 0. indeksinin maks değerine kadar devam ettirdik. Bu örnek için 8 oldu.
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)// Burada da for döngüsünü 1. indeksine göre sınırlandırdık.
                {
                    buttons[i,j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;  //Burada butonun sol taraf başlangıç noktasını belirledik.
                    left += 50; //Her seferinde 50 sola kaydırdık.
                    buttons[i, j].Top = top;  ///üst kısma olan uzaklıgını belirledik.
                    this.Controls.Add(buttons[i, j]);
                    if ((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black;

                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                }
                left = 0;
                top += 50;
            }
        }
    }
}
