using System;
using GiftAidCalculator.TestConsole.CalculateGiftAid;
using GiftAidCalculator.TestConsole.EventGiftAidSupplement;
using GiftAidCalculator.TestConsole.GiftAid;
using GiftAidCalculator.TestConsole.Infrastructure;
using GiftAidCalculator.TestConsole.TaxRate;

namespace GiftAidCalculator.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IGiftAidService giftAidService = Factory.CreateGiftAidService();
            ITaxRateService taxRateService = Factory.CreateTaxRateService();             
            
            string entry = "";            
            while (entry.ToLower() != "q")
            {                
                Console.WriteLine("who are you?");
                Console.WriteLine(string.Join("     ", 1, "Donor"));
                Console.WriteLine(string.Join("     ", 2, "Administrator"));
                int personId = int.Parse(Console.ReadLine());
                int eventTypeId;
                switch (personId)
                {
                    case 1:
                        Console.WriteLine("Please Enter donation amount:");
                        decimal donationAmount = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("which event do you want to donate to? :");
                        Console.WriteLine(string.Join("     ", 1, "Running"));
                        Console.WriteLine(string.Join("     ", 2, "Swimming"));
                        Console.WriteLine(string.Join("     ", 3, "Other"));

                        eventTypeId = int.Parse(Console.ReadLine());
                        IEventGiftAidSupplementService eventGiftAidSupplement = Factory.CreateEventGiftAidSupplementService((EventType)eventTypeId);

                        ICalculateGiftAid calculateGiftAid = new CalculateGiftAid.CalculateGiftAid(eventGiftAidSupplement,giftAidService,taxRateService);                        
                        decimal totalGiftAid = calculateGiftAid.GetTotalGiftAid(donationAmount);

                        Console.WriteLine($"Your gift aid for this event is {totalGiftAid}");                        
                        break;
                    case 2:
                        Console.WriteLine("Please New Tax Rate:");
                        decimal newTaxRate = decimal.Parse(Console.ReadLine());
                        taxRateService.SaveTaxRate(newTaxRate);
                        Console.WriteLine($"Tax Rate of {newTaxRate} has been saved:");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Enter q to quit or tap space to continue: \n");
                entry = Console.ReadLine();
            }

        }

        static decimal GiftAidAmount(decimal donationAmount)
        {
            var gaRatio = 17.5m / (100 - 17.5m);
            return donationAmount * gaRatio;
        }
    }
}
