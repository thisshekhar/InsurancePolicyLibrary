
namespace InsurancePolicyLibrary
{
    public abstract class PolicyCoverageDecorator : BasePolicy
    {
        BasePolicy _basePolicy;

        public PolicyCoverageDecorator(BasePolicy basePolicy)
        {
                this._basePolicy = basePolicy;
        }
        public override decimal CalculatePremium()
        {
            return this._basePolicy.CalculatePremium() + this.Premium;
        }
    }
}
