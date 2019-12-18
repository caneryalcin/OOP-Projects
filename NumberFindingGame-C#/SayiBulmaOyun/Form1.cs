using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SayiBulmaOyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;

        }

        int saniye = 10;
        int hak;
        public int skor = 100;

        Random rnd = new Random();
        int[] arr;
        Label label;


        int[] GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }

        private void Tekrarsız(int basamak)
        {
            arr = new int[basamak];
            int gecici;
            for(int i =0;i<arr.Length;i++)
            {

                gecici = rnd.Next(0,9);
                
                while (FarklıBasamak(gecici, arr))
                {
                    gecici = rnd.Next(11);

                }              
                arr[i] = gecici;
                
            }

        }

        private bool FarklıBasamak(int gecici, int[] arr)
        {
            foreach (var item in arr)
            {

                if (item == gecici)
                {

                    return true;

                }

            }
            return false;

        }
        private void Tekrarlı(int basamak)
        {

            arr = new int[basamak];
                       
            int basamakNumara;
            for (int i = 0; i < arr.Length; i++)
            {
                basamakNumara = rnd.Next(9);
                arr[i] = basamakNumara;
            }
           
                     
        }
               
        private void Tekrarsız_Click(object sender, EventArgs e)
        {
            Tekrarsız(int.Parse(textBox1.Text));
        }

        private void Tekrarlı_Click(object sender, EventArgs e)
        {
            Tekrarlı(int.Parse(textBox1.Text));
        }

        private void Tahmin_Click(object sender, EventArgs e)
        {
            int aynıSayı = 0;

            saniye = 10;
            timer1.Enabled = true;
            if (aynıSayı != arr.Length) { 
            hak--;
            if (hak > 0)
            {
                skor = skor - (skor / hak);
            }
            }
            
            SkorLbl.Text = skor.ToString();
            hakLbl.Text = hak.ToString();

            if(hak == 0)
            {
                SkorForm skForm = new SkorForm(int.Parse(SkorLbl.Text));
                skForm.Show();

            }            
            
            int[] a = GetIntArray(int.Parse(textBox2.Text));
            for (int i = 0; i < a.Length; i++)
            {
                if (arr[i] == a[i])
                {

                    label = (Label)Controls["label" + (i + 1).ToString()];
                    label.Text = a[i].ToString();
                    label.BackColor = Color.Blue;
                    aynıSayı++;
                }

                else {
                    foreach (int item in arr)
                    {
                        
                        if (a[i] == item)
                        {
                            label = (Label)Controls["label" + (i + 1).ToString()];
                            label.Text = a[i].ToString();                           
                            label.BackColor = Color.Red;                                                            
                        }

                    }
                }
            }

            if(aynıSayı== arr.Length)
            {
                hak++;
                skor = skor + (skor / hak);
                SkorLbl.Text = skor.ToString();
                timer1.Enabled = false;
                hakLbl.Text = hak.ToString();

                MessageBox.Show("Tebrikler Hepsini Bildiniz.");

                SkorForm skForm = new SkorForm(int.Parse(SkorLbl.Text));
                skForm.Show();
                

            }
        }        
      
        private void hakBtn_Click(object sender, EventArgs e)
        {

            hak = int.Parse(hakTextBox.Text);
            hakLbl.Text = hak.ToString();
        }
            
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            label7.Text = saniye.ToString();
            if (saniye == 0)
            {
                skor = skor - (skor / hak);
                SkorLbl.Text = skor.ToString();
                saniye = 10;
                label7.Text = saniye.ToString();
                hak--;
                hakLbl.Text = hak.ToString();
            }
            if(hak == 0)
            {

                timer1.Enabled = false;
                MessageBox.Show("Hakkınız Bitti");

            }

        }

      
    }
    
}
