using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace AdamAsmacaOyun
{
    /// <summary>
    /// Interaction logic for Kelime_Ekle_Cikar.xaml
    /// </summary>
    public partial class Kelime_Ekle_Cikar : Window
    {
        public Kelime_Ekle_Cikar()
        {
            InitializeComponent();
        }
        public string dosya_yolu = @"C:\Users\caner\OneDrive\Masaüstü\AdamAsmaca\AdamAsmaca\kelimeler.txt";
        public string dosyaKelime = "";

        public void KelimeEkle()
        {
            using (StreamWriter sw = File.AppendText(dosya_yolu))
            {
                sw.WriteLine(kelimeText.Text);
                sw.Close();
            }

        }
        public void KelimeCikar()
        {

            
            using (StreamReader sr = new StreamReader(dosya_yolu))

            {
                string n = "";
                while ((dosyaKelime = sr.ReadLine()) != null)
                {
                    if (!dosyaKelime.Contains(kelimeText.Text))
                    {
                        n += dosyaKelime + Environment.NewLine;
                    }                    
                }
                sr.Close();
                File.WriteAllText(dosya_yolu, n);
            }

        }
        private void kelimeEkle_Click(object sender, RoutedEventArgs e)
        {
            KelimeEkle();
        }

        private void kelimeCikar_Click(object sender, RoutedEventArgs e)
        {
            KelimeCikar();
        }
    }
}
