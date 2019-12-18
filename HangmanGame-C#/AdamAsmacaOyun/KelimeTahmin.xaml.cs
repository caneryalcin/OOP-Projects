using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Controls;


namespace AdamAsmacaOyun
{
    /// <summary>
    /// Interaction logic for KelimeTahmin.xaml
    /// </summary>
    public partial class KelimeTahmin : Window
    {
        public KelimeTahmin()
        {
            InitializeComponent();
            Dosya_Kelime_Kontrol();
        }

        private List<string> KelimeList = new List<string>();
        private List<string> aynıKelimeList = new List<string>();
        private string[] lines;
        private char[] karakterler;

        private string dosyaKelime;
        private string AHanekelime;
        private static string dosya_yolu = @".//kelimeler.txt";

        private int karakterSayisi;
        private int skor = 100;

        private int hak = 0;
        private int aynı = 0;
        private int birHakPuan;
        private int OlusanHarfSayisi = 0;

        private void Dosya_Kelime_Kontrol()
        {
            lines = System.IO.File.ReadAllLines(dosya_yolu);
            
        }

        private void kelimeyiBul(int hane)
        {
            foreach (string line in lines)
            {

                if (hane == line.Length)
                {

                    aynı++;
                    aynıKelimeList.Add(line);

                }

            }
            Random rand = new Random();
            if (aynı > 1)
            {
                int index = rand.Next(aynıKelimeList.Count());
                AHanekelime = aynıKelimeList[index];

            }

            {

                AHanekelime = aynıKelimeList[0];

            }
            MessageBox.Show(AHanekelime);

            hak = AHanekelime.Length + 2;
            hakLbl.Content = hak.ToString();

            birHakPuan = skor / hak;
            skorLbl.Content = skor;
        }

        private void SkorForm()
        {
            int geciciSkor = skor;

            SkorListe skListe = new SkorListe((skorLbl.Content).ToString());
            skListe.Show();
            this.Close();

        }
        private void harfKontrol()
        {

            karakterler = AHanekelime.ToCharArray();

            if (AHanekelime.Contains(harfTahminText.Text))
            {

                if (karakterler.Length > 0)
                {

                    if (harfTahminText.Text == karakterler[0].ToString())
                    {
                        label0.Content = karakterler[0].ToString();
                        label0.Visibility = Visibility.Visible;
                        OlusanHarfSayisi++;
                    }

                }
                if (karakterler.Length > 1)
                {

                    if (harfTahminText.Text == karakterler[1].ToString())
                    {
                        label1.Content = karakterler[1].ToString();
                        label1.Visibility = Visibility.Visible;
                        OlusanHarfSayisi++;

                    }

                }
                if (karakterler.Length > 2)
                {

                    if (harfTahminText.Text == karakterler[2].ToString())
                    {
                        label2.Content = karakterler[2].ToString();
                        label2.Visibility = Visibility.Visible;
                        OlusanHarfSayisi++;
                    }

                }
                if (karakterler.Length > 3)
                {

                    if (harfTahminText.Text == karakterler[3].ToString())
                    {
                        label3.Content = karakterler[3].ToString();
                        label3.Visibility = Visibility.Visible;
                        OlusanHarfSayisi++;
                    }

                }
                if (karakterler.Length > 4)
                {

                    if (harfTahminText.Text == karakterler[4].ToString())
                    {
                        label4.Content = karakterler[4].ToString();
                        label4.Visibility = Visibility.Visible;
                        OlusanHarfSayisi++;
                    }

                }
                if (karakterler.Length > 5)
                {

                    if (harfTahminText.Text == karakterler[5].ToString())
                    {
                        label5.Content = karakterler[5].ToString();
                        label5.Visibility = Visibility.Visible;
                        OlusanHarfSayisi++;
                    }

                }

            }

            else
            {
                if (listBox.Items.Contains(harfTahminText.Text))
                {

                    MessageBox.Show("Bu harf daha önce denenmiştir");
                    hak++;

                }
                else
                {

                    listBox.Items.Add(harfTahminText.Text);

                    skor = skor - birHakPuan;
                    skorLbl.Content = skor;

                }
            }
                if (OlusanHarfSayisi == karakterler.Length)
                    SkorForm();
                
        }
        private void hakSayisi()
        {
            
            if (hak > 0)
            {

                if (AHanekelime.Contains(harfTahminText.Text) == false)
                {
                    hak--;
                    hakLbl.Content = hak.ToString();                   
                }

            }
            else
            {
                MessageBox.Show("Oyun bitti.Kaybettiniz!");

            }

        }
        
       
        private void tahminEt_Click(object sender, RoutedEventArgs e)
        {
            harfKontrol();
            hakSayisi();
        }
        
        private void Hane_Click(object sender, RoutedEventArgs e)
        {
            karakterSayisi = int.Parse(kelimeHaneText.Text);
            kelimeyiBul(karakterSayisi);           

        }
    }
}

