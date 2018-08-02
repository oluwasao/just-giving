using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.TestConsole
{
    public interface IGiftAidService
    {
        decimal CalculateGiftAid(decimal donationAmount, decimal taxRate);
    }
}
