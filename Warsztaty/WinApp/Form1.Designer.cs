namespace WinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GetProducts = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.ShopId = new System.Windows.Forms.ColumnHeader();
            this.shopList = new System.Windows.Forms.ListView();
            this.ShopName = new System.Windows.Forms.ColumnHeader();
            this.SumOfPrices = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.GetProducts, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.productList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.shopList, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1132, 634);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GetProducts
            // 
            this.GetProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetProducts.Location = new System.Drawing.Point(229, 510);
            this.GetProducts.Name = "GetProducts";
            this.GetProducts.Size = new System.Drawing.Size(129, 36);
            this.GetProducts.TabIndex = 0;
            this.GetProducts.Text = "Pobierz produkty";
            this.GetProducts.UseVisualStyleBackColor = false;
            this.GetProducts.Click += new System.EventHandler(this.GetProducts_Click);
            // 
            // productList
            // 
            this.productList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Name,
            this.Price,
            this.ShopId,
            this.SumOfPrices});
            this.productList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productList.Location = new System.Drawing.Point(229, 3);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(900, 501);
            this.productList.TabIndex = 1;
            this.productList.UseCompatibleStateImageBehavior = false;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Name
            // 
            this.Name.Name = "Form1";
            this.Name.Text = "Name";
            this.Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Name.Width = 200;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 100;
            // 
            // ShopId
            // 
            this.ShopId.Text = "ShopId";
            // 
            // shopList
            // 
            this.shopList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ShopName});
            this.shopList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopList.Location = new System.Drawing.Point(3, 3);
            this.shopList.Name = "shopList";
            this.shopList.Size = new System.Drawing.Size(220, 501);
            this.shopList.TabIndex = 2;
            this.shopList.UseCompatibleStateImageBehavior = false;
            this.shopList.SelectedIndexChanged += new System.EventHandler(this.shopList_SelectedIndexChanged);
            // 
            // ShopName
            // 
            this.ShopName.Text = "Nazwa Sklepu";
            this.ShopName.Width = 200;
            // 
            // SumOfPrices
            // 
            this.SumOfPrices.Text = "Suma historycznych cen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 634);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Text = "Blablbalbabla";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button GetProducts;
        private ListView productList;
        private ColumnHeader Id;
        private ColumnHeader Name;
        private ColumnHeader Price;
        private ListView shopList;
        private ColumnHeader ShopName;
        private ColumnHeader ShopId;
        private ColumnHeader SumOfPrices;
    }
}