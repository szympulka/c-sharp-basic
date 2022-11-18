namespace WinApp
{
    partial class PriceDetails
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.priceHistory = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNewPriceInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveNewPrice = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.priceHistory, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // priceHistory
            // 
            this.priceHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Price});
            this.priceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceHistory.Location = new System.Drawing.Point(163, 3);
            this.priceHistory.Name = "priceHistory";
            this.priceHistory.Size = new System.Drawing.Size(634, 354);
            this.priceHistory.TabIndex = 0;
            this.priceHistory.UseCompatibleStateImageBehavior = false;
            this.priceHistory.SelectedIndexChanged += new System.EventHandler(this.priceHistory_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.AddNewPriceInput);
            this.flowLayoutPanel1.Controls.Add(this.SaveNewPrice);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(154, 354);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // AddNewPriceInput
            // 
            this.AddNewPriceInput.Location = new System.Drawing.Point(3, 18);
            this.AddNewPriceInput.Name = "AddNewPriceInput";
            this.AddNewPriceInput.Size = new System.Drawing.Size(151, 23);
            this.AddNewPriceInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj nową cene";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SaveNewPrice
            // 
            this.SaveNewPrice.Location = new System.Drawing.Point(3, 47);
            this.SaveNewPrice.Name = "SaveNewPrice";
            this.SaveNewPrice.Size = new System.Drawing.Size(151, 23);
            this.SaveNewPrice.TabIndex = 2;
            this.SaveNewPrice.Text = "Dodaj nowa cene";
            this.SaveNewPrice.UseVisualStyleBackColor = true;
            this.SaveNewPrice.Click += new System.EventHandler(this.SaveNewPrice_Click);
            // 
            // PriceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PriceDetails";
            this.Text = "PriceDetails";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView priceHistory;
        private ColumnHeader Id;
        private ColumnHeader Price;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox AddNewPriceInput;
        private Button SaveNewPrice;
    }
}