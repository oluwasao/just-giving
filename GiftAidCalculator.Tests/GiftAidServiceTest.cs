using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GiftAidCalculator.TestConsole;
using GiftAidCalculator.TestConsole.GiftAid;
using GiftAidCalculator.TestConsole.TaxRate;
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
        public void Should_Return_Correct_Gift_Aid_Amount_When_Donation_Is_Hundred()
        {             
            decimal donation = 100;            

            decimal giftAid = _giftAidService.CalculateGiftAid(donation,20);         
            Assert.AreEqual(25m, giftAid);
        }

        [Test]
        public void Should_Return_Correct_Gift_Aid_Amount_When_Donation_Is_One()
        {         
            decimal donation = 1;
         
            decimal giftAid = _giftAidService.CalculateGiftAid(donation,20);
         
            Assert.AreEqual(0.25m, giftAid);
        }

        [Test]
        public void Should_Return_Correct_Gift_Aid_Amount_When_Donation_Is_Zero()
        {
            decimal donation = 0;

            decimal giftAid = _giftAidService.CalculateGiftAid(donation,20);

            Assert.AreEqual(0m, giftAid);
        }
        
        [Test]
        public void Should_Calculate_Gift_Aid_Based_On_Tax_Rate_In_DataStore()
        {
            _taxRateService.SaveTaxRate(15);
            decimal taxRate = _taxRateService.GetTaxRate();
            decimal donation = 100;

            decimal giftAid = _giftAidService.CalculateGiftAid(donation, taxRate);
            Assert.AreEqual(17.65m, giftAid);
        }

        [Test]
        public void Should_Round_Gift_Aid_To_Two_Decimal_Places()
        {
            decimal donation = 15.33m;

            decimal giftAid = _giftAidService.CalculateGiftAid(donation,20);
            Assert.AreEqual(3.83m, giftAid);
        }
    }
}
