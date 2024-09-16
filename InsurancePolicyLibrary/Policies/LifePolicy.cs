
namespace InsurancePolicyLibrary.Policies
{
    public class LifePolicy : BasePolicy
    {
        public decimal CoverageAmount { get; set; }
        public string Beneficiary { get; set; }

        // Override the base method to provide specific premium calculation logic
        public override decimal CalculatePremium()
        {
            // Custom logic for life insurance premium
            return CoverageAmount * 0.02m + Premium;
        }
    }
}
