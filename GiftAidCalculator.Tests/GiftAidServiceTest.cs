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
        GiftAidService _giftAidService = new GiftAidService();
        [Test]
        public void Should_Return_Twenty_Five_When_Donation_Is_Hundred()
        {
            //arrange            
            decimal donation = 100;
            //act
            decimal giftAid = _giftAidService.CalculateGiftAid(donation);
            //assert
            Assert.AreEqual(25, giftAid);
        }

        [Test]
        public void Should_Return_Zero_Point_Two_Five_When_Donation_is_One()
        {
            //arrange            
            decimal donation = 1;
            //act
            decimal giftAid = _giftAidService.CalculateGiftAid(donation);
            //assert
            Assert.AreEqual(0.25m, giftAid);
        }

        [Test]
        public void Should_Return_Twenty_Five_When_Donation_Is_Hundred_And_Event_Type_Is_Other()
        {
            decimal donation = 100;
            _giftAidService.EventType = EventType.Other;
            decimal giftAid = _giftAidService.CalculateGiftAid(donation);
            Assert.AreEqual(25, giftAid);
        }

        [Test]
        public void Should_Return_Twenty_Five_When_Donation_Is_50_And_Event_Type_Is_Running()
        {
            decimal donation = 50;
            _giftAidService.EventType = EventType.Running;
            decimal giftAid = _giftAidService.CalculateGiftAid(donation);
            Assert.AreEqual(12.5, giftAid);
        }

    }
}
