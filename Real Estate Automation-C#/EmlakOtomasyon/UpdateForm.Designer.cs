namespace EmlakOtomasyon
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.forSaleLbl = new System.Windows.Forms.Label();
            this.forSalePriceTextBox = new System.Windows.Forms.TextBox();
            this.FotoğrafBtn = new System.Windows.Forms.Button();
            this.RentalDepositLbl = new System.Windows.Forms.Label();
            this.rentalDepositTextBox = new System.Windows.Forms.TextBox();
            this.RentalPriceTextBox = new System.Windows.Forms.TextBox();
            this.rentalPriceLbl = new System.Windows.Forms.Label();
            this.rentalforSaleComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.estateTextBox = new System.Windows.Forms.TextBox();
            this.ActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.floorNumberTextBox = new System.Windows.Forms.TextBox();
            this.RoomNumberTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 267);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // forSaleLbl
            // 
            this.forSaleLbl.AutoSize = true;
            this.forSaleLbl.Location = new System.Drawing.Point(337, 108);
            this.forSaleLbl.Name = "forSaleLbl";
            this.forSaleLbl.Size = new System.Drawing.Size(60, 13);
            this.forSaleLbl.TabIndex = 52;
            this.forSaleLbl.Text = "Satış Bedel";
            this.forSaleLbl.Visible = false;
            // 
            // forSalePriceTextBox
            // 
            this.forSalePriceTextBox.Location = new System.Drawing.Point(427, 106);
            this.forSalePriceTextBox.Name = "forSalePriceTextBox";
            this.forSalePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.forSalePriceTextBox.TabIndex = 51;
            this.forSalePriceTextBox.Visible = false;
            // 
            // FotoğrafBtn
            // 
            this.FotoğrafBtn.Location = new System.Drawing.Point(222, 315);
            this.FotoğrafBtn.Name = "FotoğrafBtn";
            this.FotoğrafBtn.Size = new System.Drawing.Size(75, 23);
            this.FotoğrafBtn.TabIndex = 50;
            this.FotoğrafBtn.Text = "Fotoğraf Seç";
            this.FotoğrafBtn.UseVisualStyleBackColor = true;
            this.FotoğrafBtn.Click += new System.EventHandler(this.FotoğrafBtn_Click_1);
            // 
            // RentalDepositLbl
            // 
            this.RentalDepositLbl.AutoSize = true;
            this.RentalDepositLbl.Location = new System.Drawing.Point(335, 80);
            this.RentalDepositLbl.Name = "RentalDepositLbl";
            this.RentalDepositLbl.Size = new System.Drawing.Size(70, 13);
            this.RentalDepositLbl.TabIndex = 49;
            this.RentalDepositLbl.Text = "Kira Depozito";
            this.RentalDepositLbl.Visible = false;
            // 
            // rentalDepositTextBox
            // 
            this.rentalDepositTextBox.Location = new System.Drawing.Point(427, 77);
            this.rentalDepositTextBox.Name = "rentalDepositTextBox";
            this.rentalDepositTextBox.Size = new System.Drawing.Size(100, 20);
            this.rentalDepositTextBox.TabIndex = 48;
            this.rentalDepositTextBox.Visible = false;
            // 
            // RentalPriceTextBox
            // 
            this.RentalPriceTextBox.Location = new System.Drawing.Point(427, 50);
            this.RentalPriceTextBox.Name = "RentalPriceTextBox";
            this.RentalPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.RentalPriceTextBox.TabIndex = 47;
            this.RentalPriceTextBox.Visible = false;
            // 
            // rentalPriceLbl
            // 
            this.rentalPriceLbl.AutoSize = true;
            this.rentalPriceLbl.Location = new System.Drawing.Point(335, 57);
            this.rentalPriceLbl.Name = "rentalPriceLbl";
            this.rentalPriceLbl.Size = new System.Drawing.Size(65, 13);
            this.rentalPriceLbl.TabIndex = 46;
            this.rentalPriceLbl.Text = "Kıralik Bedel";
            this.rentalPriceLbl.Visible = false;
            // 
            // rentalforSaleComboBox
            // 
            this.rentalforSaleComboBox.FormattingEnabled = true;
            this.rentalforSaleComboBox.Items.AddRange(new object[] {
            "Kiralık",
            "Satılık"});
            this.rentalforSaleComboBox.Location = new System.Drawing.Point(119, 49);
            this.rentalforSaleComboBox.Name = "rentalforSaleComboBox";
            this.rentalforSaleComboBox.Size = new System.Drawing.Size(121, 21);
            this.rentalforSaleComboBox.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Rental/forSale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Emlak Numarası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Aktif";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Yapım Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Alanı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Semti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Kat Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Oda Sayısı";
            // 
            // estateTextBox
            // 
            this.estateTextBox.Location = new System.Drawing.Point(119, 158);
            this.estateTextBox.Name = "estateTextBox";
            this.estateTextBox.Size = new System.Drawing.Size(100, 20);
            this.estateTextBox.TabIndex = 35;
            // 
            // ActiveCheckBox
            // 
            this.ActiveCheckBox.AutoSize = true;
            this.ActiveCheckBox.Location = new System.Drawing.Point(119, 133);
            this.ActiveCheckBox.Name = "ActiveCheckBox";
            this.ActiveCheckBox.Size = new System.Drawing.Size(47, 17);
            this.ActiveCheckBox.TabIndex = 34;
            this.ActiveCheckBox.Text = "Aktif";
            this.ActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Bahceli",
            "Mustakil",
            "Dubleks",
            "Daire"});
            this.TypeComboBox.Location = new System.Drawing.Point(119, 103);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 33;
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(119, 241);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(100, 20);
            this.areaTextBox.TabIndex = 32;
            // 
            // districtComboBox
            // 
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Items.AddRange(new object[] {
            "Yenimahalle",
            "Batıkent"});
            this.districtComboBox.Location = new System.Drawing.Point(119, 76);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(121, 21);
            this.districtComboBox.TabIndex = 31;
            // 
            // floorNumberTextBox
            // 
            this.floorNumberTextBox.Location = new System.Drawing.Point(119, 210);
            this.floorNumberTextBox.Name = "floorNumberTextBox";
            this.floorNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.floorNumberTextBox.TabIndex = 30;
            // 
            // RoomNumberTextBox
            // 
            this.RoomNumberTextBox.Location = new System.Drawing.Point(119, 184);
            this.RoomNumberTextBox.Name = "RoomNumberTextBox";
            this.RoomNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoomNumberTextBox.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(427, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(51, 315);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 55;
            this.UpdateBtn.Text = "Güncelle";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 455);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.forSaleLbl);
            this.Controls.Add(this.forSalePriceTextBox);
            this.Controls.Add(this.FotoğrafBtn);
            this.Controls.Add(this.RentalDepositLbl);
            this.Controls.Add(this.rentalDepositTextBox);
            this.Controls.Add(this.RentalPriceTextBox);
            this.Controls.Add(this.rentalPriceLbl);
            this.Controls.Add(this.rentalforSaleComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estateTextBox);
            this.Controls.Add(this.ActiveCheckBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.districtComboBox);
            this.Controls.Add(this.floorNumberTextBox);
            this.Controls.Add(this.RoomNumberTextBox);
            this.Name = "UpdateForm";
            this.Text = "Güncelleme Ekranı";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label forSaleLbl;
        public System.Windows.Forms.TextBox forSalePriceTextBox;
        public System.Windows.Forms.Button FotoğrafBtn;
        public System.Windows.Forms.Label RentalDepositLbl;
        public System.Windows.Forms.TextBox rentalDepositTextBox;
        public System.Windows.Forms.TextBox RentalPriceTextBox;
        public System.Windows.Forms.Label rentalPriceLbl;
        public System.Windows.Forms.ComboBox rentalforSaleComboBox;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox estateTextBox;
        public System.Windows.Forms.CheckBox ActiveCheckBox;
        public System.Windows.Forms.ComboBox TypeComboBox;
        public System.Windows.Forms.TextBox areaTextBox;
        public System.Windows.Forms.ComboBox districtComboBox;
        public System.Windows.Forms.TextBox floorNumberTextBox;
        public System.Windows.Forms.TextBox RoomNumberTextBox;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}