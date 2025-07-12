using MongoDB.Bson;
using MongoDB.Driver;
using Project9_MongoDbOrder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDbOrder.Services
{
    public class OrderOperation
    {
        public void addOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var collection = connection.GetOrderCollection();
            var document = new BsonDocument
            {
                { "CustomerName", order.CustomerName },
                { "District", order.District },
                { "City", order.City },
                { "TotalPrice", order.TotalPrice }
            };
            collection.InsertOne(document);
        }

         public List<Order> GetAllOrders()
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrderCollection();

            var orders = orderCollection.Find(new BsonDocument()).ToList();

            List<Order> orderList = new List<Order>();

            foreach (var order in orders)
            {
                orderList.Add(new Order
                {
                    OrderId = order["_id"].ToString(),
                    CustomerName = order["CustomerName"].ToString(),
                    District = order["District"].ToString(),
                    City = order["City"].ToString(),
                    TotalPrice = decimal.Parse(order["TotalPrice"].ToString())
                });
            }

            return orderList;
        }

        public void deleteOrder(string orderId)
        {
            var connection = new MongoDbConnection();
            var collection = connection.GetOrderCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
            collection.DeleteOne(filter);
        }

        public void updateOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var collection = connection.GetOrderCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(order.OrderId));
            var update = Builders<BsonDocument>.Update
                .Set("CustomerName", order.CustomerName)
                .Set("District", order.District)
                .Set("City", order.City)
                .Set("TotalPrice", order.TotalPrice);
            collection.UpdateOne(filter, update);
        }

        public Order GetOrderById(string orderId)
        {
            var connection = new MongoDbConnection();
            var collection = connection.GetOrderCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
            var orderDocument = collection.Find(filter).FirstOrDefault();
            if (orderDocument != null)
            {
                return new Order
                {
                    OrderId = orderDocument["_id"].ToString(),
                    CustomerName = orderDocument["CustomerName"].ToString(),
                    District = orderDocument["District"].ToString(),
                    City = orderDocument["City"].ToString(),
                    TotalPrice = decimal.Parse(orderDocument["TotalPrice"].ToString())
                };
            }
            return null;
        }

    }
}
