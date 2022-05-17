/*
 Öğr.Gör.Ömer ÖZCAN
oozcan@selcuk.edu.tr
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayintarlasi2022
{
    public partial class mayinFrm : Form
    {
        int[,] mayin = new int[10, 10];
        Button[,] btn = new Button[10, 10];
        int skor = 0;
        public mayinFrm()
        {
            InitializeComponent();
        }

        private void yenioyunbtn_Click(object sender, EventArgs e)
        {
            skor = 0;
            groupBox1.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Width = 20;
                    btn[i, j].Height = 20;
                    btn[i, j].Name = i + "-" + j;
                    btn[i, j].Top = i * 20+30;
                    btn[i, j].Left = j * 20+30;
                    btn[i, j].Parent = groupBox1;
                    btn[i, j].Click += oyunbtn_Click;
                    mayin[i, j] = 0;
                    btn[i, j].BackgroundImage=null;
                }
            }
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r.Next(10);
                int y = r.Next(10);
                mayin[x, y] = 1;
            }
            mesajLbl.Text = "Oyun Başladı";
        }

        private void oyunbtn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            String[] dizi = b.Name.Split('-');
            int x = int.Parse(dizi[0]);
            int y = int.Parse(dizi[1]);
            if(mayin[x,y]==1)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (mayin[i,j]==1)
                        {
                            btn[i, j].BackgroundImage = Image.FromFile("mayin.png");
                            btn[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                }
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = "bigboom.wav";
                sp.Play();
                mesajLbl.Text = "Kaybettiniz";
            }
            else
            {
                int mayinSayi = 0;
                if(x<9)
                {
                    if(mayin[x+1,y]==1)
                    {
                        mayinSayi++;
                    }
                }
                if (x < 9&&y<9)
                {
                    if (mayin[x + 1, y+1] == 1)
                    {
                        mayinSayi++;
                    }
                }
                if (y < 9)
                {
                    if (mayin[x, y+1] == 1)
                    {
                        mayinSayi++;
                    }
                }
                if (x >0&&y<9)
                {
                    if (mayin[x - 1, y+1] == 1)
                    {
                        mayinSayi++;
                    }
                }
                if (x>0)
                {
                    if (mayin[x - 1, y] == 1)
                    {
                        mayinSayi++;
                    }
                }
                if (x >0&&y>0)
                {
                    if (mayin[x - 1, y-1] == 1)
                    {
                        mayinSayi++;
                    }
                }
                if (y>0)
                {
                    if (mayin[x, y-1] == 1)
                    {
                        mayinSayi++;
                    }
                }
                btn[x, y].Text = mayinSayi.ToString() ;
                skor++;
                mesajLbl.Text = "Skor:" + skor;
                if(skor==90)
                {
                    mesajLbl.Text = "Kazandınız";
                }
            }
        }
    }
}
