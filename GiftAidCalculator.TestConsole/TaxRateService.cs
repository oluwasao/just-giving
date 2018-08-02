using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftAidCalculator.TestConsole
{
    public class TaxRateService : ITaxRateService
    {
        TaxRateRepository _taxRateRepository;
        public TaxRateService()
        {
            _taxRateRepository = new TaxRateRepository();
        }
        public decimal GetTaxRate()
        {
            return _taxRateRepository.GetTaxRate();
        }

        public void SaveTaxRate(decimal taxRate)
        {
            _taxRateRepository.SaveTaxRate(taxRate);
        }
    }
}
