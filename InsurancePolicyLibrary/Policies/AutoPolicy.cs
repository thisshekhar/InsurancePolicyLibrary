
namespace InsurancePolicyLibrary.Policies
{
    public class AutoPolicy : BasePolicy
    {
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public int Year { get; set; }

        public override decimal CalculatePremium()
        {
            // Custom logic for auto insurance premium
            decimal basePremium = 500m; // Example base premium
            if (Year < 2015) basePremium += 100m; // Adjust premium for older vehicles
            return basePremium + Premium;
        }
    }
}
