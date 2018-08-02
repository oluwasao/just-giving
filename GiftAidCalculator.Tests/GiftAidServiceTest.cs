using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GiftAidCalculator.TestConsole;
using NUnit;
using NUnit.Framework;

namespace GiftAidCalculator.Tests
{
    [TestFixture]
    public class GiftAidServiceTest
    {
        IGiftAidService _giftAidService = new GiftAidService();
        ITaxRateService _taxRateService = new TaxRateService();

        [Test]
        public void Should_Return_Twenty_Five_When_Donation_Is_Hundred_And_Tax_Rate_Is_20()
        {             
            decimal donation = 100;            

            decimal giftAid = _giftAidService.CalculateGiftAid(donation,20);         
            Assert.AreEqual(25m, giftAid);
        }

        [Test]
        public void Should_Return_Zero_Point_Two_Five_When_Donation_is_One_And_Tax_Rate_Is_20()
        {         
            decimal donation = 1;
         
            decimal giftAid = _giftAidService.CalculateGiftAid(donation,20);
         
            Assert.AreEqual(0.25m, giftAid);
        }

        [Test]
        public void Should_Return_Zero_When_Donation_is_Zero_And_Tax_Rate_Is_20()
        {
            decimal donation = 0;

            decimal giftAid = _giftAidService.CalculateGiftAid(donation,20);

            Assert.AreEqual(0m, giftAid);
        }
        
        [Test]
        public void Should_Return_Thirty_When_Donation_Is_Hundred_And_Tax_Rate_In_DataStore_Is_Twenty_Five()
        {
            _taxRateService.SaveTaxRate(24);
            decimal taxRate = _taxRateService.GetTaxRate();
            decimal donation = 100;

            decimal giftAid = _giftAidService.CalculateGiftAid(donation, taxRate);
            Assert.AreEqual(30m, giftAid);
        }

        [Test]
        public void Should_Round_To_Two_Decimal_Places()
        {
            decimal donation = 15.33m;

            decimal giftAid = _giftAidService.CalculateGiftAid(donation,20);
            Assert.AreEqual(3.83m, giftAid);
        }
    }
}
