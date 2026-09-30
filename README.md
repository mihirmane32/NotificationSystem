# Notification System - Design Pattern Playground

A console app for practicing core design patterns (Factory, Observer, Strategy, Adapter, Singleton) in a realistic domain: a multi-channel notification system (Email, SMS, Push). This is a self-directed learning project for understanding patterns by actually building with them, not just reading about them.

## What's working right now

- `INotificationChannel` - a common interface every notification type implements
- `EmailNotification`, `SmsNotification` (truncates message over 160 characters), and `PushNotification` - each with its own sending logic
- `NotificationFactory` - creates the correct channel object from a string, without the caller needing to know which concrete class it is holding

## Design notes

- **Factory pattern**: `NotificationFactory.CreateChannel` returns `INotificationChannel`, the interface - not a concrete class. Calling code only depends on the interface, so adding a new channel later means creating one new class and adding one case to the factory switch without changing existing code.

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
|-- Program.cs
```

## Running it

```bash
dotnet build
dotnet run
```

## Status

Factory pattern complete. Next: Observer (publisher/subscriber - notifying multiple parts of the system when something happens).