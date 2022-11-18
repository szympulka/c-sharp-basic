using Database;
using Database.Domain;
using System.Windows.Forms.VisualStyles;

namespace WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            productList.View = View.Details;
            productList.GridLines = true;
            productList.FullRowSelect = true;

            var db = new ShopContext();
            foreach (var shop in db.Set<Shop>())
            {
                string[] values = new string[2];
                values[0] = shop.Name;
                values[1] = shop.Id.ToString();

                var item = new ListViewItem(values);

                shopList.Items.Add(item);
            }


        }

        private void GetProducts_Click(object sender, EventArgs e)
        {
            CleanProductList();
            string[] values = new string[3];
            values[0] = "1";
            values[1] = "2";
            values[2] = "3";

            var item = new ListViewItem(values);
            productList.Items.Add(item);
        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var priceDetails = new PriceDetails(1);
            priceDetails.ShowDialog();
        }

        private void shopList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CleanProductList();
            var db = new ShopContext();
            var shopName = shopList.FocusedItem.Text;

            var shop = db.Set<Shop>().First(x => x.Name == shopName);
            var products = shop.Products;

            foreach (var product in products)
            {
                string[] values = new string[5];
                values[0] = product.Id.ToString();
                values[1] = product.Name;
                values[2] = product.Price.ToString();
                values[3] = product.ShopId.ToString();
                values[4] = product.ProductPriceHistories.Count().ToString();

                productList.Items.Add(new ListViewItem(values));
            }

        }

        private void CleanProductList() => productList.Items.Clear();
    }
}