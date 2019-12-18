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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace AdamAsmacaOyun
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private string dosya_yolu = @".//kelimeler.txt";
        private string dosyaKelime = "";

        private void KelimeEkle()
        {
            using (StreamWriter sw = File.AppendText(dosya_yolu))
            {
                sw.WriteLine(kelimeText.Text);
                sw.Close();
            }

        }
        private void KelimeCikar()
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

        private void oyunaBasla_Click(object sender, RoutedEventArgs e)
        {
            KelimeTahmin kTahmin = new KelimeTahmin();
            kTahmin.Show();
            this.Close();
        }
    }
}
