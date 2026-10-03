using NotificationSystem.Adapters;
using NotificationSystem.Factories;
using NotificationSystem.Observers;
using NotificationSystem.Orders;
using NotificationSystem.PaymentProviders;
using NotificationSystem.Strategies;

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

// ---------- STRATEGY PATTERN ----------
Console.WriteLine("\n=== Strategy Pattern ===");

var normalCheckout = new Checkout(new DistanceFeeStrategy());
Console.WriteLine($"Normal delivery fee: {normalCheckout.GetDeliveryFee(10, 50)}");

var surgeCheckout = new Checkout(new SurgeFeeStrategy());
Console.WriteLine($"Surge delivery fee: {surgeCheckout.GetDeliveryFee(10, 50)}");

// ---------- ADAPTER PATTERN ----------
Console.WriteLine("\n=== Adapter Pattern ===");

IPaymentProcessor stripePayment = new StripeAdapter(new StripeGateway());
stripePayment.Pay(49.99m);

IPaymentProcessor paypalPayment = new PayPalAdapter(new PayPalProcessor());
paypalPayment.Pay(49.99m);