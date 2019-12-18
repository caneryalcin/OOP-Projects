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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        StreamWriter sw = null;
        public void writeToFile(string filename, Class.House houseName)
        {
            sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + filename, true);
            sw.WriteLine(houseName.HouseInfo());
            sw.Flush();
            sw.Close();
        }
        string imageFileUrl;
        OpenFileDialog ofd = new OpenFileDialog();
        private void FotoğrafBtn_Click_1(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageFileUrl = "Images/" + ofd.SafeFileName;


            }

        }

        public string Delete(string filename)
        {
            queryHouse qHouse = new queryHouse();
            
            List<string> quotelist = File.ReadAllLines(filename).ToList();
            string firstItem = quotelist[qHouse.rowIndex];
            quotelist.RemoveAt(qHouse.rowIndex);

            File.WriteAllLines(filename, quotelist.ToArray());
            return firstItem;

        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (FirstRentalorForSale == "Kiralık") { 
            Delete("rental.txt");
            }
            else
            {
                Delete("forsale.txt");

            }

            string gender = rentalforSaleComboBox.SelectedItem.ToString();
            Class.Type type = (Class.Type)Enum.Parse(typeof(Class.Type), TypeComboBox.Text);

            if (gender == "Kiralık")
            {
                Class.RentHouse rentHouse = new Class.RentHouse(int.Parse(RoomNumberTextBox.Text), int.Parse(floorNumberTextBox.Text),
                    int.Parse(estateTextBox.Text), districtComboBox.Text.ToString(), int.Parse(areaTextBox.Text), type,
                    ActiveCheckBox.Checked, int.Parse(rentalDepositTextBox.Text), int.Parse(RentalPriceTextBox.Text), dateTimePicker1.Value.Date, rentalforSaleComboBox.Text, imageFileUrl);
                writeToFile("//rental.txt", rentHouse);

                Console.WriteLine(rentHouse.HouseInfo());

            }
            else if (gender == "Satılık")
            {

                Class.ForSaleHouse forSaleHouse = new Class.ForSaleHouse(int.Parse(RoomNumberTextBox.Text), int.Parse(floorNumberTextBox.Text),
                    int.Parse(estateTextBox.Text), districtComboBox.Text.ToString(), int.Parse(areaTextBox.Text), type,
                    ActiveCheckBox.Checked, int.Parse(forSalePriceTextBox.Text), dateTimePicker1.Value.Date, rentalforSaleComboBox.Text, imageFileUrl);
                writeToFile("//forsale.txt", forSaleHouse);

                Console.WriteLine(forSaleHouse.HouseInfo());

            }


        }

        string FirstRentalorForSale;
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            FirstRentalorForSale = rentalforSaleComboBox.Text;
        }

        
    }

}
