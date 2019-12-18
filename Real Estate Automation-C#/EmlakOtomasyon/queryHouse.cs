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
using ClassLibrary;

namespace EmlakOtomasyon
{
    public partial class queryHouse : Form
    {
        /*List<string> rental = new List<string>();
        List<string> forSale = new List<string>();*/
        List<string> rental_forSale = new List<string>();
        List<int> roomNmbr = new List<int>();
        List<int> floorNmbr = new List<int>();
        List<int> estateNmbr = new List<int>();
        List<string> district = new List<string>();
        List<int> area = new List<int>();
        List<string> type = new List<string>();
        List<string> active = new List<string>();
        List<int> frSalePrice = new List<int>();
        List<int> rentalPrice = new List<int>();
        List<int> rentalDeposit = new List<int>();
        List<string> dateOfBuilt = new List<string>();
        List<string> daysOfAge = new List<string>();
        List<string> AppropriateRentalPrice = new List<string>();
        List<string> ImageUrl = new List<string>();
        public queryHouse()
        {
            InitializeComponent();
        }
       
        private void queryHouse_Load(object sender, EventArgs e)
        {
            DataValueAddforSale();
            DataValueAddRental();
        }

        public void DataValueAddforSale()
        {
            StreamReader sr = new StreamReader("forsale.txt");
            string line = " ";

            while ((line = sr.ReadLine()) != null)
            {

                string[] components = line.Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                estateNmbr.Add(int.Parse(components[0]));
                roomNmbr.Add(int.Parse(components[1]));
                floorNmbr.Add(int.Parse(components[2]));
                district.Add(components[3]);
                area.Add(int.Parse(components[4]));
                type.Add(components[5]);
                active.Add(components[6]);
                frSalePrice.Add(int.Parse(components[7]));
                AppropriateRentalPrice.Add(components[8]);
                daysOfAge.Add(components[9]);
                dateOfBuilt.Add(components[10]);                               
                rental_forSale.Add(components[11]);
                ImageUrl.Add(components[12]);

            }
            sr.Close();
            DataTableAddforSale(); 


        }

        public void DataValueAddRental()
        {
            StreamReader sr = new StreamReader("rental.txt");
            string line = " ";
            while ((line = sr.ReadLine()) != null)
            {

                string[] components1 = line.Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                estateNmbr.Add(int.Parse(components1[0]));
                roomNmbr.Add(int.Parse(components1[1]));
                floorNmbr.Add(int.Parse(components1[2]));
                district.Add(components1[3]);
                area.Add(int.Parse(components1[4]));
                type.Add(components1[5]);
                active.Add(components1[6]);
                rentalDeposit.Add(int.Parse(components1[7]));
                rentalPrice.Add(int.Parse(components1[8]));
                AppropriateRentalPrice.Add(components1[9]);
                daysOfAge.Add(components1[10]);
                dateOfBuilt.Add(components1[11]);                                         
                rental_forSale.Add(components1[12]);
                ImageUrl.Add(components1[13]);

            }
            sr.Close();
            DataTableAddRental(); 



        }

