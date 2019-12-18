using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SayiBulmaOyun
{
    public partial class SkorForm : Form
    {
        int geciciSkor;
        public SkorForm(int skor)
        {
            InitializeComponent();
            skorBastır();
            geciciSkor = skor;
        }

        public static string dosya_yolu = @".\\skorTablo.txt";
        public string[] lines;
        public void skorBastır()
        {
            lines = System.IO.File.ReadAllLines(dosya_yolu);
            foreach (string line in lines)
            {
                listBox1.Items.Add(line);

            }
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {

            using (StreamWriter sw = File.AppendText(dosya_yolu))
            {
                sw.WriteLine("İsim: " + isimTextBox.Text + " Skor: " + geciciSkor);
                sw.Close();
            }
            listBox1.Items.Clear();
            skorBastır();
        }
    }
}
