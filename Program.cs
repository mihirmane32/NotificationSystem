using NotificationSystem.Factories;
using NotificationSystem.Observers;
using NotificationSystem.Orders;

// ---------- FACTORY PATTERN ----------
Console.WriteLine("=== Factory Pattern ===");
var factory = new NotificationFactory();
var channel = factory.CreateChannel("sms");
channel.SendNotification("Your amazon parcel OTP is 12345");

// ---------- OBSERVER PATTERN ----------
Console.WriteLine("\n=== Observer Patern ===");
var order = new Order();

var emailObserver = new CustomerEmailObserver();
var dashboardObserver = new RestaurantDashboardObserver();

order.Subscribe(emailObserver);
order.Subscribe(dashboardObserver);

Console.WriteLine("-- Updating to Preparing --");
order.UpdateStatus("Preparing");

Console.WriteLine("-- Updating to Out for Delivery --");
order.UpdateStatus("Out for Delivery");

order.Unsubscribe(emailObserver);

Console.WriteLine("-- Updating to Delivered (customer unsubscribed)");
order.UpdateStatus("Delivered");