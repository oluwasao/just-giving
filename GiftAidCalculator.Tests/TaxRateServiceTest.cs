﻿using GiftAidCalculator.TestConsole;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.Tests
{
    [TestFixture]
    public class TaxRateServiceTest
    {
        ITaxRateService taxRateService = new TaxRateService();
        [Test]
        public void Should_Update_Tax_Rate_To_40_When_Updated()
        {
            taxRateService.SaveTaxRate(40);            

            decimal rate = taxRateService.GetTaxRate();
            Assert.That(rate, Is.EqualTo(40));
        }        
    }
}
