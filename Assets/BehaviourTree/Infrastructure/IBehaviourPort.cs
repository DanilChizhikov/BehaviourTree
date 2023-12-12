namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourPort
    {
        IBehaviourState NextState { get; }
    }
}