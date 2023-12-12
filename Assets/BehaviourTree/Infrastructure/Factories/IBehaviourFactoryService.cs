namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourFactoryService
    {
        IBehaviourAction CreateAction(IBehaviourActionConfig config);
        IBehaviourDecision CreateDecision(IBehaviourDecisionConfig config);
    }
}