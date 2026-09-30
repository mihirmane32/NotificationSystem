using NotificationSystem.Factories;

var factory = new NotificationFactory();

var channel = factory.CreateChannel("sms");
channel.SendNotification("Your amazon parcel OTP is 12345");