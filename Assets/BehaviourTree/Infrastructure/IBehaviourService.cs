namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourService
    {
        IBehaviourState CreateState(IBehaviourStateConfig config);
        IBehaviourAction CreateAction(IBehaviourActionConfig config);
        IBehaviourDecision CreateDecision(IBehaviourDecisionConfig config);
    }
}