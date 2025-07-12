using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameworkStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Db3Project20Entities db = new Db3Project20Entities();
        private void Form1_Load(object sender, EventArgs e)
        {
            // toplam kategori sayısı
            int categoryCount = db.tblCategory.Count();
            lblCategoryCount.Text = categoryCount.ToString();

            // toplam ürün sayısı
            int productCount = db.tblProduct.Count();
            lblProductCount.Text = productCount.ToString();

            // toplam müşteri sayısı
            int customerCount = db.tblCustomer.Count();
            lblCustomerCount.Text = customerCount.ToString();

            //Toplam sipariş sayısı
            int orderCount = db.tblOrder.Count();
            lblOrderCount.Text = orderCount.ToString();

            //toplam stok sayısı
            var totalproductStock = db.tblProduct.Sum(x => x.ProductStock);
            lblProductTotalStock.Text = totalproductStock.ToString();

            //ortalama ürün fiyatı
            var averageProductPrice = db.tblProduct.Average(x => x.ProductPrice);
            lblProductAveragePrice.Text = averageProductPrice.ToString()+"";

            //toplam meyve stoğu sayısı
            var totalProductCountByCategoryIsFruit = db.tblProduct.Where(x => x.tblCategory.CategoryName == "Meyve").Sum(x => x.ProductStock);
            lblProductCountByCategoryIsFurit.Text = totalProductCountByCategoryIsFruit.ToString();

            //gazozun toplam işlem hacmi
            var totalProductPriceByProductNameIsGazoz = db.tblProduct.Where(x => x.ProductName == "Gazoz").Sum(x => x.ProductPrice * x.ProductStock);
            lblTotalPriceByProductNameİsGazoz.Text = totalProductPriceByProductNameIsGazoz.ToString();

            //stok sayısı 100'den az olan ürünler
            var productCountByStockCountSmalerThan100 = db.tblProduct.Where(x => x.ProductStock < 100).Count();
            lblProductStockSmallerThan100.Text = productCountByStockCountSmalerThan100.ToString();

            //kategorisi sebze olan ve durumu true olan ürünlerin stok sayısı
            var productCountByCategoryIsVegetableAndStatusTrue = db.tblProduct.Where(x => x.tblCategory.CategoryName == "Sebze" && x.ProductStatus == true).Sum(x => x.ProductStock);
            lblProductCountBySebzeAndStatusTrue.Text = productCountByCategoryIsVegetableAndStatusTrue.ToString();

            //türkiyeden alınan sipariş sayısı
            var orderCountByCountryIsTurkey = db.tblOrder.Where(x => x.tblCustomer.CustomerCountry == "Türkiye").Count();
            lblOrderCountFromTurkiye.Text = orderCountByCountryIsTurkey.ToString();

            //yapılan meyve satışlarından elde edilen toplam gelir
            var orderTotalPriceByCategoryIsFruit = db.tblOrder.Where(o => o.tblProduct.tblCategory.CategoryName == "Meyve").Sum(o => o.tblProduct.ProductPrice * o.Count);
            lblOrderTotalPriceByCategoryIsFruit.Text = orderTotalPriceByCategoryIsFruit.ToString();

            //son eklenen ürünün adı
            var lastAddedProductName = db.tblProduct.OrderByDescending(x => x.ProductId).Select(x => x.ProductName).FirstOrDefault();
            lblLastProductName.Text = lastAddedProductName ?? "Yok";

            //son eklenen ürünün kategorisi
            var lastAddedProductCategory = db.tblProduct.OrderByDescending(x => x.ProductId).Select(x => x.tblCategory.CategoryName).FirstOrDefault();
            lblLastProductCategoryName.Text = lastAddedProductCategory ?? "Yok";

            //aktif ürün sayısı
            var activeProductCount = db.tblProduct.Count(x => x.ProductStatus == true);
            lblActiveProductCount.Text = activeProductCount.ToString();

            // toplam kola stok satışlarından kazanılan gelir
            var totalIncomeFromCokeSales = db.tblProduct.Where(x => x.ProductName == "Kola").Sum(x => x.ProductPrice * x.ProductStock);
            lblTotalPriceWithByKola.Text = totalIncomeFromCokeSales.ToString();

            // son eklenen müşteri adı
            var lastAddedCustomerName = db.tblCustomer.OrderByDescending(x => x.CustomerId).Select(x => x.CustomerName).FirstOrDefault();
            lblLastCustomerName.Text = lastAddedCustomerName ?? "Yok";

            //ülke çeşitliliği sayısı
            var countryDiversityCount = db.tblCustomer.Select(x => x.CustomerCountry).Distinct().Count();
            lblCountryDifferentCount.Text = countryDiversityCount.ToString();  
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
    }
}
