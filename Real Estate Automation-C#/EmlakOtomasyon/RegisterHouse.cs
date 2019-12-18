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
    public partial class RegisterHouse : Form
    {
        public RegisterHouse()
        {
            InitializeComponent();
        }
        int i = 0;
        StreamWriter sw = null;

        public void writeToFile(string filename,Class.House houseName)
        {
            sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + filename, true);
            sw.WriteLine(houseName.HouseInfo());
            sw.Flush();
            sw.Close();
        }
       
      /*  public override string ToString()
        {
            return base.ToString();
        }
        */
        DateTime dateOfBuilt;
        
        string gender;
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            
            //dateOfBuilt = DateTime.ParseExact(dateofBuiltTextBox.Text,"dd/MM/yyyy",null);
            string gender = rentalforSaleComboBox.SelectedItem.ToString();
            Class.Type type = (Class.Type)Enum.Parse(typeof(Class.Type), TypeComboBox.Text);
            Class.House[] house = new Class.House[1000];
            
            if (gender == "Kiralık")
            {
                Class.RentHouse rentHouse = new Class.RentHouse(int.Parse(RoomNumberTextBox.Text),int.Parse(floorNumberTextBox.Text),
                    int.Parse(estateTextBox.Text),districtComboBox.Text.ToString(),int.Parse(areaTextBox.Text),type,
                    ActiveCheckBox.Checked, int.Parse(rentalDepositTextBox.Text), int.Parse(RentalPriceTextBox.Text) , dateTimePicker1.Value.Date, rentalforSaleComboBox.Text, imageFileUrl);
                writeToFile("//rental.txt", rentHouse);
                house[i] = rentHouse;
                Console.WriteLine(rentHouse.HouseInfo());
                i++;      

            }
            else if (gender == "Satılık")
            {

                Class.ForSaleHouse forSaleHouse = new Class.ForSaleHouse(int.Parse(RoomNumberTextBox.Text), int.Parse(floorNumberTextBox.Text),
                    int.Parse(estateTextBox.Text), districtComboBox.Text.ToString(), int.Parse(areaTextBox.Text), type,
                    ActiveCheckBox.Checked, int.Parse(forSalePriceTextBox.Text), dateTimePicker1.Value.Date, rentalforSaleComboBox.Text, imageFileUrl);
                writeToFile("//forsale.txt", forSaleHouse);
                house[i] = forSaleHouse;
                Console.WriteLine(forSaleHouse.HouseInfo());
                i++;

            }

            

        }

        string imageFileUrl;
        OpenFileDialog ofd = new OpenFileDialog();
        private void FotoğrafBtn_Click(object sender, EventArgs e)
        {

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageFileUrl = "Images/"+ofd.SafeFileName;
                
               

            }

        }

        private void rentalforSaleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rentalforSaleComboBox.SelectedItem == "Kiralık")
            {

                rentalPriceLbl.Visible = true;
                RentalDepositLbl.Visible = true;
                RentalPriceTextBox.Visible = true;
                rentalDepositTextBox.Visible = true;
                forSaleLbl.Visible = false;
                forSalePriceTextBox.Visible= false;
            }
            else
            {

                rentalPriceLbl.Visible = false;
                RentalDepositLbl.Visible = false;
                RentalPriceTextBox.Visible = false;
                rentalDepositTextBox.Visible = false;
                forSaleLbl.Visible = true;
                forSalePriceTextBox.Visible = true;

            }
        }

        private void KayitListeleBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            queryHouse queryHouse = new queryHouse();
            queryHouse.Show();
        
        }
    }
}
