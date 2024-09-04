using System;
using DependencyInversionPrinciple;

class Program
{
    static void Main(string[] args)
    {
        IEmailService emailService = new EmailService();
        Notification notification = new Notification(emailService);
        notification.PromotionalNotification();
    }
}


