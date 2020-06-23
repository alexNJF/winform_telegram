using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramBot
{
    public partial class Product_Form : Form
    {
       
        public Product_Form()
        {
            InitializeComponent();
        }

        private void Add_Product_Button_Click(object sender, EventArgs e)
        {
            Product_listBox.Items.Add(Product_name_TextBox.Text);
            Product_name_TextBox.Clear();
        }

        private void Delete_Product_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Product_listBox.Items.RemoveAt(Product_listBox.SelectedIndex);
            }
            catch (Exception ex) { }
        }

        private void Save_Product_Button_Click(object sender, EventArgs e)
        {
            List<Product> products_list = new List<Product>();
            try
            {
                foreach (string item in Product_listBox.Items)
                {
                    Product product_tmp = new Product();
                    product_tmp.name = item.ToString();
                    //add more product feature here
                    products_list.Add(product_tmp);
                }
                Product_list.list = products_list;
                MessageBox.Show("محصول ذخیره شد ");
                this.Close();
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void Product_Form_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Product item in Product_list.list)
                    Product_listBox.Items.Add(item.name);
            }
            catch{ }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
