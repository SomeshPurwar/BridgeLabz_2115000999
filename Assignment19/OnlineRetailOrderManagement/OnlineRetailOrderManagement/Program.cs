using System;
namespace OnlineRetailOrderManagement
{
    class Order
    {
        public string orderId;
        public DateTime orderDate;

        public Order(string orderId, DateTime orderDate)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
        }

        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }


    }

    class ShippedOrder : Order
    {
        public int trackingNumber;

        public ShippedOrder(string orderId, DateTime orderDate, int trackingNumber) : base(orderId, orderDate)
        {
            this.trackingNumber = trackingNumber;
        }

        public override string GetOrderStatus()
        {
            return "Order Shipped";
        }


    }

    class DeliveredOrder : ShippedOrder
    {
        public DateTime deliveryDate;

        public DeliveredOrder(string orderId, DateTime orderDate, int trackingNumber, DateTime deliveryDate) : base(orderId, orderDate, trackingNumber)
        {
            this.deliveryDate = deliveryDate;
        }

        public override string GetOrderStatus()
        {
            return "Order Delivered";
        }


    }

    class Program
    {
        static void Main()
        {
            Order order = new Order("O101", DateTime.Now);
            ShippedOrder shippedOrder = new ShippedOrder("O101", DateTime.Now, 1234567);
            DeliveredOrder deliveredOrder = new DeliveredOrder("O101", DateTime.Now, 1234567, DateTime.Now.AddDays(3));

            Console.WriteLine($"Order ID: {order.orderId}, Status: {order.GetOrderStatus()}");
            Console.WriteLine($"Order ID: {shippedOrder.orderId}, Tracking: {shippedOrder.trackingNumber}, Status: {shippedOrder.GetOrderStatus()}");
            Console.WriteLine($"Order ID: {deliveredOrder.orderId}, Tracking: {deliveredOrder.trackingNumber}, Delivery Date: {deliveredOrder.deliveryDate}, Status: {deliveredOrder.GetOrderStatus()}");

        }
    }
}