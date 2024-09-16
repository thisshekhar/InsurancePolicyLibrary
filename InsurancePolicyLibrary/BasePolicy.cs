namespace InsurancePolicyLibrary
{
    public abstract class BasePolicy
    {
        public string? PolicyNumber { get; set; }
        public string InsuranceProvider { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Premium { get; set; }
        public decimal CoverageAmount { get; set; }
        public PolicyHolder Holder { get; set; }
        public abstract decimal CalculatePremium();
    }
}