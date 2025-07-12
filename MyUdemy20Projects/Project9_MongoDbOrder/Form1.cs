using Project9_MongoDbOrder.Entities;
using Project9_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDbOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OrderOperation orderOperation = new OrderOperation();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var order = new Order()
            {
                City = txtCity.Text,
                CustomerName = txtCustomerName.Text,
                District = txtDistrict.Text,
                TotalPrice = Convert.ToDecimal(txtTotalPrice.Text),
            };

            orderOperation.addOrder(order);
            MessageBox.Show("Order added successfully!");

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Order> orders = orderOperation.GetAllOrders();
            dataGridView1.DataSource = orders;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            orderOperation.deleteOrder(orderId);
            MessageBox.Show("Order deleted successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            var order = new Order()
            {
                OrderId = orderId,
                City = txtCity.Text,
                CustomerName = txtCustomerName.Text,
                District = txtDistrict.Text,
                TotalPrice = Convert.ToDecimal(txtTotalPrice.Text),
            };

            orderOperation.updateOrder(order);
            MessageBox.Show("Order updated successfully!");

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            Order order = orderOperation.GetOrderById(orderId);
            dataGridView1.DataSource = new List<Order> { order };

        }
    }
}
