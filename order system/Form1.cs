using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace order_system
{
    public partial class Form1 : Form
    {
        private List<OrderItem> orderItems = new List<OrderItem>();
        private string filePath = "orders.json";

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void CalculateTotal()
        {
            double dishPrice = ParsePrice(lblDish.Text);
            double drinkPrice = ParsePrice(lblDrinks.Text);

            double total = dishPrice + drinkPrice;
            double tax = total * 0.12;
            lblTax.Text = tax.ToString();
            lblTotal.Text = total.ToString();


        }

        private double ParsePrice(string priceText)
        {
            if (double.TryParse(priceText, out double price))
            {
                return price;
            }
            return 0; // Default to 0 if parsing fails
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    orderItems = JsonConvert.DeserializeObject<List<OrderItem>>(json);
                    dgvOrderHistory.DataSource = orderItems;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private void SaveData()
        {
            try
            {
                string json = JsonConvert.SerializeObject(orderItems);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving data: {ex.Message}");
            }
        }


        private void cboDrinks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                switch (comboBox.Text)
                {
                    case "RED HORSE":
                        lblDrinks.Text = "65";
                        break;
                    case "TANDUAY":
                        lblDrinks.Text = "40";
                        break;
                    case "SOJU":
                    case "GIN":
                        lblDrinks.Text = "60";
                        break;
                }
            }
            CalculateTotal();
        }

        private void cboDishes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                switch (comboBox.Text)
                {
                    case "CALDERETA":
                        lblDish.Text = "30";
                        break;
                    case "SISIG":
                        lblDish.Text = "40";
                        break;
                    case "ASADO":
                        lblDish.Text = "50";
                        break;
                    case "MENUDO":
                        lblDish.Text = "60";
                        break;
                    case "PANDESAL":
                        lblDish.Text = "20";
                        break;
                    case "ANCHOVY":
                        lblDish.Text = "10";
                        break;
                }
                comboBox.SelectedItem.ToString();
            }
            CalculateTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dishPrice = ParsePrice(lblDish.Text);
            double drinkPrice = ParsePrice(lblDrinks.Text);

            double total = dishPrice + drinkPrice;
            double tax = total * 0.12;
            lblTax.Text = tax.ToString();
            lblTotal.Text = total.ToString();

            if (string.IsNullOrEmpty(txtCash.Text))
            {
                MessageBox.Show("Invalid cash amount");
                return;
            }

            if (double.TryParse(txtCash.Text, out double amount))
            {
                if (amount > total)
                {
                    double change = amount - total;
                    lblChange.Text = change.ToString("F2");

                    // Create an OrderItem instance and add it to the orderItems list
                    OrderItem newItem = new OrderItem
                    {
                        Dish = cboDishes.SelectedItem.ToString(),
                        Drink = cboDrinks.SelectedItem.ToString(),
                        Total = total,
                        Cash = amount,
                        Change = change
                    };
                    orderItems.Add(newItem);

                    button2.Enabled = true;

                    SaveData(); // Save data after adding new order item

                    return;
                }
                else
                {
                    MessageBox.Show("Not Enough Cash");
                }
            }
            else
            {
                MessageBox.Show("Invalid cash amount");
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(filePath);
            orderItems = JsonConvert.DeserializeObject<List<OrderItem>>(json);
            dgvOrderHistory.DataSource = orderItems;
        }

        private void lblDish_Click(object sender, EventArgs e)
        {

        }

        private void lblDrinks_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }

    public class OrderItem
    {
        public string Dish { get; set; }
        public string Drink { get; set; }
        public double Total { get; set; }
        public double Cash { get; set; }
        public double Change { get; set; }
    }
}
