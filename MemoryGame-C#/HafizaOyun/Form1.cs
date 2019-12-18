using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafizaOyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResimlerKutuAtama();
            baslangicResimGoster();
            saniyeLbl.Text = saniye.ToString();
        }

        Random random = new Random();

        List<string> resimler = new List<string>()
        {
            //Webdings'in içinde harflere karşılık gelen resimler için ayarlandı.
            "!","!","N","N",",",",","k","k","b","b","v","v","w","w","z","z","a","a","s","s",
            "m","m",".",".","ü","ü","n","n","8","8","2","2","-","-","*","*","q","q","ç","ç"


        };



        private void ResimlerKutuAtama()
        {

            Label label;
            int randomNumara;

            //yineleme
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {

                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;


                randomNumara = random.Next(0, resimler.Count);
                label.Text = resimler[randomNumara];

                //Birden fazla aynı random numara gelmemesi için randomNumara resimler listesinden silinir.
                resimler.RemoveAt(randomNumara);

            }



        }

        private void baslangicResimGoster()
        {
            timer3.Start();
            Label label;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {

                label = tableLayoutPanel1.Controls[i] as Label;

                label.ForeColor = Color.Black;

            }

        }

        Label ilkTiklama, ikinciTiklama;
        int saniye = 5;
        int sıra = 1;
        int oyuncu1Skor =0 , oyuncu2Skor = 0;
        private void label_Click(object sender, EventArgs e)
        {
            //2 tıklamadan sonra vakit dolana kadar 3. tıklanma yapılmaması için
            if (ilkTiklama != null && ikinciTiklama != null)
                return;

            //sender objesi sayesinde tıklanan kontrolün türünü alabiliriz.
            //Tıklanan label değilse null değer döndürür.
            Label labelTiklanmis = sender as Label;
          
            if (ilkTiklama == null)
            {

                ilkTiklama = labelTiklanmis;
                ilkTiklama.ForeColor = Color.Black;
                timer2.Start();
            
                return;

            }

            ikinciTiklama = labelTiklanmis;
            ikinciTiklama.ForeColor = Color.Black;
                       

            

            if (ilkTiklama.Text == ikinciTiklama.Text)
            {
                

                ilkTiklama = null;
                ikinciTiklama = null;
                timer2.Stop();
                saniye = 5;
                saniyeLbl.Text = saniye.ToString();

                if (sıra == 1)
                {

                    oyuncu1Skor++;
                    oyuncu1Lbl.Text = oyuncu1Skor.ToString();

                }
                else if(sıra == 2)
                {

                    oyuncu2Skor++;
                    oyuncu2Lbl.Text = oyuncu2Skor.ToString();

                }
            }
            else
            {
                
                timer1.Start();
                if (sıra == 1)
                     sıra = 2;
                else 
                     sıra = 1;
                
            }
            KazanmaKontrol();
              

        }



        private void KazanmaKontrol()
        {

            if (oyuncu1Skor == 11)
            {

                MessageBox.Show("1.Oyuncu Kazandı!");
                
                Close();

            }

            else if (oyuncu2Skor == 11)
            {
                MessageBox.Show("2.oyuncu kazandı");
                Close();

            }
            else if (oyuncu1Skor == 10 && oyuncu2Skor == 10)
            {

                MessageBox.Show("Tüm Resimler açıldı!\nBerabere");
                Close();

            }

        }
   
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Stop();
            saniye = 5;
            saniyeLbl.Text = saniye.ToString();
            ilkTiklama.ForeColor = ilkTiklama.BackColor;
            ikinciTiklama.ForeColor = ikinciTiklama.BackColor;

            ilkTiklama = null;
            ikinciTiklama = null;
        }

       

        private void timer2_Tick(object sender, EventArgs e)
        {

            saniye--;
            saniyeLbl.Text = saniye.ToString();
            if (saniye == 0)
            {

                timer2.Stop();


            }
            if (ilkTiklama != null && saniye == 0 && ikinciTiklama == null)
            {
                if (sıra == 1)
                    sıra = 2;
                else
                    sıra = 1;

                saniyeLbl.Text = "0";

                ilkTiklama.ForeColor = ilkTiklama.BackColor;
                ilkTiklama = null;
                saniye = 5;
                saniyeLbl.Text = saniye.ToString();
            }
            
            
            
        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            Label label;

             for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
              {

                  label = tableLayoutPanel1.Controls[i] as Label;

                  label.ForeColor = Color.Silver;

              }
              
        }

        
           
        }

        
    }

