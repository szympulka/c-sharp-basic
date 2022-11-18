using Database;
using Database.Domain;
using System.Collections;
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


            var item2 = new ListViewItem(new string[3]
            {
                "1",
                "2",
                "3"
            });

            productList.Items.Add(item);
        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = productList.FocusedItem.Text;
            var priceDetails = new PriceDetails(int.Parse(id));
            priceDetails.ShowDialog();
        }

        private void shopList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new ShopContext();
            CleanProductList();


            productList.Items.AddRange(
                            db.Set<Shop>()
                              .First(x => x.Name == shopList.FocusedItem.Text)
                              .Products
                              .Select(product => new ListViewItem(new string[5]
                              {
                                product.Id.ToString(),
                                product.Name,
                                product.Price.ToString(),
                                product.ShopId.ToString(),
                                product.ProductPriceHistories.Count().ToString(),
                              })).ToArray());
        }

        private void CleanProductList() => productList.Items.Clear();
    }
}