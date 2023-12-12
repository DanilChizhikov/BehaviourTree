namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourActionFactory : IServiceable
    {
        IBehaviourAction Create(IBehaviourActionConfig config);
    }
}