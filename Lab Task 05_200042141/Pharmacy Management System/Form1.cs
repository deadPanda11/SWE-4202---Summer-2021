using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Dependencies;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        List<Medicine> medicines = new List<Medicine>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddMedButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdTextBox.Text);
            string name = MedNameTextBox.Text;
            string power = PowerTextBox.Text;
            int price = Convert.ToInt32(PriceTextBox.Text);
            int quantity = Convert.ToInt32(QuantityTextBox.Text);

            Medicine medicine = new Medicine();

            medicine.id = id;
            medicine.name = name;
            medicine.power = power;
            medicine.price = price;
            medicine.quantity = quantity;

            medicines.Add(medicine);

            MessageBox.Show("Medicine has been added successfully");
        }

        private void SellMedButton_Click(object sender, EventArgs e)
        {
            int medicineid = Convert.ToInt32(SellMedIdTextBox.Text);
            int sellquantity = Convert.ToInt32(SellQuantityTextBox.Text);

            foreach (Medicine medicine in medicines)
            {
                if (medicine.id == medicineid)
                {
                    if ((medicine.quantity <= 0) || (medicine.quantity <= sellquantity))
                    {
                        MessageBox.Show("Out of Stock.");
                    }
                    if(medicine.quantity >= sellquantity)
                    {
                        medicine.quantity = medicine.quantity - sellquantity;
                        medicine.balance = medicine.balance + (sellquantity * medicine.price);
                        MessageBox.Show("Medicine has been sold.");
                    }
                }
            }
        }

        private void ShowStockButton_Click(object sender, EventArgs e)
        {
            int stockid = Convert.ToInt32(MedIdStockTextBox.Text);

            foreach (Medicine medicine in medicines)
            {
                if (medicine.id == stockid)
                {
                    ShowMedNameLabel.Text = medicine.name.ToString();
                    ShowMedPowerLabel.Text = medicine.power.ToString();
                    ShowQuantityLabel.Text = medicine.quantity.ToString();
                }
            }
        }

        private void ShowBalanceButton_Click(object sender, EventArgs e)
        {
            TotalBalance total = new TotalBalance();
            foreach (Medicine medicine in medicines)
            {
                total.totalBalance = total.totalBalance + medicine.balance;
            }
            AccBalanceLabel.Text = Convert.ToString(total.totalBalance);
        }
    }
}
