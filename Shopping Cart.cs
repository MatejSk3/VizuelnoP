using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Cart
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void addNewProduct_Click(object sender, EventArgs e)
        {
            AddProductForm newForm=new AddProductForm();
            
            if (newForm.ShowDialog() == DialogResult.OK)
              
            productList.Items.Add(newForm.newProduct);
            
           
        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productList.SelectedIndex != -1)
            {
                Product p = productList.SelectedItem as Product;
                nameTB.Text = p.Name;
                categoryTB.Text = p.Category;
                priceTB.Text = Convert.ToString(p.Price);
            }
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            Product p = productList.SelectedItem as Product;
            cartList.Items.Add(p);
            calculateTotal(p.Price);
        }

        public void calculateTotal(int priceToAdd)
        {
            int totalPrice = int.Parse(totalTB.Text);
            totalTB.Text = Convert.ToString(totalPrice + priceToAdd);
        }

        private void removeFromCart_Click(object sender, EventArgs e)
        {
            Product ItemToRemove = cartList.SelectedItem as Product;
            cartList.Items.Remove(ItemToRemove);
            deducePrice(ItemToRemove.Price);
        }

        public void deducePrice(int priceToDeduce)
        {
            int totalPrice = int.Parse(totalTB.Text);
            totalTB.Text=Convert.ToString(totalPrice - priceToDeduce);
        }

        private void removeProduct_Click(object sender, EventArgs e)
        {

            Product ItemToRemove = productList.SelectedItem as Product;
            productList.Items.Remove(ItemToRemove);
            clearTextBoxes();
        }

        public void clearTextBoxes()
        {
            nameTB.Clear();
            categoryTB.Clear();
            priceTB.Clear();
        }

        private void clearCart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dali ste sigurni?", "Izprazni ja listata", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result)
            {
                cartList.Items.Clear();
                totalTB.Text = "0";
            }
            else;
        }

        private void removeProducts_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dali ste sigurni?","Izprazni ja listata", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result) productList.Items.Clear();
            else ;
            
        }
    }
}
