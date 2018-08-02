namespace GiftAidCalculator.TestConsole.TaxRate
{
   public interface ITaxRateService
    {
        void SaveTaxRate(decimal taxRate);
        decimal GetTaxRate();
    }
}
