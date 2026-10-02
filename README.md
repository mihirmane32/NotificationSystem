# Notification System - Design Pattern Playground

A console app for practicing core design patterns (Factory, Observer, Strategy, Adapter, Singleton) in a realistic domain: a multi-channel notification system (Email, SMS, Push) combined with an order-tracking scenario. This is a self-directed learning project for understanding patterns by actually building with them, not just reading about them.

## What's working right now

- `INotificationChannel` - a common interface every notification type implements
- `EmailNotification`, `SmsNotification` (truncates message over 160 characters), and `PushNotification` - each with its own sending logic
- `NotificationFactory` - creates the correct channel object from a string, without the caller needing to know which concrete class it is holding
- `IOrderObserver` - a common interface for anything that wants to react to an order's status changing
- `CustomerEmailObserver`, `RestaurantDashboardObserver` - independent reactions to status change
- `Order` - holds a dynamic list of subscribed observers; notifies all of them when the status changes, with no knowledge of who or how many are listening
- `IFeeStrategy` - a common interface for interchangeable fee-calculation algorithm
- `FlatFeeStrategy`, `DistanceFeeStrategy`, `SurgeFeeStrategy` - each a different pricing formula
- `Checkout` - receives an `IFeeStrategy` via its constructor and delegates fee calculation to it, without knowing the formula itself

## Design notes

- **Factory pattern**: `NotificationFactory.CreateChannel` returns `INotificationChannel`, the interface - not a concrete class. Calling code only depends on the interface, so adding a new channel later means creating one new class and adding one case to the factory switch without changing existing code.
- **Observer pattern**: `Order` never calls any observer by name. Observers subscribe/unsubscribe at runtime, and `Order` just loops over whoever's currently subscribed. Adding a new reaction (e.g. analytics tracking) means one new class and one `Subscribe` call - `Order` itself never changes.
- **Strategy pattern**: `Checkout` depends only on `IFeeStrategy`, not on any specific formula. Unlike Factory (which translates an unknown string into the right object), Strategy is used when the caller already knows which algorithm it wants at the point of writing the code - it's injected directly via the constructor, no string-to-object translation needed. Both patterns use the same underlyingtool (interface + interchangeable implementations), applied to different problems.

## Project structure

```text
NotificationSystem/
|-- Channels/
|   |-- INotificationChannel.cs     # Contract: anything that can SendNotification
|   |-- EmailNotification.cs
|   |-- SmsNotification.cs
|   |-- PushNotification.cs
|
|-- Factories/
|   |-- NotificationFactory.cs      # Decides which concrete channel to create
|
|-- Observers/
|   |-- IOrderObserver.cs
|   |-- CustomerEmailObserver.cs
|   |-- RestaurantDashboardObserver.cs
|
|-- Orders/
|   |-- Order.cs
|
|-- Strategy/
|   |-- DistanceFeeStrategy.cs
|   |-- FlatFeeStrategy.cs
|   |-- IFeeStrategy.cs
|   |-- SurgeFeeStrategy.cs
|
|-- Program.cs
```

## Running it

```bash
dotnet build
dotnet run
```

## Status

Factory, Observer, and Strategy pattern complete. Next Adapter (wrapping incompatible interfaces, e.g. different payment providers).