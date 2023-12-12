namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourGraphBuilder
    {
        IBehaviourGraph Build();
        void Reset();
    }
}