namespace GiftAidCalculator.TestConsole.TaxRate
{
    public class TaxRateService : ITaxRateService
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