        static int increase;
        DataTable dt = new DataTable();
        public void DataTableAddforSale()
        {

            dt.Columns.Add("Emlak Numarası", typeof(int));
            dt.Columns.Add("Oda Sayısı", typeof(int));
            dt.Columns.Add("Kat Numarası", typeof(int));
            dt.Columns.Add("İlçe", typeof(string));
            dt.Columns.Add("Alan", typeof(int));
            dt.Columns.Add("Tipi", typeof(string));
            dt.Columns.Add("Aktif", typeof(string));
            dt.Columns.Add("Satılık Bedel");
            dt.Columns.Add("Kiralık Depozito", typeof(int));
            dt.Columns.Add("Kiralık Bedel", typeof(int));
            dt.Columns.Add("Yapım Tarihi", typeof(string));
            dt.Columns.Add("Günlük Olarak Yaşı", typeof(string));
            dt.Columns.Add("Uygun Kiralık Bedel", typeof(int));
            dt.Columns.Add("Kiralık_Satılık", typeof(string));
            dataGridView1.DataSource = dt;

            
            StreamReader file = new StreamReader("forsale.txt");

            while (file.ReadLine() != null)
            {
                DataRow drToAdd = dt.NewRow();
                drToAdd[0] = estateNmbr[increase];
                drToAdd[1] = roomNmbr[increase];
                drToAdd[2] = floorNmbr[increase];
                drToAdd[3] = district[increase];
                drToAdd[4] = area[increase];
                drToAdd[5] = type[increase];
                drToAdd[6] = active[increase];
                drToAdd[7] = frSalePrice[increase];
                drToAdd[8] = 0;
                drToAdd[9] = 0;
                drToAdd[11] = dateOfBuilt[increase];
                drToAdd[10] = daysOfAge[increase];
                drToAdd[12] = AppropriateRentalPrice[increase];
                drToAdd[13] = rental_forSale[increase];
            
                dt.Rows.Add(drToAdd);
                dt.AcceptChanges();
                increase++;

            }
            file.Close();

        }
        public void DataTableAddRental()
        {

            StreamReader file = new StreamReader("rental.txt");
            increase = 0;
            while (file.ReadLine() != null)
            {
                DataRow drToAdd = dt.NewRow();
                drToAdd[0] = estateNmbr[increase];
                drToAdd[1] = roomNmbr[increase];
                drToAdd[2] = floorNmbr[increase];
                drToAdd[3] = district[increase];
                drToAdd[4] = area[increase];
                drToAdd[5] = type[increase];
                drToAdd[6] = active[increase];
                drToAdd[7] = 0;
                drToAdd[8] = rentalDeposit[increase];
                drToAdd[9] = rentalPrice[increase];
                drToAdd[11] = dateOfBuilt[increase];
                drToAdd[10] = daysOfAge[increase];
                drToAdd[12] = AppropriateRentalPrice[increase];
                drToAdd[13] = rental_forSale[increase];   
     
                dt.Rows.Add(drToAdd);
                dt.AcceptChanges();
                increase++;

            }
            file.Close();

        }
     
        private void filtreBtn_Click(object sender, EventArgs e)
        {
            string filterField = "Oda Sayısı";
            dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", filterField, roomNumber.Text);

        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = "Tipi";
            dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", filter, TypeComboBox.Text);
        }

        private void ActiveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            string filter = "Aktif";
            dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", filter, ActiveComboBox.Text);
           
          
        }
        
        public int rowIndex;
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == null)
            {

                MessageBox.Show("İlk önce Kiralık ve ya satılık olarak filtreleme yapınız");

            }
            else
            {
                rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
                if (comboBox1.Text == "Kiralık")
                {
                    DeleteRow("rental.txt");

                }
                else if (comboBox1.Text == "Satılık")
                {
                    DeleteRow("forsale.txt");

                }
            }
        }

        public string DeleteRow(string filename)
        {

            List<string> quotelist = File.ReadAllLines(filename).ToList();
            string firstItem = quotelist[rowIndex];
            quotelist.RemoveAt(rowIndex);
            
            File.WriteAllLines(filename, quotelist.ToArray());
            return firstItem;

        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filter = "Kiralık_Satılık";
            dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", filter, comboBox1.Text);
            if (comboBox1.Text == "Tümü")
            {
                dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", filter, comboBox1.Text="");


            }
        }

     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            UpdateForm updateForm = new UpdateForm();



            updateForm.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value);
            updateForm.estateTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateForm.RoomNumberTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateForm.floorNumberTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateForm.districtComboBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateForm.areaTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            updateForm.TypeComboBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateForm.ActiveCheckBox.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            updateForm.rentalforSaleComboBox.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            updateForm.forSalePriceTextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            updateForm.rentalDepositTextBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            updateForm.RentalPriceTextBox.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            updateForm.pictureBox1.ImageLocation = ImageUrl[increase];

            if (dataGridView1.CurrentRow.Cells[13].Value.ToString() == "Kiralık")
            {

                updateForm.rentalDepositTextBox.Visible = true;
                updateForm.RentalPriceTextBox.Visible = true;
                updateForm.RentalDepositLbl.Visible = true;
                updateForm.rentalPriceLbl.Visible = true;

            }
            else
            {

                updateForm.forSalePriceTextBox.Visible = true;
                updateForm.forSaleLbl.Visible = true;

            }

            updateForm.ShowDialog();
        }

    }
}

