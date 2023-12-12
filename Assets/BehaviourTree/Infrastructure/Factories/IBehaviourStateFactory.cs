namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourStateFactory : IServiceable
    {
        IBehaviourState Create(IBehaviourStateConfig config);
    }
}