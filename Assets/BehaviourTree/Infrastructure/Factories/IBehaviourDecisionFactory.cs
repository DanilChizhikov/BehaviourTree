namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourDecisionFactory : IServiceable
    {
        IBehaviourDecision Create(IBehaviourDecisionConfig config);
    }
}