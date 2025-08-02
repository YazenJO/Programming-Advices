using System;

namespace ConsoleApplication1
{
    public class OrderEventArgs : EventArgs
    {
        public int OrderId { get; set; }
        public int OrderTotalPrice { get; set; }
        public string ClientEmail { get;  }

        public OrderEventArgs(int orderId, int orderTotalPrice, string clientEmail)
        {
            OrderId = orderId;
            OrderTotalPrice = orderTotalPrice;
            ClientEmail = clientEmail;
        }
    }

    public class Order
    {
        public event EventHandler<OrderEventArgs> OrderCreated;

        public void Create(int orderID, int orderTotalPrice, string clientEmail)
        {
            Console.WriteLine("New order created;now will notify everyone by raising the event.\n");
            if (OrderCreated !=null)
            {
                OrderCreated(this, new OrderEventArgs(orderID, orderTotalPrice, clientEmail));
            }
          
        }
    }

    public class EmailService
    {
        public void Subscribe(Order order)
        {
            order.OrderCreated += SendEmail;
        }
        public void Unsubscribe(Order order)
        {
            order.OrderCreated -= SendEmail;
        }
        private void SendEmail(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Email sent to {e.ClientEmail} for order {e.OrderId} with total price {e.OrderTotalPrice}");
        }
        
        
    }
    public class SmsService
    {
        public void Subscribe(Order order)
        {
            order.OrderCreated += SendSms;
        }
        public void Unsubscribe(Order order)
        {
            order.OrderCreated -= SendSms;
        }
        private void SendSms(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"SMS sent to {e.ClientEmail} for order {e.OrderId} with total price {e.OrderTotalPrice}");
        }
    }
    public class ShippingService
    {
        public void Subscribe(Order order)
        {
            order.OrderCreated += ShipOrder;
        }
        public void Unsubscribe(Order order)
        {
            order.OrderCreated -= ShipOrder;
        }
        private void ShipOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Order {e.OrderId} shipped to {e.ClientEmail}");
        }
    }
    
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            var Order = new Order();
            var emailService = new EmailService();
            var smsService = new SmsService();
            var shippingService = new ShippingService();
            emailService.Subscribe(Order);
            smsService.Subscribe(Order);
            shippingService.Subscribe(Order);
            Order.Create(10,540,"Tareq3mk@gmail.com");
        }
    }
}