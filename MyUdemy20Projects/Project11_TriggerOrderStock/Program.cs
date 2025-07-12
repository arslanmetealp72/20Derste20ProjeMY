using Project11_TriggerOrderStock.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11_TriggerOrderStock
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Db11Project20Entities context = new Db11Project20Entities();

            string number;
            Console.WriteLine("### Sipariş Stok Sistemi ###");
            Console.WriteLine();
            Console.WriteLine("1-Ürün Listesi");
            Console.WriteLine("2-Sipariş Listesi");
            Console.WriteLine("3-Kasa Durumu");
            Console.WriteLine("4-Yeni Ürün Satışı");
            Console.WriteLine("5-İşlem Sayacı");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            Console.Write("Lütfen bir işlem seçiniz: ");
            number = Console.ReadLine();
            Console.WriteLine();

            if (number == "1")
            {
                Console.WriteLine("---- Ürün Listesi ----");
                var values = context.tblProduct.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine(item.ProductId + "-" + item.ProductName + " Stok Sayısı: " + item.ProductStock + " Fiyatı: " + item.ProductPrice + " tl ");

                }
            }

            if (number == "2")
            {
                Console.WriteLine("---- Sipariş Listesi ----");
                var values = context.tblOrder.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine(item.OrderId + "-" + item.tblProduct.ProductName + " Birim Fiyat: " + item.UnitPrice + " Adet: " + item.Quantity + " Toplam Fiyat: "+ item.TotalPrice);

                }
            }

            if(number == "3")
            {
                Console.WriteLine("---- Kasa Durumu ----");
                var values = context.tblCashRegister.Select(x=>x.Balance).FirstOrDefault();
                Console.WriteLine("Kasa Bakiyesi: " + values + " tl " );
            }

            if (number == "4")
            {
                Console.WriteLine("---- Yeni Ürün Sipariş Girişi ----");
                
                Console.Write("Müşteri Adı: ");
                string customerName = Console.ReadLine();

                Console.Write("Ürün ID: ");
                int productId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Adet: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("---- Sipariş Bilgileri: ----");

                Console.WriteLine();

                var productName = context.tblProduct.Where(x => x.ProductId == productId).Select(x => x.ProductName).FirstOrDefault();

                Console.Write("Ürün Adı: " + productName + " ");

                var productUnitPrice = context.tblProduct.Where(x => x.ProductId == productId).Select(x => x.ProductPrice).FirstOrDefault();
                
                Console.Write("Ürün Birim Fiyatı: " + productUnitPrice + " tl ");

                decimal totalPrice = quantity * decimal.Parse(productUnitPrice.ToString());

                Console.Write("Toplam Fiyat: " + totalPrice + " tl ");
                Console.WriteLine();


                tblOrder order = new tblOrder
                {
                    Customer = customerName,
                    ProductId = productId,
                    Quantity = quantity,
                    UnitPrice = productUnitPrice,
                    TotalPrice = totalPrice
                };

                context.tblOrder.Add(order);
                context.SaveChanges();

            }

            if (number == "5")
            {
                Console.WriteLine("---- İşlem Sayacı ----");
                var values = context.tblProcess.Select(x => x.Process).FirstOrDefault();
                Console.WriteLine("Toplam İşlem Sayısı: " + values);

            }


            Console.Read();
        }
    }
}

