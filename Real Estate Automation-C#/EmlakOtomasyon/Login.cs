using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.IO;


namespace EmlakOtomasyon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        List<string> users = new List<string>();
        List<string> pass = new List<string>();

        private void LoginBtn_Click(object sender, EventArgs e)
        {

           
           if (users.Contains(idTextBox.Text) && pass.Contains(passwordTextBox.Text) && Array.IndexOf(users.ToArray(), idTextBox.Text) == Array.IndexOf(pass.ToArray(), passwordTextBox.Text))
           {
               this.Hide();
               RegisterHouse registerHouse = new RegisterHouse();              
               registerHouse.ShowDialog();
              

           }
           else { MessageBox.Show("Id or Password is wrong.\nPlease try again."); }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("users.txt");
            string line = " ";
            while ((line = sr.ReadLine()) != null)
            {

                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);                
                users.Add(components[0]);
                pass.Add(components[1]);
                
            }
            sr.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}