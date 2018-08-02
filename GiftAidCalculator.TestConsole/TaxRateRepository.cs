using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.TestConsole
{
    public  class TaxRateRepository
    {
        decimal _currentTaxRate = 20;
        public void SaveTaxRate(decimal currentTaxRate)
        {
            _currentTaxRate = currentTaxRate;
        }
        public decimal GetTaxRate()
        {
            return _currentTaxRate;
        }
    }
}
