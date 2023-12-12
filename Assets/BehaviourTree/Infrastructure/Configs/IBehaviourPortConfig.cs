namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourPortConfig
    {
        string Name { get; }
        IBehaviourStateConfig NextState { get; }
    }
}