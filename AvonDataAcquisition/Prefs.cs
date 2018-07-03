using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace AvonDataAcquisition
{
    //!!!Remove OrderItem _id field!

    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int ClientDiscount { get; set; }
    }

    public class Product
    {
        //public int ProductId { get; set; }
        [BsonId]
        public string ProductCode { get; set; }
        public int Page { get; set; }
        public int Price { get; set; }
    }

    public class OrderItem
    {
        public int OrderItemId { get; set; }
        [BsonRef("products")]
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    public class ClientOrder
    {
        public int ClientOrderId { get; set; }
        //[BsonRef("orders")]
        public List<OrderItem> OrderItems { get; set; }
        [BsonRef("clients")]
        public Client Client { get; set; }
        public ClientOrder() { OrderItems = new List<OrderItem>(); }
    }

    public class OverallOrder
    {
        public int OverallOrderId { get; set; }
        public int CatalogNum { get; set; }
        public DateTime Date { get; set; }
        //New field!
        public bool IsOrderClosed { get; set; }
        [BsonRef("client_orders")]
        public List<ClientOrder> ClientOrders { get; set; }
        public OverallOrder() { ClientOrders = new List<ClientOrder>(); }
    }

    public static class Prefs
    {
        static public ConnectionString dbFileName = new ConnectionString("myDataBase.db");
        static LiteDatabase db;

        static public string ColClients { get { return "clients"; } }
        static public string ColProducts { get { return "products"; } }
        static public string ColOrders { get { return "orders"; } }
        static public string ColClientOrders { get { return "client_orders"; } }
        static public string ColOverallOrders { get { return "overall_orders"; } }

        static public int MaxOrderSum { get; } = 10000;

        static public LiteDatabase DB
        {
            get
            {
                if (db == null)
                {
                    //dbFileName.Password = "1233";
                    db = new LiteDatabase(dbFileName);
                    /*try
                    {
                        var a = db.Engine.Locker;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }*/
                }
                return db;
            }
            set
            {
                db = value;
            }
        }
    }
}
