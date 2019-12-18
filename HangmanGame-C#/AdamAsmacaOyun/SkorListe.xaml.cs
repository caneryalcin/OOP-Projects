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
    /// Interaction logic for SkorListe.xaml
    /// </summary>
    public partial class SkorListe : Window
    {
        int skorgecici;
        public SkorListe(string skor)
        {
            InitializeComponent();
            skorBastır();
            skorgecici = int.Parse(skor);
        }
        private static string dosya_yolu = @".//skortablo.txt";
        private string[] lines;

        private void skorBastır()
        {
            lines = System.IO.File.ReadAllLines(dosya_yolu);
            foreach (string line in lines)
            {
                listBox.Items.Add(line);

            }
        }
        private void İsim_Click(object sender, RoutedEventArgs e)
        {
            KelimeTahmin k = new KelimeTahmin();

            using (StreamWriter sw = File.AppendText(dosya_yolu))
            {
                sw.WriteLine("İsim: "+textBox.Text+" Skor: "+ skorgecici);
                sw.Close();
            }
            listBox.Items.Clear();
            skorBastır();

            
            }
        }
    }

