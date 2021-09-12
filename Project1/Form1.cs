using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var productsText = "Ürünler";
            var addToCartbuttonText = "Sepete Ekle";
            var cartText = "Sepetiniz";
            var removeFromCartButton = "Sepeti Sil";

            lblProducts.Text = productsText;
            btnAddToCart.Text = addToCartbuttonText;
            lblCart.Text = cartText;
            btnRemoveFromCart.Text = removeFromCartButton;

            string[] products = new string[] { "Laptop", "Masaüstü PC", "Klavye" };

            foreach (var product in products)
            {
                lbxProducts.Items.Add(product);
            }
        }
       private void button1_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null)
            {
                lblxCart.Items.Add(lbxProducts.SelectedItem);
            }
            else
            {
                MessageBox.Show("Bir Eleman Seçmelisiniz");
            }


        }
    }
}
