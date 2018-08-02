using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.TestConsole
{
   public interface ITaxRateService
    {
        void SaveTaxRate(decimal taxRate);
        decimal GetTaxRate();
    }
}
