
namespace InsurancePolicyLibrary.Factories
{
    public class PolicyFactory
    {
        public static BasePolicy CreatePolicy(PolicyType type)
        {
            return type switch
            {
                PolicyType.Life => new Policies.LifePolicy(),
                PolicyType.Auto => new Policies.AutoPolicy(),
                // Add other policy types here
                _ => throw new ArgumentOutOfRangeException(nameof(type), "Unknown policy type"),
            };
        }
    }
}
