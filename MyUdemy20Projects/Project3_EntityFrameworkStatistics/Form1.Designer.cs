namespace Project3_EntityFrameworkStatistics
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategoryCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblOrderCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblProductTotalStock = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblProductCountBySebzeAndStatusTrue = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblProductStockSmallerThan100 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTotalPriceByProductNameİsGazoz = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblProductCountByCategoryIsFurit = new System.Windows.Forms.Label();
            this.lbl19 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblProductAveragePrice = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblActiveProductCount = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblLastProductCategoryName = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblLastProductName = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblOrderTotalPriceByCategoryIsFruit = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lblOrderCountFromTurkiye = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lblCountryDifferentCount = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.lblLastCustomerName = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.lblTotalPriceWithByKola = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.lblCategoryCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 109);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Sayısı";
            // 
            // lblCategoryCount
            // 
            this.lblCategoryCount.AutoSize = true;
            this.lblCategoryCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryCount.Location = new System.Drawing.Point(63, 66);
            this.lblCategoryCount.Name = "lblCategoryCount";
            this.lblCategoryCount.Size = new System.Drawing.Size(50, 19);
            this.lblCategoryCount.TabIndex = 1;
            this.lblCategoryCount.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(170)))));
            this.panel2.Controls.Add(this.lblProductCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(197, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 109);
            this.panel2.TabIndex = 1;
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCount.Location = new System.Drawing.Point(63, 66);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(50, 19);
            this.lblProductCount.TabIndex = 1;
            this.lblProductCount.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Sayısı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.panel3.Controls.Add(this.lblCustomerCount);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(382, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 109);
            this.panel3.TabIndex = 2;
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerCount.Location = new System.Drawing.Point(63, 66);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(50, 19);
            this.lblCustomerCount.TabIndex = 1;
            this.lblCustomerCount.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Müşteri Sayısı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(174)))), ((int)(((byte)(146)))));
            this.panel4.Controls.Add(this.lblOrderCount);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(572, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 109);
            this.panel4.TabIndex = 2;
            // 
            // lblOrderCount
            // 
            this.lblOrderCount.AutoSize = true;
            this.lblOrderCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderCount.Location = new System.Drawing.Point(63, 66);
            this.lblOrderCount.Name = "lblOrderCount";
            this.lblOrderCount.Size = new System.Drawing.Size(50, 19);
            this.lblOrderCount.TabIndex = 1;
            this.lblOrderCount.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(39, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sipariş Sayısı";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.panel5.Controls.Add(this.lblProductTotalStock);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(760, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 109);
            this.panel5.TabIndex = 3;
            // 
            // lblProductTotalStock
            // 
            this.lblProductTotalStock.AutoSize = true;
            this.lblProductTotalStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductTotalStock.Location = new System.Drawing.Point(63, 66);
            this.lblProductTotalStock.Name = "lblProductTotalStock";
            this.lblProductTotalStock.Size = new System.Drawing.Size(50, 19);
            this.lblProductTotalStock.TabIndex = 1;
            this.lblProductTotalStock.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(24, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Toplam Stok Sayısı";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(212)))), ((int)(((byte)(170)))));
            this.panel6.Controls.Add(this.lblProductCountBySebzeAndStatusTrue);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(760, 142);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 109);
            this.panel6.TabIndex = 8;
            // 
            // lblProductCountBySebzeAndStatusTrue
            // 
            this.lblProductCountBySebzeAndStatusTrue.AutoSize = true;
            this.lblProductCountBySebzeAndStatusTrue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCountBySebzeAndStatusTrue.Location = new System.Drawing.Point(55, 66);
            this.lblProductCountBySebzeAndStatusTrue.Name = "lblProductCountBySebzeAndStatusTrue";
            this.lblProductCountBySebzeAndStatusTrue.Size = new System.Drawing.Size(58, 19);
            this.lblProductCountBySebzeAndStatusTrue.TabIndex = 1;
            this.lblProductCountBySebzeAndStatusTrue.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(32, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Aktif Sebze Stoğu";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(98)))), ((int)(((byte)(175)))));
            this.panel7.Controls.Add(this.lblProductStockSmallerThan100);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(572, 142);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(165, 109);
            this.panel7.TabIndex = 6;
            // 
            // lblProductStockSmallerThan100
            // 
            this.lblProductStockSmallerThan100.AutoSize = true;
            this.lblProductStockSmallerThan100.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductStockSmallerThan100.Location = new System.Drawing.Point(55, 66);
            this.lblProductStockSmallerThan100.Name = "lblProductStockSmallerThan100";
            this.lblProductStockSmallerThan100.Size = new System.Drawing.Size(58, 19);
            this.lblProductStockSmallerThan100.TabIndex = 1;
            this.lblProductStockSmallerThan100.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(-3, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Stok Sayısı 100 den Az Ürünler";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(138)))), ((int)(((byte)(88)))));
            this.panel8.Controls.Add(this.lblTotalPriceByProductNameİsGazoz);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Location = new System.Drawing.Point(382, 142);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(165, 109);
            this.panel8.TabIndex = 7;
            // 
            // lblTotalPriceByProductNameİsGazoz
            // 
            this.lblTotalPriceByProductNameİsGazoz.AutoSize = true;
            this.lblTotalPriceByProductNameİsGazoz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPriceByProductNameİsGazoz.Location = new System.Drawing.Point(55, 66);
            this.lblTotalPriceByProductNameİsGazoz.Name = "lblTotalPriceByProductNameİsGazoz";
            this.lblTotalPriceByProductNameİsGazoz.Size = new System.Drawing.Size(58, 19);
            this.lblTotalPriceByProductNameİsGazoz.TabIndex = 1;
            this.lblTotalPriceByProductNameİsGazoz.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(2, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = " Gazoz Toplam İşlem Hacmi";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(134)))));
            this.panel9.Controls.Add(this.lblProductCountByCategoryIsFurit);
            this.panel9.Controls.Add(this.lbl19);
            this.panel9.Location = new System.Drawing.Point(197, 142);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(165, 109);
            this.panel9.TabIndex = 5;
            // 
            // lblProductCountByCategoryIsFurit
            // 
            this.lblProductCountByCategoryIsFurit.AutoSize = true;
            this.lblProductCountByCategoryIsFurit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCountByCategoryIsFurit.Location = new System.Drawing.Point(63, 66);
            this.lblProductCountByCategoryIsFurit.Name = "lblProductCountByCategoryIsFurit";
            this.lblProductCountByCategoryIsFurit.Size = new System.Drawing.Size(58, 19);
            this.lblProductCountByCategoryIsFurit.TabIndex = 1;
            this.lblProductCountByCategoryIsFurit.Text = "label17";
            this.lblProductCountByCategoryIsFurit.Click += new System.EventHandler(this.label17_Click);
            // 
            // lbl19
            // 
            this.lbl19.AutoSize = true;
            this.lbl19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl19.Location = new System.Drawing.Point(19, 14);
            this.lbl19.Name = "lbl19";
            this.lbl19.Size = new System.Drawing.Size(118, 15);
            this.lbl19.TabIndex = 0;
            this.lbl19.Text = "Toplam Meyve Stoku";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.panel10.Controls.Add(this.lblProductAveragePrice);
            this.panel10.Controls.Add(this.label20);
            this.panel10.Location = new System.Drawing.Point(12, 142);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(165, 109);
            this.panel10.TabIndex = 4;
            // 
            // lblProductAveragePrice
            // 
            this.lblProductAveragePrice.AutoSize = true;
            this.lblProductAveragePrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductAveragePrice.ForeColor = System.Drawing.Color.White;
            this.lblProductAveragePrice.Location = new System.Drawing.Point(45, 66);
            this.lblProductAveragePrice.Name = "lblProductAveragePrice";
            this.lblProductAveragePrice.Size = new System.Drawing.Size(58, 19);
            this.lblProductAveragePrice.TabIndex = 1;
            this.lblProductAveragePrice.Text = "label19";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(18, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Ortalama Ürün Fiyatı";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(82)))), ((int)(((byte)(31)))));
            this.panel11.Controls.Add(this.lblActiveProductCount);
            this.panel11.Controls.Add(this.label22);
            this.panel11.Location = new System.Drawing.Point(760, 270);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(165, 109);
            this.panel11.TabIndex = 13;
            // 
            // lblActiveProductCount
            // 
            this.lblActiveProductCount.AutoSize = true;
            this.lblActiveProductCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblActiveProductCount.Location = new System.Drawing.Point(55, 66);
            this.lblActiveProductCount.Name = "lblActiveProductCount";
            this.lblActiveProductCount.Size = new System.Drawing.Size(58, 19);
            this.lblActiveProductCount.TabIndex = 1;
            this.lblActiveProductCount.Text = "label21";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(32, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "Aktif Ürün Sayısı";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(245)))), ((int)(((byte)(0)))));
            this.panel12.Controls.Add(this.lblLastProductCategoryName);
            this.panel12.Controls.Add(this.label24);
            this.panel12.Location = new System.Drawing.Point(572, 270);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(165, 109);
            this.panel12.TabIndex = 11;
            // 
            // lblLastProductCategoryName
            // 
            this.lblLastProductCategoryName.AutoSize = true;
            this.lblLastProductCategoryName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastProductCategoryName.Location = new System.Drawing.Point(55, 66);
            this.lblLastProductCategoryName.Name = "lblLastProductCategoryName";
            this.lblLastProductCategoryName.Size = new System.Drawing.Size(58, 19);
            this.lblLastProductCategoryName.TabIndex = 1;
            this.lblLastProductCategoryName.Text = "label23";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(-1, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(166, 15);
            this.label24.TabIndex = 0;
            this.label24.Text = "Son Eklenen Ürün Kategorisi";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.panel13.Controls.Add(this.lblLastProductName);
            this.panel13.Controls.Add(this.label26);
            this.panel13.Location = new System.Drawing.Point(382, 270);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(165, 109);
            this.panel13.TabIndex = 12;
            // 
            // lblLastProductName
            // 
            this.lblLastProductName.AutoSize = true;
            this.lblLastProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastProductName.Location = new System.Drawing.Point(55, 66);
            this.lblLastProductName.Name = "lblLastProductName";
            this.lblLastProductName.Size = new System.Drawing.Size(58, 19);
            this.lblLastProductName.TabIndex = 1;
            this.lblLastProductName.Text = "label25";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(27, 14);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(107, 15);
            this.label26.TabIndex = 0;
            this.label26.Text = "Son Eklenen Ürün";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.panel14.Controls.Add(this.lblOrderTotalPriceByCategoryIsFruit);
            this.panel14.Controls.Add(this.label28);
            this.panel14.Location = new System.Drawing.Point(197, 270);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(165, 109);
            this.panel14.TabIndex = 10;
            // 
            // lblOrderTotalPriceByCategoryIsFruit
            // 
            this.lblOrderTotalPriceByCategoryIsFruit.AutoSize = true;
            this.lblOrderTotalPriceByCategoryIsFruit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderTotalPriceByCategoryIsFruit.Location = new System.Drawing.Point(55, 66);
            this.lblOrderTotalPriceByCategoryIsFruit.Name = "lblOrderTotalPriceByCategoryIsFruit";
            this.lblOrderTotalPriceByCategoryIsFruit.Size = new System.Drawing.Size(58, 19);
            this.lblOrderTotalPriceByCategoryIsFruit.TabIndex = 1;
            this.lblOrderTotalPriceByCategoryIsFruit.Text = "label27";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(19, 14);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(134, 15);
            this.label28.TabIndex = 0;
            this.label28.Text = "Meyve Satışları Kazancı";
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(35)))));
            this.panel15.Controls.Add(this.lblOrderCountFromTurkiye);
            this.panel15.Controls.Add(this.label30);
            this.panel15.Location = new System.Drawing.Point(12, 270);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(165, 109);
            this.panel15.TabIndex = 9;
            // 
            // lblOrderCountFromTurkiye
            // 
            this.lblOrderCountFromTurkiye.AutoSize = true;
            this.lblOrderCountFromTurkiye.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderCountFromTurkiye.Location = new System.Drawing.Point(55, 66);
            this.lblOrderCountFromTurkiye.Name = "lblOrderCountFromTurkiye";
            this.lblOrderCountFromTurkiye.Size = new System.Drawing.Size(58, 19);
            this.lblOrderCountFromTurkiye.TabIndex = 1;
            this.lblOrderCountFromTurkiye.Text = "label29";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(3, 14);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(163, 15);
            this.label30.TabIndex = 0;
            this.label30.Text = "Türkiyeden Verilen Siparişler";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(205)))));
            this.panel16.Controls.Add(this.label31);
            this.panel16.Controls.Add(this.label32);
            this.panel16.Location = new System.Drawing.Point(760, 396);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(165, 109);
            this.panel16.TabIndex = 18;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(55, 66);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 19);
            this.label31.TabIndex = 1;
            this.label31.Text = "label31";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(37, 14);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 15);
            this.label32.TabIndex = 0;
            this.label32.Text = "Kategori Sayısı";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(248)))));
            this.panel17.Controls.Add(this.label33);
            this.panel17.Controls.Add(this.label34);
            this.panel17.Location = new System.Drawing.Point(572, 396);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(165, 109);
            this.panel17.TabIndex = 16;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.Location = new System.Drawing.Point(55, 66);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(58, 19);
            this.label33.TabIndex = 1;
            this.label33.Text = "label33";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.Location = new System.Drawing.Point(39, 14);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(82, 15);
            this.label34.TabIndex = 0;
            this.label34.Text = "Sipariş Sayısı";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(141)))), ((int)(((byte)(208)))));
            this.panel18.Controls.Add(this.lblCountryDifferentCount);
            this.panel18.Controls.Add(this.label36);
            this.panel18.Location = new System.Drawing.Point(382, 396);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(165, 109);
            this.panel18.TabIndex = 17;
            // 
            // lblCountryDifferentCount
            // 
            this.lblCountryDifferentCount.AutoSize = true;
            this.lblCountryDifferentCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountryDifferentCount.Location = new System.Drawing.Point(55, 66);
            this.lblCountryDifferentCount.Name = "lblCountryDifferentCount";
            this.lblCountryDifferentCount.Size = new System.Drawing.Size(58, 19);
            this.lblCountryDifferentCount.TabIndex = 1;
            this.lblCountryDifferentCount.Text = "label35";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.Location = new System.Drawing.Point(27, 14);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(122, 15);
            this.label36.TabIndex = 0;
            this.label36.Text = "Ülke Çeşitliliği Sayısı";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(239)))), ((int)(((byte)(145)))));
            this.panel19.Controls.Add(this.lblLastCustomerName);
            this.panel19.Controls.Add(this.label38);
            this.panel19.Location = new System.Drawing.Point(197, 396);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(165, 109);
            this.panel19.TabIndex = 15;
            // 
            // lblLastCustomerName
            // 
            this.lblLastCustomerName.AutoSize = true;
            this.lblLastCustomerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastCustomerName.Location = new System.Drawing.Point(37, 66);
            this.lblLastCustomerName.Name = "lblLastCustomerName";
            this.lblLastCustomerName.Size = new System.Drawing.Size(58, 19);
            this.lblLastCustomerName.TabIndex = 1;
            this.lblLastCustomerName.Text = "label37";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(19, 14);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(120, 15);
            this.label38.TabIndex = 0;
            this.label38.Text = "Son Eklenen Müşteri";
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(221)))), ((int)(((byte)(0)))));
            this.panel20.Controls.Add(this.lblTotalPriceWithByKola);
            this.panel20.Controls.Add(this.label40);
            this.panel20.Location = new System.Drawing.Point(12, 396);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(165, 109);
            this.panel20.TabIndex = 14;
            // 
            // lblTotalPriceWithByKola
            // 
            this.lblTotalPriceWithByKola.AutoSize = true;
            this.lblTotalPriceWithByKola.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPriceWithByKola.Location = new System.Drawing.Point(55, 66);
            this.lblTotalPriceWithByKola.Name = "lblTotalPriceWithByKola";
            this.lblTotalPriceWithByKola.Size = new System.Drawing.Size(58, 19);
            this.lblTotalPriceWithByKola.TabIndex = 1;
            this.lblTotalPriceWithByKola.Text = "label39";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.Location = new System.Drawing.Point(9, 14);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(153, 15);
            this.label40.TabIndex = 0;
            this.label40.Text = "Toplam Kola Kazanç Tutarı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 526);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " İstatikler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategoryCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProductCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblOrderCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblProductTotalStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblProductCountBySebzeAndStatusTrue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblProductStockSmallerThan100;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTotalPriceByProductNameİsGazoz;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblProductCountByCategoryIsFurit;
        private System.Windows.Forms.Label lbl19;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblProductAveragePrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblActiveProductCount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblLastProductCategoryName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblLastProductName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblOrderTotalPriceByCategoryIsFruit;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lblOrderCountFromTurkiye;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label lblCountryDifferentCount;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label lblLastCustomerName;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label lblTotalPriceWithByKola;
        private System.Windows.Forms.Label label40;
    }
}

