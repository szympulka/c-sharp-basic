using Database;
using Database.Domain;
using Database.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class PriceDetails : Form
    {
        private readonly int id = 0;
        public PriceDetails()
        {
            InitializeComponent();
        }
        public PriceDetails(int id)
        {
            this.id = id;

            InitializeComponent();
            priceHistory.View = View.Details;
            priceHistory.GridLines = true;
            priceHistory.FullRowSelect = true;
            UpdateData();

        }

        private void priceHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveNewPrice_Click(object sender, EventArgs e)
        {
            var value = double.Parse(AddNewPriceInput.Text);

            var db = new ShopContext();

            var product = db.Set<Product>().First(x => x.Id == id);

            db.Add(new ProductPriceHistory()
            {
                Price = product.Price,
                ProductId = id
            });
            product.Price = value;
            db.SaveChanges();

            AddNewPriceInput.Text = "";
            UpdateData();

        }

        private void UpdateData()
        {
            priceHistory.Items.Clear();
            var db = new ShopContext();
            var data = db.Set<ProductPriceHistory>()
                .Where(x => x.ProductId == id)
                .Select(x => new ListViewItem(new string[2]
                {
                    x.Id.ToString(),
                    x.Price.ToString()
                }))
                .ToArray();

            priceHistory.Items.AddRange(data);
        }
    }
}
